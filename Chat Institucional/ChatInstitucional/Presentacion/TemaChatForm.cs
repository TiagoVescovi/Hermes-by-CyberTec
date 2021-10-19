using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatInstitucional.Logica;

namespace ChatInstitucional.Presentacion
{
    public partial class TemaChatForm : Form
    {
        int idCh;

        public TemaChatForm(int idChat)
        {
            InitializeComponent();

            idCh = idChat;
        }

        private void TemaChat_Load(object sender, EventArgs e)
        {
            Chat chat = new Chat();
            Persona persona = new Persona();
            Consulta consulta = new Consulta();
            
            Dgv_Participantes.Columns.Add("Nombre", "nombre");
            Dgv_Participantes.Columns.Add("Apellido", "apellido");
            Dgv_Participantes.Columns.Add("Tipo", "tipo");

            Dgv_Participantes.Rows.Add(persona.BuscarPersona(consulta.BuscarConsulta(Convert.ToInt32(chat.Participantes(idCh).Rows[0][0])).GetCiProfesor()).GetNombre() + persona.BuscarPersona(consulta.BuscarConsulta(Convert.ToInt32(chat.Participantes(idCh).Rows[0][0])).GetCiProfesor()).GetApellido() + "Docente");

            for (int i = 0; i < chat.Participantes(idCh).Rows.Count; i++)
            {
                if (Convert.ToInt32(chat.Participantes(idCh).Rows[i][1]) == consulta.BuscarConsulta(Convert.ToInt32(chat.Participantes(idCh).Rows[i][0])).GetCiAlumno())
                {
                    Dgv_Participantes.Rows.Add(persona.BuscarPersona(Convert.ToInt32(chat.Participantes(idCh).Rows[i][1])).GetNombre() + persona.BuscarPersona(Convert.ToInt32(chat.Participantes(idCh).Rows[i][1])).GetApellido() + "Anfitrión");
                }
                else
                {
                    Dgv_Participantes.Rows.Add(persona.BuscarPersona(Convert.ToInt32(chat.Participantes(idCh).Rows[i][1])).GetNombre() + persona.BuscarPersona(Convert.ToInt32(chat.Participantes(idCh).Rows[i][1])).GetApellido() + " ");
                }
            }
        }

        private void Btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
