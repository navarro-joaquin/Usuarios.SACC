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
	public partial class FrmOpUsuario : Form
	{
		int id_usuario;
		int a_modificar;

		public FrmOpUsuario(int id)
		{
			InitializeComponent();
			id_usuario = id;
			a_modificar = -1;
		}

		public FrmOpUsuario(int id, int modificar)
		{
			InitializeComponent();
			id_usuario = id;
			a_modificar = modificar;
		}

		private void FrmOpUsuario_Load(object sender, EventArgs e)
		{
			// TODO: esta línea de código carga datos en la tabla 'cessa_bdsaccDataSet.usuarios' Puede moverla o quitarla según sea necesario.
			// this.usuariosTableAdapter.Fill(this.cessa_bdsaccDataSet.usuarios);
			if (a_modificar > 0)
			{
				this.usuariosTableAdapter.getUsuarioById(this.cessa_bdsaccDataSet.usuarios, a_modificar);
			}
		}

		private void Reset()
		{
			txtLogin.ResetText();
			txtPassword.ResetText();
			txtNombre.ResetText();
			txtCargo.ResetText();
			txtRol.ResetText();
			txtUbicacion.ResetText();
			txtEstado.ResetText();
		}

		public void OcultarPassword()
		{
			txtPassword.Enabled = false;
			btnAgregar.Text = "Modificar";
			lblCreado.Text = "Modificado:";
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{	
			if (a_modificar < 0)
			{
				if (txtLogin.Text != "" && txtPassword.Text != "" && txtNombre.Text != "" && txtCargo.Text != "" && txtRol.Text != "" && txtUbicacion.Text != "" && txtEstado.Text != "")
				{
					string login = txtLogin.Text;
					string password = SHA1Class.GetSHA1(txtPassword.Text);
					string nombre = txtNombre.Text;
					string cargo = txtCargo.Text;
					string rol = txtRol.Text;
					string ubicacion = txtUbicacion.Text;
					string estado = txtEstado.Text;
					DateTime creado = dtpCreado.Value;

					try
					{
						this.usuariosTableAdapter.insertUsuario(login, password, nombre, cargo, rol, ubicacion, estado, creado, null, id_usuario, null);
						MessageBox.Show("Usuario creado con éxito");
						this.Close();
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error! " + ex.Message);
					}
				}
				else
				{
					MessageBox.Show("Debe rellenar todos los datos");
				}
			}
			else
			{
				if (txtLogin.Text != "" && txtPassword.Text != "" && txtNombre.Text != "" && txtCargo.Text != "" && txtRol.Text != "" && txtUbicacion.Text != "" && txtEstado.Text != "")
				{
					string login = txtLogin.Text;
					string nombre = txtNombre.Text;
					string cargo = txtCargo.Text;
					string rol = txtRol.Text;
					string ubicacion = txtUbicacion.Text;
					string estado = txtEstado.Text;
					DateTime creado = dtpCreado.Value;

					try
					{
						this.usuariosTableAdapter.updateUsuario(login, nombre, cargo, rol, ubicacion, estado, creado, id_usuario, a_modificar);
						MessageBox.Show("Modificado correctamente");
						this.Close();
					}
					catch(Exception ex)
					{
						MessageBox.Show("Error! " + ex.Message);
					}
				}
				else
				{
					MessageBox.Show("Debe rellenar todos los datos");
				}
			}
			
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
