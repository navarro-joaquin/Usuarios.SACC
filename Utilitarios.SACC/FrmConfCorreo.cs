using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Utilitarios.SACC
{
    public partial class FrmConfCorreo : Form
    {
        public FrmConfCorreo()
        {
            InitializeComponent();
        }

        private void FrmConfCorreo_Load(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            txtServidor.Text = config.AppSettings.Settings["SmtpServer"].Value;
            txtPuerto.Text = config.AppSettings.Settings["SmtpPort"].Value;
            txtCorreo.Text = config.AppSettings.Settings["SenderEmail"].Value;
            txtContraseña.Text = config.AppSettings.Settings["SenderPassword"].Value;
            txtCorreoDestino.Text = config.AppSettings.Settings["ReceiverEmail"].Value;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            config.AppSettings.Settings.Remove("SmtpServer");
            config.AppSettings.Settings.Add("SmtpServer", txtServidor.Text);
            config.AppSettings.Settings.Remove("SmtpPort");
            config.AppSettings.Settings.Add("SmtpPort", txtPuerto.Text);
            config.AppSettings.Settings.Remove("SenderEmail");
            config.AppSettings.Settings.Add("SenderEmail", txtCorreo.Text);
            config.AppSettings.Settings.Remove("SenderPassword");
            config.AppSettings.Settings.Add("SenderPassword", txtContraseña.Text);
            config.AppSettings.Settings.Remove("ReceiverEmail");
            config.AppSettings.Settings.Add("ReceiverEmail", txtCorreoDestino.Text);
            config.Save(ConfigurationSaveMode.Modified);

            MessageBox.Show("Cambios en la configuración guardados", "Configuración de Correo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
