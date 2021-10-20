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
            catch
            {
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

        public bool Buscar(string query)
        {
            bool existe = false;

            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                existe = true;
            }
            catch
            {
                existe = false;
            }
            finally
            {
                connection.Close();
            }

            return existe;
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

        public bool LogInBDD(int ci, string pass) // INICIAR SESION
        {
            bool ExistePersona = false;
            DataTable dataTable = new DataTable();

            try
            {
                connection.Open();
                MySqlCommand CheckPersona = new MySqlCommand("SELECT cedula FROM persona WHERE cedula = " + ci + " AND activo = true AND logueado = false AND passwd = '" + pass + "';", connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(CheckPersona);
                adapter.Fill(dataTable);

                if (!String.IsNullOrEmpty(dataTable.Rows[0][0].ToString()))
                {
                    MySqlCommand UpdateLogueado = new MySqlCommand("UPDATE persona SET logueado = true WHERE cedula = " + ci + ";", connection);
                    UpdateLogueado.ExecuteNonQuery();
                    ExistePersona = true;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
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

        public Alumno AlumnoActual(int ci)
        {
            Alumno alumno = new Alumno();
            DataTable dataTable = new DataTable();
            Grupo grupo = new Grupo();
            Fotografia foto = new Fotografia();

            try
            {
                connection.Open();  //En la bdd tenes q cambiar grupo.nombre por grupo.nombreGr sino no te va a funcionar       //Si cambias aca donde dice la cedula por el parametro se buguea
                MySqlCommand command = new MySqlCommand("SELECT * FROM persona p, alumno a, grupo g WHERE p.cedula = a.cedula AND p.cedula = 145632623 AND a.idGrupo = g.idGrupo;", connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dataTable);

                Console.WriteLine(dataTable.Rows.Count);

                alumno.SetCI(Convert.ToInt32(dataTable.Rows[0]["cedula"]));
                alumno.SetNombre(dataTable.Rows[0]["nombre"].ToString());
                alumno.SetApellido(dataTable.Rows[0]["apellido"].ToString());
                alumno.SetPass(dataTable.Rows[0]["passwd"].ToString());

                // Ver como agregar atributo foto 
                alumno.SetFoto(((byte[])dataTable.Rows[0]["foto"]));

                alumno.SetNickname(dataTable.Rows[0]["nickname"].ToString());
                alumno.SetActivo(Convert.ToBoolean(dataTable.Rows[0]["activo"]));
                alumno.SetLogueado(Convert.ToBoolean(dataTable.Rows[0]["logueado"]));
                alumno.SetGrupo(Convert.ToInt32(dataTable.Rows[0]["idGrupo"]));
                grupo.SetIdGrupo(Convert.ToInt32(dataTable.Rows[0]["idGrupo"]));
                grupo.SetNombre(dataTable.Rows[0]["nombreGr"].ToString());
                grupo.SetAno(Convert.ToInt32(dataTable.Rows[0]["año"]));
                grupo.SetIdOrientacion(Convert.ToInt32(dataTable.Rows[0]["idOrientacion"]));

                Console.WriteLine(dataTable.Rows[0]["cedula"].ToString());
                Console.WriteLine(dataTable.Rows[0]["nombre"].ToString());
                Console.WriteLine(dataTable.Rows[0]["apellido"].ToString());
                Console.WriteLine(dataTable.Rows[0]["passwd"].ToString());
                Console.WriteLine(dataTable.Rows[0]["nickname"].ToString());
                Console.WriteLine(dataTable.Rows[0]["activo"].ToString());
                Console.WriteLine(dataTable.Rows[0]["logueado"].ToString());
                Console.WriteLine(dataTable.Rows[0]["idGrupo"].ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                connection.Close();
            }

            return alumno;
        }

        public DataTable TraerIdMateria()
        {
            DataTable dataTable = new DataTable();
            try
            {
                connection.Open();
                MySqlCommand comando = new MySqlCommand("SELECT p.cedula, m.nombre as 'nombreMat', p.nombre, p.apellido, m.idMateria FROM materia m, enseña e, persona p WHERE m.idMateria = e.idMateria AND e.ciProfesor = p.cedula;", connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                adapter.Fill(dataTable);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                connection.Close();
            }

            return dataTable;
        }

        /*public bool SubirConsulta(Asincronica a)
        {
            bool consulto = false;

            try
            {   
                connection.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO consulta(ciAlumno,ciProfesor,idMateria,idGrupo) VALUES (" + a.GetCiAlumno() + "," + a.GetCiProfesor() + "," + a.GetIdMateria() + "," + a.GetIdGrupo() + ");", connection);
                command.ExecuteNonQuery();
                a.SetIdConsulta(Convert.ToInt32(Select("SELECT idConsulta FROM consulta WHERE ciAlumno = " + Validacion.UsuarioActual + " AND idConsulta >= ALL (SELECT idConsulta FROM consulta WHERE ciAlumno = " + Validacion.UsuarioActual + ");").Rows[0]["idConsulta"]));
                MySqlCommand comando = new MySqlCommand("INSERT INTO asincronica(idConsulta,estado,contenido) VALUES (" + a.GetIdConsulta() + ",'" + a.GetEstado() + "','" + a.GetContenido() + "');", connection);
                comando.ExecuteNonQuery();
                consulto = true;
            }
            catch
            {
                consulto = false;
            }
            finally
            {
                connection.Close();
            }

            return consulto;
        }*/
    }
}

