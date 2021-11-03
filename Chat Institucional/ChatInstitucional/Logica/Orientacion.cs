using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ChatInstitucional.Logica
{
    class Orientacion
    {
        protected int IdOrientacion;
        protected string Nombre;
        protected bool activo;

        public Orientacion()
        {
            
        }

        public int GetIdOri()
        {
            return IdOrientacion;
        }

        public void SetIdOri(int ori)
        {
            IdOrientacion = ori;
        }

        public string GetNombre()
        {
            return Nombre;
        }

        public void SetNombre(string nom)
        {
            Nombre = nom;
        }

        public bool GetActivo()
        {
            return activo;
        }

        public void SetActivo(bool act)
        {
            activo = act;
        }

        public DataTable ListarOrientaciones()
        {
            Validacion validacion = new Validacion();
            return validacion.Select("SELECT * FROM orientacion WHERE activo = true;");
        }

        public bool AgregarOrientacion(Orientacion o)
        {
            Validacion validacion = new Validacion();
            try
            {
                if (validacion.Insert("INSERT INTO orientacion(nombre) VALUES ('" + o.GetNombre() + "');"))
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

        public Orientacion BuscarOrientacion(int id)
        {
            Validacion validacion = new Validacion();
            Orientacion orientacion = new Orientacion();
            DataTable dataTable = new DataTable();

            try
            {
                if (validacion.Select("SELECT * FROM orientacion WHERE idOrientacion = " + id + " AND activo = true;").Rows.Count > 0) 
                {
                    dataTable = validacion.Select("SELECT * FROM orientacion WHERE idOrientacion = " + id + " AND activo = true;");

                    orientacion.SetIdOri(Convert.ToInt32(dataTable.Rows[0][0]));
                    orientacion.SetNombre(dataTable.Rows[0][1].ToString());
                    orientacion.SetActivo(Convert.ToBoolean(dataTable.Rows[0][2]));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return orientacion;
        }

        public bool EliminarOrientacion(int id)
        {
            Validacion validacion = new Validacion();
            return validacion.Update("UPDATE orientacion SET activo = false WHERE idOrientacion = " + id + ";");
        }

        public bool ModificarOrientación(string atributo, string cambio, int id)
        {
            Validacion validacion = new Validacion();
            try
            {
                if (validacion.Update("UPDATE orientacion SET " + atributo + " = " + cambio + " WHERE idOrientacion = " + id + ";"))
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
