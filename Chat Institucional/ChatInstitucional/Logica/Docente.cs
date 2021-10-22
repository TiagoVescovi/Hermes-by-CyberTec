using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ChatInstitucional.Logica
{
    class Docente : Persona
    {
        public Docente()
        {

        }

        public DataTable ListarDocentes()
        {
            Validacion validacion = new Validacion();
            return validacion.Select("SELECT * FROM docente;");
        }

    }
}
