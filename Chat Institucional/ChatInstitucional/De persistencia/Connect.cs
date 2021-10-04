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
                connection = new MySqlConnection("server=127.0.0.1; database=bd_chat; Uid=root; Pass=;");
            }
            catch
            {
                Console.Write("Error en la conexion");
            }
        }

        public bool AgregarAlumno(Alumno a) // AGREGAR ALUMNO A LA BDD
        {
            bool added = false;
            DataTable dataTable = new DataTable();

            try
            {
                connection.Open(); 
                MySqlCommand CheckPersona = new MySqlCommand("SELECT cedula FROM persona;", connection);
                MySqlDataAdapter AdapterPersona = new MySqlDataAdapter(CheckPersona);
                AdapterPersona.Fill(dataTable);

                for (int i = 0; i < dataTable.Rows.Count; i++) //Checkea si existe la persona 
                {
                    if (dataTable.Rows[i]["cedula"].Equals(53557824))
                    {
                        MySqlCommand CheckAlumno = new MySqlCommand("SELECT cedula FROM alumno WHERE cedula = 53557824;", connection);
                        MySqlDataAdapter AdapterAlumno = new MySqlDataAdapter(CheckAlumno);
                        AdapterAlumno.Fill(dataTable);

                        for (int c = 0; c < dataTable.Rows.Count; c++) //Checkea si existe el alumno
                        {
                            if (!dataTable.Rows[c]["cedula"].Equals(53557824))
                            {
                                MySqlCommand command = new MySqlCommand("UPDATE persona SET nombre = 'Ismael', apellido = 'Aloy', passwd = 'noAdmin1234', foto = null, nickname = 'Elisma2711', activo = false, logueado = false WHERE cedula = 53557824;", connection);
                                command.ExecuteNonQuery();
                                MySqlCommand query = new MySqlCommand("INSERT INTO Alumno(cedula,idGrupo) VALUES(53557824,1);", connection);
                                query.ExecuteNonQuery(); //SE EJECUTA PERO DEVUELVE UNA EXCEPCION ¯\_(ツ)_/¯ XDDD
                                added = true;
                            }
                            else
                            {
                                //El alumno ya existe
                                added = false;
                                Console.WriteLine("IF ALUMNO");
                            }
                        }  
                    }
                    else
                    {
                        added = false;
                        //No existe una persona con esa cedula
                        Console.WriteLine("IF PERSONA");
                    }
                }
                
            }
            catch
            {
                //Ocurrio un error en la creacion del alumno
                added = false;
                Console.WriteLine("TRY AND CATCH");
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

        public bool LogInBDD(int ci, string pass) // INICIAR SESION
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

        public DataTable TraerIdGrupo()
        {
            DataTable idGrupos = new DataTable();
            try
            {
                connection.Open();
                MySqlCommand comando = new MySqlCommand("SELECT * FROM grupo;", connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                adapter.Fill(idGrupos);
            }
            catch
            {
                
            }
            finally
            {
                connection.Close();
            }
                
            return idGrupos;
        }
    }
}

