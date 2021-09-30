using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatInstitucional.Logica
{
    class Grupo
    {
        protected int IdGrupo;
        protected string Nombre;
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
            return Nombre;
        }

        public void SetNombre(string nom)
        {
            Nombre = nom;
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
        
    }
}
