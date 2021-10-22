using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ChatInstitucional.Logica
{
    class Docente : Persona
    {
        public Docente()
        {

        }

        public DataTable ListarDocentes()
        {
            Validacion validacion = new Validacion();
            return validacion.Select("SELECT * FROM docente;");
        }

        public Docente BuscarDocente(int ci)
        {
            Docente docente = new Docente();
            DataTable dataTable = new DataTable();
            Validacion validacion = new Validacion();

            try
            {
                dataTable = validacion.Select("SELECT * FROM persona p, docente d WHERE d.cedula = p.cedula AND cedula = " + ci + ";");

                docente.SetCI(Convert.ToInt32(dataTable.Rows[0]["cedula"]));
                docente.SetNombre(dataTable.Rows[0]["nombre"].ToString());
                docente.SetApellido(dataTable.Rows[0]["apellido"].ToString());
                docente.SetPass(dataTable.Rows[0]["passwd"].ToString());
                docente.SetNickname(dataTable.Rows[0]["nickname"].ToString());
                docente.SetActivo(Convert.ToBoolean(dataTable.Rows[0]["activo"]));
                docente.SetLogueado(Convert.ToBoolean(dataTable.Rows[0]["logueado"]));
                //persona.SetFoto((byte[])dataTable.Rows[0]["foto"]); //XDDDDDDDD SIGUE FUNCIONANDO
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return docente;
        }

        public bool ValidarDocente(int ci, string pass)
        {
            Docente docente = new Docente();
            Validacion validacion = new Validacion();
            bool exists = false;

            if (validacion.Select("SELECT * FROM docente d, persona p WHERE d.cedula = p.cedula AND d.cedula = " + ci + " AND passwd = '" + pass + "';").Rows.Count > 0) 
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
