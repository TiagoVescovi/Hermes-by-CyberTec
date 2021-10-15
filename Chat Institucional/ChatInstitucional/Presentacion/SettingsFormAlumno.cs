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
    public partial class SettingsFormAlumno : Form
    {
        Validacion validacion = new Validacion();
        Fotografia fotografia = new Fotografia();

        public SettingsFormAlumno()
        {
            InitializeComponent();
        }

        private void Btn_ChangeNick_Click(object sender, EventArgs e)
        {
            //Cambia el nickname
            DialogResult result = MessageBox.Show("¿Está segur@ que desea cambiar su Nickname?","Cambiar Nickname",MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                validacion.Modify("UPDATE persona SET nickname = '" + Text_Nick.Text + "' WHERE cedula = " + Validacion.UsuarioActual + ";");
            }
        }

        private void Btn_BajaUser_Click(object sender, EventArgs e)
        {
            //Elimina logicamente al usuario
            DialogResult result = MessageBox.Show("¿Está segur@ que desea eliminar su usuario?\nSi lo hace no podrá volver a iniciar sesión", "Eliminar usuario", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if(validacion.Modify("UPDATE persona SET activo = false WHERE cedula = " + Validacion.UsuarioActual + ";"))
                {
                    MessageBox.Show("No se pudo eliminar el usuario");
                }
            }
        }

        private void Btn_SubirFoto_Click(object sender, EventArgs e)
        {
            //Cambiar foto en el programa -- Parece q esto funciona bien
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
            }
        }

        private void Btn_ChangeFoto_Click(object sender, EventArgs e)
        {
            //Subir imagen a bdd -- Arreglar
            byte[] foto = fotografia.ImageToByte(Picture_ImgPerfil.Image);


            DialogResult result = MessageBox.Show("¿Está segur@ que desea cambiar su foto de perfil?", "Cambiar imágen", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
               // if(validacion.Modify("UPDATE persona SET foto = LOAD_FILE('" + Picture_ImgPerfil.Image + "' WHERE cedula = " + Validacion.UsuarioActual + ";"))
                if(validacion.ModifyPicture(foto,Validacion.UsuarioActual))
                {
                    MessageBox.Show("No se pudo cargar correctamente la imágen");
                }
            }
        }
    }
}
