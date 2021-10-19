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
        int IdChat = 0;

        public ChatFormAlumno()
        {
            InitializeComponent();
        }

        private void ChatFormAlumno_Load(object sender, EventArgs e)
        {
            //Llenar el Dgv_Chats
            Chat chat = new Chat();
            Dgv_Chats.DataSource = chat.LlenarChats(Validacion.UsuarioActual);
        }

        private void Btn_Send_Click(object sender, EventArgs e)
        {
            Send();
        }

        void Send()
        {
            if (Text_Mensaje.Text.Trim().Length == 0) return;

            mensaje.SetContenido(Text_Mensaje.Text);
            mensaje.SetHora(DateTime.Now); //Formato no es el mismo q DateTime en la BD -- Arreglado
            mensaje.SetIdChat(IdChat);
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
            Chat chat = new Chat();
            Dgv_Chats.DataSource = chat.LlenarChats(Validacion.UsuarioActual);
        }

        private void Dgv_Chats_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Abre el chat y lo llena con lo q hay en tabla Mensaje
            Pnl_Chat.Controls.Clear();
            int index = Dgv_Chats.CurrentRow.Index;
            IdChat = Convert.ToInt32(Dgv_Chats.Rows[index].Cells[0].Value);
            Btn_Tema.Text = Dgv_Chats.Rows[index].Cells[1].Value.ToString();
            
            for(int i = 0; i< mensaje.TraerMensaje(IdChat).Rows.Count; i++)
            {
                if (!mensaje.TraerMensaje(IdChat).Rows[i]["idAutor"].Equals(Validacion.UsuarioActual))
                {
                    Persona persona = new Persona();
                    AddIncomming(mensaje.TraerMensaje(IdChat).Rows[i]["Contenido"].ToString(), mensaje.TraerMensaje(IdChat).Rows[i]["hora"].ToString(), persona.BuscarPersona(Convert.ToInt32(mensaje.TraerMensaje(IdChat).Rows[i]["idAutor"])).GetNombre() + " " + persona.BuscarPersona(Convert.ToInt32(mensaje.TraerMensaje(IdChat).Rows[i]["idAutor"])).GetApellido());
                }
                else
                {
                    AddOutgoing(mensaje.TraerMensaje(IdChat).Rows[i]["contenido"].ToString());
                }
            }

            Text_Mensaje.Enabled = true;
            Btn_Send.Enabled = true;
            Btn_Tema.Enabled = true;
            Btn_Opciones.Enabled = true;
        }

        private void Btn_Tema_Click(object sender, EventArgs e)
        {
            // Lista de personas q perticipan en el chat
            // Conectados/desconectados -- FALTA ESTO
            // Diferencia al Host y al Docente
            TemaChatForm tCF = new TemaChatForm(IdChat);
            tCF.ShowDialog();
        }

        private void Btn_Opciones_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro@ que quiere salir del chat?", "Abandonar chat", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                // AAAAAAAAAAAAAAAAAAAAAA HAY Q VOLVER A CAMBIAR LA BD
                // HAY Q HACERLE BAJA LOGICA EN PARTICIPA
                // Esto lo voy a dejar para recordar el momento exacto en el q me quise matar al enterarme q habia q cambiar por 190391810° vez la BD
                if(validacion.Update("UPDATE participa SET participando = false WHERE ciAlumno = " + Validacion.UsuarioActual + ";"))
                {
                    MessageBox.Show("Abandonaste el chat");
                }
                else
                {
                    MessageBox.Show("No se pudo concretar la operación");
                }
            }
        }
    }
}
