﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ChatInstitucional.Logica
{
    class Consulta
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
    }
}
