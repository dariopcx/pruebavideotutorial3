using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programaderecursoshumanos
{
    public partial class frmvacaciones : Form
    {
        conexion con = new conexion();
        public frmvacaciones()
        {
            InitializeComponent();
        }

        public void mostrarDatos()
        {
            con.consulta("Select * from empleados", "empleados");
            dgvvacaciones.DataSource = con.ds.Tables["empleados"];
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmvacaciones_Load(object sender, EventArgs e)
        {
            con.conectar();
            mostrarDatos();
            this.Size = new Size(525, 180);

        }

        private void dgvvacaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = dgvvacaciones.Rows[e.RowIndex];
        }

        private void btbmostrartabla_Click(object sender, EventArgs e)
        {
            this.Size = new Size(525, 327);
        }

        private void btbcancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frmmenuprincipal frm = new Frmmenuprincipal();

            frm.Show();


        }

        private void btbaceptar_Click(object sender, EventArgs e)
        {

            string actualizar = "estadodelempleado='" + cbestadodelempleado.Text + "',diasdevacaciones='" + txtdias.Text + "',comentario='" + txtcomentario.Text + "'";
            if (con.actualizar("empleados", actualizar, "codigo=" + txtcodigo.Text))
            {
                MessageBox.Show("Datos actualizados");
                mostrarDatos();

            }
            else
            {
                MessageBox.Show("Error al actualizar, codigo invalido");
            }
        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }

            else
            {
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    if (Char.IsSeparator(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }
    }
}

                 
            
        




        
