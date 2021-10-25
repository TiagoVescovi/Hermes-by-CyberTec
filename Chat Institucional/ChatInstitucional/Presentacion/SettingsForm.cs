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
    public partial class SettingsForm : Form
    {
        Validacion validacion = new Validacion();
        Fotografia fotografia = new Fotografia();

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void Btn_ChangeNick_Click(object sender, EventArgs e)
        {
            // Cambia el nickname
            Persona persona = new Persona();
            DialogResult result = MessageBox.Show("¿Está segur@ que desea cambiar su Nickname?","Cambiar Nickname",MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                if (persona.ModificarPersona("nickname", "'" + Text_Nick.Text + "'", Validacion.UsuarioActual))
                {
                    MessageBox.Show("Nickname cambiado existosamente");
                }
            }
        }

        private void Btn_BajaUser_Click(object sender, EventArgs e)
        {
            // Elimina logicamente al usuario
            Persona persona = new Persona();
            DialogResult result = MessageBox.Show("¿Está segur@ que desea eliminar su usuario?\nSi lo hace no podrá volver a iniciar sesión\nLa aplicación se cerrará", "Eliminar usuario", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if(persona.EliminarPersona(Validacion.UsuarioActual))
                {
                    MessageBox.Show("Usuario eliminado satisfactoriamente");
                    validacion.ValidarLogOut(Validacion.UsuarioActual);
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar al usuario");
                }
            }
        }

        private void Btn_SubirFoto_Click(object sender, EventArgs e)
        {
            // Cambiar foto en el programa -- Parece q esto funciona bien
            openFileDialog1.Filter = "Imagenes|*.jpg;*.jpeg;*.png;*.gif;";
            openFileDialog1.Title = "Seleccione su nueva imágen";
            
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    Picture_ImgPerfil.Image = Image.FromFile(imagen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
                Console.WriteLine(ex.ToString());
            }
        }

        private void Btn_ChangeFoto_Click(object sender, EventArgs e)
        {
            //Subir imagen a bdd -- Arreglar
            byte[] foto = fotografia.ImageToByte(Picture_ImgPerfil.Image);


            DialogResult result = MessageBox.Show("¿Está segur@ que desea cambiar su foto de perfil?", "Cambiar imágen", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Fotografia fotografia = new Fotografia();
                fotografia.SetImagen(foto);
                if(fotografia.CambiarImagen(foto, Validacion.UsuarioActual))
                {
                    MessageBox.Show("La imágen se subió correctamente");
                    // Cuando se suba q aparezca arriba
                }
                else
                {
                    MessageBox.Show("No se pudo subir la imágen");
                }
            }
        }

        private void Btn_ChangeLang_Click(object sender, EventArgs e)
        {
            if(Combo_Idioma.SelectedItem.ToString() == "English")
            {
                // Agregar en bd atributo idioma
                // Aca lo cambiaria a ingles
            }else if(Combo_Idioma.SelectedItem.ToString() == "Español")
            {
                // Aca lo cambia a español
            }
            else
            {
                // Mensaje de error de q no se selecciono nada
            }
        }

        private void Btn_ChangeTheme_Click(object sender, EventArgs e)
        {
            // Capaz q esto no lo hacemos
        }
    }
}
