using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ChatInstitucional.Logica
{
    public class Alumno : Persona
    {
        protected int IdGrupo;

        public Alumno()
        {
            
        }

        public int GetIdGrupo()
        {
            return IdGrupo;
        }

        public void SetGrupo(int idgroup)
        {
            IdGrupo = idgroup;
        }
    }
}
