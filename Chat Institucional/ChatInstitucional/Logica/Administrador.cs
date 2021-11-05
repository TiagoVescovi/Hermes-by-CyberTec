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

        public bool AceptarUsuario(int ci)
        {
            Validacion validacion = new Validacion();
            return validacion.Update("UPDATE persona SET activo = true WHERE cedula = " + ci + ";");
        }

        public DataTable ListarAdmins()
        {
            Validacion validacion = new Validacion();
            return validacion.Select("SELECT a.cedula as 'Cédula', p.nombre as 'Nombre', p.apellido as 'Apellido', a.cargo as 'Cargo' FROM administrador a, persona p WHERE a.cedula = p.cedula AND p.activo = true;");
        }

        public Administrador BuscarAdmin(int ci)
        {
            Administrador administrador = new Administrador();
            DataTable dataTable = new DataTable();
            Validacion validacion = new Validacion();

            try
            {
                dataTable = validacion.Select("SELECT * FROM persona p, administrador a WHERE a.cedula = p.cedula AND p.cedula = " + ci + ";");
                
                administrador.SetCI(Convert.ToInt32(dataTable.Rows[0]["cedula"]));
                administrador.SetNombre(dataTable.Rows[0]["nombre"].ToString());
                administrador.SetApellido(dataTable.Rows[0]["apellido"].ToString());
                administrador.SetPass(dataTable.Rows[0]["passwd"].ToString());
                administrador.SetNickname(dataTable.Rows[0]["nickname"].ToString());
                administrador.SetActivo(Convert.ToBoolean(dataTable.Rows[0]["activo"]));
                administrador.SetLogueado(Convert.ToBoolean(dataTable.Rows[0]["logueado"]));
                administrador.SetCargo(dataTable.Rows[0]["cargo"].ToString());
                if (dataTable.Rows[0]["foto"] != null)
                {
                    administrador.SetFoto((byte[])dataTable.Rows[0]["foto"]);
                }
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

        public DataTable ListaValidarDocentes()
        {
            Validacion validacion = new Validacion();
            return validacion.Select("SELECT * FROM docente d, persona p WHERE d.cedula = p.cedula AND activo = false;");
        }

        public DataTable ListaValidarAlumnos()
        {
            Validacion validacion = new Validacion();
            return validacion.Select("SELECT * FROM alumno a, persona p, grupo g WHERE a.cedula = p.cedula AND a.idGRupo = g.idGrupo AND p.activo = false;");
        }

        public bool AgregarAlumno(int ci)
        {
            Validacion validacion = new Validacion();
            Alumno alumno = new Alumno();

            if (alumno.BuscarPersona(ci).GetCI() == ci)
            {
                return false;
            }
            else
            {
                if (alumno.BuscarAlumno(ci).GetCI() == ci)
                {
                    return false;
                }
                else
                {
                    if (validacion.Insert("INSERT INTO persona(cedula) VALUES (" + ci + ");"))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public bool EliminarAdmin(int ci)
        {
            Validacion validacion = new Validacion();
            if (validacion.Delete("DELETE FROM administrador WHERE cedula = " + ci + ";"))
            {
                Persona persona = new Persona();
                if (persona.EliminarPersona(ci))
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
        }

        public bool AgregarEnDocente(int ci)
        {
            Validacion validacion = new Validacion();
            Docente docente = new Docente();

            if(docente.BuscarPersona(ci).GetCI() == ci)
            {
                if(docente.BuscarDocente(ci).GetCI() == ci)
                {
                    return false;
                }
                else
                {
                    if (validacion.Insert("INSERT INTO docente(cedula) VALUES (" + ci + ");"))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
        }

        public bool AgregarEnAdmin(int ci, string cargo)
        {
            Validacion validacion = new Validacion();
            Administrador administrador = new Administrador();

            if (administrador.BuscarPersona(ci).GetCI() == ci)
            {
                if (administrador.BuscarAdmin(ci).GetCI() == ci)
                {
                    return false;
                }
                else
                {
                    if (validacion.Insert("INSERT INTO administrador(cedula,cargo) VALUES (" + ci + ",'" + cargo + "');")) 
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
        }

        public bool AgregarEnAlumno(int ci, int grupo)
        {
            Validacion validacion = new Validacion();
            Alumno alumno = new Alumno();

            try
            {
                if (alumno.BuscarPersona(ci).GetCI() == ci)
                {
                    if (alumno.BuscarAlumno(ci).GetCI() == ci)
                    {
                        return false;
                    }
                    else
                    {
                        if (validacion.Insert("INSERT INTO alumno(cedula,idGrupo) VALUES (" + ci + "," + grupo + ");"))
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
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

        public bool AgregarAdmin(Administrador a)
        {
            Validacion validacion = new Validacion();

            if (a.IngresarPersona(a))
            {
                if (validacion.Insert("INSERT INTO administrador(cedula,cargo) VALUES (" + a.GetCI() + ",'" + a.GetCargo() + "');"))
                {
                    if (a.ModificarPersona("activo", "true", a.GetCI()))
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
            }
            else
            {
                return false;
            }
        }

        public bool ModificarAdmin(string atributo, string cambio, int ci)
        {
            Validacion validacion = new Validacion();
            try
            {
                if (validacion.Update("UPDATE administrador SET " + atributo + " = " + cambio + " WHERE cedula = " + ci + ";"))
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
    }
}
