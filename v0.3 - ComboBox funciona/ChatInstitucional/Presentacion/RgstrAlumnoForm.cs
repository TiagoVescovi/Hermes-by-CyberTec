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
    public partial class RgstrAlumnoForm : Form
    {
        Validacion validacion = new Validacion();

        public RgstrAlumnoForm()
        {
            InitializeComponent();
            DataTable idgrupos = validacion.TraerAlumno();
            for (int i = 0; i < idgrupos.Rows.Count; i++)
            {
                Combo_Grupo.Items.Add(idgrupos.Rows[i]["idGrupo"] + " - " +idgrupos.Rows[i]["nombre"]);
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
            try
            {
                string Nickname = Text_Nickname.Text;
                int Cedula = Convert.ToInt32(Text_Cedula.Text);
                string Nombre = Text_Nombre.Text;
                string Apellido = Text_Apellido.Text;
                string Pass = Text_Pass.Text;
                string PassCheck = Text_PassCheck.Text;
                int Grupo = Convert.ToInt32(Combo_Grupo.SelectedItem.ToString());

                if(!String.IsNullOrEmpty(Nickname) && !String.IsNullOrEmpty(Cedula.ToString()) && !String.IsNullOrEmpty(Nombre) && !String.IsNullOrEmpty(Apellido) && !String.IsNullOrEmpty(Pass) && !String.IsNullOrEmpty(PassCheck) && !String.IsNullOrEmpty(Grupo.ToString()))
                {
                    if(Pass == PassCheck)
                    {
                        Alumno alumno = new Alumno();
                        alumno.SetNickname(Nickname);
                        alumno.SetCI(Cedula);
                        alumno.SetNombre(Nombre);
                        alumno.SetApellido(Apellido);
                        alumno.SetPass(Pass);
                        alumno.SetGrupo(Grupo);

                        if (validacion.CrearAlumno(alumno) == true)
                        {
                            DialogResult result = MessageBox.Show("Usuario alumno creado satisfactoriamente.\nYa puede iniciar sesión.", "Usuario creado", MessageBoxButtons.OK);
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
                    MessageBox.Show("Debe llenar todas las casillas.");
                }
            }
            catch
            {
                MessageBox.Show("Ocurrió un error con el programa.\nReinície e intente otra vez.");
            }
        }
    }
}
