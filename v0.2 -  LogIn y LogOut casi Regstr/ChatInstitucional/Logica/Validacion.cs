using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatInstitucional.De_persistencia;

namespace ChatInstitucional.Logica
{
    class Validacion
    {
        Connect connect = new Connect();
        public static int UsuarioActual { get; set; }

        public Validacion()
        {
            
        }

        public bool ValidarLogin(int ci, String pass)
        {
            return connect.LogInBDD(ci, pass);
        }

        public bool ValidarLogOut(int ci)
        {
            return connect.LogOutBDD(ci);
        }

        public bool CrearAlumno(Alumno a)
        {
            return connect.AgregarAlumno(a);
        }
    }
}
