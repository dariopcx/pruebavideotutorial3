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
    public partial class frmestadodelempleado : Form
    {

        conexion con = new conexion();

        public frmestadodelempleado()
        {
            InitializeComponent();
        }

        private void btbcancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void mostrarDatos()
        {
            con.consulta("Select * from empleados", "empleados");
            dgvestadoempleado.DataSource = con.ds.Tables["empleados"];
        }


        private void frmestadodelempleado_Load(object sender, EventArgs e)
        {
            con.conectar();
            mostrarDatos();
            this.Size = new Size(710, 179);
            btbcambiar.Enabled = false;

        }

        private void btbcambiar_Click(object sender, EventArgs e)
        {

            string actualizar = "estadodelempleado='" + cbestadodelempleado.Text + "',comentario='" + txtcomentario.Text + "'";
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Size = new Size(724, 351);

        }

        private void dgvestadoempleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = dgvestadoempleado.Rows[e.RowIndex];
        }

        private void txtcomentario_TextChanged(object sender, EventArgs e)
        {
            if (txtcomentario.Text != String.Empty)
            {
                btbcambiar.Enabled = true;
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
         


    
        
        
    



    
    



