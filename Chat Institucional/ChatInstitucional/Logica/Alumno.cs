using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ChatInstitucional.Logica
{
    public class Alumno : Persona
    {
        protected int IdGrupo;

        public Alumno()
        {
            
        }

        public int GetIdGrupo()
        {
            return IdGrupo;
        }

        public void SetGrupo(int idgroup)
        {
            IdGrupo = idgroup;
        }

                    // Comienzo de ABM con BuscarAlumno() abajo

        public bool IngresarAlumno(Alumno a)
        {
            //Alta alumno
            Validacion validacion = new Validacion();
            
            try
            {
                if (a.BuscarPersona(a.GetCI()).GetCI() == a.GetCI()) //Checkea si existe en persona
                {
                    // Agregar q el nick no se puede repetir

                    if (a.BuscarAlumno(a.GetCI()).GetCI() == a.GetCI()) //Checkea si existe en alumno
                    {
                        // Ya existe el alumno
                        return false;
                    }
                    else
                    {
                        if (a.EditarPersonaDeAlumno(a))
                        {
                            // Le hace update a Persona
                            if (validacion.Insert("INSERT INTO Alumno(cedula,idGrupo) VALUES (" + a.GetCI() + "," + a.GetIdGrupo() + ");"))
                            {
                                // Lo inserta en Alumno
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    //No existe una persona con esa cedula
                    return false;
                }
            }
            catch(Exception ex)
            {
                //Ocurrio un error en la creacion del alumno
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool EliminarAlumno(Alumno a)
        {
            //Baja alumno
            Validacion validacion = new Validacion();
            return validacion.Update("UPDATE persona SET activo = 0 WHERE cedula = " + a.GetCI() + ";");
        }

        public bool ModificarAlumno(string atributo, string cambio, int ci)
        {
            //Modify alumno
            Validacion validacion = new Validacion();
            return validacion.Update("UPDATE alumno SET " + atributo + " = " + cambio + " WHERE cedula = " + ci + ";");
        }

        public Alumno BuscarAlumno(int ced)
        {
            //Devuelve un alumno
            Alumno alumno = new Alumno();
            DataTable dataTable = new DataTable();
            Validacion validacion = new Validacion();
            Fotografia fotografia = new Fotografia();

            try
            {
                dataTable = validacion.Select("SELECT * FROM alumno a, persona p WHERE a.cedula = p.cedula AND p.cedula = " + ced + ";");

                alumno.SetCI(Convert.ToInt32(dataTable.Rows[0]["cedula"]));
                alumno.SetGrupo(Convert.ToInt32(dataTable.Rows[0]["idGrupo"]));
                alumno.SetNombre(dataTable.Rows[0]["nombre"].ToString());
                alumno.SetApellido(dataTable.Rows[0]["apellido"].ToString());
                alumno.SetPass(dataTable.Rows[0]["passwd"].ToString());
                alumno.SetNickname(dataTable.Rows[0]["nickname"].ToString());
                alumno.SetActivo(Convert.ToBoolean(dataTable.Rows[0]["activo"]));
                alumno.SetLogueado(Convert.ToBoolean(dataTable.Rows[0]["logueado"]));
                alumno.SetIdioma(dataTable.Rows[0]["idioma"].ToString());
                alumno.SetFoto((byte[])dataTable.Rows[0]["foto"]); // MAS RARO ESTO PERO FUNCIONA
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return alumno;
        }

        public DataTable ListarAlumnos()
        {
            Validacion validacion = new Validacion();
            return validacion.Select("SELECT a.cedula as 'Cédula', p.nombre as 'Nombre', p.apellido as 'Apellido', g.nombre as 'Grupo' FROM alumno a, persona p, grupo g WHERE a.cedula = p.cedula AND a.idGrupo = g.idGrupo AND p.activo = true;");
        }

        public bool ValidarAlumno(int ci, string pass)
        {
            Validacion validacion = new Validacion();

            if (validacion.Select("SELECT * FROM alumno a, persona p WHERE a.cedula = p.cedula AND a.cedula = " + ci + " AND passwd = '" + pass + "';").Rows.Count > 0) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool EditarPersonaDeAlumno(Alumno a)
        {
            Validacion validacion = new Validacion();
            Fotografia fotografia = new Fotografia();
            try
            {
                if (validacion.Update("UPDATE persona SET nombre = '" + a.GetNombre() + "', apellido = '" + a.GetApellido() + "', passwd = '" + a.GetPass() + "', nickname = '" + a.GetNickname() + "', activo = " + a.GetActivo() + ", logueado = " + a.GetLogueado() + " WHERE cedula = " + a.GetCI() + ";"))
                {
                    if (validacion.ModifyPicture(a.GetFoto(), a.GetCI()))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }
    }
}
