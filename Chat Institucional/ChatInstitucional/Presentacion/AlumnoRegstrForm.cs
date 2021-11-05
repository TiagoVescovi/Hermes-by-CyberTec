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

// mensaje(idMensaje,hora,contenido,idAutor)
// Enviado(idChat,idMensaje)

namespace ChatInstitucional.Presentacion
{
    public partial class AlumnoRegstrForm : Form
    {
        Validacion validacion = new Validacion();

        public AlumnoRegstrForm()
        {
            InitializeComponent();

            Grupo grupo = new Grupo();
            for (int i = 0; i < grupo.LlenarComboBox().Rows.Count; i++)
            {
                Combo_Grupo.Items.Add(grupo.ListarGrupos().Rows[i]["nombre"]);
            }
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

        private void Btn_RegAlumno_Click(object sender, EventArgs e)
        {
            Fotografia foto = new Fotografia();

            foto.SetImagen(foto.ImageToByte(Hermes.Properties.Resources.descarga));

            try
            {
                if (!String.IsNullOrEmpty(Text_Nickname.Text) && !String.IsNullOrEmpty(Text_Cedula.Text) && !String.IsNullOrEmpty(Text_Nombre.Text) && !String.IsNullOrEmpty(Text_Apellido.Text) && !String.IsNullOrEmpty(Text_Pass.Text) && !String.IsNullOrEmpty(Text_PassCheck.Text) && !String.IsNullOrEmpty(Combo_Grupo.SelectedIndex.ToString()))
                {
                    string cedula = Text_Cedula.Text;
                    string pass = Text_Pass.Text;
                    string ced = "1111111";
                    string iden = "2";

                    if (cedula.Length == 8)
                    {
                        ced = cedula.Substring(0, 7);
                        iden = cedula.Substring(7, 1);
                    }

                    if (CIValidator.Validate(ced+"-"+iden))
                    {
                        if (Text_Pass.Text == Text_PassCheck.Text)
                        {
                            Alumno alumno = new Alumno();
                            Grupo grupo = new Grupo();
                            alumno.SetNickname(Text_Nickname.Text);
                            alumno.SetCI(int.Parse(ced));
                            alumno.SetNombre(Text_Nombre.Text);
                            alumno.SetApellido(Text_Apellido.Text);
                            alumno.SetPass(Text_Pass.Text);
                            alumno.SetGrupo(Convert.ToInt32(grupo.LlenarComboBox().Rows[Combo_Grupo.SelectedIndex][0]));
                            //alumno.SetFoto(foto.GetImagen()); //Hay un lugar en el q esto no funca

                            if (alumno.IngresarAlumno(alumno))
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
            System.Diagnostics.Process.Start("https://unruffled-snyder-7aa318.netlify.app");
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

        private void Combo_Grupo_TextUpdate(object sender, EventArgs e)
        {
            
        }
    }
}
