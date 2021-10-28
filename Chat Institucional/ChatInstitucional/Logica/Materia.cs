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
        
        public DataTable LlenarComboBoxConsulta()
        {
            Validacion validacion = new Validacion();
            return validacion.Select("SELECT * FROM materia m, enseña e, persona p, grupo g WHERE m.idMateria = e.idMateria AND e.ciProfesor = p.cedula AND e.idGrupo = g.idGrupo AND e.activo = true;");
        }

        public DataTable ListarMaterias(int grupo)
        {
            Validacion validacion = new Validacion();
            return validacion.Select("SELECT * FROM materia m, enseña e, persona p, grupo g WHERE m.idMateria = e.idMateria AND p.cedula = e.ciProfesor AND g.idGrupo = e.idGrupo AND g.idGrupo = " + grupo + ";");
        }

        public DataTable MateriasPorGrupo(int idGru)
        {
            Validacion validacion = new Validacion();
            return validacion.Select("SELECT * FROM materia m, enseña e WHERE e.idMateria = m.idMateria AND idGrupo = " + idGru + ";");
        }

        public bool AgregarEnsenia(int mat, int ci, int grupo)
        {
            Validacion validacion = new Validacion();
            // Poner if q busque si existe por si es activo
            if (validacion.Select("SELECT * FROM enseña WHERE idMateria = " + mat + " AND ciProfesor = " + ci + " AND idGrupo = " + grupo + ";").Rows.Count > 0)
            {
                if (validacion.Update("UPDATE enseña SET activo = true WHERE idMateria = " + mat + " AND ciProfesor = " + ci + " AND idGrupo = " + grupo + ";"))
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
                if (validacion.Insert("INSERT INTO enseña(idMateria,ciProfesor,idGrupo) VALUES (" + mat + "," + ci + "," + grupo + ");"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool EliminarEnsenia(int mat, int ci, int grupo)
        {
            Validacion validacion = new Validacion();
            return validacion.Update("UPDATE enseña SET activo = false WHERE idMateria = " + mat + " AND ciProfesor = " + ci + " AND idGrupo = " + grupo + ";");
        }

        public DataTable LlenarDgvEnsenia(int ci)
        {
            Validacion validacion = new Validacion();
            return validacion.Select("SELECT m.nombre as 'Materia', p.nombre as 'Nombre', p.apellido as 'Apellido', g.nombre as 'Grupo' FROM enseña e, materia m, persona p, grupo g WHERE e.idGrupo = g.idGrupo AND p.cedula = e.ciProfesor AND e.idMateria = m.idMateria AND ciProfesor = " + ci + " AND e.activo = true;");
        }

        public DataTable ListarEnsenia(int ci)
        {
            Validacion validacion = new Validacion();
            return validacion.Select("SELECT * FROM enseña WHERE ciProfesor = " + ci + " AND activo = true;");
        }
    }
}
