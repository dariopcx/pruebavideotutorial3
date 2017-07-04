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
    public partial class frmdespidos : Form
    {
        conexion con = new conexion();
        public frmdespidos()
        {
            InitializeComponent();
        }

        public void mostrarDatos()
        {
            con.consulta("Select * from empleados", "empleados");
            dgvdespidos.DataSource = con.ds.Tables["empleados"];
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btbcalendario_Click(object sender, EventArgs e)
        {
            frmcalendario frm = new frmcalendario();
            frm.Show();
        }

        private void btbcalculadora_Click(object sender, EventArgs e)
        {
            frmcalculadora frm = new frmcalculadora();
            frm.Show();
        }

        private void btbnavegador_Click(object sender, EventArgs e)
        {
            frmnavegador frm = new frmnavegador();
            frm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = dgvdespidos.Rows[e.RowIndex];

        }

        private void frmdespidos_Load(object sender, EventArgs e)
        {

            con.conectar();
            mostrarDatos();
        }

        private void txtactualizar_Click(object sender, EventArgs e)
        {
            mostrarDatos();
        }

        private void btbaceptar_Click(object sender, EventArgs e)
        {
            string actualizar = "estadodelempleado='" + cbestadodelempleado.Text + "',sueldo='" + txtsueldo.Text + "',comentario='" + clxcomentario.Text + "'";
            if (con.actualizar("empleados", actualizar, "codigo=" + txtcodigo.Text))
            {
                MessageBox.Show("Empleado despedido");
                mostrarDatos();

            }
            else
            {
                MessageBox.Show("Error al actualizar, codigo invalido");
            }
        }

        private void btbcancelar_Click(object sender, EventArgs e)
        {
            Frmmenuprincipal frm = new Frmmenuprincipal();

            frm.Show();

            {

                this.Hide();
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

        private void txtsueldo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
        


            
       
