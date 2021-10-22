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
    public partial class MainFormAlumno : Form
    {
        Validacion validacion = new Validacion();
        Persona persona = new Persona();
        Alumno alumno = new Alumno();
        Docente docente = new Docente();
        PrincipalForm pf = new PrincipalForm();
        ConsultaFormAlumno cf = new ConsultaFormAlumno();
        ChatForm chf = new ChatForm();
        SettingsForm sf = new SettingsForm();
        CursosAlumnoForm cuf = new CursosAlumnoForm();
        Fotografia foto = new Fotografia();
        Grupo grupo = new Grupo();

        public MainFormAlumno()
        {
            InitializeComponent();

            pf.TopLevel = false;
            pf.AutoScroll = true;
            Pnl_Der.Controls.Add(pf);
            pf.Dock = DockStyle.Fill;
            Lbl_FormAbierto.Text = "PRINCIPAL";

            pf.Show();
        }

        private void MainFormAlumno_Load(object sender, EventArgs e)
        {
            try
            {
                Lbl_UserName.Text = alumno.BuscarAlumno(Validacion.UsuarioActual).GetNombre() + " " + alumno.BuscarAlumno(Validacion.UsuarioActual).GetApellido();
                Lbl_UserGrupo.Text = grupo.TraerGrupo(alumno.BuscarAlumno(Validacion.UsuarioActual).GetIdGrupo()).GetNombre().ToString();

                //Sigue sin funcionar
                Pic_Perfil.Image = Image.FromStream(foto.ByteToImage(alumno.BuscarPersona(Validacion.UsuarioActual).GetFoto()));
                Console.WriteLine(foto.ByteToImage(alumno.GetFoto()).ToString());
                //Pic_Perfil.Image = Image.FromStream(foto.ByteToImage(alumno.BuscarAlumno(Validacion.UsuarioActual).GetFoto())); -- Tampoco funco
                //Pic_Perfil.Image = foto.ByteToImage(persona.BuscarPersona(Validacion.UsuarioActual).GetFoto()); -- Este tampoco
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Exit exit = new Exit();
            exit.ShowDialog();
            if(exit.Respuesta() == 0)
            {
                validacion.ValidarLogOut(Validacion.UsuarioActual);
                this.Close();
            }
            else
            {
                if (exit.Respuesta() == 1)
                {
                    // No hace nada aca xd
                }
                else
                {
                    validacion.ValidarLogOut(Validacion.UsuarioActual);
                    Application.Exit();
                }
            }
        }

        private void Btn_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Btn_Cursos_Click(object sender, EventArgs e)
        {
            //CursosForm
            cuf.TopLevel = false;
            cuf.AutoScroll = true;
            Pnl_Der.Controls.Add(cuf);
            cuf.Dock = DockStyle.Fill;
            Lbl_FormAbierto.Text = "MIS CURSOS";

            pf.Hide();
            cuf.Show();   //Muestra este
            cf.Hide();
            chf.Hide();
            sf.Hide();
        }

        private void Btn_Consultas_Click(object sender, EventArgs e)
        {
            //ConsultaForm
            cf.TopLevel = false;
            cf.AutoScroll = true;
            Pnl_Der.Controls.Add(cf);
            cf.Dock = DockStyle.Fill;
            Lbl_FormAbierto.Text = "CONSULTAS";

            pf.Hide();
            cuf.Hide();
            cf.Show();  //Muestra este
            chf.Hide();
            sf.Hide();
        }

        private void Btn_Chats_Click(object sender, EventArgs e)
        {
            //ChatForm
            chf.TopLevel = false;
            chf.AutoScroll = true;
            Pnl_Der.Controls.Add(chf);
            chf.Dock = DockStyle.Fill;
            Lbl_FormAbierto.Text = "MIS CHATS";

            pf.Hide();
            cuf.Hide();
            cf.Hide();
            chf.Show(); //Muestra este
            sf.Hide();
        }

        private void Btn_Settings_Click(object sender, EventArgs e)
        {
            //SettingsForm
            sf.TopLevel = false;
            sf.AutoScroll = true;
            Pnl_Der.Controls.Add(sf);
            sf.Dock = DockStyle.Fill;
            Lbl_FormAbierto.Text = "CONFIGURACIÓN";

            pf.Hide();
            cuf.Hide();
            cf.Hide();
            chf.Hide();
            sf.Show();  //Muestra este
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //PrincipalForm
            pf.TopLevel = false;
            pf.AutoScroll = true;
            Pnl_Der.Controls.Add(pf);
            pf.Dock = DockStyle.Fill;
            Lbl_FormAbierto.Text = "PRINCIPAL";

            pf.Show();  //Muestra este
            cuf.Hide();
            cf.Hide();
            chf.Hide();
            sf.Hide();
        }
        
    }
}
