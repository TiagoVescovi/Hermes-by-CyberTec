using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ChatInstitucional.Logica
{
    class Materia
    {
        protected string Nombre;
        protected int IdMateria;

        public Materia()
        {
            //Nombre = GetNombre();
        }

        public string GetNombre()
        {
            return Nombre;
        }

        public void SetNombre(string nom)
        {
            Nombre = nom;
        }

        public int GetIdMateria()
        {
            return IdMateria;
        }

        public void SetIdMateria(int idmat)
        {
            IdMateria = idmat;
        }

        public void Ingreso()
        {

        }

        public void Modificacion()
        {

        }

        public void Eliminar()
        {

        }
        
        public DataTable LlenarComboBoxConsulta()
        {
            Validacion validacion = new Validacion();
            return validacion.Select("SELECT * FROM materia m, enseña e, persona p, grupo g WHERE m.idMateria = e.idMateria AND e.ciProfesor = p.cedula AND e.idGrupo = g.idGrupo;");
        }

        public DataTable ListarMaterias(int grupo)
        {
            Validacion validacion = new Validacion();
            return validacion.Select("SELECT * FROM materia m, enseña e, persona p, grupo g WHERE m.idMateria = e.idMateria AND p.cedula = e.ciProfesor AND g.idGrupo = e.idGrupo AND g.idGrupo = " + grupo + ";");
        }
    }
}
