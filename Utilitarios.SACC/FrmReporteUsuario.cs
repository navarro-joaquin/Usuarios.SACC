using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using Microsoft.Reporting.WinForms;
using System.IO;

namespace Utilitarios.SACC
{
    public partial class FrmReporteUsuario : Form
    { 
        string fecha;
        string nombre_usuario;
        int id_usuario;

        public FrmReporteUsuario()
        {
            InitializeComponent();
        }

        public FrmReporteUsuario(string fecha_param, int id_param)
        {
            InitializeComponent();
            fecha = fecha_param;
            id_usuario = id_param;
        }

        public FrmReporteUsuario(string fecha_param, int id_param, string nombre_param)
        {
            InitializeComponent();
            fecha = fecha_param;
            id_usuario = id_param;
            nombre_usuario = nombre_param;
        }

        private void FrmReporteUsuario_Load(object sender, EventArgs e)
        {
            consultasDataSet ds = new consultasDataSet();
            string ConnectionString = ConfigurationManager.ConnectionStrings["Utilitarios.SACC.Properties.Settings.cessa_bdsaccConnectionString"].ConnectionString;
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = ConnectionString;
            connection.Open();

            string Consulta = "SELECT usuarios.login, tickets.ubicacion, tickets.fecha_solicitud, CONCAT(tickets.tipo, '-', tickets.numero) as Ticket, tickets.hora_atencion, tickets.hora_conclusion,"
                             + " SUBTIME(tickets.hora_conclusion, tickets.hora_atencion) as TiempoAtencion,"
                             + " (SELECT SEC_TO_TIME(AVG(TIME_TO_SEC(SUBTIME(tickets.hora_conclusion, tickets.hora_atencion)))) AS TiempoAtencionPromedio FROM tickets WHERE tickets.estado = 4 AND tickets.fecha_solicitud = '" + fecha + "' AND tickets.usuario_operador_id = " + id_usuario + " AND(SUBTIME(tickets.hora_conclusion, tickets.hora_atencion) > '00:00:45')) AS TiempoAtencionPromedio,"
                             + " (SELECT COUNT(tickets.id) FROM tickets WHERE tickets.estado = 4 AND tickets.fecha_solicitud = '" + fecha + "' AND tickets.usuario_operador_id = " + id_usuario + " AND(SUBTIME(tickets.hora_conclusion, tickets.hora_atencion) > '00:00:45')) AS TotalAtendidos"
                             + " FROM tickets INNER JOIN usuarios"
                             + " ON tickets.usuario_operador_id = usuarios.id"
                             + " WHERE tickets.estado = 4 AND tickets.fecha_solicitud = '" + fecha + "' AND tickets.usuario_operador_id = " + id_usuario + " AND(SUBTIME(tickets.hora_conclusion, tickets.hora_atencion) > '00:00:45')"
                             + " ORDER BY tickets.hora_atencion ASC";

            MySqlCommand cmd = new MySqlCommand();
            MySqlDataAdapter adapter = new MySqlDataAdapter(Consulta, ConnectionString);
            adapter.Fill(ds, ds.Tables[0].TableName);

            ReportDataSource rds = new ReportDataSource("Consulta", ds.Tables[0]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.Refresh();

            connection.Close();

            this.reportViewer1.RefreshReport();
        }

        public string generarPDF()
        {
            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string fileNameExtension;

            byte[] bytes = reportViewer1.LocalReport.Render(
                "PDF", null, out mimeType, out encoding, out fileNameExtension,
                out streamids, out warnings);

            string nombre_archivo = @"Reportes\Reporte Atencion " + nombre_usuario + " " + fecha + ".pdf";

            using (FileStream fs = new FileStream(nombre_archivo, FileMode.Create))
            {
                fs.Write(bytes, 0, bytes.Length);
            }

            return nombre_archivo;
        }
    }
}
