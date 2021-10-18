using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ChatInstitucional.Logica
{
    class Asincronica : Consulta
    {
        protected string Estado;
        protected string consulta;
        protected string Respuesta;

        public Asincronica()
        {

        }

        public string GetEstado()
        {
            return Estado;
        }

        public void SetEstado(string state)
        {
            Estado = state;
        }

        public string GetConsulta()
        {
            return consulta;
        }

        public void SetConsulta(string content)
        {
            consulta = content;
        }

        public string GetRespuesta()
        {
            return Respuesta;
        }

        public void SetRespuesta(string ans)
        {
            Respuesta = ans;
        }

        public int ConseguirIdConsulta(int ci)
        {
            Validacion validacion = new Validacion();
            return Convert.ToInt32(validacion.Select("SELECT idConsulta FROM consulta WHERE ciAlumno = " + ci + " AND idConsulta >= ALL (SELECT idConsulta FROM consulta WHERE ciAlumno = " + ci + ");").Rows[0]["idConsulta"]);
        }

        public DataTable ListarAsincronica()
        {
            Validacion validacion = new Validacion();
            return validacion.Select("SELECT * FROM asincronica;");
        }

        public bool SubirAsincronica(Asincronica a)
        {
            Validacion validacion = new Validacion();
            bool uploaded = false;

            try
            {
                if (validacion.Insert("INSERT INTO asincronica(idAsincronica,estado,consulta,respuesta) VALUES (" + a.GetIdConsulta() + ",'" + a.GetEstado() + "','" + a.GetConsulta() + "','" + a.GetRespuesta() + "');"))
                {
                    uploaded = true;
                }
                else
                {
                    uploaded = false;
                }
            }
            catch
            {
                uploaded = false;
            }

            return uploaded;
        }

        public DataTable TraerRealizadas(int ci)
        {
            Validacion validacion = new Validacion();
            return validacion.Select("SELECT c.idConsulta AS ' .', p.nombre as 'Nombre', p.apellido as 'Apellido' FROM asincronica a, consulta c, persona p WHERE cedula = ciProfesor AND c.idConsulta = a.idAsincronica AND estado = 'Realizada' AND ciAlumno = " + ci + ";");
        }

        public DataTable TraerContestadas(int ci)
        {
            Validacion validacion = new Validacion();
            return validacion.Select("SELECT c.idConsulta AS ' .', p.nombre as 'Nombre', p.apellido as 'Apellido' FROM asincronica a, consulta c, persona p WHERE cedula = ciProfesor AND c.idConsulta = a.idAsincronica AND estado = 'Contestada' AND ciAlumno = " + ci + ";");
        }

        public DataTable TraerRecibidas(int ci)
        {
            Validacion validacion = new Validacion();
            return validacion.Select("SELECT c.idConsulta AS ' .', p.nombre as 'Nombre', p.apellido as 'Apellido' FROM asincronica a, consulta c, persona p WHERE cedula = ciProfesor AND c.idConsulta = a.idAsincronica AND estado = 'Recibida' AND ciAlumno = " + ci + ";");
        }

        public Asincronica VerAsincronica(int id)
        {
            Asincronica asincronica = new Asincronica();
            DataTable dataTable = new DataTable();
            Validacion validacion = new Validacion();

            try
            {
                dataTable = validacion.Select("SELECT * FROM asincronica WHERE idAsincronica = "+id+";");

                asincronica.SetIdConsulta(Convert.ToInt32(dataTable.Rows[0][0]));
                asincronica.SetEstado(dataTable.Rows[0][1].ToString());
                asincronica.SetConsulta(dataTable.Rows[0][2].ToString());
                asincronica.SetRespuesta(dataTable.Rows[0][3].ToString());
            }
            catch
            {

            }

            return asincronica;
        }
    }
}
