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
        
        public Grupo TraerGrupo(int id)
        {
            Grupo grupo = new Grupo();
            Validacion validacion = new Validacion();
            DataTable dataTable = new DataTable();
            try
            {
                dataTable = validacion.Select("SELECT * FROM grupo WHERE idGrupo = " + id + ";");

                grupo.SetIdGrupo(Convert.ToInt32(dataTable.Rows[0]["idGrupo"]));
                grupo.SetNombre(dataTable.Rows[0]["nombreGr"].ToString());
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
            return validacion.Select("SELECT * FROM grupo g, orientacion o WHERE g.idOrientacion = o.idOrientacion;");
        }
    }
}
