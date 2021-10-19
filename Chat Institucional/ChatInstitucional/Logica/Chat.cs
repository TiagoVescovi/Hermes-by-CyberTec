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
        protected DateTime HoraIni;
        protected DateTime HoraFin;

        public Chat()
        {

        }

        public DateTime GetHoraIni()
        {
            return HoraIni;
        }

        public void SetHoraIni(DateTime ini)
        {
            HoraIni = ini;
        }

        public DateTime GetHoraFin()
        {
            return HoraFin;
        }

        public void SetHoraFin(DateTime fin)
        {
            HoraFin = fin;
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
    }
}
