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
            return validacion.Select("SELECT ch.idChat AS 'Código', m.nombre AS 'Tema' FROM consulta co, chat ch, participa p, materia m WHERE ch.idChat = p.idChat AND co.idMateria = m.idMateria AND p.ciAlumno = " + ci + ";");
        }

        public DataTable Participantes(int id)
        {
            Validacion validacion = new Validacion();
            return validacion.Select("SELECT * FROM participa pa, chat ch WHERE ch.idChat = pa.idChat AND ch.idChat = " + id + ";");
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
                chat.SetHoraFin(DateTime.Parse(dataTable.Rows[0][2].ToString()));
                chat.SetCiAlumno(Convert.ToInt32(dataTable.Rows[0][4]));
                chat.SetCiProfesor(Convert.ToInt32(dataTable.Rows[0][5]));
                chat.SetIdMateria(Convert.ToInt32(dataTable.Rows[0][6]));
                chat.SetIdGrupo(Convert.ToInt32(dataTable.Rows[0][7]));
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
                if(validacion.Insert("INSERT INTO chat(idChat,horaIni) VALUES (" + c.GetIdConsulta() + ",'" + c.GetHoraIni() + "';"))
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

        public bool UnirseChat(Chat c)
        {
            bool joined = false;
            Validacion validacion = new Validacion();

            for(int i = 0; i < c.ListarConsultas().Rows.Count; i++)
            {
                if(c.GetIdConsulta() == Convert.ToInt32(validacion.Select("SELECT * FROM participa;").Rows[i][0]) && c.GetCiAlumno() == Convert.ToInt32(validacion.Select("SELECT * FROM participa;").Rows[i][4]))
                {
                    joined = false;
                }
                else
                {
                    if (validacion.Insert("INSERT INTO participa(idChat,ciAlumno) VALUES (" + c.GetIdConsulta() + "," + c.GetCiAlumno() + ";"))
                    {
                        joined = true;
                    }
                    else
                    {
                        joined = false;
                    }
                }
            }
            return joined;
        }
    }
}
