using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ChatInstitucional.De_persistencia
{
    class Dato
    {
        public void Conectar()
        {
            MySqlConnection connection = new MySqlConnection("Server = localhost; port 3306; Database = BD_CHAT; Uid root;");
            connection.Open();
        }
    }
}
