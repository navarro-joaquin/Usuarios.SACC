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
	public partial class FrmAvisos : Form
	{
		int id_usuario;

		public FrmAvisos()
		{
			InitializeComponent();
		}

		public FrmAvisos(int id)
		{
			InitializeComponent();
			id_usuario = id;
		}

		private void FrmAvisos_Load(object sender, EventArgs e)
		{
            // TODO: esta línea de código carga datos en la tabla 'cessa_bdsaccDataSet.mensajes' Puede moverla o quitarla según sea necesario.
            // this.mensajesTableAdapter.Fill(this.cessa_bdsaccDataSet.mensajes);
            DataGridViewColumn col = dgvAvisos.Columns[1];
            col.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.mensajesTableAdapter.getMensajesOrderById(this.cessa_bdsaccDataSet.mensajes);
		}

        private void agregarAviso_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.mensajesTableAdapter.getMensajesOrderById(this.cessa_bdsaccDataSet.mensajes);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmOpAviso agregarAviso = new FrmOpAviso(id_usuario);
            agregarAviso.FormClosed += new FormClosedEventHandler(agregarAviso_FormClosed);
            agregarAviso.ShowDialog();
        }

        private void modificarAviso_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.mensajesTableAdapter.getMensajesOrderById(this.cessa_bdsaccDataSet.mensajes);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvAvisos.SelectedRows.Count != 0)
            {
                int id = Convert.ToInt32(dgvAvisos.CurrentRow.Cells[0].Value);
                FrmOpAviso modificarAviso = new FrmOpAviso(id_usuario, id);
                modificarAviso.FormClosed += new FormClosedEventHandler(modificarAviso_FormClosed);
                modificarAviso.Text = "Modificar Aviso";
                modificarAviso.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }
    }
}
