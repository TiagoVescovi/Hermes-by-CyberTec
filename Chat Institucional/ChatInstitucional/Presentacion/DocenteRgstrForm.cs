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
    public partial class DocenteRgstrForm : Form
    {
        public DocenteRgstrForm()
        {
            InitializeComponent();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_RegDocente_Click(object sender, EventArgs e)
        {
            // Metodo para el insert a bdd de Docente
            Fotografia foto = new Fotografia();

            foto.SetImagen(foto.ImageToByte(ChatInstitucional.Properties.Resources.descarga));

            try
            {
                if (!String.IsNullOrEmpty(Text_Nick.Text) && !String.IsNullOrEmpty(Text_Cedula.Text) && !String.IsNullOrEmpty(Text_Apellido.Text) && !String.IsNullOrEmpty(Text_Nombre.Text) && !String.IsNullOrEmpty(Text_Pass.Text) && !String.IsNullOrEmpty(Text_CheckPass.Text))
                {
                    string cedula = Text_Cedula.Text;
                    string[] ced = cedula.Split('-');
                    if (CIValidator.Validate(cedula))
                    {
                        if (Text_Pass.Text == Text_CheckPass.Text)
                        {
                            Docente docente = new Docente();
                            docente.SetNickname(Text_Nick.Text);
                            docente.SetCI(int.Parse(ced[0]));
                            docente.SetNombre(Text_Nombre.Text);
                            docente.SetApellido(Text_Apellido.Text);
                            docente.SetPass(Text_Pass.Text);
                            //docente.SetFoto(foto.GetImagen()); // Hay un lugar en el q esto no funca

                            if (docente.AgregarDocente(docente))
                            {
                                DialogResult result = MessageBox.Show("Usuario creado satisfactoriamente.\nEspere a que un administrador valide su usuario para iniciar sesión.", "Usuario creado", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    this.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ocurrió un error al crear el usuario.\nRegrese e intente nuevamente.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Las contraseñas no coinciden.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese una cédula válida");
                    }
                }
                else
                {
                    MessageBox.Show("Debe llenar todos los campos.");
                }
            }
            catch
            {
                MessageBox.Show("Ocurrió un error con el programa.\nReinicie e intente otra vez.");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://cybertecuy.wordpress.com");
        }

        private void Text_Cedula_KeyPress(object sender, KeyPressEventArgs e)
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
        }
    }
}
