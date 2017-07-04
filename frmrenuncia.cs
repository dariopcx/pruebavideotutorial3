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
    public partial class frmrenuncia : Form
    {
        conexion con = new conexion();
        string sueldoresult = "0000";
        public frmrenuncia()
        {
            InitializeComponent();
        }

        public void mostrarDatos()
        {
            con.consulta("Select * from empleados", "empleados");
            dgvrenuncia.DataSource = con.ds.Tables["empleados"];
        }

        private void frmrenuncia_Load(object sender, EventArgs e)
        {
            con.conectar();
            mostrarDatos();
            
        }

        private void btbaceptar_Click(object sender, EventArgs e)
        {
          
              
            string actualizar = "estadodelempleado='" + cbestadodelempleado.Text + "',sueldo='" + sueldoresult + "',comentario='" + clxmotivo.Text + "'";
            if (con.actualizar("empleados", actualizar, "codigo=" + txtcodigo.Text))
            {
                MessageBox.Show("Datos guardados");
                mostrarDatos();

            }
            else
            {
                MessageBox.Show("Error al actualizar, codigo invalido");
            }
        }

        private void dgvrenuncia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = dgvrenuncia.Rows[e.RowIndex];
        }

        private void btbcancelar_Click(object sender, EventArgs e)
        {
            Frmmenuprincipal frm = new Frmmenuprincipal();
            frm.Show();
            this.Hide();
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

           

 
 
                    
        