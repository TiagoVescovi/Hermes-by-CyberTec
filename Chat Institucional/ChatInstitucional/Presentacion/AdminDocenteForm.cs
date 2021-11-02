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
    public partial class AdminDocenteForm : Form
    {
        public AdminDocenteForm()
        {
            InitializeComponent();
        }

        private void AdminDocenteForm_Load(object sender, EventArgs e)
        {
            RecargarDocentes();
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            RecargarDocentes();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            AdminAltaModForm aamF = new AdminAltaModForm(1, 1);
            aamF.ShowDialog();
        }

        private void Btn_Del_Click(object sender, EventArgs e)
        {
            Docente docente = new Docente();
            DialogResult dialogResult = MessageBox.Show("¿Seguro que quiere eliminar este usuario?", "Eliminar usuario", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (docente.EliminarDocente(Convert.ToInt32(Dgv_Docentes.CurrentRow.Cells[0].Value))) 
                {
                    MessageBox.Show("Docente eliminado satisfactoriamente");
                    RecargarDocentes();
                }
                else
                {
                    MessageBox.Show("No se ha podido eliminar el docente");
                }
            }
        }

        private void Btn_Mod_Click(object sender, EventArgs e)
        {
            AdminAltaModForm aamF = new AdminAltaModForm(1, 2, Convert.ToInt32(Dgv_Docentes.CurrentRow.Cells[0].Value));
            aamF.ShowDialog();
            RecargarDocentes();
        }

        private void Btn_Val_Click(object sender, EventArgs e)
        {
            AdminValidarForm aavF = new AdminValidarForm(1);
            aavF.ShowDialog();
            RecargarDocentes();
        }

        private void RecargarDocentes()
        {
            Docente docente = new Docente();
            Dgv_Docentes.DataSource = docente.ListarDocentes();
        }

        private void Dgv_Docentes_MouseClick(object sender, MouseEventArgs e)
        {
            Btn_Del.Enabled = true;
            Btn_Materias.Enabled = true;
            Btn_Mod.Enabled = true;
        }
    }
}
