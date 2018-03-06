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
            frm.generarPDF();
        }
    }
}
