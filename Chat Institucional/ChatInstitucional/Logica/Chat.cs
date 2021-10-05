using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
