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
            Chat chat = new Chat();
            if (Validacion.UsuarioActual == chat.BuscarChat(idCh).GetCiAlumno())
            {
                Btn_Fin.Enabled = true;
            }
            else
            {
                Btn_Fin.Enabled = false;
            }
        }

        private void TemaChat_Load(object sender, EventArgs e)
        {
            Chat chat = new Chat();
            Persona persona = new Persona();
            
            Dgv_Participantes.Columns.Add("Nombre", "NOMBRE");
            Dgv_Participantes.Columns.Add("Apellido", "APELLIDO");
            Dgv_Participantes.Columns.Add("Tipo", "TIPO");

            Dgv_Participantes.Rows.Add(persona.BuscarPersona(chat.BuscarConsulta(Convert.ToInt32(chat.Participantes(idCh).Rows[0][0])).GetCiProfesor()).GetNombre(), persona.BuscarPersona(chat.BuscarConsulta(Convert.ToInt32(chat.Participantes(idCh).Rows[0][0])).GetCiProfesor()).GetApellido(), "Docente");

            for (int i = 0; i < chat.Participantes(idCh).Rows.Count; i++)
            {
                if (Convert.ToInt32(chat.Participantes(idCh).Rows[i][1]) == chat.BuscarConsulta(Convert.ToInt32(chat.Participantes(idCh).Rows[i][0])).GetCiAlumno())
                {
                    Dgv_Participantes.Rows.Add(persona.BuscarPersona(Convert.ToInt32(chat.Participantes(idCh).Rows[i][1])).GetNombre(),persona.BuscarPersona(Convert.ToInt32(chat.Participantes(idCh).Rows[i][1])).GetApellido(),"Anfitrión");
                    Btn_Fin.Enabled = true;
                }
                else
                {
                    Dgv_Participantes.Rows.Add(persona.BuscarPersona(Convert.ToInt32(chat.Participantes(idCh).Rows[i][1])).GetNombre(),persona.BuscarPersona(Convert.ToInt32(chat.Participantes(idCh).Rows[i][1])).GetApellido()," ");
                }
            }
        }

        private void Btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Fin_Click(object sender, EventArgs e)
        {
            // Solo lo ve el Host -- Esta en el Load
            // Setea la horaFin del chat -- No la setea
            // Cambia todos los participa.participando a 0 de todos los alumnos del chat

            Chat chat = new Chat();
            Validacion validacion = new Validacion();

            chat.BuscarChat(idCh).SetHoraFin(DateTime.Now);
            chat.BuscarChat(idCh).SetIdConsulta(idCh);

            DialogResult dialogResult = MessageBox.Show("¿Está segur@ de que quiere finalizar el chat?\nNo podrá volver a acceder a él una vez terminado", "Terminar chat", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (chat.TerminarChat(chat.BuscarChat(idCh)))
                {
                    MessageBox.Show("Finalizaste el chat");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo terminar el chat");
                }
            }
        }
    }
}
