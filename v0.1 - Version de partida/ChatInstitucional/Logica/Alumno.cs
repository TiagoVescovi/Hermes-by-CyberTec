using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatInstitucional.Logica
{
    public class Alumno : Persona
    {
        protected String grupo;

        public Alumno()
        {
            grupo = GetGrupo();
        }

        public String GetGrupo()
        {
            return grupo;
        }

        public string ToStringo()
        {
            return "'" + Ci + "','" + Nickname + "','" + grupo + "'";
        }
    }
}
