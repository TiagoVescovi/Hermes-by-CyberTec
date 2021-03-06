using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ChatInstitucional.Logica;
using System.Data;
using System.Drawing;
using System.IO;

namespace ChatInstitucional.De_persistencia
{
    public class Connect
    {
        MySqlConnection connection = new MySqlConnection();

        public Connect()
        {
            try
            {
                connection = new MySqlConnection("server=192.168.5.50;Port=3306; database=cyber_tec; user id=tiago.vescovi;password=54611821;SSL MODE = 0");
            }
            catch
            {
                Console.Write("Error en la conexion");
            }
        }

        public bool ModifyPicture(byte[] picture, int ci)
        {
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("UPDATE persona SET foto = @foto WHERE cedula = " + ci + ";", connection);
                command.Parameters.AddWithValue("@foto", picture);
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool Update(string query)
        {
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool Insert(string query)
        {
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
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

        public bool Delete(string query)
        {
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool LogOutBDD(int ci) // CERRAR SESION
        {
            try
            {
                connection.Open();
                MySqlCommand UpdateLogueado = new MySqlCommand("UPDATE persona SET logueado = false WHERE cedula = " + ci + ";", connection);
                UpdateLogueado.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}

