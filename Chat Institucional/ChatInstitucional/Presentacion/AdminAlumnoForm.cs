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
    public partial class AdminAlumnoForm : Form
    {
        public AdminAlumnoForm()
        {
            InitializeComponent();
        }

        private void AdminAlumnoForm_Load(object sender, EventArgs e)
        {
            //Carga el dgv
            RecargarAlumnos();
        }

        private void RecargarAlumnos()
        {
            Alumno alumno = new Alumno();
            Dgv_Alumnos.DataSource = alumno.ListarAlumnos();
        }

        private void Btn_Val_Click(object sender, EventArgs e)
        {
            // ValidarAlumnos
            AdminValidarForm aavF = new AdminValidarForm(2);
            aavF.ShowDialog();
            RecargarAlumnos();
        }

        private void Btn_Del_Click(object sender, EventArgs e)
        {
            // Eliminar
            Alumno alumno = new Alumno();

            DialogResult dialogResult = MessageBox.Show("¿Seguro que quiere eliminar este usuario?", "Modificar usuario", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                alumno.SetCI(Convert.ToInt32(Dgv_Alumnos.CurrentRow.Cells[0].Value));
                if (alumno.EliminarAlumno(alumno))
                {
                    MessageBox.Show("Alumno eliminado satisfactoriamente");
                    RecargarAlumnos();
                }
                else
                {
                    MessageBox.Show("No se ha podido eliminar el alumno");
                }
            }
        }

        private void Dgv_Alumnos_MouseClick(object sender, MouseEventArgs e)
        {
            // Click en el dgv

            Btn_Del.Enabled = true;
            Btn_Mod.Enabled = true;
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            //Lo mismo q el load
            RecargarAlumnos();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            //Este es 1
            AdminAltaModForm adminAltaMod = new AdminAltaModForm(2, 1);
            adminAltaMod.ShowDialog();
        }

        private void Btn_Mod_Click(object sender, EventArgs e)
        {
            //Este es 2
            AdminAltaModForm adminAltaMod = new AdminAltaModForm(2, 2, Convert.ToInt32(Dgv_Alumnos.CurrentRow.Cells[0].Value));
            adminAltaMod.ShowDialog();
        }
    }
}
