using MySql.Data.MySqlClient;
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

        DBMySQL dbMySQL = new DBMySQL();
        

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

        //Cargar datos de usuarios conectados y tickets en cola
        private void CargarUsuarios()
        {
            string query = 
                "SELECT COUNT(usuarios_log.id) AS 'Usuarios conectados', usuarios.rol AS 'Rol' FROM usuarios_log " +
                "INNER JOIN usuarios " +
                "ON usuarios_log.login = usuarios.login " +
                "WHERE usuarios_log.estado = 'C' " +
                "GROUP BY usuarios.rol; ";

            using (MySqlDataReader dataReader = dbMySQL.Seleccionar(query))
            {
                string Rol = "";
                string UsuariosConectados = "";
                string Cantidad = "";
                lblCantPlat.ResetText();
                lblPlataforma.ResetText();
                while (dataReader.Read())
                {
                    Rol = dataReader.GetString(1) + ": ";
                    UsuariosConectados = dataReader.GetString(0) + " ";
                    if (dataReader.GetString(0).Equals("1"))
                    {
                        Cantidad = "Usuario";
                    }
                    else
                    {
                        Cantidad = "Usuarios";
                    }
                    lblPlataforma.Text += Rol + "\n";
                    lblCantPlat.Text += UsuariosConectados + Cantidad + "\n" ;
                }
                dataReader.Close();
            }
        }

        private void TicketsPlataforma()
        {
            string query = 
                "SELECT COUNT(id) AS 'Tickets pendientes' " +
                "FROM tickets " +
                "WHERE fecha_solicitud = CURRENT_DATE " +
                "AND tipo IN ('A', 'B', 'C') AND " +
                "estado < 2 " +
                "ORDER BY id DESC;";
            using (MySqlDataReader dataReader = dbMySQL.Seleccionar(query))
            {
                string CantidadTicketsPlataforma = "";
                if (dataReader.Read())
                {
                    CantidadTicketsPlataforma = dataReader.GetString(0);
                    lblCantTicketPlataforma.Text = CantidadTicketsPlataforma + " Tickets";
                    dataReader.Close();
                }
            }
        }

        private void TicketsCajas()
        {
            string query =
                "SELECT COUNT(id) AS 'Tickets pendientes' " +
                "FROM tickets " +
                "WHERE fecha_solicitud = CURRENT_DATE " +
                "AND tipo IN ('G', 'H', 'I') AND " +
                "estado < 2 " +
                "ORDER BY id DESC;";
            using (MySqlDataReader dataReader = dbMySQL.Seleccionar(query))
            {
                string CantidadTicketsCajas = "";
                if (dataReader.Read())
                {
                    CantidadTicketsCajas = dataReader.GetString(0);
                    lblCantTicketCajas.Text = CantidadTicketsCajas + " Tickets";
                    dataReader.Close();
                }
            }
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

        private void timer_Tick(object sender, EventArgs e)
        {
            CargarUsuarios();
            TicketsPlataforma();
            TicketsCajas();
        }

        private void MnuItemHorasPico_Click(object sender, EventArgs e)
        {
            FrmReporteHorasPico frm = new FrmReporteHorasPico();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
