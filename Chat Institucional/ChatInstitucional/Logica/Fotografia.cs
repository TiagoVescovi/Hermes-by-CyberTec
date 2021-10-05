using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatInstitucional.Logica
{
    class Fotografia
    {
        protected object Imagen;

        public Fotografia()
        {

        }

        public object GetImagen()
        {
            return Imagen;
        }

        public void SetImagen(object img)
        {
            Imagen = img;
        }
    }
}
