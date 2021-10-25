using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ChatInstitucional.Logica
{
    class Horario
    {
        protected int ciProfesor;
        protected string horaIni;
        protected string horaFin;
        protected string dia; //Puede ser 'Lunes', 'Martes', 'Miercoles', 'Jueves', 'Viernes', 'Sabado', 'Domingo'
        protected bool activo;

        public Horario()
        {

        }

        public int GetCiProfesor()
        {
            return ciProfesor;
        }

        public void SetCiProfesor(int ciProfe)
        {
            ciProfesor = ciProfe;
        }

        public string GetHoraIni()
        {
            return horaIni;
        }

        public void SetHoraIni(DateTime ini)
        {
            horaIni = ini.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public string GetHoraFin()
        {
            return horaFin;
        }

        public void SetHoraFin(DateTime fin)
        {
            horaFin = fin.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public string GetDia()
        {
            return dia;
        }

        public void SetDia(string day)
        {
            dia = day;
        }

        public bool GetActivo()
        {
            return activo;
        }

        public void SetActivo(bool act)
        {
            activo = act;
        }

        public DataTable ListarHorarios()
        {
            Validacion validacion = new Validacion();
            return validacion.Select("SELECT * FROM horario;");
        }

        public DataTable HorariosProfe(int ci)
        {
            Validacion validacion = new Validacion();
            return validacion.Select("SELECT * FROM horario WHERE ciProfesor = " + ci + ";");
        }

        public DataTable HorariosPorDia(int ci, string day)
        {
            Validacion validacion = new Validacion();
            return validacion.Select("SELECT * FROM horario WHERE ciProfesor = " + ci + " AND dia = '" + day + "';");
        }

        public Horario BuscarHorario(int ci, DateTime hIni, DateTime hFin, string day)
        {
            Horario horario = new Horario();
            DataTable dataTable = new DataTable();
            Validacion validacion = new Validacion();

            try
            {
                if (validacion.Select("SELECT * FROM horario WHERE ciProfesor = "+ci+" AND horaIni = '"+hIni.ToString("yyyy-MM-dd HH:mm:ss")+"' AND horaFin = "+hFin.ToString("yyyy-MM-dd HH:mm:ss")+"' AND dia = '"+dia+"';").Rows.Count > 0)
                {
                    dataTable = validacion.Select("SELECT * FROM horario WHERE ciProfesor = " + ci + " AND horaIni = '" + hIni.ToString("yyyy-MM-dd HH:mm:ss") + "' AND horaFin = " + hFin.ToString("yyyy-MM-dd HH:mm:ss") + "' AND dia = '" + dia + "';");

                    horario.SetCiProfesor(Convert.ToInt32(dataTable.Rows[0][0]));
                    horario.SetHoraIni(DateTime.Parse(dataTable.Rows[0][1].ToString()));
                    horario.SetHoraFin(DateTime.Parse(dataTable.Rows[0][2].ToString()));
                    horario.SetDia(dataTable.Rows[0][3].ToString());
                    horario.SetActivo(Convert.ToBoolean(dataTable.Rows[0][4]));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());

                horario.SetCiProfesor(0);
                horario.SetHoraIni(DateTime.Parse("0000-00-00 00:00:00"));
                horario.SetHoraFin(DateTime.Parse("0000-00-00 00:00:00"));
                horario.SetDia("");
                horario.SetActivo(false);
            }

            return horario;
        }

        public bool AgregarHorario(Horario h)
        {
            Validacion validacion = new Validacion();
            try
            {
                if (validacion.Insert("INSERT INTO horario(ciProfesor,horaIni,horaFin.dia) VALUES (" + h.GetCiProfesor() + ",'" + h.GetHoraIni() + "','" + h.GetHoraFin() + "','" + h.GetDia() + "');"))
                {
                    return true;
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
    }
}
