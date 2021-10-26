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

        public DataTable MateriasPorGrupo(int idGru)
        {
            Validacion validacion = new Validacion();
            return validacion.Select("SELECT * FROM materia m, enseña e WHERE e.idMateria = m.idMateria AND idGrupo = " + idGru + " AND activo = true;");
        }

        public bool AgregarEnsenia(int mat, int ci, int grupo)
        {
            Validacion validacion = new Validacion();
            // Poner inf q busque si existe por si es activo y si lo hace lo sobreescriba )?
            return validacion.Insert("INSERT INTO enseña(idMateria,ciProfesor,idGrupo) VALUES (" + mat + "," + ci + "," + grupo + ");");
        }

        public bool EliminarEnsenia(int mat, int ci, int grupo)
        {
            Validacion validacion = new Validacion();
            return validacion.Update("UPDATE enseña SET activo = false WHERE idMateria = " + mat + " AND ciProfesor = " + ci + " AND idGrupo = " + grupo + ";");
        }
    }
}
