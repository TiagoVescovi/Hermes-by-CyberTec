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
    public partial class AdminAdminForm : Form
    {
        public AdminAdminForm()
        {
            InitializeComponent();
        }

        private void AdminAdminForm_Load(object sender, EventArgs e)
        {
            RecargarAdmins();
            RecargarPersonas();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            AdminAltaModForm form = new AdminAltaModForm(3, 1);
            form.ShowDialog();
            RecargarAdmins();
            RecargarPersonas();
        }

        private void Btn_Del_Click(object sender, EventArgs e)
        {
            Administrador administrador = new Administrador();
            if(administrador.ListarAdmins().Rows.Count == 1)
            {
                DialogResult dialogResult = MessageBox.Show("ADVERTENCIA:\nEres el último administrador de este sistema. Si te eliminas ahora no habrán más administradores.\n¿Quieres proceder?","ADVERTENCIA",MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    if (administrador.EliminarAdmin(Convert.ToInt32(Dgv_Docentes.CurrentRow.Cells[0].Value)))
                    {
                        MessageBox.Show("¡Felicidades!\nDejaste el sistema sin administradores");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el administrador");
                    }
                }
            }
            else
            {
                if (administrador.EliminarAdmin(Convert.ToInt32(Dgv_Docentes.CurrentRow.Cells[0].Value)))
                {
                    MessageBox.Show("Administrador eliminado satisfactoriamente");
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el administrador");
                }
            }
        }

        private void Btn_Mod_Click(object sender, EventArgs e)
        {
            AdminAltaModForm form = new AdminAltaModForm(3, 2, Convert.ToInt32(Dgv_Docentes.CurrentRow.Cells[0].Value));
            form.ShowDialog();
            RecargarPersonas();
            RecargarAdmins();
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            RecargarAdmins();
            RecargarPersonas();
        }

        private void Dgv_Docentes_MouseClick(object sender, MouseEventArgs e)
        {
            Btn_Del.Enabled = true;
            Btn_Mod.Enabled = true;
        }

        public void RecargarAdmins()
        {
            Administrador administrador = new Administrador();
            Dgv_Docentes.DataSource = administrador.ListarAdmins();
        }

        public void RecargarPersonas()
        {
            Administrador administrador = new Administrador();
            Dgv_Todas.DataSource = administrador.ListarPersonas();
        }
    }
}
