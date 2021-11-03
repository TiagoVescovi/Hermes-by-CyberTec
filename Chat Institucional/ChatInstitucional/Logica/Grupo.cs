using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ChatInstitucional.Logica
{
    class Grupo
    {
        protected int IdGrupo;
        protected string NombreGr;
        protected int Ano;
        protected int IdOrientacion;
        protected bool activo;

        public Grupo()
        {

        }

        public int GetIdGrupo()
        {
            return IdGrupo;
        }

        public void SetIdGrupo(int idgroup)
        {
            IdGrupo = idgroup;
        }

        public string GetNombre()
        {
            return NombreGr;
        }

        public void SetNombre(string nom)
        {
            NombreGr = nom;
        }

        public int GetAno()
        {
            return Ano;
        }

        public void SetAno(int anio)
        {
            Ano = anio;
        }

        public int GetIdOrientacion()
        {
            return IdOrientacion;
        }

        public void SetIdOrientacion(int idori)
        {
            IdOrientacion = idori;
        }

        public bool GetActivo()
        {
            return activo;
        }

        public void SetActivo(bool act)
        {
            activo = act;
        }

        public Grupo TraerGrupo(int id)
        {
            Grupo grupo = new Grupo();
            Validacion validacion = new Validacion();
            DataTable dataTable = new DataTable();
            try
            {
                dataTable = validacion.Select("SELECT * FROM grupo WHERE idGrupo = " + id + ";");

                grupo.SetIdGrupo(Convert.ToInt32(dataTable.Rows[0]["idGrupo"]));
                grupo.SetNombre(dataTable.Rows[0]["nombre"].ToString());
                grupo.SetAno(Convert.ToInt32(dataTable.Rows[0]["año"]));
                grupo.SetIdOrientacion(Convert.ToInt32(dataTable.Rows[0]["idOrientacion"]));
            }
            catch
            {

            }
            return grupo;
        }

        public DataTable LlenarComboBox()
        {
            Validacion validacion = new Validacion();
            return validacion.Select("SELECT * FROM grupo g, orientacion o WHERE g.idOrientacion = o.idOrientacion AND g.activo = true;");
        }

        public DataTable GruposPorOrientacion(int idOri)
        {
            Validacion validacion = new Validacion();
            return validacion.Select("SELECT * FROM grupo WHERE idOrientacion = " + idOri + " AND g.activo = true;");
        }

        public DataTable ListarGrupos()
        {
            Validacion validacion = new Validacion();
            return validacion.Select("SELECT * FROM grupo;");
        }

        public bool EliminarGrupo(int id)
        {
            Validacion validacion = new Validacion();
            return validacion.Update("UPDATE grupo SET activo = false WHERE idGrupo = " + id + ";");
        }

        public bool AgregarGrupo(Grupo g)
        {
            Validacion validacion = new Validacion();
            try
            {
                if (validacion.Insert("INSERT INTO grupo(nombre,año,idOrientacion) VALUES ('" + g.GetNombre() + "'," + g.GetAno() + "," + g.GetIdOrientacion() + ");"))
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

        public bool ModificarGrupo(string atributo, string cambio, int id)
        {
            Validacion validacion = new Validacion();
            try
            {
                if (validacion.Update("UPDATE grupo SET " + atributo + " = " + cambio + " WHERE idGrupo = " + id + ";"))
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
