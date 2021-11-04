﻿using System;
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
using System.IO;

namespace ChatInstitucional.Presentacion
{
    public partial class FormChat : Form
    {
        Validacion validacion = new Validacion();
        Mensaje mensaje = new Mensaje();
        int IdChat = 0;
        int msgLast = 0;
        int posicionUltima = 0;

        public FormChat()
        {
            InitializeComponent();


        }

        private void ChatFormAlumno_Load(object sender, EventArgs e)
        {
            //Llenar el Dgv_Chats
            Chat chat = new Chat();
            Grupo grupo = new Grupo();
            Docente docente = new Docente();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("materia");
            dataTable.Columns.Add("grupo");

            // Comparar para caundo sea docente q sea Rows[i][9] no 12
            if(Validacion.UsuarioActual == docente.BuscarDocente(Validacion.UsuarioActual).GetCI())
            {
                for (int i = 0; i < chat.LlenarChats(Validacion.UsuarioActual).Rows.Count; i++)
                {
                    dataTable.Rows.Add(chat.LlenarChats(Validacion.UsuarioActual).Rows[i][9].ToString(), grupo.TraerGrupo(Convert.ToInt32(chat.LlenarChats(Validacion.UsuarioActual).Rows[i][7])).GetNombre().ToString());
                }
            }
            else
            {
                for (int i = 0; i < chat.LlenarChats(Validacion.UsuarioActual).Rows.Count; i++)
                {
                    dataTable.Rows.Add(chat.LlenarChats(Validacion.UsuarioActual).Rows[i][12].ToString(), grupo.TraerGrupo(Convert.ToInt32(chat.LlenarChats(Validacion.UsuarioActual).Rows[i][7])).GetNombre().ToString());
                }
            }

            Dgv_Chats.DataSource = dataTable;
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

            Pnl_Chat.VerticalScroll.Value = Pnl_Chat.VerticalScroll.Maximum;
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
            Grupo grupo = new Grupo();
            Docente docente = new Docente();
            DataTable dataTable = new DataTable();
            Dgv_Chats.Columns.Add("materia","materia");
            Dgv_Chats.Columns.Add("grupo", "grupo");

            if (Validacion.UsuarioActual == docente.BuscarDocente(Validacion.UsuarioActual).GetCI())
            {
                for (int i = 0; i < chat.LlenarChats(Validacion.UsuarioActual).Rows.Count; i++)
                {
                    dataTable.Rows.Add(chat.LlenarChats(Validacion.UsuarioActual).Rows[i][9].ToString(), grupo.TraerGrupo(Convert.ToInt32(chat.LlenarChats(Validacion.UsuarioActual).Rows[i][7])).GetNombre().ToString());
                }
            }
            else
            {
                for (int i = 0; i < chat.LlenarChats(Validacion.UsuarioActual).Rows.Count; i++)
                {
                    dataTable.Rows.Add(chat.LlenarChats(Validacion.UsuarioActual).Rows[i][12].ToString(), grupo.TraerGrupo(Convert.ToInt32(chat.LlenarChats(Validacion.UsuarioActual).Rows[i][7])).GetNombre().ToString());
                }
            }

            Dgv_Chats.DataSource = dataTable;

            //for (int i = 0; i < chat.LlenarChats(Validacion.UsuarioActual).Rows.Count; i++)
            //{
            //    if (Dgv_Chats.Rows.Count > 0)
            //    {
            //        for(int j = 0; j < chat.LlenarChats(Validacion.UsuarioActual).Rows.Count; j++)
            //        {
            //            if (Dgv_Chats.Rows[i].Cells[0].Value.ToString() == chat.LlenarChats(Validacion.UsuarioActual).Rows[i][13].ToString())
            //            {
            //                return;
            //            }
            //            else
            //            {
            //                Dgv_Chats.Rows.Add(chat.LlenarChats(Validacion.UsuarioActual).Rows[i][13].ToString(), grupo.TraerGrupo(Convert.ToInt32(chat.LlenarChats(Validacion.UsuarioActual).Rows[i][7])).GetNombre().ToString());
            //            }
            //        }
            //    }
            //    else
            //    {
            //        Dgv_Chats.Rows.Add(chat.LlenarChats(Validacion.UsuarioActual).Rows[i][13].ToString(), grupo.TraerGrupo(Convert.ToInt32(chat.LlenarChats(Validacion.UsuarioActual).Rows[i][7])).GetNombre().ToString());
            //    }
            //}
        }

        private void Dgv_Chats_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Abre el chat y lo llena con lo q hay en tabla Mensaje
            Chat chat = new Chat();
            Grupo grupo = new Grupo();
            Pnl_Chat.Controls.Clear();
            int index = Dgv_Chats.CurrentRow.Index;
            chat.SetIdConsulta(Convert.ToInt32(chat.LlenarChats(Validacion.UsuarioActual).Rows[index][0]));
            IdChat = chat.GetIdConsulta();
            Btn_Tema.Text = Dgv_Chats.Rows[index].Cells[0].Value.ToString() + " - " + grupo.TraerGrupo(chat.BuscarConsulta(IdChat).GetIdGrupo()).GetNombre();

            for (int i = 0; i < mensaje.TraerMensaje(IdChat).Rows.Count; i++)
            {
                if (!mensaje.TraerMensaje(IdChat).Rows[i]["idAutor"].Equals(Validacion.UsuarioActual))
                {
                    Persona persona = new Persona();
                    AddIncomming(mensaje.TraerMensaje(IdChat).Rows[i]["Contenido"].ToString(), mensaje.TraerMensaje(IdChat).Rows[i]["hora"].ToString(), persona.BuscarPersona(Convert.ToInt32(mensaje.TraerMensaje(IdChat).Rows[i]["idAutor"])).GetNombre() + " " + persona.BuscarPersona(Convert.ToInt32(mensaje.TraerMensaje(IdChat).Rows[i]["idAutor"])).GetApellido());
                    Pnl_Chat.VerticalScroll.Value = Pnl_Chat.VerticalScroll.Maximum;
                    msgLast = Convert.ToInt32(mensaje.TraerMensaje(IdChat).Rows[i][0]);
                    posicionUltima = i;
                }
                else
                {
                    AddOutgoing(mensaje.TraerMensaje(IdChat).Rows[i]["contenido"].ToString());
                    Pnl_Chat.VerticalScroll.Value = Pnl_Chat.VerticalScroll.Maximum;
                    msgLast = Convert.ToInt32(mensaje.TraerMensaje(IdChat).Rows[i][0]);
                    posicionUltima = i;
                }
            }

            Timer timer = new Timer { Interval = 500 };
            timer.Enabled = true;
            timer.Tick += new System.EventHandler(RecargarMensajes);

            Text_Mensaje.Enabled = true;
            Btn_Send.Enabled = true;
            Btn_Tema.Enabled = true;
            Btn_Opciones.Enabled = true;
        }

        private void RecargarMensajes(object source, EventArgs e)
        {
            Chat chat = new Chat();
            int index = Dgv_Chats.CurrentRow.Index;
            chat.SetIdConsulta(Convert.ToInt32(chat.LlenarChats(Validacion.UsuarioActual).Rows[index][0]));
            IdChat = chat.GetIdConsulta();

            try
            {

                // No consigo q funcione
                // Creo q no lo pense del todo bien -- Ya funciona

                if (mensaje.RefrescarMensajes(IdChat, msgLast).Rows.Count > 0)
                {
                    Console.WriteLine("Primer if");
                    if (mensaje.RefrescarMensajes(IdChat, msgLast).Rows[0][0] != mensaje.TraerMensaje(IdChat).Rows[posicionUltima][0])
                    {
                        Console.WriteLine("For if");
                        for (int i = 0; i < mensaje.RefrescarMensajes(IdChat, msgLast).Rows.Count; i++)
                        {
                            if (!mensaje.RefrescarMensajes(IdChat, msgLast).Rows[i]["idAutor"].Equals(Validacion.UsuarioActual))
                            {
                                Persona persona = new Persona();
                                AddIncomming(mensaje.RefrescarMensajes(IdChat, msgLast).Rows[i]["Contenido"].ToString(), mensaje.RefrescarMensajes(IdChat, msgLast).Rows[i]["hora"].ToString(), persona.BuscarPersona(Convert.ToInt32(mensaje.RefrescarMensajes(IdChat, msgLast).Rows[i]["idAutor"])).GetNombre() + " " + persona.BuscarPersona(Convert.ToInt32(mensaje.RefrescarMensajes(IdChat, msgLast).Rows[i]["idAutor"])).GetApellido());
                                Pnl_Chat.VerticalScroll.Value = Pnl_Chat.VerticalScroll.Maximum;
                                msgLast = Convert.ToInt32(mensaje.RefrescarMensajes(IdChat, msgLast).Rows[i][0]);
                                posicionUltima = i;
                            }
                            else
                            {
                                //AddOutgoing(mensaje.RefrescarMensajes(IdChat, msgLast).Rows[i]["contenido"].ToString());
                                //Pnl_Chat.VerticalScroll.Value = Pnl_Chat.VerticalScroll.Maximum;
                                msgLast = Convert.ToInt32(mensaje.RefrescarMensajes(IdChat, msgLast).Rows[i][0]);
                                posicionUltima = i;
                            }
                        }
                    }
                    else
                    {
                        // A
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
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