using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ChatInstitucional.Logica
{

    class Chat : Consulta
    {
        protected string HoraIni;
        protected string HoraFin;

        int IdChat;

        public Chat()
        {

        }

        public string GetHoraIni()
        {
            return HoraIni;
        }

        public void SetHoraIni(DateTime ini)
        {
            HoraIni = ini.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public string GetHoraFin()
        {
            return HoraFin;
        }

        public void SetHoraFin(DateTime fin)
        {
            HoraFin = fin.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public DataTable LlenarChats(int ci)
        {
            Validacion validacion = new Validacion();
            DataTable dataTable = new DataTable();
            DataTable alumno = validacion.Select("SELECT * FROM chat ch, consulta co, participa p, materia m WHERE ch.idChat = p.idChat AND co.idMateria = m.idMateria AND ch.idChat = co.idConsulta AND p.ciAlumno = " + ci + " AND p.participando = true;");
            DataTable docente = validacion.Select("SELECT * FROM chat ch, consulta co, materia m WHERE co.idMateria = m.idMateria AND ch.idChat = co.idConsulta AND co.ciProfesor = " + ci + ";");

            if (alumno.Rows.Count > 0)  // Cambiar todos los q estan asi por switchs pq son mas rapidos
            {
                dataTable = alumno;
            }
            else if(alumno.Rows.Count == 0)
            {
                dataTable = docente;
            }
            else
            {
                dataTable = null;
            }

            return dataTable;
        }

        public DataTable Participantes(int id)
        {
            Validacion validacion = new Validacion();
            return validacion.Select("SELECT * FROM participa pa, chat ch WHERE ch.idChat = pa.idChat AND ch.idChat = " + id + " AND pa.participando = true;");
        }

        public Chat BuscarChat(int id)
        {
            Chat chat = new Chat();
            DataTable dataTable = new DataTable();
            Validacion validacion = new Validacion();

            try
            {
                dataTable = validacion.Select("SELECT * FROM chat ch, consulta co WHERE ch.idChat = co.idConsulta AND co.idConsulta = " + id + ";");

                chat.SetIdConsulta(Convert.ToInt32(dataTable.Rows[0][0]));
                chat.SetHoraIni(DateTime.Parse(dataTable.Rows[0][1].ToString()));
                chat.SetCiAlumno(Convert.ToInt32(dataTable.Rows[0][4]));
                chat.SetCiProfesor(Convert.ToInt32(dataTable.Rows[0][5]));
                chat.SetIdMateria(Convert.ToInt32(dataTable.Rows[0][6]));
                chat.SetIdGrupo(Convert.ToInt32(dataTable.Rows[0][7]));
                chat.SetHoraFin(DateTime.Parse(dataTable.Rows[0][2].ToString()));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return chat;
        }

        public DataTable ListarChats()
        {
            Validacion validacion = new Validacion();
            return validacion.Select("SELECT * FROM chat;");
        }

        public DataTable EncontrarEnConsulta(int idMat, int idGr)
        {
            Validacion validacion = new Validacion();
            return validacion.Select("SELECT * FROM consulta WHERE idMateria = " + idMat + " AND idGrupo = " + idGr + ";");
        }

        public DataTable EncontrarEnChat(int idChat)
        {
            Validacion validacion = new Validacion();
            return validacion.Select("SELECT * FROM chat WHERE idChat = " + idChat + " AND horaFin IS NULL;");
        }

        public bool CrearChat(Chat c)
        {
            Validacion validacion = new Validacion();

            try
            {
                if (c.SubirConsulta(c))
                {
                    c.SetIdConsulta(c.ConseguirIdConsulta(Validacion.UsuarioActual));
                    c.SetHoraIni(DateTime.Now);
                    Console.WriteLine(c.GetHoraIni());

                    if(validacion.Insert("INSERT INTO chat(idChat,horaIni) VALUES (" + c.GetIdConsulta() + ",'" + c.GetHoraIni() + "');"))
                    {
                        if(validacion.Insert("INSERT INTO participa(idChat,ciAlumno) VALUES (" + c.GetIdConsulta() + "," + c.GetCiAlumno() + ");"))
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }

        public int UnirseChat(Chat c)
        {
            // 0 = no se pudo unir
            // 1 = se pudo unir
            // 2 = ya se habia unido
            Validacion validacion = new Validacion();
            DataTable dataTable = new DataTable();
            dataTable = validacion.Select("SELECT * FROM participa WHERE idChat = " + c.GetIdConsulta() + " AND ciAlumno = " + c.GetCiAlumno() + " AND participando = true;");

            try
            {
                if (dataTable.Rows.Count == 0)
                {
                    // No pertenece al chat entonces lo agrega
                    if (validacion.Insert("INSERT INTO participa(idChat,ciAlumno) VALUES (" + c.GetIdConsulta() + "," + c.GetCiAlumno() + ");"))
                    {
                        // Lo agrega al chat
                        return 1;
                    }
                    else
                    {
                        if (c.GetIdConsulta() == Convert.ToInt32(dataTable.Rows[0][0]) && c.GetCiAlumno() == Convert.ToInt32(dataTable.Rows[0][1]) && Convert.ToBoolean(dataTable.Rows[0][2]) == true)
                        {
                            // Ya existe el alumno en ese chat
                            return 2;
                        }
                        else
                        {
                            // Vuelve al default
                            return 0;
                        }
                    }
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.ToString());
                return 0;
            }
        }

        public bool ValidarChat(Chat c)
        {
            // Busca si existe en consulta y luego en chat
            try
            {
                if (c.EncontrarEnConsulta(c.GetIdMateria(),c.GetIdGrupo()).Rows.Count > 0)
                {
                    c.SetIdConsulta(c.ConseguirIdChat(c));
                        
                    if (c.EncontrarEnChat(c.GetIdConsulta()).Rows.Count > 0)
                    {
                        IdChat = c.GetIdConsulta();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }

        public int ConseguirIdChat(Chat c)
        {
            Validacion validacion = new Validacion();
            return Convert.ToInt32(validacion.Select("SELECT idConsulta FROM consulta co, chat ch WHERE co.idConsulta = ch.idChat AND idMateria = " + c.GetIdMateria() + " AND idgrupo = " + c.GetIdGrupo() + ";").Rows[0][0]);
        }

        public bool TerminarChat(Chat c)
        {
            bool ended = false;
            Validacion validacion = new Validacion();

            try
            {
                if (validacion.Update("UPDATE chat SET horaFin = current_timestamp() WHERE idChat = " + c.GetIdConsulta() + ";"))
                {
                    if (validacion.Update("UPDATE participa SET participando = false WHERE idChat = " + c.GetIdConsulta() + ";"))
                    {
                        ended = true;
                    }
                    else
                    {
                        ended = false;
                    }
                }
                else
                {
                    ended = false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                ended = false;
            }
            return ended;
        }
    }
}
