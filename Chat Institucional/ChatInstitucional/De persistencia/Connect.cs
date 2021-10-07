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

        public bool AgregarAlumno(Alumno a) // AGREGAR ALUMNO A LA BDD
        {
            bool added = false;
            int ci = a.GetCI();
            string nickname = a.GetNickname();
            string nombre = a.GetNombre();
            string apellido = a.GetApellido();
            string pass = a.GetPass();
            int idGrupo = a.GetIdGrupo();

            DataTable dataTablePer = new DataTable();
            DataTable dataTableAlum = new DataTable();

            try
            {
                connection.Open(); 
                MySqlCommand CheckPersona = new MySqlCommand("SELECT cedula FROM persona;", connection);
                MySqlDataAdapter AdapterPersona = new MySqlDataAdapter(CheckPersona);
                AdapterPersona.Fill(dataTablePer);

                for (int i = 0; i < dataTablePer.Rows.Count; i++) //Checkea si existe la persona 
                {
                    Console.Write(dataTablePer.Rows[i]["cedula"].ToString());

                    if (dataTablePer.Rows[i]["cedula"].Equals(ci))
                    {
                        MySqlCommand CheckAlumno = new MySqlCommand("SELECT cedula FROM alumno;", connection);
                        MySqlDataAdapter AdapterAlumno = new MySqlDataAdapter(CheckAlumno);
                        AdapterAlumno.Fill(dataTableAlum);

                        //capaz conviene hacer do while
                        bool exist = false;
                        for (int c = 0; c < dataTableAlum.Rows.Count; c++) //Checkea si existe el alumno
                        {
                            if (dataTableAlum.Rows[c]["cedula"].Equals(ci))
                            {
                                Console.WriteLine("Entró acá");
                                exist = true;
                            }
                        }
                        if (!exist)
                        {
                            MySqlCommand insertAlum = new MySqlCommand("INSERT INTO Alumno(cedula,idGrupo) VALUES(1,1);", connection);
                            Console.WriteLine("se rompió?");
                            insertAlum.ExecuteNonQuery();
                            Console.WriteLine("no encontró");
                            MySqlCommand command = new MySqlCommand("UPDATE persona SET nombre = '" + nombre + "', apellido = '" + apellido + "', passwd = '" + pass + "', foto = null, nickname = '" + nickname + "', activo = false, logueado = false WHERE cedula = " + ci + ";", connection);
                            command.ExecuteNonQuery();
                            Console.WriteLine("Actualizo bien datos");
                            Console.WriteLine("noup, anda perfecto ;)");
                            added = true;
                        }
                    }
                    else
                    {
                        //No existe una persona con esa cedula
                        Console.WriteLine("IF PERSONA");
                    }
                }
        }
            catch
            {
                //Ocurrio un error en la creacion del alumno
                added = false;
                Console.WriteLine("Si D:");
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

        public bool LogOutBDD(int ci) // CERRAR SESION // Arreglarlo para q muestre el usuario en el main
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

            try
            {
                connection.Open();  //En la bdd tenes q cambiar grupo.nombre por grupo.nombreGr sino no te va a funcionar       //Si cambias aca donde dice la cedula por el parametro se buguea
                MySqlCommand command = new MySqlCommand("SELECT p.cedula, nombre, apellido, passwd, foto, nickname, activo, logueado, a.idGrupo, nombreGr FROM persona p, alumno a, grupo g WHERE p.cedula = a.cedula AND p.cedula = 145632623 AND a.idGrupo = g.idGrupo;", connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dataTable);

                Console.WriteLine(dataTable.Rows.Count);

                alumno.SetCI(Convert.ToInt32(dataTable.Rows[0]["cedula"]));
                alumno.SetNombre(dataTable.Rows[0]["nombre"].ToString());
                alumno.SetApellido(dataTable.Rows[0]["apellido"].ToString());
                alumno.SetPass(dataTable.Rows[0]["passwd"].ToString());
                // Ver como agregar atributo foto aca
                alumno.SetNickname(dataTable.Rows[0]["nickname"].ToString());
                alumno.SetActivo(Convert.ToBoolean(dataTable.Rows[0]["activo"]));
                alumno.SetLogueado(Convert.ToBoolean(dataTable.Rows[0]["logueado"]));
                alumno.SetGrupo(Convert.ToInt32(dataTable.Rows[0]["idGrupo"]));
                grupo.SetIdGrupo(Convert.ToInt32(dataTable.Rows[0]["idGrupo"]));
                grupo.SetNombre(dataTable.Rows[0]["nombreGr"].ToString());

                Console.WriteLine(dataTable.Rows[0]["cedula"].ToString());
                Console.WriteLine(dataTable.Rows[0]["nombre"].ToString());
                Console.WriteLine(dataTable.Rows[0]["apellido"].ToString());
                Console.WriteLine(dataTable.Rows[0]["passwd"].ToString());
                Console.WriteLine(dataTable.Rows[0]["nickname"].ToString());
                Console.WriteLine(dataTable.Rows[0]["activo"].ToString());
                Console.WriteLine(dataTable.Rows[0]["logueado"].ToString());
                Console.WriteLine(dataTable.Rows[0]["idGrupo"].ToString());
            }
            catch
            {

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
                MySqlCommand comando = new MySqlCommand("SELECT m.nombre as 'nombreMat', p.nombre, p.apellido, m.idMateria FROM materia m, enseña e, persona p WHERE m.idMateria = e.idMateria AND e.ciProfesor = p.cedula;", connection); // Pq materia no se relaciona con orientacion?
                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
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

        public bool EnviarConsulta(Asincronica a)
        {
            Asincronica asincronica = new Asincronica();
            bool consulto = false;

            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO consulta(ciAlumno,ciProfesor,idMateria,idGrupo) VALUES (53557824,413515145,1,1);", connection);
                command.ExecuteNonQuery();
                MySqlCommand comando = new MySqlCommand("INSERT INTO asincronica(idConsulta,estado,contenido) VALUES (1,'Realizada','Alto gei');", connection);
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
        }
    }
}

