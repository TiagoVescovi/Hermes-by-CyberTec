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
    public partial class AdminMainForm : Form
    {
        Validacion validacion = new Validacion();
        Administrador admin = new Administrador();
        Persona persona = new Persona();
        Alumno alumno = new Alumno();
        Docente docente = new Docente();
        PrincipalForm pf = new PrincipalForm();
        AdminAlumnoForm aaluF = new AdminAlumnoForm();
        AdminDocenteForm adocF = new AdminDocenteForm();
        AdminUsersForm ausrF = new AdminUsersForm();
        SettingsForm sf = new SettingsForm();
        AdminAdminForm aadmF = new AdminAdminForm();
        Fotografia foto = new Fotografia();
        Grupo grupo = new Grupo();

        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void MainFormAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                Lbl_UserName.Text = admin.BuscarAdmin(Validacion.UsuarioActual).GetNombre() + " " + admin.BuscarAdmin(Validacion.UsuarioActual).GetApellido();

                //Sigue sin funcionar
                Pic_Perfil.Image = Image.FromStream(foto.ByteToImage(admin.BuscarAdmin(Validacion.UsuarioActual).GetFoto()));
                Console.WriteLine(foto.ByteToImage(admin.BuscarAdmin(Validacion.UsuarioActual).GetFoto()).ToString());
                //Pic_Perfil.Image = Image.FromStream(foto.ByteToImage(alumno.BuscarAlumno(Validacion.UsuarioActual).GetFoto())); -- Tampoco funco
                //Pic_Perfil.Image = foto.ByteToImage(persona.BuscarPersona(Validacion.UsuarioActual).GetFoto()); -- Este tampoco
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void Btn_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Exit exit = new Exit();
            exit.ShowDialog();
            if (exit.Respuesta() == 0)
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

        private void Btn_Alumnos_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Docentes_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Admins_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Settings_Click(object sender, EventArgs e)
        {

        }

        private void Btn_MateGrupOri_Click(object sender, EventArgs e)
        {

        }
    }
}
