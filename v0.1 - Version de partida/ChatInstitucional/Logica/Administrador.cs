using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatInstitucional.Logica
{
    class Administrador : Persona
    {
        protected String Cargo;

        public Administrador()
        {

        }

        public String GetCargo()
        {
            return Cargo;
        }

        public void AceptarAlumno()
        {
            //Tiene que aceptar al alumno
        }

        public void PendienteAlumno()
        {
            //Los alumnos q tiene q aceptar
        }
    }
}
