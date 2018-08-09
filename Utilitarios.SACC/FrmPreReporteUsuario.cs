using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;

namespace Utilitarios.SACC
{
    public partial class FrmPreReporteUsuario : Form
    {
        public FrmPreReporteUsuario()
        {
            InitializeComponent();
        }

        private void FrmPreReporteUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cessa_bdsaccDataSet.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.cessa_bdsaccDataSet.usuarios);

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string fecha = dtpFecha.Value.ToString("yyyy-MM-dd");
            int id_usuario = Convert.ToInt32(cmbUsuario.SelectedValue);

            FrmReporteUsuario frm = new FrmReporteUsuario(fecha, id_usuario);
            frm.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string fecha = dtpFecha.Value.ToString("yyyy-MM-dd");
            int id_usuario = Convert.ToInt32(cmbUsuario.SelectedValue);
            string nombre_usuario = cmbUsuario.Text;

            FrmReporteUsuario frm = new FrmReporteUsuario(fecha, id_usuario, nombre_usuario);
            frm.Show();
            frm.Hide();
            string nombre_archivo = frm.generarPDF();
            frm.Close();

            EnviarCorreo(nombre_archivo);
        }

        private void EnviarCorreo(string nombre_archivo)
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                string servidor_smtp = config.AppSettings.Settings["SmtpServer"].Value;
                string puerto_smtp = config.AppSettings.Settings["SmtpPort"].Value;
                string correo_remitente = config.AppSettings.Settings["SenderEmail"].Value;
                string contraseña_remitente = config.AppSettings.Settings["SenderPassword"].Value;
                string correo_destino = config.AppSettings.Settings["ReceiverEmail"].Value;
                string appPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

                MailMessage mail = new MailMessage();
                SmtpClient smtp = new SmtpClient(servidor_smtp);

                mail.From = new MailAddress(correo_remitente);
                mail.To.Add(correo_destino);
                mail.Subject = nombre_archivo;
                mail.Attachments.Add(new Attachment(appPath + "\\" + nombre_archivo));

                smtp.Port = Convert.ToInt32(puerto_smtp);
                smtp.Credentials = new System.Net.NetworkCredential(correo_remitente, contraseña_remitente);
                smtp.EnableSsl = true;

                ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
                { return true; };

                smtp.Send(mail);
                MessageBox.Show("Mensaje enviado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
