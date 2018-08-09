using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Utilitarios.SACC
{
    public partial class FrmVideosFTP : Form
    {
        public FrmVideosFTP()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Multiselect = false;
                openFileDialog1.Filter = "Video files (*.mp4)|*.mp4";
                if (this.openFileDialog1.ShowDialog() != DialogResult.Cancel)
                {
                    System.IO.FileInfo fi = new System.IO.FileInfo(openFileDialog1.FileName);
                    if (fi.Length > 700000000)
                        throw new Exception("El tamaño del archivo superó los 700 MBytes");
                    else
                        this.txtArchivo.Text = this.openFileDialog1.FileName;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            //if (this.openFileDialog1.ShowDialog() != DialogResult.Cancel)
            //    this.txtArchivo.Text = this.openFileDialog1.FileName;
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            // El boton subir tambien es usado como boton para cancelar, dependiendo del estado del hilo claseFTP
            if (this.claseFTP1.IsBusy)
            {
                this.claseFTP1.CancelAsync();
                this.btnSubir.Text = "Subir";
            }
            else
            {
                // Comprueba que los datos del usuario FTP sean rellenados en el formulario
                if (!txtServidor.Text.Equals(string.Empty) && !txtUsuario.Text.Equals(string.Empty) && !txtContrasena.Text.Equals(string.Empty))
                {
                    // Crea una nueva instancia 'ftpSettings' para almacenar todos los paramentros del hilo claseFTP
                    FtpSettings f = new FtpSettings();
                    f.Servidor = this.txtServidor.Text;
                    f.Usuario = this.txtUsuario.Text;
                    f.Contrasena = this.txtContrasena.Text;
                    f.CarpetaDestino = this.txtCarpetaDestino.Text;
                    f.Archivo = this.txtArchivo.Text;
                    try
                    {
                        f.Puerto = Int32.Parse(this.txtPuerto.Text);
                    }
                    catch { }
                    this.toolStripProgressBar1.Visible = true;
                    this.claseFTP1.RunWorkerAsync(f);
                    this.btnSubir.Text = "Cancelar";
                }
                else
                {
                    MessageBox.Show("Error: Datos faltantes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void claseFTP1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.toolStripStatusLabel1.Text = e.UserState.ToString(); // El mensaje sera algo como 45 Kb / 100.12 Mb
            this.toolStripProgressBar1.Value = Math.Min(this.toolStripProgressBar1.Maximum, e.ProgressPercentage);
        }

        private void claseFTP1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.ToString(), "Error FTP");
            }
            else if (e.Cancelled)
            {
                this.toolStripStatusLabel1.Text = "Subida cancelada";
            }
            else
            {
                this.toolStripStatusLabel1.Text = "Subida completada";
                this.txtArchivo.ResetText();
            }
            this.btnSubir.Text = "Subir";
            this.toolStripProgressBar1.Visible = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
