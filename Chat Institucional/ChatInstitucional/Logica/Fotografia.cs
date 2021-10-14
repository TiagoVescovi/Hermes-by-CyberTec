﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing;

namespace ChatInstitucional.Logica
{
    class Fotografia
    {
        protected object Imagen;

        public Fotografia()
        {

        }

        public object GetImagen()
        {
            return Imagen;
        }

        public void SetImagen(object img)
        {
            Imagen = img;
        }
        //Convierte Byte a Imagen
        public MemoryStream ByteToImage(byte[] array)
        {
            MemoryStream ms = new MemoryStream((byte[])array);
            return ms;
        }

        //Convierte Imagen a Byte
        public byte[] ImageToByte(Image imagenIn)
        {
            MemoryStream ms = new MemoryStream();
            imagenIn.Save(ms, ImageFormat.Jpeg);

            return ms.ToArray();
        }
    }
}
