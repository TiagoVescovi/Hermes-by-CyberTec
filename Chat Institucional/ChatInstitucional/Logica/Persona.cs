using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ChatInstitucional.Logica
{
    public class Persona
    {
        protected int Ci;
        protected string Nombre;
        protected string Apellido;
        protected string Pass;
        protected string Nickname;
        protected byte[] foto;
        protected bool Activo;
        protected bool Logueado;

        public Persona()
        {
            
        }

        public int GetCI()
        {
            return Ci;
        }

        public void SetCI(int ced)
        {
            Ci = ced;
        }

        public string GetNombre()
        {
            return Nombre;
        }

        public void SetNombre(string nom)
        {
            Nombre = nom;
        }

        public string GetApellido()
        {
            return Apellido;
        }

        public void SetApellido(string ape)
        {
            Apellido = ape;
        }

        public string GetPass()
        {
            return Pass;
        }

        public void SetPass(string passwd)
        {
            Pass = passwd;
        }

        public string GetNickname()
        {
            return Nickname;
        }

        public void SetNickname(string nick)
        {
            Nickname = nick;
        }

        public bool GetActivo()
        {
            return Activo;
        }

        public void SetActivo(bool act)
        {
            Activo = act;
        }

        public bool GetLogueado()
        {
            return Logueado;
        }

        public void SetLogueado(bool log)
        {
            Logueado = log;
        }
        public byte[] GetFoto()
        {
            return foto;
        }
        public void SetFoto(byte[] picture)
        {
            picture = foto;
        }

                                    // Comienzo da ABM

        public bool IngresarPersona(Persona p)
        {
            // Alta
            Validacion validacion = new Validacion();
            bool added = false;

            int ci = p.GetCI();
            string nickname = p.GetNickname();  // Hacer q esto no se pueda repetir
            string nombre = p.GetNombre();
            string apellido = p.GetApellido();
            string pass = p.GetPass();
            byte[] foto = p.GetFoto();
            bool activo = p.GetActivo();
            bool logueado = p.GetLogueado();

            try
            {
                if (p.BuscarPersona(ci).GetCI() == ci) //Checkea si existe en persona
                {
                    // Existe
                    added = false;
                }
                else
                {
                    // No existe
                    if (validacion.Insert("INSERT INTO persona(cedula,nombre,apellido,passwd,foto,nickname,activo,logueado) VALUES (" + p.GetCI() + ",'" + p.GetNombre() + "','" + p.GetApellido() + "','" + p.GetFoto() + "','" + p.GetNickname() + "'," + p.GetActivo() + "," + p.GetLogueado() + ");"))
                    {
                        added = true;
                    }
                    else
                    {
                        added = false;
                    }
                }
            }
            catch
            {
                added = false;
            }

            return added;
        }

        public bool EliminarPersona(Persona p)
        {
            // Baja
            Validacion validacion = new Validacion();
            return validacion.Update("UPDATE persona SET activo = 0 WHERE cedula = " + p.GetCI() + ";");
        }

        public bool ModificarPersona(Persona p)
        {
            // Modificar
            Validacion validacion = new Validacion();
            bool modified = false;
            try
            {
                if(validacion.Update("UPDATE persona SET nombre = '" + p.GetNombre() + "', apellido = '" + p.GetApellido() + "', passwd = '" + p.GetPass() + "', nickname = '" + p.GetNickname() + "', activo = " + p.GetActivo() + ", logueado = " + p.GetLogueado() + " WHERE cedula = " + p.GetCI() + ";"))
                {
                    if(validacion.ModifyPicture(p.GetFoto(), p.GetCI()))
                    {
                        modified = true;
                    }
                    else
                    {
                        modified = false;
                    }
                }
                else
                {
                    modified = false;
                }    
            }
            catch
            {
                Console.WriteLine("NO SE PUDO");
            }
            return modified;
        }

        public Persona BuscarPersona(int ci)
        {
            // Buscar
            // Devuelve Persona con todos sus atributos
            Validacion validacion = new Validacion();
            Persona persona = new Persona();
            DataTable dataTable = new DataTable();

            try
            {
                dataTable = validacion.Select("SELECT * FROM persona WHERE cedula = " + ci + ";");

                persona.SetCI(Convert.ToInt32(dataTable.Rows[0]["cedula"]));
                persona.SetNombre(dataTable.Rows[0]["nombre"].ToString());
                persona.SetApellido(dataTable.Rows[0]["apellido"].ToString());
                persona.SetPass(dataTable.Rows[0]["passwd"].ToString());
                persona.SetNickname(dataTable.Rows[0]["nickname"].ToString());
                persona.SetActivo(Convert.ToBoolean(dataTable.Rows[0]["activo"]));
                persona.SetLogueado(Convert.ToBoolean(dataTable.Rows[0]["logueado"]));
                //persona.SetFoto((byte[])dataTable.Rows[0]["foto"]); //XDDDDDDDD SIGUE FUNCIONANDO
            }
            catch
            {

            }
            return persona;
        }

        public DataTable ListarPersonas()
        {
            Validacion validacion = new Validacion();
            return validacion.Select("SELECT * FROM persona;");
        }

        public bool LogIn(int ci)
        {
            Validacion validacion = new Validacion();
            return validacion.Update("UPDATE persona SET logueado = 1 WHERE cedula = " + ci + ";");
        }

        public int ActivoLogueado(int ci)
        {
            // 0 = no activo
            // 1 = activo no logueado
            // 2 = logueado
            Validacion validacion = new Validacion();
            int devolver = 0;
            try
            {
                if (Convert.ToInt32(validacion.Select("SELECT cedula, activo, logueado FROM persona WHERE cedula = " + ci + ";").Rows[0][1]) == 1 && Convert.ToInt32(validacion.Select("SELECT cedula, activo, logueado FROM persona WHERE cedula = " + ci + ";").Rows[0][2]) == 0)
                {
                    devolver = 1;
                }
                else if (Convert.ToInt32(validacion.Select("SELECT cedula, activo, logueado FROM persona WHERE cedula = " + ci + ";").Rows[0][1]) == 1 && Convert.ToInt32(validacion.Select("SELECT cedula, activo, logueado FROM persona WHERE cedula = " + ci + ";").Rows[0][2]) == 1)
                {
                    devolver = 2;
                }
                else
                {
                    devolver = 0;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                devolver = 0;
            }
            
            return devolver;
        }
    }
}
