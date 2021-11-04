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
        string[] cargos = { "Director/a", "Subdirector/a", "Adscripto/a", "Secretario/a", "Otro/a" };

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
            Combo_Nuevo_Existenete.ForeColor = Color.Black;

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
                    Combo_Grupos.Enabled = true;

                    Combo_Grupos.Items.AddRange(cargos);
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

            Combo_Nuevo_Existenete.Enabled = false;
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
                    Combo_Grupos.Items.AddRange(cargos);

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
                                if(Combo_Nuevo_Existenete.SelectedIndex == 0)
                                {
                                    Fotografia foto = new Fotografia();

                                    foto.SetImagen(foto.ImageToByte(ChatInstitucional.Properties.Resources.descarga));

                                    try
                                    {
                                        if (!String.IsNullOrEmpty(Text_Nick.Text) && Text_Nick.Text != "Nickname" && !String.IsNullOrEmpty(Text_Cedula.Text) && Text_Cedula.Text != "Cedula" && !String.IsNullOrEmpty(Text_Apellido.Text) && Text_Apellido.Text != "Apellido" && !String.IsNullOrEmpty(Text_Nombre.Text) && Text_Nombre.Text != "Nombre" && !String.IsNullOrEmpty(Text_Pass.Text) && Text_Pass.Text != "Contaseña" && !String.IsNullOrEmpty(Text_PassCheck.Text) && Text_PassCheck.Text != "Confirmar Contraseña")
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

                                            if (CIValidator.Validate(ced + "-" + iden))
                                            {
                                                if (Text_Pass.Text == Text_PassCheck.Text)
                                                {
                                                    Docente docente = new Docente();
                                                    docente.SetNickname(Text_Nick.Text);
                                                    docente.SetCI(int.Parse(ced));
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
                                        MessageBox.Show("Ocurrió un error, intente otra vez.");
                                    }
                                }
                                else if (Combo_Nuevo_Existenete.SelectedIndex == 1)
                                {
                                    if (!String.IsNullOrEmpty(Text_Nick.Text) && Text_Nick.Text != "Nickname" && !String.IsNullOrEmpty(Text_Cedula.Text) && Text_Cedula.Text != "Cedula" && !String.IsNullOrEmpty(Text_Apellido.Text) && Text_Apellido.Text != "Apellido" && !String.IsNullOrEmpty(Text_Nombre.Text) && Text_Nombre.Text != "Nombre" && !String.IsNullOrEmpty(Text_Pass.Text) && Text_Pass.Text != "Contaseña" && !String.IsNullOrEmpty(Text_PassCheck.Text) && Text_PassCheck.Text != "Confirmar Contraseña")
                                    {
                                        Administrador administrador = new Administrador();
                                        string cedula = Text_Cedula.Text;
                                        string pass = Text_Pass.Text;
                                        string ced = "1111111";
                                        string iden = "2";

                                        if (cedula.Length == 8)
                                        {
                                            ced = cedula.Substring(0, 7);
                                            iden = cedula.Substring(7, 1);
                                        }

                                        if (CIValidator.Validate(ced + "-" + iden))
                                        {
                                            if (administrador.AgregarEnDocente(int.Parse(ced)))
                                            {
                                                MessageBox.Show("Docente agregado satisfacttoriamente");
                                                this.Close();
                                            }
                                            else
                                            {
                                                MessageBox.Show("El docente ya está creado u ocurrió un error en su creación");
                                                this.Close();
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
                                else
                                {
                                    MessageBox.Show("Debe seleccionar el estado de la persona");
                                }
                                break;

                            case 2:
                                //Modificar
                                if (!String.IsNullOrEmpty(Text_Cedula.Text) && Text_Cedula.Text != "Cedula" && !String.IsNullOrEmpty(Text_Nombre.Text) && Text_Nombre.Text != "Nombre" && !String.IsNullOrEmpty(Text_Apellido.Text) && Text_Apellido.Text != "Apellido" && !String.IsNullOrEmpty(Text_Nick.Text) && Text_Nick.Text != "Nickname")
                                {
                                    Docente docente = new Docente();
                                    int cedula = int.Parse(Text_Cedula.Text);

                                    if (docente.ModificarPersona("nombre", "'" + Text_Nombre.Text + "'", cedula) && docente.ModificarPersona("apellido", "'" + Text_Apellido.Text + "'", cedula) && docente.ModificarPersona("nickname", "'" + Text_Nick.Text + "'", cedula))
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
                        break; // Fin del docente

                    case 2:
                        //Alumno
                        switch (Accion)
                        {
                            case 1:
                                //Añadir
                                if(Combo_Nuevo_Existenete.SelectedIndex == 0)
                                {
                                    try
                                    {
                                        DialogResult dialogResult = MessageBox.Show("Solo se ingresará la cédula para que luego un alumno se registre\n¿Desea continuar?", "Añadir usuario", MessageBoxButtons.YesNo);
                                        if (dialogResult == DialogResult.Yes)
                                        {
                                            // No ser fija si existe
                                            if (!String.IsNullOrEmpty(Text_Cedula.Text) && Text_Cedula.Text != "Cedula")
                                            {
                                                Administrador administrador = new Administrador();
                                                string cedula = Text_Cedula.Text;
                                                string pass = Text_Pass.Text;
                                                string ced = "1111111";
                                                string iden = "2";

                                                if (cedula.Length == 8)
                                                {
                                                    ced = cedula.Substring(0, 7);
                                                    iden = cedula.Substring(7, 1);
                                                }

                                                if (CIValidator.Validate(ced + "-" + iden))
                                                {
                                                    if (administrador.AgregarAlumno(int.Parse(ced)))
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
                                            else
                                            {
                                                MessageBox.Show("Debe llenar el campo de cédula.");
                                            }
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex.ToString());
                                        this.Close();
                                    }
                                }
                                else if(Combo_Nuevo_Existenete.SelectedIndex == 1)
                                {

                                    if (!String.IsNullOrEmpty(Text_Cedula.Text) && Text_Cedula.Text != "Cedula" && Combo_Grupos.SelectedIndex != -1)
                                    {
                                        Administrador administrador = new Administrador();
                                        Grupo grupo = new Grupo();
                                        string cedula = Text_Cedula.Text;
                                        string ced = "1111111";
                                        string iden = "2";

                                        if (cedula.Length == 8)
                                        {
                                            ced = cedula.Substring(0, 7);
                                            iden = cedula.Substring(7, 1);
                                        }

                                        if (CIValidator.Validate(ced + "-" + iden))
                                        {
                                            if (administrador.AgregarEnAlumno(int.Parse(ced), Convert.ToInt32(grupo.LlenarComboBox().Rows[Combo_Grupos.SelectedIndex][0])) && administrador.ModificarPersona("activo", "false", int.Parse(ced)))
                                            {
                                                MessageBox.Show("Alumno agregado satisfactoriamente");
                                                this.Close();
                                            }
                                            else
                                            {
                                                MessageBox.Show("El alumno ya está creado u ocurrió un error en su creación");
                                                this.Close();
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
                                else
                                {
                                    MessageBox.Show("Debe seleccionar el estado de la persona");
                                }
                                break;

                            case 2:
                                //Modificar
                                if (!String.IsNullOrEmpty(Text_Nick.Text) && Text_Nick.Text != "Nickname" && !String.IsNullOrEmpty(Text_Cedula.Text) && Text_Cedula.Text != "Cedula" && !String.IsNullOrEmpty(Text_Apellido.Text) && Text_Apellido.Text != "Apellido" && !String.IsNullOrEmpty(Text_Nombre.Text) && Text_Nombre.Text != "Nombre"  && Combo_Grupos.SelectedIndex != -1)
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
                                if(Combo_Nuevo_Existenete.SelectedIndex == 0)
                                {
                                    Fotografia foto = new Fotografia();

                                    foto.SetImagen(foto.ImageToByte(ChatInstitucional.Properties.Resources.descarga));

                                    try
                                    {
                                        if (!String.IsNullOrEmpty(Text_Cedula.Text) && Text_Cedula.Text != "Cedula" && !String.IsNullOrEmpty(Text_Nick.Text) && Text_Nick.Text != "Nickname" && !String.IsNullOrEmpty(Text_Cedula.Text) && Text_Cedula.Text != "Cedula" && !String.IsNullOrEmpty(Text_Apellido.Text) && Text_Apellido.Text != "Apellido" && !String.IsNullOrEmpty(Text_Nombre.Text) && Text_Nombre.Text != "Nombre" && !String.IsNullOrEmpty(Text_Pass.Text) && Text_Pass.Text != "Contaseña" && !String.IsNullOrEmpty(Text_PassCheck.Text) && Text_PassCheck.Text != "Confirmar Contraseña")
                                        {
                                            string cedula = Text_Cedula.Text;
                                            string ced = "1111111";
                                            string iden = "2";

                                            if (cedula.Length == 8)
                                            {
                                                ced = cedula.Substring(0, 7);
                                                iden = cedula.Substring(7, 1);
                                            }

                                            if (CIValidator.Validate(ced + "-" + iden))
                                            {
                                                if (Text_Pass.Text == Text_PassCheck.Text)
                                                {
                                                    Administrador admin = new Administrador();
                                                    admin.SetNickname(Text_Nick.Text);
                                                    admin.SetCI(int.Parse(ced));
                                                    admin.SetNombre(Text_Nombre.Text);
                                                    admin.SetApellido(Text_Apellido.Text);
                                                    admin.SetPass(Text_Pass.Text);
                                                    admin.SetCargo(Combo_Grupos.SelectedItem.ToString());
                                                    //admin.SetFoto(foto.GetImagen()); // Hay un lugar en el q esto no funca

                                                    if (admin.AgregarAdmin(admin))
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
                                        MessageBox.Show("Ocurrió un error, intente otra vez.");
                                    }
                                }
                                else if(Combo_Nuevo_Existenete.SelectedIndex == 1)
                                {

                                    if (!String.IsNullOrEmpty(Text_Cedula.Text) && Text_Cedula.Text != "Cedula" && !String.IsNullOrEmpty(Combo_Grupos.SelectedIndex.ToString()))
                                    {
                                        Administrador administrador = new Administrador();
                                        string cedula = Text_Cedula.Text;
                                        string ced = "1111111";
                                        string iden = "2";

                                        if (cedula.Length == 8)
                                        {
                                            ced = cedula.Substring(0, 7);
                                            iden = cedula.Substring(7, 1);
                                        }

                                        if (CIValidator.Validate(ced + "-" + iden))
                                        {
                                            if (administrador.AgregarEnAdmin(int.Parse(ced), Combo_Grupos.SelectedItem.ToString()))
                                            {
                                                MessageBox.Show("Administrador agregado satisfactoriamente");
                                                this.Close();
                                            }
                                            else
                                            {
                                                MessageBox.Show("El administrador ya está creado u ocurrió un error en su creación");
                                                this.Close();
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
                                else
                                {
                                    MessageBox.Show("Debe seleccionar el estado de la persona");
                                }
                                break;

                            case 2:
                                //Modificar
                                if (!String.IsNullOrEmpty(Text_Cedula.Text) && Text_Cedula.Text != "Cedula" && !String.IsNullOrEmpty(Text_Nick.Text) && Text_Nick.Text != "Nickname" && !String.IsNullOrEmpty(Text_Cedula.Text) && Text_Cedula.Text != "Cedula" && !String.IsNullOrEmpty(Text_Apellido.Text) && Text_Apellido.Text != "Apellido" && !String.IsNullOrEmpty(Text_Nombre.Text) && Text_Nombre.Text != "Nombre" && !String.IsNullOrEmpty(Text_Pass.Text) && Text_Pass.Text != "Contaseña" && !String.IsNullOrEmpty(Text_PassCheck.Text) && Text_PassCheck.Text != "Confirmar Contraseña" && !String.IsNullOrEmpty(Combo_Grupos.SelectedIndex.ToString()))
                                {
                                    Administrador admin = new Administrador();
                                    int cedula = int.Parse(Text_Cedula.Text);

                                    if (admin.ModificarPersona("nombre", "'" + Text_Nombre.Text + "'", cedula) && admin.ModificarPersona("apellido", "'" + Text_Apellido.Text + "'", cedula) && admin.ModificarPersona("nickname", "'" + Text_Nick.Text + "'", cedula) && admin.ModificarAdmin("cargo", "'" + Combo_Grupos.SelectedItem.ToString() + "'", cedula)) 
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Solo se pueden poner numeros
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
            Fotografia fotografia = new Fotografia();
            Persona persona = new Persona();
            try
            {
                if(!String.IsNullOrEmpty(Text_Cedula.Text) && Text_Cedula.Text != "Cedula")
                {
                    string cedula = Text_Cedula.Text;
                    string ced = "1111111";
                    string iden = "2";

                    if (cedula.Length == 8)
                    {
                        ced = cedula.Substring(0, 7);
                        iden = cedula.Substring(7, 1);
                    }

                    if (CIValidator.Validate(ced + "-" + iden))
                    {
                        fotografia.SetImagen(fotografia.ImageToByte(ChatInstitucional.Properties.Resources.descarga));
                        if (persona.ModificarPersona("foto", "'" + fotografia.GetImagen() + "'", Convert.ToInt32(Text_Cedula.Text)))
                        {
                            MessageBox.Show("Imágen actualizada exitosamente");
                        }
                        else
                        {
                            MessageBox.Show("La imágen no se pudo actualizar");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese una cédula válida");
                    }
                }
                else
                {
                    MessageBox.Show("Debes llenar el campo de cédula");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("Ocurrió un error.\nPor favor vuelva a intentar");
                this.Close();
            }
        }

        private void Combo_Nuevo_Existenete_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Combo_Nuevo_Existenete.SelectedIndex == 1)
            {
                Combo_Grupos.Enabled = true;

                Grupo grupo = new Grupo();
                for (int i = 0; i < grupo.LlenarComboBox().Rows.Count; i++)
                {
                    Combo_Grupos.Items.Add(grupo.LlenarComboBox().Rows[i]["nombre"]);
                }
            }
        }

        private void Texts_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = Convert.ToChar("'");
            if (e.KeyChar == chr)
            {
                // Solo se pueden poner numeros
                e.Handled = true;
            }
        }

        private void Text_Cedula_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Solo se pueden poner numeros
                e.Handled = true;
            }
        }
    }
}
