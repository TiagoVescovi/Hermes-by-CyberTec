using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ChatInstitucional.Logica
{
    public class Consulta
    {
        protected int IdConsulta;
        protected int CiAlumno;
        protected int CiProfesor;
        protected int IdMateria;
        protected int IdGrupo;

        public Consulta()
        {
            
        }

        public int GetIdConsulta()
        {
            return IdConsulta;
        }

        public void SetIdConsulta(int idcon)
        {
            IdConsulta = idcon;
        }

        public int GetCiAlumno()
        {
            return CiAlumno;
        }

        public void SetCiAlumno(int cialum)
        {
            CiAlumno = cialum;
        }

        public int GetCiProfesor()
        {
            return CiProfesor;
        }

        public void SetCiProfesor(int ciprof)
        {
            CiProfesor = ciprof;
        }

        public int GetIdMateria()
        {
            return IdMateria;
        }

        public void SetIdMateria(int idmate)
        {
            IdMateria = idmate;
        }

        public int GetIdGrupo()
        {
            return IdGrupo;
        }

        public void SetIdGrupo(int idgr)
        {
            IdGrupo = idgr;
        }

        public int ConseguirIdConsulta(int ci)
        {
            Validacion validacion = new Validacion();
            return Convert.ToInt32(validacion.Select("SELECT idConsulta FROM consulta WHERE ciAlumno = " + ci + " AND idConsulta >= ALL (SELECT idConsulta FROM consulta WHERE ciAlumno = " + ci + ");").Rows[0]["idConsulta"]);
        }

        public bool SubirConsulta(Consulta c)
        {
            Validacion validacion = new Validacion();
            return validacion.Insert("INSERT INTO consulta(ciAlumno,ciProfesor,idMateria,idGrupo) VALUES (" + c.GetCiAlumno() + "," + c.GetCiProfesor() + "," + c.GetIdMateria() + "," + c.GetIdGrupo() + ");");
        }

        public DataTable ListarConsultas()
        {
            Validacion validacion = new Validacion();
            return validacion.Select("SELECT * FROM consulta;");
        }

        public Consulta BuscarConsulta(int id)
        {
            Validacion validacion = new Validacion();
            Consulta consulta = new Consulta();
            DataTable dataTable = new DataTable();

            try
            {
                dataTable = validacion.Select("SELECT * FROM consulta WHERE idConsulta = " + id + ";");

                consulta.SetIdConsulta(Convert.ToInt32(dataTable.Rows[0][0]));
                consulta.SetCiAlumno(Convert.ToInt32(dataTable.Rows[0][1]));
                consulta.SetCiProfesor(Convert.ToInt32(dataTable.Rows[0][2]));
                consulta.SetIdMateria(Convert.ToInt32(dataTable.Rows[0][3]));
                consulta.SetIdGrupo(Convert.ToInt32(dataTable.Rows[0][4]));
            }
            catch
            {

            }
            return consulta;
        }
    }
}
