using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ChatInstitucional.Logica;
using System.Data;

namespace ChatInstitucional.De_persistencia
{
    class Connect
    {
        MySqlConnection connection = new MySqlConnection();

        public Connect()
        {
            try
            {
                connection = new MySqlConnection("server=127.0.0.1;Port=3306; database=bd_chat; Uid=root; Password=;SSL MODE = 0");
            }
            catch
            {
                Console.Write("Error en la conexion");
            }
        }

        public bool ModifyPicture(byte[] picture, int ci)
        {
            bool modified = false;

            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("UPDATE persona SET foto = @foto WHERE cedula = " + ci + ";", connection);
                command.Parameters.AddWithValue("@foto", picture);
                command.ExecuteNonQuery();
                modified = true;
            }
            catch
            {
                modified = false;
            }
            finally
            {
                connection.Close();
            }

            return modified;
        }

        public bool Update(string query)
        {
            bool updated = false;

            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                updated = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                updated = false;
            }
            finally
            {
                connection.Close();
            }

            return updated;
        }

        public bool Insert(string query)
        {
            bool insertado = false; //Generalizar los Inserts y Selects

            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                insertado = true;
            }
            catch
            {
                insertado = false;
            }
            finally
            {
                connection.Close();
            }

            return insertado;
        }

        public DataTable Select(string query)
        {
            DataTable dataTable = new DataTable();

            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return dataTable;
        }

        public bool LogOutBDD(int ci) // CERRAR SESION
        {
            bool Salio = false;

            try
            {
                connection.Open();
                MySqlCommand UpdateLogueado = new MySqlCommand("UPDATE persona SET logueado = false WHERE cedula = " + ci + ";", connection);
                UpdateLogueado.ExecuteNonQuery();
                Salio = true;
            }
            catch
            {
                Salio = false;
            }
            finally
            {
                connection.Close();
            }

            return Salio;
        }
    }
}

