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
    public partial class AdminAltaModForm : Form
    {
        int TipoUser;
        int Accion;
        int CI;

        public AdminAltaModForm(int userType, int action)   //Este añade
        {
            InitializeComponent();
            
            // TipoUser
                // 1 = docente
                // 2 = alumno
                // 3 = admin

            // Accion
                // 1 = añadir
                // 2 = modificar

            TipoUser = userType;
            Accion = action;

            Text_Cedula.ForeColor = Color.Black;
            Text_Nombre.ForeColor = Color.Black;
            Text_Apellido.ForeColor = Color.Black;
            Text_Nick.ForeColor = Color.Black;
            Text_Pass.ForeColor = Color.Black;
            Text_PassCheck.ForeColor = Color.Black;

            switch (TipoUser)
            {
                case 1:
                    //Docente
                    Text_Cedula.Enabled = true;
                    Text_Nombre.Enabled = true;
                    Text_Apellido.Enabled = true;
                    Text_Nick.Enabled = true;
                    Text_Pass.Enabled = true;
                    Text_PassCheck.Enabled = true;
                    Combo_Grupos.Enabled = false;
                    break;

                case 2:
                    //Alumno
                    MessageBox.Show("Para añadir un alumno solo se le exige ingresar su cédula");

                    //Todos los texbox en false pq este solo pasa la cedula
                    Text_Cedula.Enabled = true;
                    Text_Nombre.Enabled = false;
                    Text_Apellido.Enabled = false;
                    Text_Nick.Enabled = false;
                    Text_Pass.Enabled = false;
                    Text_PassCheck.Enabled = false;
                    Combo_Grupos.Enabled = false;
                    
                    Text_Nombre.ForeColor = Color.Gray;
                    Text_Apellido.ForeColor = Color.Gray;
                    Text_Nick.ForeColor = Color.Gray;
                    Text_Pass.ForeColor = Color.Gray;
                    Text_PassCheck.ForeColor = Color.Gray;
                    break; // Aca termina alumno

                case 3:
                    //Admin
                    Text_Cedula.Enabled = true;
                    Text_Nombre.Enabled = true;
                    Text_Apellido.Enabled = true;
                    Text_Nick.Enabled = true;
                    Text_Pass.Enabled = true;
                    Text_PassCheck.Enabled = true;
                    Combo_Grupos.Enabled = false;
                    break;

                default:
                    //Mensaje de error y sale
                    MessageBox.Show("Ocurrió un error. Regrese e intente de nuevo");
                    this.Close();
                    break;

                // Aca termina el switch
            }
        }

        public AdminAltaModForm(int userType, int action, int ci)   //Este modifica
        {

            InitializeComponent();

            TipoUser = userType;
            Accion = action;
            CI = ci;

            Text_Cedula.ForeColor = Color.Gray;
            Text_Nombre.ForeColor = Color.Black;
            Text_Apellido.ForeColor = Color.Black;
            Text_Nick.ForeColor = Color.Black;

            switch (TipoUser)
            {
                case 1:
                    //Docente
                    Docente docente = new Docente();
                    Text_Cedula.Enabled = false;
                    Text_Nombre.Enabled = true;
                    Text_Apellido.Enabled = true;
                    Text_Nick.Enabled = true;
                    Text_Pass.Enabled = false;
                    Text_PassCheck.Enabled = false;
                    Combo_Grupos.Enabled = false;

                    Text_Cedula.Text = docente.BuscarDocente(CI).GetCI().ToString();
                    Text_Nombre.Text = docente.BuscarDocente(CI).GetNombre();
                    Text_Apellido.Text = docente.BuscarDocente(CI).GetApellido();
                    Text_Nick.Text = docente.BuscarDocente(CI).GetNickname();
                    break;

                case 2:
                    //Alumno
                    Alumno alumno = new Alumno();
                    Text_Cedula.Enabled = false;
                    Text_Nombre.Enabled = true;
                    Text_Apellido.Enabled = true;
                    Text_Nick.Enabled = true;
                    Text_Pass.Enabled = false;
                    Text_PassCheck.Enabled = false;
                    Combo_Grupos.Enabled = true;

                    //Llena el Combo_Grupos
                    Grupo grupo = new Grupo();
                    for (int i = 0; i < grupo.LlenarComboBox().Rows.Count; i++)
                    {
                        Combo_Grupos.Items.Add(grupo.LlenarComboBox().Rows[i]["nombre"]);
                    }

                    Text_Cedula.Text = alumno.BuscarAlumno(CI).GetCI().ToString();
                    Text_Nombre.Text = alumno.BuscarAlumno(CI).GetNombre();
                    Text_Apellido.Text = alumno.BuscarAlumno(CI).GetApellido();
                    Text_Nick.Text = alumno.BuscarAlumno(CI).GetNickname();
                    Combo_Grupos.Text = grupo.TraerGrupo(alumno.BuscarAlumno(CI).GetIdGrupo()).GetNombre();

                    Combo_Grupos.ForeColor = Color.Black;
                    break; // Aca termina alumno

                case 3:
                    //Admin
                    Administrador administrador = new Administrador();
                    Text_Cedula.Enabled = false;
                    Text_Nombre.Enabled = true;
                    Text_Apellido.Enabled = true;
                    Text_Nick.Enabled = true;
                    Text_Pass.Enabled = false;
                    Text_PassCheck.Enabled = false;
                    Combo_Grupos.Enabled = false;

                    //Llenar el combo box con los cargos

                    Text_Cedula.Text = administrador.BuscarAdmin(CI).GetCI().ToString();
                    Text_Nombre.Text = administrador.BuscarAdmin(CI).GetNombre();
                    Text_Apellido.Text = administrador.BuscarAdmin(CI).GetApellido();
                    Text_Nick.Text = administrador.BuscarAdmin(CI).GetNickname();
                    break;

                default:
                    //Mensaje de error y sale
                    MessageBox.Show("Ocurrió un error. Regrese e intente de nuevo");
                    this.Close();
                    break;

                    // Aca termina el switch
            }
        }

        private void AdminAltas_Load(object sender, EventArgs e)
        {
            // No hace nada
        }

        private void Btn_Accept_Click(object sender, EventArgs e)
        {
            try
            {
                switch (TipoUser)
                {
                    case 1:
                        //Docente
                        switch (Accion)
                        {
                            case 1:
                                //Añadir

                                break;

                            case 2:
                                //Modificar

                                break;

                            default:
                                //Mensaje de error y sale
                                MessageBox.Show("Ocurrió un error. Regrese e intente de nuevo");
                                this.Close();
                                break;
                        }
                        break; // Fin del docente

                    case 2:
                        //Alumno
                        switch (Accion)
                        {
                            case 1:
                                //Añadir
                                DialogResult dialogResult = MessageBox.Show("Solo se ingresará la cédula para que luego un alumno se registre\n¿Desea continuar?", "Añadir usuario", MessageBoxButtons.YesNo);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    if (!String.IsNullOrEmpty(Text_Cedula.Text) && Text_Cedula.Text != "Cedula")
                                    {
                                        Administrador administrador = new Administrador();
                                        string cedula = Text_Cedula.Text;
                                        string[] ced = cedula.Split('-');

                                        if (CIValidator.Validate(cedula))
                                        {
                                            if (administrador.AgregarAlumno(int.Parse(ced[0])))
                                            {
                                                MessageBox.Show("Usuario Ingresado\nDebe esperar a que un alumno se registre para poder editarlo");
                                                this.Close();
                                            }
                                            else
                                            {
                                                MessageBox.Show("No se pudo ingresar el usuario");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Ingrese una cédula válida");
                                        }
                                    }
                                }
                                break;

                            case 2:
                                //Modificar
                                if (!String.IsNullOrEmpty(Text_Cedula.Text) && Text_Cedula.Text != "Cedula" && !String.IsNullOrEmpty(Text_Nombre.Text) && !String.IsNullOrEmpty(Text_Apellido.Text) && !String.IsNullOrEmpty(Text_Nick.Text) && !String.IsNullOrEmpty(Combo_Grupos.SelectedIndex.ToString()))
                                {
                                    Alumno alumno = new Alumno();
                                    Grupo grupo = new Grupo();
                                    int cedula = int.Parse(Text_Cedula.Text);

                                    
                                    if (alumno.ModificarPersona("nombre", "'" + Text_Nombre.Text + "'", cedula) && alumno.ModificarPersona("apellido", "'" + Text_Apellido.Text + "'", cedula) && alumno.ModificarPersona("nickname", "'" + Text_Nick.Text + "'", cedula) && alumno.ModificarAlumno("idGrupo", grupo.LlenarComboBox().Rows[Combo_Grupos.SelectedIndex][0].ToString(), cedula)) 
                                    {
                                        MessageBox.Show("Usuario actualizado correctamente");
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se pudo actualizar el usuario");
                                    }
                                }
                                break;

                            default:
                                //Mensaje de error y sale
                                MessageBox.Show("Ocurrió un error. Regrese e intente de nuevo");
                                this.Close();
                                break;
                        }
                        break; // Fin del alumno

                    case 3:
                        //Admin
                        switch (Accion)
                        {
                            case 1:
                                //Añadir
                                break;

                            case 2:
                                //Modificar
                                break;

                            default:
                                //Mensaje de error y sale
                                MessageBox.Show("Ocurrió un error. Regrese e intente de nuevo");
                                this.Close();
                                break;
                        }
                        break; // Fin del admin
                }
            }
            catch (Exception ex)
            {
                //Mensaje de error
                Console.WriteLine(ex.ToString());
                this.Close();
            }
        }

        private void Text_Cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo numeros y un guion
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

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_ImgDefault_Click(object sender, EventArgs e)
        {
            // Le pone la imagen default a esa cedula
        }

        private void ColorTexto(object sender, KeyPressEventArgs e)
        {
            // Cambian de color cuando estan encima de los text box y ademas se borra el texto pero despues aparece de nuevo
        }
    }
}
