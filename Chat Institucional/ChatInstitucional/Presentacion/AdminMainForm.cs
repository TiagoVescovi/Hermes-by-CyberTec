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
        AdminCursosForm acurF = new AdminCursosForm();
        SettingsForm sf = new SettingsForm();
        AdminAdminForm aadmF = new AdminAdminForm();
        Fotografia foto = new Fotografia();
        Grupo grupo = new Grupo();

        public AdminMainForm()
        {
            InitializeComponent();

            // PrincipalForm
            pf.TopLevel = false;
            pf.AutoScroll = true;
            Pnl_Der.Controls.Add(pf);
            pf.Dock = DockStyle.Fill;
            Lbl_FormAbierto.Text = "PRINCIPAL";

            pf.Show();      //Muestra este
            aaluF.Hide();
            adocF.Hide();
            aadmF.Hide();
            acurF.Hide();
            sf.Hide();
        }

        private void MainFormAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                Lbl_UserName.Text = admin.BuscarAdmin(Validacion.UsuarioActual).GetNombre() + " " + admin.BuscarAdmin(Validacion.UsuarioActual).GetApellido();
                Lbl_UserGrupo.Text = admin.BuscarAdmin(Validacion.UsuarioActual).GetCargo();

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
            // AdminAlumnoForm
            aaluF.TopLevel = false;
            aaluF.AutoScroll = true;
            Pnl_Der.Controls.Add(aaluF);
            aaluF.Dock = DockStyle.Fill;
            Lbl_FormAbierto.Text = "EDITAR ALUMNOS";

            pf.Hide();
            aaluF.Show();   //Muestra este
            adocF.Hide();
            aadmF.Hide();
            acurF.Hide();
            sf.Hide();
        }

        private void Btn_Docentes_Click(object sender, EventArgs e)
        {
            // AdminDocenteForm
            adocF.TopLevel = false;
            adocF.AutoScroll = true;
            Pnl_Der.Controls.Add(adocF);
            adocF.Dock = DockStyle.Fill;
            Lbl_FormAbierto.Text = "EDITAR DOCENTES";

            pf.Hide();
            aaluF.Hide();
            adocF.Show();   //Muestra este
            aadmF.Hide();
            acurF.Hide();
            sf.Hide();
        }

        private void Btn_Admins_Click(object sender, EventArgs e)
        {
            // AdminAdminForm
            aadmF.TopLevel = false;
            aadmF.AutoScroll = true;
            Pnl_Der.Controls.Add(aadmF);
            aadmF.Dock = DockStyle.Fill;
            Lbl_FormAbierto.Text = "EDITAR ADMINISTRADORES";

            pf.Hide();
            aaluF.Hide();
            adocF.Hide();
            aadmF.Show();   //Muestra este
            acurF.Hide();
            sf.Hide();
        }

        private void Btn_Settings_Click(object sender, EventArgs e)
        {
            // Settings
            sf.TopLevel = false;
            sf.AutoScroll = true;
            Pnl_Der.Controls.Add(sf);
            sf.Dock = DockStyle.Fill;
            Lbl_FormAbierto.Text = "CONFIGURACIÓN";

            pf.Hide();
            aaluF.Hide();   
            adocF.Hide();
            aadmF.Hide();
            acurF.Hide();
            sf.Show();      //Muestra este
        }

        private void Btn_MateGrupOri_Click(object sender, EventArgs e)
        {
            // AdminCursosForm
            acurF.TopLevel = false;
            acurF.AutoScroll = true;
            Pnl_Der.Controls.Add(acurF);
            acurF.Dock = DockStyle.Fill;
            Lbl_FormAbierto.Text = "EDITAR CURSOS";

            pf.Hide();
            aaluF.Hide();
            adocF.Hide();
            aadmF.Hide();
            acurF.Show();   //Muestra este
            sf.Hide();      
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // PrincipalForm
            pf.TopLevel = false;
            pf.AutoScroll = true;
            Pnl_Der.Controls.Add(pf);
            pf.Dock = DockStyle.Fill;
            Lbl_FormAbierto.Text = "PRINCIPAL";

            pf.Show();      //Muestra este
            aaluF.Hide();
            adocF.Hide();
            aadmF.Hide();
            acurF.Hide();   
            sf.Hide();
        }
    }
}
