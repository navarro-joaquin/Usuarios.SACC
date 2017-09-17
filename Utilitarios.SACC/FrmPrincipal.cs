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
					btnMensajes.Enabled = true;
					btnVideos.Enabled = true;
					break;
				case "RRPP":
					btnUsuarios.Enabled = false;
					btnMensajes.Enabled = true;
					btnVideos.Enabled = false;
					break;
				default:
					btnUsuarios.Enabled = false;
					btnMensajes.Enabled = false;
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
	}
}
