using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatInstitucional.Logica
{
    class Materia
    {
        protected string Nombre;
        protected int IdMateria;

        public Materia()
        {
            //Nombre = GetNombre();
        }

        public string GetNombre()
        {
            return Nombre;
        }

        public void SetNombre(string nom)
        {
            Nombre = nom;
        }

        public int GetIdMateria()
        {
            return IdMateria;
        }

        public void SetIdMateria(int idmat)
        {
            IdMateria = idmat;
        }

        public void Ingreso()
        {

        }

        public void Modificacion()
        {

        }

        public void Eliminar()
        {

        }
    }
}
