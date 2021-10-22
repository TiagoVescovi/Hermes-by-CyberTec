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
    public partial class LoginForm : Form
    {
        Validacion validacion = new Validacion();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Lbl_RgstrDocente_Click(object sender, EventArgs e)
        {
            RgstrDocenteForm df = new RgstrDocenteForm();
            this.Hide();
            df.ShowDialog();
            this.Show();
        }

        private void Lbl_RgstrAlumno_Click(object sender, EventArgs e)
        {
            RgstrAlumnoForm af = new RgstrAlumnoForm();
            this.Hide();
            af.ShowDialog();
            this.Show();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                if(!String.IsNullOrEmpty(Text_User.Text) && !String.IsNullOrEmpty(Text_Pass.Text))
                {
                    int cedula = Convert.ToInt32(Text_User.Text);
                    String pass = Text_Pass.Text;
                    if(validacion.ValidarLogin(cedula, pass))
                    {
                        Administrador administrador = new Administrador();
                        Docente docente = new Docente();
                        Alumno alumno = new Alumno();
                        Persona persona = new Persona();
                        int main = 0;

                        for(int i = 0; i < persona.ListarPersonas().Rows.Count; i++)
                        {
                            // Aca no se puede usar un Switch -- No entiendo como funciona el switch -- Re raro

                            if (cedula == Convert.ToInt32(administrador.ListarAdmins().Rows[i][0])) // El break esta mal aca
                            {
                                // Abre MainFormAdmin
                                main = 1;
                                break;
                            }
                            else if (cedula == Convert.ToInt32(docente.ListarDocentes().Rows[i][0]))
                            {
                                // Abre MainFormDocente
                                main = 2;

                                MainFormDocente mfd = new MainFormDocente();
                                this.Hide();
                                Validacion.UsuarioActual = cedula;
                                mfd.ShowDialog();
                                this.Show();

                                break;
                            }
                            else if (cedula == Convert.ToInt32(alumno.ListarAlumnos().Rows[i][0]))
                            {
                                // Abre MainFormAlumno
                                main = 3;

                                MainFormAlumno mfo = new MainFormAlumno();
                                this.Hide();
                                Validacion.UsuarioActual = cedula;
                                mfo.ShowDialog();
                                this.Show();

                                break;
                            }
                            else
                            {
                                main = 0;
                            }
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("No se hayaron las credenciales");
                    }
                }
                else
                {
                    MessageBox.Show("Debe llenar todos los campos");
                }
            }
            catch
            {
                MessageBox.Show("Ocurrió un error, intente nuevamente");
            }
        }

        private void Lbl_Forgot_Click(object sender, EventArgs e)
        {
            //Olvidaste tu contraseña?
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://cybertecuy.wordpress.com");
            // Ver como hacer q salga un mensaje q diga algo como
            // "Página web"
        }
    }
}
