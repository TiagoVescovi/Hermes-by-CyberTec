using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatInstitucional.Logica
{
    class Asincronica : Consulta
    {
        protected string Estado;
        protected string Contenido;

        public Asincronica()
        {

        }

        public string GetEstado()
        {
            return Estado;
        }

        public void SetEstado(string state)
        {
            Estado = state;
        }

        public string GetContenido()
        {
            return Contenido;
        }

        public void SetContenido(string content)
        {
            Contenido = content;
        }
    }
}
