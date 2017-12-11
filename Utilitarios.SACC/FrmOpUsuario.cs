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
			//txtCargo.ResetText();
			//txtRol.ResetText();
			//txtUbicacion.ResetText();
			//txtEstado.ResetText();
		}

		public void OcultarPassword()
		{
			txtPassword.Enabled = false;
			btnAgregar.Text = "Modificar";
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{	
			if (a_modificar < 0)
			{
				if (txtLogin.Text != "" && txtPassword.Text != "" && txtNombre.Text != "" && cmbCargo.Text != "" && cmbRol.Text != "" && cmbUbicacion.Text != "" && cmbEstado.Text != "")
				{
					string login = txtLogin.Text;
					string password = SHA1Class.GetSHA1(txtPassword.Text);
					string nombre = txtNombre.Text;
					string cargo = cmbCargo.Text;
					string rol = cmbRol.Text;
					string ubicacion = cmbUbicacion.Text;
					string estado = cmbEstado.Text;
                    DateTime creado = DateTime.Today;

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
				if (txtLogin.Text != "" && txtPassword.Text != "" && txtNombre.Text != "" && cmbCargo.Text != "" && cmbRol.Text != "" && cmbUbicacion.Text != "" && cmbEstado.Text != "")
				{
					string login = txtLogin.Text;
					string nombre = txtNombre.Text;
					string cargo = cmbCargo.Text;
					string rol = cmbRol.Text;
					string ubicacion = cmbUbicacion.Text;
					string estado = cmbEstado.Text;
					DateTime modificado = DateTime.Today;

					try
					{
						this.usuariosTableAdapter.updateUsuario(login, nombre, cargo, rol, ubicacion, estado, modificado, id_usuario, a_modificar);
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

		private void cmbCargo_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (cmbCargo.SelectedIndex)
			{
				case 0:
					cmbRol.Items.Clear();
					cmbRol.Items.Add("PLATAFORMA");
					cmbRol.SelectedIndex = 0;
					break;
				case 1:
					cmbRol.Items.Clear();
					cmbRol.Items.Add("CAJAS");
					cmbRol.SelectedIndex = 0;
					break;
				case 2:
					cmbRol.Items.Clear();
					cmbRol.Items.Add("RRPP");
					cmbRol.SelectedIndex = 0;
					break;
				case 3:
					cmbRol.Items.Clear();
					cmbRol.Items.Add("ADMINISTRADOR");
					cmbRol.SelectedIndex = 0;
					break;
			}
		}

		private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (cmbRol.SelectedItem.ToString())
			{
				case "PLATAFORMA":
					cmbUbicacion.Items.Clear();
					cmbUbicacion.Items.Add("PLT1");
					cmbUbicacion.Items.Add("PLT2");
					cmbUbicacion.Items.Add("PLT3");
					cmbUbicacion.Items.Add("PLT4");
					cmbUbicacion.SelectedIndex = 0;
					break;
				case "CAJAS":
					cmbUbicacion.Items.Clear();
					cmbUbicacion.Items.Add("Caja1");
					cmbUbicacion.Items.Add("Caja2");
					cmbUbicacion.Items.Add("Caja3");
					cmbUbicacion.Items.Add("Caja4");
					cmbUbicacion.SelectedIndex = 0;
					break;
				case "RRPP":
					cmbUbicacion.Items.Clear();
					cmbUbicacion.Items.Add("RRPP");
					cmbUbicacion.SelectedIndex = 0;
					break;
				case "ADMINISTRADOR":
					cmbUbicacion.Items.Clear();
					cmbUbicacion.Items.Add("ADMINISTRADOR");
					cmbUbicacion.SelectedIndex = 0;
					break;
			}
		}
	}
}
