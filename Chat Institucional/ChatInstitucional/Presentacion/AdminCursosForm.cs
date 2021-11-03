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
    public partial class AdminCursosForm : Form
    {
        public AdminCursosForm()
        {
            InitializeComponent();
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            LlenarDgvOri();
            LlenarDgvGrupos();
            LlenarDgvMaterias();
        }

        private void AdminCursosForm_Load(object sender, EventArgs e)
        {
            LlenarDgvOri();
            LlenarDgvGrupos();
            LlenarDgvMaterias();
        }

        private void LlenarDgvOri()
        {
            try
            {
                Orientacion orientacion = new Orientacion();
                DataTable dataTable = orientacion.ListarOrientaciones();
                dataTable.Columns[1].ColumnName = "Orientación";
                Dgv_Ori.DataSource = dataTable;
                Dgv_Ori.Columns[1].Width = Dgv_Ori.Width;
                Dgv_Ori.Columns[0].Visible = false;
                Dgv_Ori.Columns[2].Visible = false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void LlenarDgvGrupos()
        {
            Grupo grupo = new Grupo();
            DataTable dataTable = new DataTable();

            dataTable = grupo.ListarGrupos();
            dataTable.Columns[1].ColumnName = "Grupo";
            Dgv_Grupos.DataSource = dataTable;
            Dgv_Grupos.Columns[1].Width = Dgv_Grupos.Width;
            Dgv_Grupos.Columns[0].Visible = false;
            Dgv_Grupos.Columns[2].Visible = false;
            Dgv_Grupos.Columns[3].Visible = false;
            Dgv_Grupos.Columns[4].Visible = false;
        }

        private void LlenarDgvMaterias()
        {
            Materia materia = new Materia();
            DataTable dataTable = new DataTable();

            dataTable = materia.ListarSoloMaterias();
            dataTable.Columns[1].ColumnName = "Materia";
            Dgv_Materias.DataSource = dataTable;
            Dgv_Materias.Columns[1].Width = Dgv_Materias.Width;
            Dgv_Materias.Columns[0].Visible = false;
            Dgv_Materias.Columns[2].Visible = false;
        }

        private void Btn_Add_Ori_Click(object sender, EventArgs e)
        {
            AdminCursosAMForm adminCursosAMForm = new AdminCursosAMForm(1, 1);
            adminCursosAMForm.ShowDialog();
            LlenarDgvOri();
            LlenarDgvGrupos();
            LlenarDgvMaterias();
        }

        private void Btn_Del_Ori_Click(object sender, EventArgs e)
        {
            Orientacion orientacion = new Orientacion();
            if (orientacion.EliminarOrientacion(Convert.ToInt32(orientacion.ListarOrientaciones().Rows[Dgv_Ori.CurrentRow.Index][0])))
            {
                MessageBox.Show("Orientación eliminada satisfactoriamente");
                LlenarDgvOri();
                LlenarDgvGrupos();
                LlenarDgvMaterias();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar la orientación");
            }
        }

        private void Btn_Mod_Ori_Click(object sender, EventArgs e)
        {
            Orientacion orientacion = new Orientacion();
            AdminCursosAMForm adminCursosAMForm = new AdminCursosAMForm(1, 2, Convert.ToInt32(orientacion.ListarOrientaciones().Rows[Dgv_Ori.CurrentRow.Index][0]));
            adminCursosAMForm.ShowDialog();
            LlenarDgvOri();
            LlenarDgvGrupos();
            LlenarDgvMaterias();
        }

        private void Btn_Add_Gr_Click(object sender, EventArgs e)
        {
            AdminCursosAMForm adminCursosAMForm = new AdminCursosAMForm(2, 1);
            adminCursosAMForm.ShowDialog();
            LlenarDgvOri();
            LlenarDgvGrupos();
            LlenarDgvMaterias();
        }

        private void Btn_Del_Gr_Click(object sender, EventArgs e)
        {
            Grupo grupo = new Grupo();
            if (grupo.EliminarGrupo(Convert.ToInt32(grupo.ListarGrupos().Rows[Dgv_Grupos.CurrentRow.Index][0])))
            {
                MessageBox.Show("Grupo eliminado satisfactoriamente");
                LlenarDgvOri();
                LlenarDgvGrupos();
                LlenarDgvMaterias();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el grupo");
            }
        }

        private void Btn_Mod_Gr_Click(object sender, EventArgs e)
        {
            Grupo grupo = new Grupo();
            AdminCursosAMForm adminCursosAMForm = new AdminCursosAMForm(2, 2, Convert.ToInt32(grupo.ListarGrupos().Rows[Dgv_Grupos.CurrentRow.Index][0]));
            adminCursosAMForm.ShowDialog();
            LlenarDgvOri();
            LlenarDgvGrupos();
            LlenarDgvMaterias();
        }

        private void Btn_Add_Mat_Click(object sender, EventArgs e)
        {
            AdminCursosAMForm adminCursosAMForm = new AdminCursosAMForm(3, 2);
            adminCursosAMForm.ShowDialog();
            LlenarDgvOri();
            LlenarDgvGrupos();
            LlenarDgvMaterias();
        }

        private void Btn_Del_Mat_Click(object sender, EventArgs e)
        {
            Materia materia = new Materia();
            if (materia.EliminarMateria(Convert.ToInt32(materia.ListarSoloMaterias().Rows[Dgv_Materias.CurrentRow.Index][0])))
            {
                MessageBox.Show("Grupo eliminado satisfactoriamente");
                LlenarDgvOri();
                LlenarDgvGrupos();
                LlenarDgvMaterias();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el grupo");
            }
        }

        private void Btn_Mod_Mat_Click(object sender, EventArgs e)
        {
            Materia materia = new Materia();
            AdminCursosAMForm adminCursosAMForm = new AdminCursosAMForm(3, 2, Convert.ToInt32(materia.ListarSoloMaterias().Rows[Dgv_Materias.CurrentRow.Index][0]));
            adminCursosAMForm.ShowDialog();
            LlenarDgvOri();
            LlenarDgvGrupos();
            LlenarDgvMaterias();
        }

        private void Dgv_Ori_MouseClick(object sender, MouseEventArgs e)
        {
            Btn_Del_Ori.Enabled = true;
            Btn_Mod_Ori.Enabled = true;
        }

        private void Dgv_Grupos_MouseClick(object sender, MouseEventArgs e)
        {
            Btn_Del_Gr.Enabled = true;
            Btn_Mod_Gr.Enabled = true;
        }

        private void Dgv_Materias_MouseClick(object sender, MouseEventArgs e)
        {
            Btn_Del_Mat.Enabled = true;
            Btn_Mod_Mat.Enabled = true;
        }
    }
}
