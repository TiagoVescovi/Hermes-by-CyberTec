using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatInstitucional.De_persistencia;
using System.Data;

namespace ChatInstitucional.Logica
{
    class Validacion
    {
        Connect connect = new Connect();
        Persona persona = new Persona();
        Alumno alumno = new Alumno();
        Docente docente = new Docente();

        public static int UsuarioActual { get; set; }

        public Validacion()
        {
            
        }

        public bool Update(string query)
        {
            return connect.Update(query);
        }

        public bool ModifyPicture(byte[] picture, int cedula)
        {
            return connect.ModifyPicture(picture, cedula);
        }

        public bool Insert(string query)
        {
            return connect.Insert(query);
        }

        public DataTable Select(string query)
        {
            return connect.Select(query);
        }

        public Alumno AlumnoActual(int ci)
        {
            return connect.AlumnoActual(ci);
        }

        public bool ValidarLogin(int ci, String pass)
        {
            return connect.LogInBDD(ci, pass);
        }

        public bool ValidarLogOut(int ci)
        {
            return connect.LogOutBDD(ci);
        }

        //public DataTable TraerGrupo()
        //{
        //    return connect.TraerIdGrupo();
        //}

        public DataTable TraerIdMateria()
        {
            return connect.TraerIdMateria();
        }

        /*public bool SubirConsulta(Asincronica a)
        {
            return connect.SubirConsulta(a);
        }*/
    }
}
