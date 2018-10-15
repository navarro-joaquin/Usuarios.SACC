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

namespace Utilitarios.SACC
{
    public partial class FrmConfAtencion : Form
    {

        private MySqlConnection connection;

        public FrmConfAtencion()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["Utilitarios.SACC.Properties.Settings.cessa_bdsaccConnectionString"].ConnectionString;
            connection = new MySqlConnection(ConnectionString);
        }

        //Abrir conexión a la base de datos
        public bool AbrirConexion()
        {
            if (connection.State == ConnectionState.Open)
            {
                return true;
            }
            else
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (MySqlException ex)
                {
                    switch (ex.Number)
                    {
                        case 0:
                            MessageBox.Show("No puede conectar al servidor. Contacte al Administrador");
                            break;

                        case 1045:
                            MessageBox.Show("Usuario/Contraseña incorrecto, por favor inténtelo nuevamente");
                            break;
                    }
                    return false;
                }
            }
        }

        //Cerrar Conexión
        public void CerrarConexion()
        {
            if (connection.State == ConnectionState.Open)
            {
                try
                {
                    connection.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //Procedimientos Almacenados
        public void Ejecutar(string query)
        {
            //Open connection
            if (this.AbrirConexion() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CerrarConexion();
            }
        }

        private void btnPlat2n1m_Click(object sender, EventArgs e)
        {
            string query =
                "USE `cessa_bdsacc`; " +
                "DROP function IF EXISTS `func_atencion_plataforma`; " +
                "CREATE DEFINER =`cessa`@`%` FUNCTION `func_atencion_plataforma`() RETURNS varchar(200) " +
                "BEGIN " +
                    "DECLARE consulta VARCHAR(200); " +
                    "DECLARE hayMayoresPlataforma BOOLEAN; " +
                    "DECLARE id_normal INT; " +
                    "DECLARE id_mayor INT; " +

                    "SET consulta := ''; " +
                    "SET hayMayoresPlataforma = NULL; " +

                    "IF EXISTS(SELECT id, hora_solicitud FROM tickets WHERE tickets.fecha_solicitud = CURRENT_DATE AND estado IN ('8', '9') ORDER BY estado DESC, numero ASC) THEN " +
                        "SET consulta = \"SELECT id, hora_solicitud FROM tickets WHERE fecha_solicitud = CURRENT_DATE AND estado IN('8', '9') ORDER BY estado DESC, numero ASC\"; " +
                        "RETURN consulta; " +
                    "ELSE " +
                        "IF EXISTS(SELECT id, hora_solicitud FROM tickets WHERE tickets.fecha_solicitud = CURRENT_DATE AND tipo IN('A') AND estado < 2) THEN " +
                            "IF EXISTS(SELECT id, hora_solicitud FROM tickets WHERE tickets.fecha_solicitud = CURRENT_DATE AND tipo IN('B', 'C') AND estado < 2) THEN " +
                                "SET id_mayor = (SELECT id FROM tickets WHERE tickets.fecha_solicitud = CURRENT_DATE AND tipo IN('B', 'C') AND estado< 2 ORDER BY numero ASC LIMIT 1); " +
                                "SET id_normal = (SELECT id FROM tickets WHERE tickets.fecha_solicitud = CURRENT_DATE AND tipo IN('A') AND estado< 2 ORDER BY numero ASC LIMIT 1); " +
                                "IF(id_mayor < id_normal) THEN " +
                                    "UPDATE aux_call SET aux_plat = 0 WHERE id = 1; " +
                                    "SET hayMayoresPlataforma := TRUE; " +
                                "ELSE " +

                                    "IF((SELECT aux_cajas FROM aux_plat WHERE id = 1) >= 0 AND(SELECT aux_plat FROM aux_call WHERE id = 1) < 2) THEN " +
                                        "UPDATE aux_call SET aux_plat = aux_plat + 1 WHERE id = 1; " +
                                        "SET hayMayoresPlataforma := FALSE; " +
                                    "ELSE " +
                                        "UPDATE aux_call SET aux_plat = 0 WHERE id = 1; " +
                                        "SET hayMayoresPlataforma := TRUE; " +
                                    "END IF; " +
                                "END IF; " +
                            "ELSE " +
                                "UPDATE aux_call SET aux_cajas = aux_plat + 1 WHERE id = 1; " +
                                "SET hayMayoresPlataforma := FALSE; " +
                            "END IF; " +
                        "ELSE " +
                            "UPDATE aux_call SET aux_plat = 0 WHERE id = 1; " +
                            "SET hayMayoresPlataforma = TRUE; " +
                        "END IF; " +

                        "IF(hayMayoresPlataforma = TRUE) THEN " +
                            "SET consulta:= \"SELECT id, hora_solicitud FROM tickets WHERE fecha_solicitud = CURRENT_DATE AND(estado < '2') AND tipo IN('B', 'C') ORDER BY estado DESC, numero ASC\"; " +
                            "RETURN consulta; " +
                        "ELSE " +
                            "SET consulta:= \"SELECT id, hora_solicitud FROM tickets WHERE fecha_solicitud = CURRENT_DATE AND(estado < '2') AND tipo IN('A') ORDER BY estado DESC, numero ASC\"; " +
                            "RETURN consulta; " +
                        "END IF; " +
                    "END IF; " +
                "END";

            try
            {
                Ejecutar(query);
                MessageBox.Show("Consulta ejecutada correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPlat2m1n_Click(object sender, EventArgs e)
        {
            string query =
                "USE `cessa_bdsacc`; " +
                "DROP function IF EXISTS `func_atencion_plataforma`; " +
                "CREATE DEFINER =`cessa`@`%` FUNCTION `func_atencion_plataforma`() RETURNS varchar(200) " +
                "BEGIN " +
                    "DECLARE consulta VARCHAR(200); " +
                    "DECLARE hayMayoresPlataforma BOOLEAN; " +
                    "DECLARE id_normal INT; " +
                    "DECLARE id_mayor INT; " +

                    "SET consulta := ''; " +
                    "SET hayMayoresPlataforma = NULL; " +

                    "IF EXISTS(SELECT id, hora_solicitud FROM tickets WHERE tickets.fecha_solicitud = CURRENT_DATE AND estado IN ('8', '9') ORDER BY estado DESC, numero ASC) THEN " +
                        "SET consulta = \"SELECT id, hora_solicitud FROM tickets WHERE fecha_solicitud = CURRENT_DATE AND estado IN('8', '9') ORDER BY estado DESC, numero ASC\"; " +
                        "RETURN consulta; " +
                    "ELSE " +
                        "IF EXISTS(SELECT id, hora_solicitud FROM tickets WHERE tickets.fecha_solicitud = CURRENT_DATE AND tipo IN('B', 'C') AND estado < 2) THEN " +
                            "IF EXISTS(SELECT id, hora_solicitud FROM tickets WHERE tickets.fecha_solicitud = CURRENT_DATE AND tipo IN('A') AND estado < 2) THEN " +
                                "SET id_normal = (SELECT id FROM tickets WHERE tickets.fecha_solicitud = CURRENT_DATE AND tipo IN('A') AND estado< 2 ORDER BY numero ASC LIMIT 1); " +
                                "SET id_mayor = (SELECT id FROM tickets WHERE tickets.fecha_solicitud = CURRENT_DATE AND tipo IN('B', 'C') AND estado< 2 ORDER BY numero ASC LIMIT 1); " +
                                "IF(id_mayor < id_normal) THEN " +
                                    "UPDATE aux_call SET aux_plat = 0 WHERE id = 1; " +
                                    "SET hayMayoresPlataforma := TRUE; " +
                                "ELSE " +

                                    "IF((SELECT aux_plat FROM aux_call WHERE id = 1) >= 0 AND(SELECT aux_plat FROM aux_call WHERE id = 1) < 1) THEN " +
                                        "UPDATE aux_call SET aux_plat = aux_plat + 1 WHERE id = 1; " +
                                        "SET hayMayoresPlataforma := FALSE; " +
                                    "ELSE " +
                                        "UPDATE aux_call SET aux_plat = 0 WHERE id = 1; " +
                                        "SET hayMayoresPlataforma := TRUE; " +
                                    "END IF; " +
                                "END IF; " +
                            "ELSE " +
                                "UPDATE aux_call SET aux_plat = 0 WHERE id = 1; " +
                                "SET hayMayoresPlataforma = TRUE; " +
                            "END IF; " +
                        "ELSE " +
                            "UPDATE aux_call SET aux_plat = 0 WHERE id = 1; " +
                            "SET hayMayoresPlataforma = TRUE; " +
                        "END IF; " +

                        "IF(hayMayoresPlataforma = TRUE) THEN " +
                            "SET consulta:= \"SELECT id, hora_solicitud FROM tickets WHERE fecha_solicitud = CURRENT_DATE AND(estado < '2') AND tipo IN('B', 'C') ORDER BY estado DESC, numero ASC\"; " +
                            "RETURN consulta; " +
                        "ELSE " +
                            "SET consulta:= \"SELECT id, hora_solicitud FROM tickets WHERE fecha_solicitud = CURRENT_DATE AND(estado < '2') AND tipo IN('A') ORDER BY estado DESC, numero ASC\"; " +
                        "RETURN consulta; " +
                        "END IF; " +
                    "END IF; " +
                "END";

            try
            {
                Ejecutar(query);
                MessageBox.Show("Consulta ejecutada correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCajas2n1m_Click(object sender, EventArgs e)
        {
            string query =
                "USE `cessa_bdsacc`; " +
                "DROP function IF EXISTS `func_atencion_cajas`; " +
                "CREATE DEFINER =`cessa`@`localhost` FUNCTION `func_atencion_cajas`() RETURNS varchar(200) " +
                "BEGIN " +
                    "DECLARE consulta VARCHAR(200); " +
                    "DECLARE hayMayoresCajas BOOLEAN; " +
                    "DECLARE id_normal INT; " +
                    "DECLARE id_mayor INT; " +

                    "SET consulta := ''; " +
                    "SET hayMayoresCajas = NULL; " +

                    "IF EXISTS(SELECT id, hora_solicitud FROM tickets WHERE tickets.fecha_solicitud = CURRENT_DATE AND estado IN ('6', '7') ORDER BY estado DESC, numero ASC) THEN " +
                        "SET consulta = \"SELECT id, hora_solicitud FROM tickets WHERE fecha_solicitud = CURRENT_DATE AND estado IN('6', '7') ORDER BY estado DESC, numero ASC\"; " +
                        "RETURN consulta; " +
                    "ELSE " +
                        "IF EXISTS(SELECT id, hora_solicitud FROM tickets WHERE tickets.fecha_solicitud = CURRENT_DATE AND tipo IN('G') AND estado < 2) THEN " +
                            "IF EXISTS(SELECT id, hora_solicitud FROM tickets WHERE tickets.fecha_solicitud = CURRENT_DATE AND tipo IN('H', 'I') AND estado < 2) THEN " +
                                "SET id_mayor = (SELECT id FROM tickets WHERE tickets.fecha_solicitud = CURRENT_DATE AND tipo IN('H', 'I') AND estado< 2 ORDER BY numero ASC LIMIT 1); " +
                                "SET id_normal = (SELECT id FROM tickets WHERE tickets.fecha_solicitud = CURRENT_DATE AND tipo IN('G') AND estado< 2 ORDER BY numero ASC LIMIT 1); " +
                                "IF(id_mayor < id_normal) THEN " +
                                    "UPDATE aux_call SET aux_cajas = 0 WHERE id = 1; " +
                                    "SET hayMayoresCajas := TRUE; " +
                                "ELSE " +

                                    "IF((SELECT aux_cajas FROM aux_call WHERE id = 1) >= 0 AND(SELECT aux_cajas FROM aux_call WHERE id = 1) < 2) THEN " +
                                        "UPDATE aux_call SET aux_cajas = aux_cajas + 1 WHERE id = 1; " +
                                        "SET hayMayoresCajas := FALSE; " +
                                    "ELSE " +
                                        "UPDATE aux_call SET aux_cajas = 0 WHERE id = 1; " +
                                        "SET hayMayoresCajas := TRUE; " +
                                    "END IF; " +
                                "END IF; " +
                            "ELSE " +
                                "UPDATE aux_call SET aux_cajas = aux_cajas + 1 WHERE id = 1; " +
                                "SET hayMayoresCajas := FALSE; " +
                            "END IF; " +
                        "ELSE " +
                            "UPDATE aux_call SET aux_cajas = 0 WHERE id = 1; " +
                            "SET hayMayoresCajas = TRUE; " +
                        "END IF; " +

                        "IF(hayMayoresCajas = TRUE) THEN " +
                            "SET consulta:= \"SELECT id, hora_solicitud FROM tickets WHERE fecha_solicitud = CURRENT_DATE AND(estado < '2') AND tipo IN('H', 'I') ORDER BY estado DESC, numero ASC\"; " +
                            "RETURN consulta; " +
                        "ELSE " +
                            "SET consulta:= \"SELECT id, hora_solicitud FROM tickets WHERE fecha_solicitud = CURRENT_DATE AND(estado < '2') AND tipo IN('G') ORDER BY estado DESC, numero ASC\"; " +
                            "RETURN consulta; " +
                        "END IF; " +
                    "END IF; " +
                "END";

            try
            {
                Ejecutar(query);
                MessageBox.Show("Consulta ejecutada correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCajas2m1n_Click(object sender, EventArgs e)
        {
            string query =
                "USE `cessa_bdsacc`; " +
                "DROP function IF EXISTS `func_atencion_cajas`; " +
                "CREATE DEFINER =`cessa`@`localhost` FUNCTION `func_atencion_cajas`() RETURNS varchar(200) " +
                "BEGIN " +
                    "DECLARE consulta VARCHAR(200); " +
                    "DECLARE hayMayoresCajas BOOLEAN; " +
                    "DECLARE id_normal INT; " +
                    "DECLARE id_mayor INT; " +

                    "SET consulta := ''; " +
                    "SET hayMayoresCajas = NULL; " +

                    "IF EXISTS(SELECT id, hora_solicitud FROM tickets WHERE tickets.fecha_solicitud = CURRENT_DATE AND estado IN ('6', '7') ORDER BY estado DESC, numero ASC) THEN " +
                        "SET consulta = \"SELECT id, hora_solicitud FROM tickets WHERE fecha_solicitud = CURRENT_DATE AND estado IN('6', '7') ORDER BY estado DESC, numero ASC\"; " +
                        "RETURN consulta; " +
                    "ELSE " +
                        "IF EXISTS(SELECT id, hora_solicitud FROM tickets WHERE tickets.fecha_solicitud = CURRENT_DATE AND tipo IN('H', 'I') AND estado < 2) THEN " +
                            "IF EXISTS(SELECT id, hora_solicitud FROM tickets WHERE tickets.fecha_solicitud = CURRENT_DATE AND tipo IN('G') AND estado < 2) THEN " +
                                "SET id_normal = (SELECT id FROM tickets WHERE tickets.fecha_solicitud = CURRENT_DATE AND tipo IN('G') AND estado< 2 ORDER BY numero ASC LIMIT 1); " +
                                "SET id_mayor = (SELECT id FROM tickets WHERE tickets.fecha_solicitud = CURRENT_DATE AND tipo IN('H', 'I') AND estado< 2 ORDER BY numero ASC LIMIT 1); " +
                                "IF(id_mayor < id_normal) THEN " +
                                    "UPDATE aux_call SET aux_cajas = 0 WHERE id = 1; " +
                                    "SET hayMayoresCajas := TRUE; " +
                                "ELSE " +

                                    "IF((SELECT aux_cajas FROM aux_call WHERE id = 1) >= 0 AND(SELECT aux_cajas FROM aux_call WHERE id = 1) < 1) THEN " +
                                        "UPDATE aux_call SET aux_cajas = aux_cajas + 1 WHERE id = 1; " +
                                        "SET hayMayoresCajas := FALSE; " +
                                    "ELSE " +
                                        "UPDATE aux_call SET aux_cajas = 0 WHERE id = 1; " +
                                        "SET hayMayoresCajas := TRUE; " +
                                    "END IF; " +
                                "END IF; " +
                            "ELSE " +
                                "UPDATE aux_call SET aux_cajas = 0 WHERE id = 1; " +
                                "SET hayMayoresCajas = TRUE; " +
                            "END IF; " +
                        "ELSE " +
                            "UPDATE aux_call SET aux_cajas = 0 WHERE id = 1; " +
                            "SET hayMayoresCajas = TRUE; " +
                        "END IF; " +

                        "IF(hayMayoresCajas = TRUE) THEN " +
                            "SET consulta:= \"SELECT id, hora_solicitud FROM tickets WHERE fecha_solicitud = CURRENT_DATE AND(estado < '2') AND tipo IN('H', 'I') ORDER BY estado DESC, numero ASC\"; " +
                            "RETURN consulta; " +
                        "ELSE " +
                            "SET consulta:= \"SELECT id, hora_solicitud FROM tickets WHERE fecha_solicitud = CURRENT_DATE AND(estado < '2') AND tipo IN('G') ORDER BY estado DESC, numero ASC\"; " +
                        "RETURN consulta; " +
                        "END IF; " +
                    "END IF; " +
                "END";

            try
            {
                Ejecutar(query);
                MessageBox.Show("Consulta ejecutada correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
