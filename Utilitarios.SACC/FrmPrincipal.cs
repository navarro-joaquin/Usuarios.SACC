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
	public partial class FrmPrincipal : Form
	{
		int id_usuario;

		public FrmPrincipal(string cargo, int id)
		{
			InitializeComponent();
			switch (cargo)
			{
				case "ADMINISTRADOR":
					btnUsuarios.Enabled = true;
					btnAvisos.Enabled = true;
					btnVideos.Enabled = true;
					break;
				case "RRPP":
					btnUsuarios.Enabled = false;
					btnAvisos.Enabled = true;
					btnVideos.Enabled = false;
					break;
				default:
					btnUsuarios.Enabled = false;
					btnAvisos.Enabled = false;
					btnVideos.Enabled = false;
					break;
			}

			id_usuario = id;
		}

		private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
		{
			//Application.Exit();
		}

		private void btnUsuarios_Click(object sender, EventArgs e)
		{
			FrmUsuarios usuarios = new FrmUsuarios(id_usuario);
			this.Hide();
			usuarios.ShowDialog();
			this.Show();
		}

		private void btnAvisos_Click(object sender, EventArgs e)
		{
			FrmAvisos avisos = new FrmAvisos(id_usuario);
			this.Hide();
			avisos.ShowDialog();
			this.Show();
		}

        private void btnVideos_Click(object sender, EventArgs e)
        {
            FrmVideosFTP videos = new FrmVideosFTP();
            this.Hide();
            videos.ShowDialog();
            this.Show();
        }
    }
}
