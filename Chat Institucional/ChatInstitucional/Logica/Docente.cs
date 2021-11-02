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
            return validacion.Select("SELECT d.cedula as 'Cédula', p.nombre as 'Nombre', p.apellido as 'Apellido' FROM docente d, persona p WHERE d.cedula = p.cedula AND p.activo = true;");
        }

        public Docente BuscarDocente(int ci)
        {
            Docente docente = new Docente();
            DataTable dataTable = new DataTable();
            Validacion validacion = new Validacion();

            try
            {
                dataTable = validacion.Select("SELECT * FROM persona p, docente d WHERE p.cedula = d.cedula AND d.cedula = " + ci + ";");

                docente.SetCI(Convert.ToInt32(dataTable.Rows[0]["cedula"]));
                docente.SetNombre(dataTable.Rows[0]["nombre"].ToString());
                docente.SetApellido(dataTable.Rows[0]["apellido"].ToString());
                docente.SetPass(dataTable.Rows[0]["passwd"].ToString());
                docente.SetNickname(dataTable.Rows[0]["nickname"].ToString());
                docente.SetActivo(Convert.ToBoolean(dataTable.Rows[0]["activo"]));
                docente.SetLogueado(Convert.ToBoolean(dataTable.Rows[0]["logueado"]));
                docente.SetFoto((byte[])dataTable.Rows[0]["foto"]); //XDDDDDDDD SIGUE FUNCIONANDO
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

        public bool AgregarDocente(Docente d)
        {
            // Agrega docentes a la bd
            Validacion validacion = new Validacion();
            
            try
            {
                if (d.IngresarPersona(d)) //Checkea si existe en persona
                {
                    // Agregar q el nick no se puede repetir

                    if (validacion.Insert("INSERT INTO docente(cedula) VALUES (" + d.GetCI() + ");"))
                    {
                        // Ingresa el docente en docente
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    //No existe una persona con esa cedula
                    return false;
                }
            }
            catch (Exception ex)
            {
                //Ocurrio un error en la creacion del docente
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool ModificarDocente(string atributo, string cambio, int ci)
        {
            // Modifica un docente
            Validacion validacion = new Validacion();
            try
            {
                if (validacion.Update("UPDATE persona SET " + atributo + " = " + cambio + " WHERE cedula = " + ci + ";"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }

        public bool EliminarDocente(int ci)
        {
            // Elimina un docente
            Validacion validacion = new Validacion();
            return validacion.Update("UPDATE persona SET activo = 0 WHERE cedula = " + ci + ";");
        }

    }
}
