using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatInstitucional.Logica
{
    public class Persona
    {
        protected int Ci;
        protected string Nombre;
        protected string Apellido;
        protected string Pass;
        protected string Nickname;
        protected byte[] foto;
        protected bool Activo;
        protected bool Logueado;

        public Persona()
        {
            
        }

        public int GetCI()
        {
            return Ci;
        }

        public void SetCI(int ced)
        {
            Ci = ced;
        }

        public string GetNombre()
        {
            return Nombre;
        }

        public void SetNombre(string nom)
        {
            Nombre = nom;
        }

        public string GetApellido()
        {
            return Apellido;
        }

        public void SetApellido(string ape)
        {
            Apellido = ape;
        }

        public string GetPass()
        {
            return Pass;
        }

        public void SetPass(string passwd)
        {
            Pass = passwd;
        }

        public string GetNickname()
        {
            return Nickname;
        }

        public void SetNickname(string nick)
        {
            Nickname = nick;
        }

        public bool GetActivo()
        {
            return Activo;
        }

        public void SetActivo(bool act)
        {
            Activo = act;
        }

        public bool GetLogueado()
        {
            return Logueado;
        }

        public void SetLogueado(bool log)
        {
            Logueado = log;
        }
        public byte[] GetFoto()
        {
            return foto;
        }
        public void SetFoto(byte[] picture)
        {
            picture = foto;
        }
    }
}
