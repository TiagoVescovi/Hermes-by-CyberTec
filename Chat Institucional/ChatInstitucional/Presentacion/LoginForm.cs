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
            DocenteRgstrForm df = new DocenteRgstrForm();
            this.Hide();
            df.ShowDialog();
            this.Show();
        }

        private void Lbl_RgstrAlumno_Click(object sender, EventArgs e)
        {
            AlumnoRegstrForm af = new AlumnoRegstrForm();
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
                    string ced = "1111111";
                    string iden = "2";
                    string pass = Text_Pass.Text;

                    if (cedula.Length == 8)
                    {
                        ced = cedula.Substring(0, 7);
                        iden = cedula.Substring(7, 1);
                    }

                    if (CIValidator.Validate(ced+"-"+iden))
                    {
                        if (administrador.ValidarAdmin(int.Parse(ced), pass))
                        {
                            if(administrador.ActivoLogueado(int.Parse(ced)) == 1)
                            {
                                // Logueado con exito
                                // Abre MainFormAdmin
                                AdminMainForm adf = new AdminMainForm();
                                Validacion.UsuarioActual = int.Parse(ced);
                                if (administrador.LogIn(Validacion.UsuarioActual))
                                {
                                    this.Hide();
                                    adf.ShowDialog();
                                    this.Show();
                                }
                                else
                                {
                                    MessageBox.Show("No se pudo iniciar sesión");
                                }

                            }
                            else if(administrador.ActivoLogueado(int.Parse(ced)) == 2)
                            {
                                // Ya se logueo
                                MessageBox.Show("Ya iniciaste sesión");
                            }
                            else
                            {
                                // No esta activo
                                MessageBox.Show("Usuario no activo\nSi usted no eliminó su usuario contacte a un administrador");
                            }
                        }
                        else if (docente.ValidarDocente(int.Parse(ced), pass))
                        {
                            if (docente.ActivoLogueado(int.Parse(ced)) == 1)
                            {
                                // Logueado con exito
                                // Abre MainFormDocente
                                DocenteMainForm mfd = new DocenteMainForm();
                                Validacion.UsuarioActual = int.Parse(ced);
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
                            else if (docente.ActivoLogueado(int.Parse(ced)) == 2)
                            {
                                // Ya se logueo
                                MessageBox.Show("Ya iniciaste sesión");
                            }
                            else
                            {
                                // No esta activo
                                MessageBox.Show("Usuario no activo\nSi usted no eliminó su usuario contacte a un administrador");
                            }
                        }
                        else if (alumno.ValidarAlumno(int.Parse(ced), pass))
                        {
                            if (alumno.ActivoLogueado(int.Parse(ced)) == 1)
                            {
                                // Logueado con exito
                                // Abre MainFormAlumno
                                AlumnoMainForm mfa = new AlumnoMainForm();
                                Validacion.UsuarioActual = int.Parse(ced);
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
                            else if (alumno.ActivoLogueado(int.Parse(ced)) == 2)
                            {
                                // Ya se logueo
                                MessageBox.Show("Ya iniciaste sesión");
                            }
                            else
                            {
                                // No esta activo
                                MessageBox.Show("Usuario no activo\nSi usted no eliminó su usuario contacte a un administrador");
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
            // Abre otro form para ingresar la cedula
            // Le sale un mensaje al admin q esta cedula olvido la pass

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://unruffled-snyder-7aa318.netlify.app");
            // Ver como hacer q salga un mensaje q diga algo como
            // "Página web"
        }

        private void Text_User_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Solo se pueden poner numeros
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
