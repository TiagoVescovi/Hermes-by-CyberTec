﻿using System;
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
    public partial class VerConsultasForm : Form
    {
        Validacion validacion = new Validacion();
        int idAsincronica;
        int cedula;

        public VerConsultasForm(int IdAsincronica, int Cedula)
        {
            InitializeComponent();

            idAsincronica = IdAsincronica;
        }

        private void VerConsultasAlumnoForm_Load(object sender, EventArgs e)
        {
            Asincronica asincronica = new Asincronica();
            //Poner el nombre del alumno en el titulo del form -- Capaz q no
            Text_Consulta.Text = asincronica.VerAsincronica(idAsincronica).GetConsulta().ToString();
            Text_Respuesta.Text = asincronica.VerAsincronica(idAsincronica).GetRespuesta().ToString();

            if (cedula == asincronica.VerAsincronica(idAsincronica).GetCiProfesor())
            {
                Btn_Respoder.Enabled = true;
                Text_Respuesta.ReadOnly = false;
            }
        }

        private void Btn_Respoder_Click(object sender, EventArgs e)
        {
            Asincronica asincronica = new Asincronica();
            if (asincronica.ResponderAsincronica(idAsincronica, Text_Respuesta.Text))
            {
                MessageBox.Show("Se ha respondido la consulta satisfactoriamente");
            }
            else
            {
                MessageBox.Show("No se pudo enviar la respuesta");
            }
        }
    }
}
