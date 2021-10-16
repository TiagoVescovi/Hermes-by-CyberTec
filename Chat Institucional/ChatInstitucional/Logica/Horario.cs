using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatInstitucional.Logica
{
    class Horario
    {
        protected int ciProfesor;
        protected DateTime horaIni;
        protected DateTime horaFin;
        protected string dia; //Puede ser 'Lunes', 'Martes', 'Miercoles', 'Jueves', 'Viernes', 'Sabado', 'Domingo'

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

        public DateTime GetHoraIni()
        {
            return horaIni;
        }

        public void SetHoraIni(DateTime ini)
        {
            horaIni = ini;
        }

        public DateTime GetHoraFin()
        {
            return horaFin;
        }

        public void SetHoraFin(DateTime fin)
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
    }
}
