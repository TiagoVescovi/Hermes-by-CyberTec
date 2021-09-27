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
                Console.Write("Trolleo el connect");
            }
        }

        public bool AgregarAlumno(Alumno a)
        {
            bool added = false;

            try
            {
                connection.Open();
                MySqlCommand CheckPersona = new MySqlCommand("SELECT cedula FROM persona;", connection);
                CheckPersona.ExecuteNonQuery();

                if (CheckPersona.ToString().Contains(a.GetCI().ToString()))
                {
                    MySqlCommand CheckAlumno = new MySqlCommand("SELECT cedula FROM alumno;", connection);
                    CheckAlumno.ExecuteNonQuery();

                    if (CheckPersona.ToString() == CheckAlumno.ToString())
                    {
                        //El alumno ya existe
                        added = false;
                    }
                    else
                    {
                        MySqlCommand query = new MySqlCommand("INSERT INTO Alumno(cedula,nickname,idGrupo) VALUES(" + a.ToStringo() + ");", connection);
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

        /*public String Logueado()
        {
            String TipoUsuario = "error";
            //Persona p = new Persona();
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("SELECT cedula FROM persona WHERE cedula = '" + "';");
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }
            return TipoUsuario;
        }*/

        public bool LogInBDD(int ci, String pass)
        {
            bool entro = false;
            try
            {
                connection.Open();
                MySqlCommand command = connection.CreateCommand(); //Atributo activo en la base de datos comprobar
                command.CommandText = "SELECT cedula FROM persona WHERE (cedula = 42932919) AND (passwd = 'contra123');";
                int cedula = Convert.ToInt32(command.ExecuteNonQuery());
                if (cedula > 0)
                {
                    Console.Write(Convert.ToInt32(command));
                    entro = true;
                }
                if (!String.IsNullOrEmpty(cedula.ToString()))
                {
                    Console.Write("Era el if");
                }
            }
            catch
            {
                entro = false;
                Console.Write("Era el catch");
            }
            finally
            {
                connection.Close();
            }

            return entro;
        }

        public int PersonaCi()
        {
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("SELECT cedula FROM persona");
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return 1;
        }
    }
}
