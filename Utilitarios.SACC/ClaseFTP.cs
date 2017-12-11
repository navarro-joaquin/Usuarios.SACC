using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace Utilitarios.SACC
{
    public partial class ClaseFTP : BackgroundWorker
    {
        public ClaseFTP()
        {
            InitializeComponent();
        }

        public ClaseFTP(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        private void ClaseFTP_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bw = sender as BackgroundWorker;
            FtpSettings f = e.Argument as FtpSettings;
            // define la cadena de peticion al servidor. Incluye la carpeta destino y el nombre del archivo (basado en el nombre del archivo a subir)
            string Ruta = String.Format("{0}/{1}{2}", f.Servidor, f.CarpetaDestino == "" ? "" : f.CarpetaDestino + "/", Path.GetFileName(f.Archivo));
            if (!Ruta.ToLower().StartsWith("ftp://"))
            {
                Ruta = "ftp://" + Ruta;
            }
            FtpWebRequest peticion = (FtpWebRequest)WebRequest.Create(Ruta);
            peticion.UseBinary = true;
            peticion.UsePassive = f.Pasivo;
            peticion.Method = WebRequestMethods.Ftp.UploadFile;
            peticion.Credentials = new NetworkCredential(f.Usuario, f.Contrasena);

            // Copia el contenido del archivo al la secuencia de subida
            long TamañoArchivo = new FileInfo(f.Archivo).Length;
            string DescripcionTamañoArchivo = ObtenerTamañoArchivo(TamañoArchivo); // "2.4 GB" en lugar de 2400000000000000 bytes
            int TamañoPedazo = 4096, NumeroIntentos = 0, MaximoIntentos = 50;
            long BytesEnviados = 0;
            byte[] Buffer = new byte[TamañoPedazo];
            using(Stream requestStream = peticion.GetRequestStream())
            {
                using(FileStream fs = File.Open(f.Archivo, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    int BytesLeidos = fs.Read(Buffer, 0, TamañoPedazo); // Lee el primer pedazo en el buffer
                    // Envia los pedazos al servicio web uno por uno, hasta que FileStream.Read() devuelva 0, es decir, que todo el archivo a sido leido
                    while(BytesLeidos > 0)
                    {
                        try
                        {
                            if (bw.CancellationPending)
                                return;

                            // Envia este pedazo al servidor. Es enviado como un parametro byte[], pero el cliente y el servidor han sido configurados para codificar byte[] usando MTOM.
                            requestStream.Write(Buffer, 0, BytesLeidos);

                            // BytesEnviados es actualizado solamente DESPUES un envio exitoso de los bytes. Por lo que seria posible crear codigo 'reintentar', para reanudar la carga desde la posicion BytesEnviados actual si AppendChunk falla.
                            BytesEnviados += BytesLeidos;

                            // Actualiza la interfaz de usuario
                            string TextoResumen = String.Format("Transferido {0} / {1}", ObtenerTamañoArchivo(BytesEnviados), DescripcionTamañoArchivo);
                            bw.ReportProgress((int)(((decimal)BytesEnviados / (decimal)TamañoArchivo) * 100), TextoResumen);
                        }
                        catch(Exception ex)
                        {
                            Debug.WriteLine("Excepcion: " + ex.ToString());
                            if (NumeroIntentos++ < MaximoIntentos)
                            {
                                // Rebobina filestream y sigue intentando
                                fs.Position -= BytesLeidos;
                            }
                            else
                            {
                                throw new Exception(String.Format("Ocurrió un error durante la subida, muchos intentos fallidos. \n{0}", ex.ToString()));
                            }
                        }
                        BytesLeidos = fs.Read(Buffer, 0, TamañoPedazo); // Lee el siguiente pedazo (si es que existe) dentro del buffer. El bucle while terminara si no queda nada mas que leer
                    }
                }
            }
            using (FtpWebResponse respuesta = (FtpWebResponse)peticion.GetResponse())
                System.Diagnostics.Debug.WriteLine(String.Format("Subida completada, estado {0}", respuesta.StatusDescription));
        }

        public static string ObtenerTamañoArchivo(long numeroBytes)
        {
            string TamañoArchivo = "";

            if (numeroBytes > 1073741824)
                TamañoArchivo = String.Format("{0:0.00} Gb", (double)numeroBytes / 1073741824);
            else if (numeroBytes > 1048576)
                TamañoArchivo = String.Format("{0:0.00} Mb", (double)numeroBytes / 1048576);
            else
                TamañoArchivo = String.Format("{0:0} Kb", (double)numeroBytes / 1024);

            if (TamañoArchivo == "0 Kb")
                TamañoArchivo = "1 Kb";  // minimo.							
            return TamañoArchivo;
        }
    }

    public class FtpSettings
    {
        public string Servidor, Usuario, Contrasena, CarpetaDestino, Archivo;
        public bool Pasivo;
        public int Puerto = 21;
    }
}
