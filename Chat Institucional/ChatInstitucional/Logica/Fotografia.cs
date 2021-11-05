using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing;

namespace ChatInstitucional.Logica
{
    public class Fotografia
    {
        protected byte[] Imagen;

        public Fotografia()
        {

        }

        public byte[] GetImagen()
        {
            return Imagen;
        }

        public void SetImagen(byte[] img)
        {
            Imagen = img;
        }

        //Convierte Byte a Imagen
        public Image ByteToImage(byte[] array)
        {
            MemoryStream ms = new MemoryStream(array);
            return Image.FromStream(ms);
        }

        //Convierte Imagen a Byte
        public byte[] ImageToByte(Image imagenIn)
        {
            MemoryStream ms = new MemoryStream();
            imagenIn.Save(ms, imagenIn.RawFormat);
            return ms.ToArray();
        }

        public bool CambiarImagen(byte[] foto, int ci)
        {
            Validacion validacion = new Validacion();
            //return validacion.Update("UPDATE persona SET foto = '" + foto + "' WHERE cedula = " + ci + ";");
            return validacion.ModifyPicture(foto, ci);
        }
    }
}
