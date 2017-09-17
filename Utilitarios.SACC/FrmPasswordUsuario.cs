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
	public partial class FrmPasswordUsuario : Form
	{
		int id_usuario;

		public FrmPasswordUsuario()
		{
			InitializeComponent();
		}

		public FrmPasswordUsuario(int id)
		{
			InitializeComponent();
			id_usuario = id;
		}

		private void FrmPasswordUsuario_Load(object sender, EventArgs e)
		{

		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			if (txtPassword.Text == txtConfirmacion.Text)
			{
				string password = SHA1Class.GetSHA1(txtPassword.Text);
				try
				{
					this.usuariosTableAdapter.resetPassword(password, id_usuario);
					MessageBox.Show("Contraseña cambiada correctamente");
					this.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error " + ex.Message);
				}
			}
			else
			{
				MessageBox.Show("Las contraseñas deben ser iguales");
			}
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
