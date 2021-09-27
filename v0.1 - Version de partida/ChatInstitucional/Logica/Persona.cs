using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatInstitucional.Logica
{
    public class Persona
    {
        Validacion validacion = new Validacion();
        protected int Ci;
        protected String Nombre;
        protected String Apellido;
        protected String Pass;
        protected String Nickname;
        protected bool Activo;
        protected bool Logueado;

        public Persona()
        {
            /*Ci = GetCI();
            Nombre = GetNombre();
            Apellido = GetApellido();
            Pass = GetPass();*/
        }

        public int GetCI()
        {
            return Ci;
        }

        public String GetNombre()
        {
            return Nombre;
        }

        public String GetApellido()
        {
            return Apellido;
        }

        public String GetPass()
        {
            return Pass;
        }
    }
}
