using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace Utilitarios.SACC
{
    public class DBMySQL
    {
        private MySqlConnection connection;

        //MySqlDataAdapter adapter;
        //DataTable DTItems;

        //Constructor
        public DBMySQL()
        {
            Initialize();
        }

        //Inicializar valores
        private void Initialize()
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["Utilitarios.SACC.Properties.Settings.cessa_bdsaccConnectionString"].ConnectionString;
            connection = new MySqlConnection(ConnectionString);
        }


        //Abrir conexión a la base de datos
        private bool AbrirConexion()
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

        //Insert statement
        public bool Insertar(string query)
        {
            //open connection
            if (this.AbrirConexion() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CerrarConexion();
                return true;
            }
            else
            {
                return false;
            }
        }

        //Update statement
        public void Actualizar(string query)
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

        //Delete statement
        public void Eliminar(string query)
        {
            if (this.AbrirConexion() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CerrarConexion();
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

        //Select statement (OJO REVISAR)
        public MySqlDataReader Seleccionar(string query)
        {
            //Open connection
            if (this.AbrirConexion() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                return dataReader;
            }
            else
            {
                return null;
            }
        }

        //Count statement
        public int NroRegistros(string query)
        {
            int Count = -1;

            //Open Connection
            if (this.AbrirConexion() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CerrarConexion();

                return Count;
            }
            else
            {
                return Count;
            }
        }
    }
}
