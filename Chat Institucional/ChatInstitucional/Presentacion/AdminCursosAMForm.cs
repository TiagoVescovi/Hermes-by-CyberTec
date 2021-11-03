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
    public partial class AdminCursosAMForm : Form
    {
        int TipoCurso, Accion, ID;

        public AdminCursosAMForm(int type, int action)  //Este agrega
        {
            InitializeComponent();
            TipoCurso = type;
            Accion = action;

            switch (TipoCurso)
            {
                case 1:
                    //Orientacion
                    Lbl_Titulo.Text = "AGREGAR ORIENTACIÓN";
                    Combo_Ori.Enabled = false;
                    Text_Ano.Enabled = false;
                    Text_Grado.Enabled = false;
                    Text_Dist.Enabled = false;
                    break;

                case 2:
                    //Grupo
                    Lbl_Titulo.Text = "AGREGAR GRUPO";
                    Text_Nombre.Enabled = false;
                    break;

                case 3:
                    //Materia
                    Lbl_Titulo.Text = "AGREGAR MATERIA";
                    Combo_Ori.Enabled = false;
                    Text_Ano.Enabled = false;
                    Text_Grado.Enabled = false;
                    Text_Dist.Enabled = false;
                    break;
            }
        }

        private void Text_Grado_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Poner q solo se puedan numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Solo se pueden poner numeros
                e.Handled = true;
            }
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            switch (TipoCurso)
            {
                case 1:
                    //Orientacion
                    Orientacion orientacion = new Orientacion();
                    switch (Accion)
                    {
                        case 1:
                            //Agrega
                            try
                            {
                                if (!String.IsNullOrEmpty(Text_Nombre.Text))
                                {
                                    orientacion.SetNombre(Text_Nombre.Text);
                                    if (orientacion.AgregarOrientacion(orientacion))
                                    {
                                        MessageBox.Show("Orientación agregada satisfactoriamente");
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se pudo agregar la orientación");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Debe llenar todos los campos");
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.ToString());
                                MessageBox.Show("Ocurrió un error. Regrese e intente de nuevo");
                            }
                            
                            break;

                        case 2:
                            //Modifica
                            try
                            {
                                if (!String.IsNullOrEmpty(Text_Nombre.Text))
                                {
                                    if (orientacion.ModificarOrientación("nombre", "'" + Text_Nombre.Text + "'", ID))
                                    {
                                        MessageBox.Show("Orientación actualizada satisfactoriamente");
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se pudo actualizar la orientación");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Debe llenar todos los campos");
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.ToString());
                                MessageBox.Show("Ocurrió un error. Regrese e intente de nuevo");
                            }

                            break;

                        default:
                            //Mensaje de error y sale
                            MessageBox.Show("Ocurrió un error. Regrese e intente de nuevo");
                            this.Close();
                            break;
                    }
                    break;

                case 2:
                    //Grupo
                    Grupo grupo = new Grupo();
                    switch (Accion)
                    {
                        case 1:
                            //Agrega
                            try
                            {
                                if (!String.IsNullOrEmpty(Text_Grado.Text) && !String.IsNullOrEmpty(Text_Dist.Text) && !String.IsNullOrEmpty(Text_Ano.Text) && !String.IsNullOrEmpty(Combo_Ori.SelectedItem.ToString()) && !String.IsNullOrEmpty(Combo_Ori.Text))
                                {
                                    Orientacion ori = new Orientacion();
                                    grupo.SetNombre(Text_Grado.Text + "°" + Text_Dist.Text);
                                    grupo.SetIdOrientacion(Convert.ToInt32(ori.ListarOrientaciones().Rows[Combo_Ori.SelectedIndex][0]));
                                    grupo.SetAno(Convert.ToInt32(Text_Ano.Text));
                                    if (grupo.AgregarGrupo(grupo))
                                    {
                                        MessageBox.Show("Grupo agregado satisfactoriamente");
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se pudo agregar el grupo");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Debe llenar todos los campos");
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.ToString());
                                MessageBox.Show("Ocurrió un error. Regrese e intente de nuevo");
                            }
                            
                            break;

                        case 2:
                            //Modifica
                            try
                            {

                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.ToString());
                                MessageBox.Show("Ocurrió un error. Regrese e intente de nuevo");
                            }
                            if (!String.IsNullOrEmpty(Text_Grado.Text) && !String.IsNullOrEmpty(Text_Dist.Text) && !String.IsNullOrEmpty(Text_Ano.Text) && !String.IsNullOrEmpty(Combo_Ori.SelectedItem.ToString()))
                            {
                                if (grupo.ModificarGrupo("nombre", "'" + Text_Grado.Text + "°" + Text_Dist.Text + "'", ID))
                                {
                                    MessageBox.Show("Grupo actualizado satisfactoriamente");
                                }
                                else
                                {
                                    MessageBox.Show("No se pudo actualizar el grupo");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Debe llenar todos los campos");
                            }
                            break;

                        default:
                            //Mensaje de error y sale
                            MessageBox.Show("Ocurrió un error. Regrese e intente de nuevo");
                            this.Close();
                            break;
                    }
                    break;

                case 3:
                    //Materia
                    Materia materia = new Materia();
                    switch (Accion)
                    {
                        case 1:
                            //Agrega
                            try
                            {
                                if (!String.IsNullOrEmpty(Text_Nombre.Text))
                                {
                                    materia.SetNombre(Text_Nombre.Text);
                                    if (materia.AgregarMateria(materia))
                                    {
                                        MessageBox.Show("Materia agregada satisfactoriamente");
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se pudo agregar la materia");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Debe llenar todos los campos");
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.ToString());
                                MessageBox.Show("Ocurrió un error. Regrese e intente de nuevo");
                            }
                            
                            break;

                        case 2:
                            //Modifica
                            try
                            {
                                if (!String.IsNullOrEmpty(Text_Nombre.Text))
                                {
                                    if (materia.ModificarMateria("nombre", "'" + Text_Nombre.Text + "'", ID))
                                    {
                                        MessageBox.Show("Orientación actualizada satisfactoriamente");
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se pudo actualizar la orientación");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Debe llenar todos los campos");
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.ToString());
                                MessageBox.Show("Ocurrió un error. Regrese e intente de nuevo");
                            }
                            
                            break;

                        default:
                            //Mensaje de error y sale
                            MessageBox.Show("Ocurrió un error. Regrese e intente de nuevo");
                            this.Close();
                            break;
                    }
                    break;
            }
        }

        private void Text_Ano_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo numeros
            //Es un año
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Solo se pueden poner numeros
                e.Handled = true;
            }
        }

        public AdminCursosAMForm(int type, int action, int id)  //Este modifica
        {
            InitializeComponent();
            TipoCurso = type;
            Accion = action;
            ID = id;
            Orientacion orientacion = new Orientacion();

            switch (TipoCurso)
            {
                case 1:
                    //Orientacion
                    Combo_Ori.Enabled = false;
                    Text_Ano.Enabled = false;
                    Text_Grado.Enabled = false;
                    Text_Dist.Enabled = false;

                    Text_Nombre.Text = orientacion.BuscarOrientacion(ID).GetNombre();
                    break;

                case 2:
                    //Grupo
                    Grupo grupo = new Grupo();
                    Text_Nombre.Enabled = false;
                    string[] grado = grupo.TraerGrupo(ID).GetNombre().Split('°');

                    Text_Grado.Text = grado[0];
                    Text_Dist.Text = grado[1];
                    Text_Ano.Text = grupo.TraerGrupo(ID).GetAno().ToString();
                    break;

                case 3:
                    //Materia
                    Materia materia = new Materia();
                    Combo_Ori.Enabled = false;
                    Text_Ano.Enabled = false;
                    Text_Grado.Enabled = false;
                    Text_Dist.Enabled = false;

                    Text_Nombre.Text = materia.BuscarMateria(ID).GetNombre();
                    break;
            }
        }

        private void AdminCursosAMForm_Load(object sender, EventArgs e)
        {
            Orientacion orientacion = new Orientacion();
            for(int i = 0; i < orientacion.ListarOrientaciones().Rows.Count; i++)
            {
                Combo_Ori.Items.Add(orientacion.ListarOrientaciones().Rows[i][1]);
            }
        }
    }
}
