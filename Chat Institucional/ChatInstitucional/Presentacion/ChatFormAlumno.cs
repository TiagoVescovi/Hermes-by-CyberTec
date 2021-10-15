using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatInstitucional.ChatItems;
using ChatInstitucional.Logica;

namespace ChatInstitucional.Presentacion
{
    public partial class ChatFormAlumno : Form
    {
        Validacion validacion = new Validacion();
        Mensaje mensaje = new Mensaje();
        int IdConsulta = 0;

        public ChatFormAlumno()
        {
            InitializeComponent();
        }

        private void ChatFormAlumno_Load(object sender, EventArgs e)
        {
            //Llenar el Dgv_Chats
            Dgv_Chats.DataSource = validacion.Select("SELECT c.idConsulta AS 'Código', m.nombre AS 'Tema' FROM consulta c, participa p, materia m WHERE c.idConsulta = p.idConsulta AND c.idMateria = m.idMateria AND p.ciAlumno = " + Validacion.UsuarioActual + ";");
        }

        private void Btn_Send_Click(object sender, EventArgs e)
        {
            Send();
        }

        void Send()
        {
            if (Text_Mensaje.Text.Trim().Length == 0) return;

            mensaje.SetContenido(Text_Mensaje.Text);
            mensaje.SetHora(DateTime.Now); //Formato no es el mismo q DateTime en la BD
            Console.WriteLine(mensaje.GetHora()); //sacar
            mensaje.SetIdChat(IdConsulta);
            mensaje.SetIdAutor(Validacion.UsuarioActual);

            AddOutgoing(mensaje.GetContenido());
            Text_Mensaje.Text = string.Empty;

            if (!mensaje.SubirMensaje(mensaje))
            {
                MessageBox.Show("No se pudo enviar el mensaje");
            }
        }

        void AddIncomming(string msg, string fecha, string nombre)
        {
            var bubble = new Incomming();
            Pnl_Chat.Controls.Add(bubble);
            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;
            bubble.Mensaje = msg;
            bubble.Nombre = nombre;
            bubble.Fecha = fecha;
        }

        void AddOutgoing(string msg)
        {
            var bubble = new Outcomming();
            Pnl_Chat.Controls.Add(bubble);
            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;
            bubble.Mensaje = msg;
        }

        private void Text_Mensaje_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                Send();
            }
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            //Refresca el Dgv_Chats
            Dgv_Chats.DataSource = validacion.Select("SELECT c.idConsulta AS 'Código', m.nombre AS 'Tema' FROM consulta c, participa p, materia m WHERE c.idConsulta = p.idConsulta AND c.idMateria = m.idMateria AND p.ciAlumno = " + Validacion.UsuarioActual + ";");
        }

        private void Dgv_Chats_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Abre el chat y lo llena con lo q hay en tabla Mensaje
            Pnl_Chat.Controls.Clear();
            int index = Dgv_Chats.CurrentRow.Index;
            IdConsulta = Convert.ToInt32(Dgv_Chats.Rows[index].Cells[0].Value);
            Lbl_Tema.Text = Dgv_Chats.Rows[index].Cells[1].Value.ToString();
            
            for(int i = 0; i< mensaje.TraerMensaje(IdConsulta).Rows.Count; i++)
            {
                if (!mensaje.TraerMensaje(IdConsulta).Rows[i]["idAutor"].Equals(Validacion.UsuarioActual))
                {
                    Persona persona = new Persona();
                    AddIncomming(mensaje.TraerMensaje(IdConsulta).Rows[i]["Contenido"].ToString(), mensaje.TraerMensaje(IdConsulta).Rows[i]["hora"].ToString(), persona.BuscarPersona(Convert.ToInt32(mensaje.TraerMensaje(IdConsulta).Rows[i]["idAutor"])).Rows[0]["nombre"].ToString() + " " + persona.BuscarPersona(Convert.ToInt32(mensaje.TraerMensaje(IdConsulta).Rows[i]["idAutor"])).Rows[0]["apellido"].ToString());
                }
                else
                {
                    AddOutgoing(mensaje.TraerMensaje(IdConsulta).Rows[i]["contenido"].ToString());
                }
            }
        }
    }
}
