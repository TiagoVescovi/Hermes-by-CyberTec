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
        ChatFormAlumno chf = new ChatFormAlumno();
        SettingsFormAlumno sf = new SettingsFormAlumno();
        CursosAlumnoForm cuf = new CursosAlumnoForm();

        public MainFormAlumno()
        {
            InitializeComponent();

            Lbl_UserName.Text = validacion.AlumnoActual(Validacion.UsuarioActual).GetNombre() + " " + validacion.AlumnoActual(Validacion.UsuarioActual).GetApellido();
            Lbl_UserGrupo.Text = validacion.AlumnoActual(Validacion.UsuarioActual).GetIdGrupo().ToString();
            // devuelve valores raros cuando se cambia en connect por la ci

            pf.TopLevel = false;
            pf.AutoScroll = true;
            Pnl_Der.Controls.Add(pf);
            pf.Dock = DockStyle.Fill;
            Lbl_FormAbierto.Text = "PRINCIPAL";

            pf.Show();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está segur@ que desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                validacion.ValidarLogOut(Validacion.UsuarioActual);
                Application.Exit();
            }
            else
            {

            }
            //Poner MessageBox del LoL o algo parecido
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
