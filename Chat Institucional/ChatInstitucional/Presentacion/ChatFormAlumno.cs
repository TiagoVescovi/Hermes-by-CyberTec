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

namespace ChatInstitucional.Presentacion
{
    public partial class ChatFormAlumno : Form
    {
        public ChatFormAlumno()
        {
            InitializeComponent();
        }

        private void ChatFormAlumno_Load(object sender, EventArgs e)
        {
            //Llenar el Dgv_Chats
        }

        private void Btn_Send_Click(object sender, EventArgs e)
        {
            Send();
        }

        void Send()
        {
            if (Text_Mensaje.Text.Trim().Length == 0) return;

            AddOutgoing(Text_Mensaje.Text);
            Text_Mensaje.Text = string.Empty;
        }

        void AddIncomming(string msg)
        {
            var bubble = new Incomming();
            Pnl_Chat.Controls.Add(bubble);
            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;
            bubble.Mensaje = msg;
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
    }
}
