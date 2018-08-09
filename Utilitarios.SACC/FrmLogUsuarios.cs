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
    public partial class FrmLogUsuarios : Form
    {
        public FrmLogUsuarios()
        {
            InitializeComponent();
        }
        
        private void FrmLogUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cessa_bdsaccDataSet.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.cessa_bdsaccDataSet.usuarios);
            // TODO: esta línea de código carga datos en la tabla 'cessa_bdsaccDataSet.usuarios_log' Puede moverla o quitarla según sea necesario.
            this.usuarios_logTableAdapter.Fill(this.cessa_bdsaccDataSet.usuarios_log);

        }

        private void cmbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.usuarios_logTableAdapter.FilterByLogin(this.cessa_bdsaccDataSet.usuarios_log, cmbBuscar.SelectedValue.ToString());
            }
            catch(Exception) { }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            this.usuarios_logTableAdapter.Fill(this.cessa_bdsaccDataSet.usuarios_log);
        }
    }
}
