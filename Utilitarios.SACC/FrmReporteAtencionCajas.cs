using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using Microsoft.Reporting.WinForms;
using System.Configuration;

namespace Utilitarios.SACC
{
    public partial class FrmReporteAtencionCajas : Form
    {
        public FrmReporteAtencionCajas()
        {
            InitializeComponent();
        }

        private void FrmReporteAtencionCajas_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string fecha = dtpFecha.Value.ToString("yyyy-MM-dd");
            string sector = "Caja";

            List<ReportParameter> reportParams = new List<ReportParameter>();
            reportParams.Add(new ReportParameter("Fecha", fecha));

            reportViewer1.LocalReport.SetParameters(reportParams);

            consultasDataSet ds = new consultasDataSet();
            string ConnectionString = ConfigurationManager.ConnectionStrings["Utilitarios.SACC.Properties.Settings.cessa_bdsaccConnectionString"].ConnectionString;
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = ConnectionString;
            connection.Open();

            string Consulta = "SELECT usuarios.login AS Operador, COUNT(tickets.id) AS TotalAtendidosDia, tickets.fecha_solicitud AS Fecha, tickets.ubicacion as Ubicacion, " +
                "SUBSTRING(SEC_TO_TIME(AVG(TIME_TO_SEC(SUBTIME(tickets.hora_conclusion, tickets.hora_atencion)))), 1, 8) AS TiempoPromedio, " +
                "(SELECT SUBSTRING(SEC_TO_TIME(AVG(TIME_TO_SEC(SUBTIME(tickets.hora_conclusion, tickets.hora_atencion)))), 1, 8) FROM tickets " +
                "WHERE tickets.fecha_solicitud BETWEEN '" + fecha + "' AND '" + fecha + "' " +
                "AND tickets.estado = 4 " +
                "AND tickets.ubicacion LIKE ('" + sector + "%') " +
                "AND (SUBTIME(tickets.hora_conclusion, tickets.hora_atencion) > '00:00:45')) AS TiempoPromedioTotal " +
                "FROM tickets " +
                "INNER JOIN usuarios " +
                "ON tickets.usuario_operador_id = usuarios.id " +
                "WHERE tickets.fecha_solicitud BETWEEN '" + fecha + "' AND '" + fecha + "' " +
                "AND tickets.estado = 4 " +
                "AND tickets.ubicacion LIKE ('" + sector + "%')" +
                "AND (SUBTIME(tickets.hora_conclusion, tickets.hora_atencion) > '00:00:45') " +
                "GROUP BY tickets.usuario_operador_id";

            MySqlCommand cmd = new MySqlCommand();
            MySqlDataAdapter adapter = new MySqlDataAdapter(Consulta, ConnectionString);
            adapter.Fill(ds, ds.Tables[2].TableName);

            ReportDataSource rds = new ReportDataSource("ComparativaPlataforma", ds.Tables[2]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.Refresh();

            connection.Close();

            this.reportViewer1.RefreshReport();
        }
    }
}
