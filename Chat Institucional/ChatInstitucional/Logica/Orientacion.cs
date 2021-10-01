using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatInstitucional.Logica
{
    class Orientacion
    {
        protected int IdOrientacion;
        protected string Nombre;

        public Orientacion()
        {
            
        }

        public int GetIdOri()
        {
            return IdOrientacion;
        }

        public void SetIdOri(int ori)
        {
            IdOrientacion = ori;
        }

        public string GetNombre()
        {
            return Nombre;
        }

        public void SetNombre(string nom)
        {
            Nombre = nom;
        }
    }
}
