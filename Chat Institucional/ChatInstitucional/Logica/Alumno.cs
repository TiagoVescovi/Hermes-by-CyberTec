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
            bool added = false;

            int ci = a.GetCI();
            string nickname = a.GetNickname();
            string nombre = a.GetNombre();
            string apellido = a.GetApellido();
            string pass = a.GetPass();
            int idGrupo = a.GetIdGrupo();
            byte[] foto = a.GetFoto();
            bool activo = a.GetActivo();
            bool logueado = a.GetLogueado();

            try
            {
                if (a.BuscarPersona(ci).GetCI() == ci) //Checkea si existe en persona
                {
                    Console.WriteLine("PRIMER IF");  // Agregar q el nick no se puede repetir

                    if (a.BuscarAlumno(ci).GetCI() == ci) //Checkea si existe en alumno
                    {
                        // Ya existe el alumno
                        Console.WriteLine("IF ALUMNO");
                        added = false;
                    }
                    else
                    {
                        // Lo inserta en Alumno
                        if (validacion.Insert("INSERT INTO Alumno(cedula,idGrupo) VALUES (" + ci + "," + idGrupo + ");"))
                        {
                            Console.WriteLine("INSERTA");
                            // Le hace update a Persona
                            if (a.ModificarPersona(a))
                            {
                                Console.WriteLine("UPDATEA");
                                added = true;
                            }
                            else
                            {
                                Console.WriteLine("NO PUDO UPDATEAR PERSONA");
                                added = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("NO PUDO CREAR ALUMNO");
                            added = false;
                        }
                    }
                }
                else
                {
                    //No existe una persona con esa cedula
                    Console.WriteLine("IF PERSONA");
                    added = false;
                }
            }
            catch(Exception ex)
            {
                //Ocurrio un error en la creacion del alumno
                added = false;
                Console.WriteLine("TRY AND CATCH");
                Console.WriteLine(ex.ToString());
            }

            return added;
        }

        public bool EliminarAlumno(Alumno a)
        {
            //Baja alumno
            Validacion validacion = new Validacion();
            return validacion.Update("UPDATE persona SET activo = 0 WHERE cedula = " + a.GetCI() + ";");
        }

        public bool ModificarAlumno(Alumno a)
        {
            //Modify alumno
            Validacion validacion = new Validacion();
            return validacion.Update("UPDATE alumno SET idGrupo = " + a.GetIdGrupo() + " WHERE cedula = " + a.GetCI() + ";");
        }

        public Alumno BuscarAlumno(int ced)
        {
            //Devuelve un alumno
            Alumno alumno = new Alumno();
            DataTable dataTable = new DataTable();
            Validacion validacion = new Validacion();
            
            dataTable = validacion.Select("SELECT * FROM alumno a, persona p WHERE a.cedula = p.cedula AND p.cedula = " + ced + ";");

            alumno.SetCI(Convert.ToInt32(dataTable.Rows[0]["cedula"]));
            alumno.SetGrupo(Convert.ToInt32(dataTable.Rows[0]["idGrupo"]));
            alumno.SetNombre(dataTable.Rows[0]["nombre"].ToString());
            alumno.SetApellido(dataTable.Rows[0]["apellido"].ToString());
            alumno.SetPass(dataTable.Rows[0]["passwd"].ToString());
            alumno.SetFoto((byte[])dataTable.Rows[0]["foto"]); // MAS RARO ESTO PERO FUNCIONA
            alumno.SetNickname(dataTable.Rows[0]["nickname"].ToString());
            alumno.SetActivo(Convert.ToBoolean(dataTable.Rows[0]["activo"]));
            alumno.SetLogueado(Convert.ToBoolean(dataTable.Rows[0]["logueado"]));

            return alumno;
        }
    }
}
