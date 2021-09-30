using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatInstitucional.Logica
{
    class Consulta
    {
        protected string Emisor;
        protected string Receptor;
        protected string Informacion;

        public Consulta()
        {
            
        }

        public string GetEmisor()
        {
            return Emisor;
        }
    }
}
