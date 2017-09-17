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
	public partial class FrmLogin : Form
	{
		FrmPrincipal principal;

		public FrmLogin()
		{
			InitializeComponent();
		}

		private void FrmLogin2_Load(object sender, EventArgs e)
		{
			// TODO: esta línea de código carga datos en la tabla 'cessa_bdsaccDataSet.usuarios' Puede moverla o quitarla según sea necesario.
			//this.usuariosTableAdapter.Fill(this.cessa_bdsaccDataSet.usuarios);

		}

		private void Login()
		{
			string login = txtLogin.Text;
			string password = SHA1Class.GetSHA1(txtPassword.Text);

			try
			{
				int id = Convert.ToInt32(this.usuariosTableAdapter.LoginQuery(login, password));
				string cargo = this.usuariosTableAdapter.getCargoById(id).ToString();
				switch (cargo.ToUpper())
				{
					case "ADMINISTRADOR":
						//MessageBox.Show("Ingresó como administrador");
						principal = new FrmPrincipal(cargo.ToUpper(), id);
						this.Hide();
						principal.ShowDialog();
						this.Close();
						break;
					default:
						principal = new FrmPrincipal(cargo.ToUpper(), id);
						this.Hide();
						principal.ShowDialog();
						this.Close();
						break;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Datos incorrectos, intente nuevamente");
			}

			txtLogin.ResetText();
			txtPassword.ResetText();
			txtLogin.Focus();
		}

		private void keyCapture(KeyPressEventArgs e)
		{
			if (e.KeyChar == (int)Keys.Enter)
			{
				if (txtLogin.Text != "" && txtPassword.Text != "")
					Login();
				else
					MessageBox.Show("Debe rellenar todos los campos");
			}
			if (e.KeyChar == (int)Keys.Escape)
			{
				this.Close();
			}
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			Login();
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
		{
			keyCapture(e);
		}

		private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
		{
			keyCapture(e);
		}
	}
}
