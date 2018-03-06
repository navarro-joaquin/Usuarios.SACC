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
                    mnuUsuarios.Enabled = true;
                    mnuAvisos.Enabled = true;
                    mnuVideos.Enabled = true;
                    break;
                case "RRPP":
                    mnuUsuarios.Enabled = false;
                    mnuAvisos.Enabled = true;
                    mnuVideos.Enabled = false;
                    break;
                default:
                    mnuUsuarios.Enabled = false;
                    mnuAvisos.Enabled = false;
                    mnuVideos.Enabled = false;
                    break;
            }

            id_usuario = id;
        }

        //Funcionalidad de los elementos en menú
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void mnuUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios frm = new FrmUsuarios(id_usuario);
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuAvisos_Click(object sender, EventArgs e)
        {
            FrmAvisos frm = new FrmAvisos(id_usuario);
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuVideos_Click(object sender, EventArgs e)
        {
            FrmVideosFTP frm = new FrmVideosFTP();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ticketsAtendidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPreReporteUsuario frm = new FrmPreReporteUsuario();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
