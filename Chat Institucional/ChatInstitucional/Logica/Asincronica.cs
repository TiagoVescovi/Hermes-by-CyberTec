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
        protected byte[] Contenido;

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

        public byte[] GetContenido()
        {
            return Contenido;
        }

        public void SetContenido(byte[] content)
        {
            Contenido = content;
        }
    }
}
