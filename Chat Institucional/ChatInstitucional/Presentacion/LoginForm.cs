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
            LogIn();
        }

        private void LogIn()
        {
            Administrador administrador = new Administrador();
            Docente docente = new Docente();
            Alumno alumno = new Alumno();

            try
            {
                if (!String.IsNullOrEmpty(Text_User.Text) && !String.IsNullOrEmpty(Text_Pass.Text))
                {
                    string cedula = Text_User.Text;
                    string[] ced = cedula.Split('-');
                    String pass = Text_Pass.Text;
                    if (CIValidator.Validate(cedula))
                    {
                        if (administrador.ValidarAdmin(int.Parse(ced[0]), pass))
                        {
                            // Abre MainFormAdmin
                        }
                        else if (docente.ValidarDocente(int.Parse(ced[0]), pass))
                        {
                            // Abre MainFormDocente

                            MainFormDocente mfd = new MainFormDocente();
                            Validacion.UsuarioActual = int.Parse(ced[0]);
                            if (docente.LogIn(Validacion.UsuarioActual))
                            {
                                this.Hide();
                                mfd.ShowDialog();
                                this.Show();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo iniciar sesión");
                            }
                        }
                        else if (alumno.ValidarAlumno(int.Parse(ced[0]), pass))
                        {
                            // Abre MainFormAlumno

                            MainFormAlumno mfa = new MainFormAlumno();
                            Validacion.UsuarioActual = int.Parse(ced[0]);
                            if (alumno.LogIn(Validacion.UsuarioActual))
                            {
                                this.Hide();
                                mfa.ShowDialog();
                                this.Show();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo iniciar sesión");
                            }
                        }
                        else
                        {
                            // No se encontro nada
                            MessageBox.Show("No se hayaron las credenciales");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese una cédula de identidad válida");
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
            // Olvidaste tu contraseña?
            // Que le salga un mensaje al admin q esta cedula olvido la pass
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://cybertecuy.wordpress.com");
            // Ver como hacer q salga un mensaje q diga algo como
            // "Página web"
        }

        private void Text_User_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                // Solo se pueden poner numeros
                e.Handled = true;
            }

            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                // No se puede poner mas de un -
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                // Apreta el enter
                LogIn();
            }
        }

        private void Text_Pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                // Apreta el enter
                LogIn();
            }
        }
    }
}
