using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ChatInstitucional.Logica
{
    class Administrador : Persona
    {
        protected string Cargo;

        public Administrador()
        {

        }

        public string GetCargo()
        {
            return Cargo;
        }

        public void SetCargo(string carg)
        {
            Cargo = carg;
        }

        public void AceptarAlumno()
        {
            //Tiene que aceptar al alumno
        }

        public void PendienteAlumno()
        {
            //Los alumnos q tiene q aceptar
        }

        public DataTable ListarAdmins()
        {
            Validacion validacion = new Validacion();
            return validacion.Select("SELECT * FROM administrador;");
        }

        public Administrador BuscarAdmin(int ci)
        {
            Administrador administrador = new Administrador();
            DataTable dataTable = new DataTable();
            Validacion validacion = new Validacion();

            try
            {
                dataTable = validacion.Select("SELECT * FROM persona p, administrador a WHERE a.cedula = p.cedula AND cedula = " + ci + ";");
                
                administrador.SetCI(Convert.ToInt32(dataTable.Rows[0]["cedula"]));
                administrador.SetNombre(dataTable.Rows[0]["nombre"].ToString());
                administrador.SetApellido(dataTable.Rows[0]["apellido"].ToString());
                administrador.SetPass(dataTable.Rows[0]["passwd"].ToString());
                administrador.SetNickname(dataTable.Rows[0]["nickname"].ToString());
                administrador.SetActivo(Convert.ToBoolean(dataTable.Rows[0]["activo"]));
                administrador.SetLogueado(Convert.ToBoolean(dataTable.Rows[0]["logueado"]));
                administrador.SetCargo(dataTable.Rows[0]["cargo"].ToString());
                //persona.SetFoto((byte[])dataTable.Rows[0]["foto"]); //XDDDDDDDD SIGUE FUNCIONANDO
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return administrador;
        }

        public bool ValidarAdmin(int ci, string pass)
        {
            Administrador administrador = new Administrador();
            Validacion validacion = new Validacion();
            bool exists = false;

            if (validacion.Select("SELECT * FROM administrador a, persona p WHERE a.cedula = p.cedula AND a.cedula = " + ci + " AND passwd = '" + pass + "';").Rows.Count > 0) 
            {
                exists = true;
            }
            else
            {
                exists = false;
            }
            return exists;
        }
    }
}
