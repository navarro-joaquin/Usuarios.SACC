using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;

namespace Utilitarios.SACC
{
	public partial class FrmLogin : Form
	{
		FrmPrincipalMDI principal;

		public FrmLogin()
		{
			InitializeComponent();
		}

		private void FrmLogin_Load(object sender, EventArgs e)
		{
            // TODO: esta línea de código carga datos en la tabla 'cessa_bdsaccDataSet.usuarios' Puede moverla o quitarla según sea necesario.
            //this.usuariosTableAdapter.Fill(this.cessa_bdsaccDataSet.usuarios);

            //Fuentes fuente = new Fuentes();
            //fuente.aplicarFuentes(this.Controls);
		}

		private void Login()
		{
			string login = txtLogin.Text;
			string password = SHA1Class.GetSHA1(txtPassword.Text);

            if (!txtLogin.Text.Equals("") && !txtPassword.Text.Equals(""))
            {
                try
                {
                    int id = Convert.ToInt32(this.usuariosTableAdapter.LoginQuery(login, password));
                    if (id != 0)
                    {
                        string cargo = this.usuariosTableAdapter.getCargoById(id).ToString();
                        switch (cargo.ToUpper())
                        {
                            case "ADMINISTRADOR":
                                principal = new FrmPrincipalMDI(cargo.ToUpper(), id);
                                this.Hide();
                                principal.ShowDialog();
                                this.Show();
                                break;
                            default:
                                principal = new FrmPrincipalMDI(cargo.ToUpper(), id);
                                this.Hide();
                                principal.ShowDialog();
                                this.Show();
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nombre de usuario o contraseña incorrectos.\nIntente nuevamente.");
                    }
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    //MySql.Data.MySqlClient.MySqlErrorCode error = new MySql.Data.MySqlClient.MySqlErrorCode();
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Ingrese todos los datos (usuario y/o contraseña) antes de continuar.");
            }

			txtLogin.ResetText();
			txtPassword.ResetText();
			txtLogin.Focus();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			Login();
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}
    }
}
