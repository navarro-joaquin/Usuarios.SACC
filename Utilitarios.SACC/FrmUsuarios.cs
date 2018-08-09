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
	public partial class FrmUsuarios : Form
	{
		int id_usuario;

		public FrmUsuarios(int id)
		{
			InitializeComponent();
			id_usuario = id;
		}

		private void FrmUsuarios_Load(object sender, EventArgs e)
		{
			// TODO: esta línea de código carga datos en la tabla 'cessa_bdsaccDataSet.usuarios' Puede moverla o quitarla según sea necesario.
			this.usuariosTableAdapter.listUsersOrderById(this.cessa_bdsaccDataSet.usuarios);

		}

		private void agregarUsuario_FromClosed(Object sender, FormClosedEventArgs e)
		{
			this.usuariosTableAdapter.listUsersOrderById(this.cessa_bdsaccDataSet.usuarios);
		}

		private void btnNuevo_Click(object sender, EventArgs e)
		{
			FrmOpUsuario agregarUsuario = new FrmOpUsuario(id_usuario);
			agregarUsuario.FormClosed += new FormClosedEventHandler(agregarUsuario_FromClosed);
			agregarUsuario.ShowDialog();
		}

		private void modificarUsuario_FormClosed(Object sender, FormClosedEventArgs e)
		{
			this.usuariosTableAdapter.listUsersOrderById(this.cessa_bdsaccDataSet.usuarios);
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			if (dgvUsuarios.SelectedRows.Count != 0)
			{
				int id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value);
				FrmOpUsuario modificarUsuario = new FrmOpUsuario(id_usuario, id);
				modificarUsuario.FormClosed += new FormClosedEventHandler(modificarUsuario_FormClosed);
				modificarUsuario.Text = "Modificar datos del usuario";
				modificarUsuario.OcultarPassword();
				modificarUsuario.ShowDialog();
			}
			else
			{
				MessageBox.Show("Debe seleccionar una fila");
			}
		}

		private void resetPassword_FormClosed(Object sender, FormClosedEventArgs e)
		{
			this.usuariosTableAdapter.listUsersOrderById(this.cessa_bdsaccDataSet.usuarios);
		}

		private void btnResetPassword_Click(object sender, EventArgs e)
		{
            if (dgvUsuarios.SelectedRows.Count != 0)
            {
                int id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value);
                FrmPasswordUsuario resetPassword = new FrmPasswordUsuario(id);
                resetPassword.FormClosed += new FormClosedEventHandler(resetPassword_FormClosed);
                resetPassword.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            int id_usuario = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value);
            string fecha = DateTime.Today.ToString("yyyy-MM-dd");
            FrmReporteUsuario reporte = new FrmReporteUsuario(fecha, id_usuario);
            reporte.ShowDialog();
        }
    }
}
