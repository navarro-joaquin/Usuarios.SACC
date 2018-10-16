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
    public partial class FrmReporteHorasPico : Form
    {
        public FrmReporteHorasPico()
        {
            InitializeComponent();
        }

        private void FrmReporteHorasPico_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string fechaInicio = dtpFechaInicio.Value.ToString("yyyy-MM-dd");
            string fechaFin = dtpFechaFin.Value.ToString("yyyy-MM-dd");

            List<ReportParameter> reportParams = new List<ReportParameter>();
            reportParams.Add(new ReportParameter("FechaInicio", fechaInicio));
            reportParams.Add(new ReportParameter("FechaFin", fechaFin));

            reportViewer1.LocalReport.SetParameters(reportParams);

            consultasDataSet ds = new consultasDataSet();
            string ConnectionString = ConfigurationManager.ConnectionStrings["Utilitarios.SACC.Properties.Settings.cessa_bdsaccConnectionString"].ConnectionString;
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = ConnectionString;
            connection.Open();

            string Consulta =
                "SELECT COUNT(id) AS Total, " +
                "(SELECT COUNT(id) FROM tickets WHERE fecha_solicitud BETWEEN '" + fechaInicio + "' AND '" + fechaFin + "' AND hora_solicitud BETWEEN '08:00:00' AND '10:00:00' AND tipo IN('A', 'B', 'C')) AS 'PlataformaDe8a10', " +
                "(SELECT COUNT(id) FROM tickets WHERE fecha_solicitud BETWEEN '" + fechaInicio + "' AND '" + fechaFin + "' AND hora_solicitud BETWEEN '08:00:00' AND '10:00:00' AND tipo IN('G', 'H', 'I')) AS 'CajasDe8a10', " +
                "(SELECT COUNT(id) FROM tickets WHERE fecha_solicitud BETWEEN '" + fechaInicio + "' AND '" + fechaFin + "' AND hora_solicitud BETWEEN '10:00:00' AND '12:00:00' AND tipo IN('A', 'B', 'C')) AS 'PlataformaDe10a12', " +
                "(SELECT COUNT(id) FROM tickets WHERE fecha_solicitud BETWEEN '" + fechaInicio + "' AND '" + fechaFin + "' AND hora_solicitud BETWEEN '10:00:00' AND '12:00:00' AND tipo IN('G', 'H', 'I')) AS 'CajasDe10a12', " +
                "(SELECT COUNT(id) FROM tickets WHERE fecha_solicitud BETWEEN '" + fechaInicio + "' AND '" + fechaFin + "' AND hora_solicitud BETWEEN '14:00:00' AND '16:00:00' AND tipo IN('A', 'B', 'C')) AS 'PlataformaDe14a16', " +
                "(SELECT COUNT(id) FROM tickets WHERE fecha_solicitud BETWEEN '" + fechaInicio + "' AND '" + fechaFin + "' AND hora_solicitud BETWEEN '14:00:00' AND '16:00:00' AND tipo IN('G', 'H', 'I')) AS 'CajasDe14a16', " +
                "(SELECT COUNT(id) FROM tickets WHERE fecha_solicitud BETWEEN '" + fechaInicio + "' AND '" + fechaFin + "' AND hora_solicitud BETWEEN '16:00:00' AND '18:00:00' AND tipo IN('A', 'B', 'C')) AS 'PlataformaDe16a18', " +
                "(SELECT COUNT(id) FROM tickets WHERE fecha_solicitud BETWEEN '" + fechaInicio + "' AND '" + fechaFin + "' AND hora_solicitud BETWEEN '16:00:00' AND '18:00:00' AND tipo IN('G', 'H', 'I')) AS 'CajasDe16a18' " +
                "FROM tickets " +
                "WHERE fecha_solicitud BETWEEN '2018-10-11' AND '2018-10-12' " +
                "AND hora_solicitud BETWEEN '08:00:00' AND '18:00:00'";

            MySqlCommand cmd = new MySqlCommand();
            MySqlDataAdapter adapter = new MySqlDataAdapter(Consulta, ConnectionString);
            adapter.Fill(ds, ds.Tables[3].TableName);

            ReportDataSource rds = new ReportDataSource("HorasPico", ds.Tables[3]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.Refresh();

            connection.Close();

            this.reportViewer1.RefreshReport();
        }
    }
}
