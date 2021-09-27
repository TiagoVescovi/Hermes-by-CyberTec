using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatInstitucional.Logica
{
    class Consulta
    {
        protected String Emisor;
        protected String Receptor;
        protected String Informacion;

        public Consulta()
        {
            
        }

        public String GetEmisor()
        {
            return Emisor;
        }
    }
}
