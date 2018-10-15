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
    public partial class FrmPrincipalMDI : Form
    {
        int id_usuario;

        public FrmPrincipalMDI(string cargo, int id)
        {
            InitializeComponent();

            switch(cargo)
            {
                case "ADMINISTRADOR":
                    MnuItemUsuarios.Enabled = true;
                    MnuItemAvisos.Enabled = true;
                    MnuItemVideos.Enabled = true;
                    break;
                case "RRPP":
                    MnuItemUsuarios.Enabled = false;
                    MnuItemAvisos.Enabled = true;
                    MnuItemVideos.Enabled = false;
                    break;
                default:
                    MnuItemUsuarios.Enabled = false;
                    MnuItemAvisos.Enabled = false;
                    MnuItemVideos.Enabled = false;
                    break;
            }

            id_usuario = id;
        }

        //Funcionalidad de los elementos en menú
        private void EMnuItemSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MnuItemHerramientas_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = MnuItemHerramientas.Checked;
        }

        private void MnuItemEstado_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = MnuItemEstado.Checked;
        }

        private void MnuItemCascada_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void MnuItemVertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void MnuItemHorizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void MnuItemCerrarTodo_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MnuItemUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios frm = new FrmUsuarios(id_usuario);
            frm.MdiParent = this;
            frm.Show();
        }

        private void MnuItemAvisos_Click(object sender, EventArgs e)
        {
            FrmAvisos frm = new FrmAvisos(id_usuario);
            frm.MdiParent = this;
            frm.Show();
        }

        private void MnuItemVideos_Click(object sender, EventArgs e)
        {
            FrmListadoVideos frm = new FrmListadoVideos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void MnuItemReportesAtendidos_Click(object sender, EventArgs e)
        {
            FrmPreReporteUsuario frm = new FrmPreReporteUsuario();
            frm.MdiParent = this;
            frm.Show();
        }

        private void MnuItemConfCorreo_Click(object sender, EventArgs e)
        {
            FrmConfCorreo frm = new FrmConfCorreo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void MnuItemLogAccesos_Click(object sender, EventArgs e)
        {
            FrmLogUsuarios frm = new FrmLogUsuarios();
            frm.MdiParent = this;
            frm.Show();
        }

        private void MnuItemComparativaAtencion_Click(object sender, EventArgs e)
        {
            FrmReporteComparativa frm = new FrmReporteComparativa();
            frm.MdiParent = this;
            frm.Show();
        }

        private void MnuItemConfAtencion_Click(object sender, EventArgs e)
        {
            FrmConfAtencion frm = new FrmConfAtencion();
            frm.MdiParent = this;
            frm.Show();
        }

        private void MnuItemAtencionPlataforma_Click(object sender, EventArgs e)
        {
            FrmReporteAtencionPlataforma frm = new FrmReporteAtencionPlataforma();
            frm.MdiParent = this;
            frm.Show();
        }

        private void MnuItemAtencionCajas_Click(object sender, EventArgs e)
        {
            FrmReporteAtencionCajas frm = new FrmReporteAtencionCajas();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
