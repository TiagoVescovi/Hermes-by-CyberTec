using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatInstitucional.De_persistencia;
using System.Data;

namespace ChatInstitucional.Logica
{
    class Validacion
    {
        Connect connect = new Connect();

        public static int UsuarioActual { get; set; }

        public Validacion()
        {
            
        }

        public bool Update(string query)
        {
            return connect.Update(query);
        }

        public bool ModifyPicture(byte[] picture, int cedula)
        {
            return connect.ModifyPicture(picture, cedula);
        }

        public bool Insert(string query)
        {
            return connect.Insert(query);
        }

        public DataTable Select(string query)
        {
            return connect.Select(query);
        }

        public bool Delete(string query)
        {
            return connect.Delete(query);
        }

        public bool ValidarLogOut(int ci)
        {
            return connect.LogOutBDD(ci);
        }
    }
}
