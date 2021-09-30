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
        MySqlConnection connection;

        public Connect()
        {
            try
            {
                connection = new MySqlConnection("server=127.0.0.1; database=bd chat; Uid=root; Pass=;");
            }
            catch
            {
                Console.Write("Error en la conexion");
            }
        }

        public bool AgregarAlumno(Alumno a)
        {
            bool added = false;

            try
            {
                connection.Open(); 
                MySqlCommand CheckPersona = new MySqlCommand("SELECT cedula FROM persona WHERE cedula = " + a.GetCI() + ";", connection);
                CheckPersona.ExecuteNonQuery();
                //Checkea si existe la persona

                if (CheckPersona.ToString() == a.GetCI().ToString())
                {
                    MySqlCommand CheckAlumno = new MySqlCommand("SELECT cedula FROM alumno WHERE cedula = " + a.GetCI() + ";", connection);
                    CheckAlumno.ExecuteNonQuery();
                    //Checkea si existe el alumno

                    if (CheckPersona.ToString() == CheckAlumno.ToString())
                    {
                        //El alumno ya existe
                        added = false;
                    }
                    else
                    {
                        MySqlCommand query = new MySqlCommand("INSERT INTO Alumno(cedula,idGrupo) VALUES(" + a.GetCI() + "," + a.GetIdGrupo() + ");", connection);
                        query.ExecuteNonQuery();
                        added = true;
                        //Inserta el alumno
                    }
                }
                else
                {
                    added = false;
                    //No existe una persona con esa cedula
                }
            }
            catch
            {
                //Ocurrio un error en la creacion del alumno
                added = false;
            }
            finally
            {
                connection.Close();
            }

            return added;
        }

        /*public bool AgregarDocente(Docente d)
        {
            bool added = false;

            try
            {
                connection.Open();
                MySqlCommand CheckPersona = new MySqlCommand("SELECT cedula FROM persona;", connection);
                CheckPersona.ExecuteNonQuery();

                if (CheckPersona.ToString() == d.GetCI().ToString())
                {
                    MySqlCommand CheckDocente = new MySqlCommand("SELECT cedula FROM docente;", connection);
                    CheckDocente.ExecuteNonQuery();

                    if (CheckPersona.ToString() == CheckDocente.ToString())
                    {
                        //El docente ya existe
                        added = false;
                    }
                    else
                    {
                        MySqlCommand query = new MySqlCommand("INSERT INTO docente(cedula) VALUES(" + d.GetCI() + ");", connection);
                        query.ExecuteNonQuery();
                        MySqlCommand com = new MySqlCommand("SELECT idMateria FROM materia WHERE nombre = '" + d.GetMateria() + "';");
                        String mate = com.ExecuteNonQuery().ToString();
                        MySqlCommand materia = new MySqlCommand("INSERT INTO enseña(idMateria,idProfesor) VALUES(" + mate + "'" + d.GetCI() + "');");
                        materia.ExecuteNonQuery();
                        added = true;
                    }
                }
                else
                {
                    added = false;
                    //No existe una persona con esa cedula
                }
            }
            catch
            {
                //Ocurrio un error en la creacion del docente
                added = false;
            }
            finally
            {
                connection.Close();
            }

            return added;
        }*/

        public void CrearConsulta()
        {
            //Crear consulta
        }

        public void MandarMensaje()
        {
            //Mandar mensaje
        }

        public bool LogInBDD(int ci, string pass)
        {
            bool ExistePersona = false;
            try
            {
                connection.Open();
                MySqlCommand CheckPersona = new MySqlCommand("SELECT cedula FROM persona WHERE cedula = " + ci + " AND activo = true AND logueado = false AND passwd = '" + pass + "';", connection);
                CheckPersona.ExecuteNonQuery();

                if (CheckPersona.ToString() != null)
                {
                    MySqlCommand UpdateLogueado = new MySqlCommand("UPDATE persona SET logueado = true WHERE cedula = " + ci + ";", connection);
                    UpdateLogueado.ExecuteNonQuery();
                    ExistePersona = true;
                }
            }
            catch
            {
                ExistePersona = false;
            }
            finally
            {
                connection.Close();
            }

            return ExistePersona;
        }

        public bool LogOutBDD(int ci)
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
