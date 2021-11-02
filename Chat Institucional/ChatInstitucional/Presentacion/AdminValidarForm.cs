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
    public partial class AdminValidarForm : Form
    {
        int tipo;

        public AdminValidarForm(int i)
        {
            InitializeComponent();

            tipo = i;
        }

        private void AdminValidarForm_Load(object sender, EventArgs e)
        {
            switch (tipo)
            {
                case 1:
                    RecargarDocentes();
                    break;

                case 2:
                    RecargarAlumnos();
                    break;

                default:
                    MessageBox.Show("No se pudo cargar la página");
                    this.Dispose();
                    break;
            }
        }

        private void Btn_Volver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_Activar_Click(object sender, EventArgs e)
        {
            switch (tipo)
            {
                case 1:
                    // Docente
                    Administrador administrador = new Administrador();
                    if (administrador.AceptarUsuario(Convert.ToInt32(Dgv_Alumnos.CurrentRow.Cells[0].Value)))
                    {
                        MessageBox.Show("Docente " + Dgv_Alumnos.CurrentRow.Cells[1].Value.ToString() + " " + Dgv_Alumnos.CurrentRow.Cells[2].Value.ToString() + " aceptado");
                        RecargarDocentes();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo aceptar a " + Dgv_Alumnos.CurrentRow.Cells[1].Value.ToString() + " " + Dgv_Alumnos.CurrentRow.Cells[2].Value.ToString());
                    }
                    break;

                case 2:
                    // Alumno
                    Administrador admin = new Administrador();
                    if (admin.AceptarUsuario(Convert.ToInt32(Dgv_Alumnos.CurrentRow.Cells[0].Value)))
                    {
                        MessageBox.Show("Alumno " + Dgv_Alumnos.CurrentRow.Cells[1].Value.ToString() + " " + Dgv_Alumnos.CurrentRow.Cells[2].Value.ToString() + " aceptado");
                        RecargarAlumnos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo aceptar a " + Dgv_Alumnos.CurrentRow.Cells[1].Value.ToString() + " " + Dgv_Alumnos.CurrentRow.Cells[2].Value.ToString());
                    }
                    break;

                default:
                    MessageBox.Show("No se pudo activar el usuario");
                    this.Close();
                    break;
            }
        }

        private void Dgv_Alumnos_MouseClick(object sender, MouseEventArgs e)
        {
            Btn_Activar.Enabled = true;
        }

        private void RecargarAlumnos()
        {
            Administrador administrador = new Administrador();

            Dgv_Alumnos.Columns.Add("Cedula", "Cedula");
            Dgv_Alumnos.Columns.Add("Nombre", "Nombre");
            Dgv_Alumnos.Columns.Add("Apellido", "Apellido");
            Dgv_Alumnos.Columns.Add("Grupo", "Grupo");

            if (administrador.ListaValidarAlumnos().Rows.Count > 0)
            {
                for (int i = 0; i < administrador.ListaValidarAlumnos().Rows.Count; i++)
                {
                    Dgv_Alumnos.Rows.Add(administrador.ListaValidarAlumnos().Rows[i][0], administrador.ListaValidarAlumnos().Rows[i][3], administrador.ListaValidarAlumnos().Rows[i][4], administrador.ListaValidarAlumnos().Rows[i][12]);
                }
            }
            else
            {
                MessageBox.Show("No hay alumnos que validar o no se pueden mostrar");
                this.Close();
            }
        }

        private void RecargarDocentes()
        {
            Administrador admin = new Administrador();

            Dgv_Alumnos.Columns.Add("Cedula", "Cedula");
            Dgv_Alumnos.Columns.Add("Nombre", "Nombre");
            Dgv_Alumnos.Columns.Add("Apellido", "Apellido");

            if (admin.ListaValidarDocentes().Rows.Count > 0)
            {
                for (int i = 0; i < admin.ListaValidarDocentes().Rows.Count; i++)
                {
                    Dgv_Alumnos.Rows.Add(admin.ListaValidarDocentes().Rows[i][0], admin.ListaValidarDocentes().Rows[i][2], admin.ListaValidarDocentes().Rows[i][3]);
                }
            }
            else
            {
                MessageBox.Show("No hay docentes que validar o no se pueden mostrar");
                this.Close();
            }
        }
    }
}
