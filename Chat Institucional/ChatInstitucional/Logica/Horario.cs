using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ChatInstitucional.Logica
{
    public class Horario
    {
        protected int ciProfesor;
        protected string horaIni; // Esto ahora es Time en bd
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

        public void SetHoraIni(string ini)
        {
            horaIni = ini;
        }

        public string GetHoraFin()
        {
            return horaFin;
        }

        public void SetHoraFin(string fin)
        {
            horaFin = fin;
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
            return validacion.Select("SELECT dia as 'Dia', horaIni as 'Desde', horaFin as 'Hasta' FROM horario WHERE ciProfesor = " + ci + " AND activo = true;");
        }

        public Horario BuscarHorario(int ci, string hIni, string hFin, string day)
        {
            Horario horario = new Horario();
            DataTable dataTable = new DataTable();
            Validacion validacion = new Validacion();

            try
            {
                if (validacion.Select("SELECT * FROM horario WHERE ciProfesor = " + ci + " AND horaIni = '" + hIni + "' AND horaFin = " + hFin + "' AND dia = '" + dia + "';").Rows.Count > 0) 
                {
                    dataTable = validacion.Select("SELECT * FROM horario WHERE ciProfesor = " + ci + " AND horaIni = '" + hIni + "' AND horaFin = " + hFin + "' AND dia = '" + dia + "';");

                    horario.SetCiProfesor(Convert.ToInt32(dataTable.Rows[0][0]));
                    horario.SetHoraIni(dataTable.Rows[0][1].ToString());
                    horario.SetHoraFin(dataTable.Rows[0][2].ToString());
                    horario.SetDia(dataTable.Rows[0][3].ToString());
                    horario.SetActivo(Convert.ToBoolean(dataTable.Rows[0][4]));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());

                //horario.SetCiProfesor(0);
                //horario.SetHoraIni("");
                //horario.SetHoraFin("");
                //horario.SetDia("");
                //horario.SetActivo(false);
            }

            return horario;
        }

        public bool AgregarHorario(Horario h)
        {
            Validacion validacion = new Validacion();
            try
            {
                if (validacion.Select("SELECT * FROM horario WHERE ciProfesor = " + h.GetCiProfesor() + " AND horaIni = '" + h.GetHoraIni() + "' AND horaFin = '" + h.GetHoraFin() + "' AND dia = '" + h.GetDia() + "';").Rows.Count > 0)
                {
                    if(validacion.Update("UPDATE horario SET activo = true WHERE ciProfesor = " + h.GetCiProfesor() + " AND horaIni = '" + h.GetHoraIni() + "' AND horaFin = '" + h.GetHoraFin() + "' AND dia = '" + h.GetDia() + "';"))
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
                    if (validacion.Insert("INSERT INTO horario(ciProfesor,horaIni,horaFin,dia) VALUES (" + h.GetCiProfesor() + ",'" + h.GetHoraIni() + "','" + h.GetHoraFin() + "','" + h.GetDia() + "');"))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                } 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }

        public bool EliminarHorario(Horario h)
        {
            Validacion validacion = new Validacion();
            return validacion.Delete("DELETE FROM horario WHERE ciProfesor = " + h.GetCiProfesor() + " AND horaIni = '" + h.GetHoraIni() + "' AND horaFin = '" + h.GetHoraFin() + "' AND dia = '" + h.GetDia() + "';");
        }

        public DataTable HorariosPorDia(int ci, string dia)
        {
            Validacion validacion = new Validacion();
            return validacion.Select("SELECT horaIni as 'Desde', horaFin as 'Hasta' FROM horario WHERE ciProfesor = " + ci + " AND dia = '" + dia + "' AND activo = true;");
        }
    }
}
