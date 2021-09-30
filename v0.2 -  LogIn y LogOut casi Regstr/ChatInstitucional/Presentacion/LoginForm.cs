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
                    if(validacion.ValidarLogin(cedula, pass) == true)
                    {
                        MainForm mfo = new MainForm();
                        this.Hide();
                        Validacion.UsuarioActual = cedula;
                        mfo.Show();
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
    }
}
