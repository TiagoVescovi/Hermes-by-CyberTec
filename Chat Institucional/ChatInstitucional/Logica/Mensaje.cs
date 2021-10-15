using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ChatInstitucional.Logica
{
    class Mensaje
    {
        protected int idMensaje;
        protected string contenido;
        protected string hora; //Formato   YYYY-MM-DD HH:MM:SS
        protected int idChat;
        protected int idAutor;

        public Mensaje()
        {

        }

        public int GetIdMensaje()
        {
            return idMensaje;
        }

        public void SetIdMensaje(int id)
        {
            idMensaje = id;
        }

        public string GetContenido()
        {
            return contenido;
        }

        public void SetContenido(string msg)
        {
            contenido = msg;
        }

        public string GetHora()
        {
            return hora;
        }

        public void SetHora(DateTime dateTime)
        {
            hora = dateTime.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public int GetIdChat()
        {
            return idChat;
        }

        public void SetIdChat(int idCh)
        {
            idChat = idCh;
        }

        public int GetIdAutor()
        {
            return idAutor;
        }

        public void SetIdAutor(int idAut)
        {
            idAutor = idAut;
        }

        public bool SubirMensaje(Mensaje mensaje)
        {
            bool subido = false;
            Validacion validacion = new Validacion();
            if(validacion.Insert("INSERT INTO mensaje(contenido,hora,idChat,idAutor) VALUES ('" + mensaje.GetContenido() + "','" + mensaje.GetHora() + "'," + mensaje.GetIdChat() + "," + mensaje.GetIdAutor() + ");"))
            {
                subido = true;
            }
            else
            {
                subido = false;
            }
            return subido;
        }

        public DataTable TraerMensaje(int idCons)
        {
            Validacion validacion = new Validacion();
            return validacion.Select("SELECT * FROM mensaje WHERE idChat = " + idCons + ";");
        }
    }
}
