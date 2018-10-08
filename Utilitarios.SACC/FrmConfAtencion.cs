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
                    "DECLARE contador INT; " +
                    "DECLARE consulta VARCHAR(200); " +
                    "DECLARE bandera BOOLEAN; " +
                    "DECLARE hora TIME; " +
                    "DECLARE hora_normal TIME; " +
                    "DECLARE hayMayoresPlataforma BOOLEAN; " +
                    "SET hayMayoresPlataforma = NULL; " +
                    "SET contador = 0; " +
                    "SET consulta = \"\"; " +
                    "SET bandera = FALSE; " +
                    "SET hora = '00:00:00'; " +
                    "SET hora_normal = '00:00:00'; " +
                    "IF EXISTS(SELECT id, hora_solicitud FROM tickets WHERE tickets.fecha_solicitud = CURRENT_DATE AND estado IN ('8', '9') ORDER BY estado DESC, numero ASC) THEN " +
                        "SET consulta = \"SELECT id, hora_solicitud FROM tickets WHERE fecha_solicitud = CURRENT_DATE AND estado IN('8', '9') ORDER BY estado DESC, numero ASC\"; " +
                        "RETURN consulta; " +
                    "ELSE " +
                        "IF EXISTS (SELECT id, hora_solicitud FROM tickets WHERE tickets.fecha_solicitud = CURRENT_DATE AND tipo IN ('B', 'C') AND estado < 2) THEN " +
                            "SET hora = (SELECT hora_solicitud FROM tickets WHERE tickets.fecha_solicitud = CURRENT_DATE AND tipo IN ('B', 'C') AND estado < 2 ORDER BY estado DESC, numero ASC LIMIT 1); " +
                        "ELSE " +
                            "SET hora = '23:59:59'; " +
                        "END IF; " +
                        "IF (EXISTS(SELECT id, hora_solicitud FROM tickets WHERE tickets.fecha_solicitud = CURRENT_DATE AND tipo IN ('B', 'C') AND estado < 2) AND bandera) THEN " +
                            "SET contador = 0; " +
                            "SET bandera = FALSE; " +
                            "SET hayMayoresPlataforma = TRUE; " +
                        "ELSE " +
                            "IF EXISTS(SELECT id, hora_solicitud FROM tickets WHERE tickets.fecha_solicitud = CURRENT_DATE AND tipo IN ('A') AND estado < 2) THEN " +
                                "SET hayMayoresPlataforma = FALSE; " +
                                "SET contador = contador + 1; " +
                                "SET hora_normal = (SELECT hora_solicitud FROM tickets WHERE tickets.fecha_solicitud = CURRENT_DATE AND tipo IN ('A') AND estado < 2 ORDER BY estado DESC, numero ASC LIMIT 1); " +
                                "IF (contador = 2 OR (hora < hora_normal)) THEN " +
                                    "SET hayMayoresPlataforma = TRUE; " +
                                    "SET contador = 0; " +
                                "END IF; " +
                            "ELSE " +
                                "SET hayMayoresPlataforma = TRUE; " +
                                "SET contador = 0; " +
                            "END IF; " +
                            "IF (contador = 2) THEN " +
                                "SET bandera = TRUE; " +
                            "END IF; " +
                        "END IF; " +
                        "IF (hayMayoresPlataforma = TRUE) THEN " +
                            "SET consulta = \"SELECT id, hora_solicitud FROM tickets WHERE fecha_solicitud = CURRENT_DATE AND(estado < '2') AND tipo IN('B', 'C') ORDER BY estado DESC, numero ASC\"; " +
                            "RETURN consulta; " +
                        "ELSE " +
                            "SET consulta = \"SELECT id, hora_solicitud FROM tickets WHERE fecha_solicitud = CURRENT_DATE AND(estado < '2') AND tipo IN('A') ORDER BY estado DESC, numero ASC\"; " +
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
                    "DECLARE contador INT; " +
                    "DECLARE consulta VARCHAR(200); " +
                    "SET contador := 0; " +
                    "SET consulta := ''; " +
                    "IF EXISTS(SELECT id, hora_solicitud FROM tickets WHERE tickets.fecha_solicitud = CURRENT_DATE AND tipo IN('B', 'C') AND estado < 2) THEN " +
                        "IF(contador >= 0 AND contador < 2) THEN " +
                            "SET contador = contador + 1; " +
                            "SET consulta = \"SELECT id, hora_solicitud FROM tickets WHERE fecha_solicitud = CURRENT_DATE AND (estado < '2') AND tipo IN ('B', 'C') ORDER BY estado DESC, numero ASC\"; " +
                            "RETURN consulta; " +
                        "ELSE " +
                            "SET contador = 0; " +
                            "SET consulta = \"SELECT id, hora_solicitud FROM tickets WHERE fecha_solicitud = CURRENT_DATE AND (estado < '2') AND tipo IN ('A') ORDER BY estado DESC, numero ASC\"; " +
                            "RETURN consulta; " +
                        "END IF; " +
                    "ELSE " +
                        "SET contador = 0; " +
                        "SET consulta = \"SELECT id, hora_solicitud FROM tickets WHERE fecha_solicitud = CURRENT_DATE AND (estado < '2') AND tipo IN ('A') ORDER BY estado DESC, numero ASC\"; " +
                        "RETURN consulta; " +
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
                "DROP function IF EXISTS `func_atencion_cajas_otro`; " +
                "CREATE DEFINER =`cessa`@`%` FUNCTION `func_atencion_cajas_otro`() RETURNS varchar(200) " +
                "BEGIN " +
                    "DECLARE contador INT; " +
                    "DECLARE consulta VARCHAR(200); " +
                    "DECLARE bandera BOOLEAN; " +
                    "DECLARE hora TIME; " +
                    "DECLARE hora_normal TIME; " +
                    "DECLARE hayMayoresCajas BOOLEAN; " +
                    "SET hayMayoresCajas = NULL; " +
                    "SET contador = 0; " +
                    "SET consulta = \"\"; " +
                    "SET bandera = FALSE; " +
                    "SET hora = '00:00:00'; " +
                    "SET hora_normal = '00:00:00'; " +
                    "IF EXISTS(SELECT id, hora_solicitud FROM tickets WHERE tickets.fecha_solicitud = CURRENT_DATE AND estado IN ('6', '7') ORDER BY estado DESC, numero ASC) THEN " +
                        "SET consulta = \"SELECT id, hora_solicitud FROM tickets WHERE fecha_solicitud = CURRENT_DATE AND estado IN('6', '7') ORDER BY estado DESC, numero ASC\"; " +
                        "RETURN consulta; " +
                    "ELSE " +
                        "IF EXISTS (SELECT id, hora_solicitud FROM tickets WHERE tickets.fecha_solicitud = CURRENT_DATE AND tipo IN ('H', 'I') AND estado < 2) THEN " +
                            "SET hora = (SELECT hora_solicitud FROM tickets WHERE tickets.fecha_solicitud = CURRENT_DATE AND tipo IN ('H', 'I') AND estado < 2 ORDER BY estado DESC, numero ASC LIMIT 1); " +
                        "ELSE " +
                            "SET hora = '23:59:59'; " +
                        "END IF; " +
                        "IF (EXISTS(SELECT id, hora_solicitud FROM tickets WHERE tickets.fecha_solicitud = CURRENT_DATE AND tipo IN ('H', 'I') AND estado < 2) AND bandera) THEN " +
                            "SET contador = 0; " +
                            "SET bandera = FALSE; " +
                            "SET hayMayoresCajas = TRUE; " +
                        "ELSE " +
                            "IF EXISTS(SELECT id, hora_solicitud FROM tickets WHERE tickets.fecha_solicitud = CURRENT_DATE AND tipo IN ('G') AND estado < 2) THEN " +
                                "SET hayMayoresCajas = FALSE; " +
                                "SET contador = contador + 1; " +
                                "SET hora_normal = (SELECT hora_solicitud FROM tickets WHERE tickets.fecha_solicitud = CURRENT_DATE AND tipo IN ('G') AND estado < 2 ORDER BY estado DESC, numero ASC LIMIT 1); " +
                                "IF (contador = 2 OR (hora < hora_normal)) THEN " +
                                    "SET hayMayoresCajas = TRUE; " +
                                    "SET contador = 0; " +
                                "END IF; " +
                            "ELSE " +
                                "SET hayMayoresCajas = TRUE; " +
                                "SET contador = 0; " +
                            "END IF; " +
                            "IF (contador = 2) THEN " +
                                "SET bandera = TRUE; " +
                            "END IF; " +
                        "END IF; " +
                        "IF (hayMayoresCajas = TRUE) THEN " +
                            "SET consulta = \"SELECT id, hora_solicitud FROM tickets WHERE fecha_solicitud = CURRENT_DATE AND(estado < '2') AND tipo IN('H', 'I') ORDER BY estado DESC, numero ASC\"; " +
                            "RETURN consulta; " +
                        "ELSE " +
                            "SET consulta = \"SELECT id, hora_solicitud FROM tickets WHERE fecha_solicitud = CURRENT_DATE AND(estado < '2') AND tipo IN('G') ORDER BY estado DESC, numero ASC\"; " +
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
                "DROP function IF EXISTS `func_atencion_cajas_otro`; " +
                "CREATE DEFINER =`cessa`@`%` FUNCTION `func_atencion_cajas_otro`() RETURNS varchar(200) " +
                "BEGIN " +
                    "DECLARE contador INT; " +
                    "DECLARE consulta VARCHAR(200); " +
                    "SET contador := 0; " +
                    "SET consulta := ''; " +
                    "IF EXISTS(SELECT id, hora_solicitud FROM tickets WHERE tickets.fecha_solicitud = CURRENT_DATE AND tipo IN('H', 'I') AND estado < 2) THEN " +
                        "IF(contador >= 0 AND contador < 2) THEN " +
                            "SET contador = contador + 1; " +
                            "SET consulta = \"SELECT id, hora_solicitud FROM tickets WHERE fecha_solicitud = CURRENT_DATE AND (estado < '2') AND tipo IN ('H', 'I') ORDER BY estado DESC, numero ASC\"; " +
                            "RETURN consulta; " +
                        "ELSE " +
                            "SET contador = 0; " +
                            "SET consulta = \"SELECT id, hora_solicitud FROM tickets WHERE fecha_solicitud = CURRENT_DATE AND (estado < '2') AND tipo IN ('G') ORDER BY estado DESC, numero ASC\"; " +
                            "RETURN consulta; " +
                        "END IF; " +
                    "ELSE " +
                        "SET contador = 0; " +
                        "SET consulta = \"SELECT id, hora_solicitud FROM tickets WHERE fecha_solicitud = CURRENT_DATE AND (estado < '2') AND tipo IN ('G') ORDER BY estado DESC, numero ASC\"; " +
                        "RETURN consulta; " +
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
