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
            DataTable alumno = validacion.Select("SELECT ch.idChat AS 'Código', m.nombre AS 'Tema' FROM chat ch, consulta co, participa p, materia m WHERE ch.idChat = p.idChat AND co.idMateria = m.idMateria AND ch.idChat = co.idConsulta AND p.ciAlumno = " + ci + " AND ch.horaFin IS NULL AND p.participando = true;");
            DataTable docente = validacion.Select("SELECT ch.idChat AS 'Código', m.nombre AS 'Tema' FROM chat ch, consulta co, participa p, materia m WHERE ch.idChat = p.idChat AND co.idMateria = m.idMateria AND ch.idChat = co.idConsulta AND p.ciProfesor = " + ci + " AND ch.horaFin IS NULL AND p.participando = true;");

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
            catch
            {

            }
            return chat;
        }

        public DataTable ListarChats()
        {
            Validacion validacion = new Validacion();
            return validacion.Select("SELECT * FROM chat;");
        }

        public bool CrearChat(Chat c)
        {
            bool created = false;
            Validacion validacion = new Validacion();

            try
            {
                if(validacion.Insert("INSERT INTO chat(idChat,horaIni) VALUES (" + c.GetIdConsulta() + ",'" + c.GetHoraIni() + "');"))
                {
                    created = true;
                }
                else
                {
                    created = false;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                created = false;
            }
            return created;
        }

        public int UnirseChat(Chat c)
        {
            int joined = 0;
            // 0 = no se pudo unir
            // 1 = se pudo unir
            // 2 = ya se habia unido
            Validacion validacion = new Validacion();
            DataTable dataTable = new DataTable();
            dataTable = validacion.Select("SELECT * FROM participa WHERE idChat = " + c.GetIdConsulta() + " AND ciAlumno = " + c.GetCiAlumno() + ";");

            try
            {
                if (dataTable.Rows.Count == 0)
                {
                    // No pertenece al chat entonces lo agrega
                    if (validacion.Insert("INSERT INTO participa(idChat,ciAlumno) VALUES (" + c.GetIdConsulta() + "," + c.GetCiAlumno() + ");"))
                    {
                        // Lo agrega al chat
                        joined = 1;
                    }
                    else
                    {
                        if (c.GetIdConsulta() == Convert.ToInt32(dataTable.Rows[0][0]) && c.GetCiAlumno() == Convert.ToInt32(dataTable.Rows[0][1]) && Convert.ToBoolean(dataTable.Rows[0][2]) == true)
                        {
                            // Ya existe el alumno en ese chat
                            joined = 2;
                        }
                        else
                        {
                            // Vuelve al default
                            joined = 0;
                        }
                    }
                }
                else 
                {
                    joined = 0;
                }
            }
            catch (Exception e)
            {
                joined = 0;
            }
            return joined;
        }

        public bool ValidarChat(Chat c)
        {
            bool validated = false;
            Validacion validacion = new Validacion();
            Chat chat = new Chat();

            try
            {
                if (validacion.Select("SELECT idMateria, idGrupo FROM consulta, chat WHERE idConsulta = idChat AND idMateria = " + c.GetIdMateria() + " AND idGrupo = " + c.GetIdGrupo() + ";") == null)
                {
                    validated = false;
                }
                else
                {
                    DataTable dataTable = new DataTable();
                    dataTable = validacion.Select("SELECT * FROM consulta, chat WHERE idConsulta = idChat AND idMateria = " + c.GetIdMateria() + " AND idGrupo = " + c.GetIdGrupo() + ";");
                    for(int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        if(c.GetIdMateria() == Convert.ToInt32(dataTable.Rows[i][3]) && c.GetIdGrupo() == Convert.ToInt32(dataTable.Rows[i][4]) && !String.IsNullOrEmpty(dataTable.Rows[i][6].ToString()) && String.IsNullOrEmpty(dataTable.Rows[i][7].ToString()))
                        {
                            // Existe un chat al q se puede unir
                            validated = true;
                        }
                        else
                        {
                            // Tiene q crear el chat
                            validated = false;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                validated = false;
            }

            return validated;
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
                if (validacion.Update("UPDATE chat SET horaFin = '" + c.GetHoraFin() + "' WHERE idChat = " + c.GetIdConsulta() + ";"))
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
