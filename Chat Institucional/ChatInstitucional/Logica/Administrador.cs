﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ChatInstitucional.Logica
{
    class Administrador : Persona
    {
        protected string Cargo;

        public Administrador()
        {

        }

        public string GetCargo()
        {
            return Cargo;
        }

        public void SetCargo(string carg)
        {
            Cargo = carg;
        }

        public void AceptarAlumno()
        {
            //Tiene que aceptar al alumno
        }

        public void PendienteAlumno()
        {
            //Los alumnos q tiene q aceptar
        }

        public DataTable ListarAdmins()
        {
            Validacion validacion = new Validacion();
            return validacion.Select("SELECT * FROM administrador;");
        }
    }
}
