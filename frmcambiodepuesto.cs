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
    public partial class frmcambiodepuesto : Form
    {
        conexion con = new conexion();
        public frmcambiodepuesto()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btbcancelar_Click(object sender, EventArgs e)
        {
            Frmmenuprincipal frm = new Frmmenuprincipal();
            frm.Show();
            this.Hide();
        }

        private void btbtabla_Click(object sender, EventArgs e)
        {
            frmlistadodelpersonal frm = new frmlistadodelpersonal();
            frm.Show();
        }

        private void frmcambiodepuesto_Load(object sender, EventArgs e)
        {
            txtsueldo.Enabled = false;
            btbaceptar.Enabled = false;
            btbaceptar2.Enabled = false;
        }

        private void btbaceptar_Click(object sender, EventArgs e)
        {
            if (rbtsi.Checked)
            {

                string actualizar = "puesto='" + cbpuestodelempleado.Text + "',sueldo='" + txtsueldo.Text + "'";
                if (con.actualizar("empleados", actualizar, "codigo=" + txtcodigo.Text))
                {
                    MessageBox.Show("Cambio de puesto y aumento de sueldo actualizados correctamente");


                }
                else
                {
                    MessageBox.Show("Error al actualizar, codigo invalido");
                }
            }
        }


        private void rbtsi_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtsi.Checked)
            {
                txtsueldo.Enabled = true;
                btbaceptar.Enabled = true;
                btbaceptar2.Enabled = false;


            }
            if (rbtno.Checked)
            {
                txtsueldo.Enabled = false;

            }
        }

        private void btbaceptar2_Click(object sender, EventArgs e)
        {
            {
                
            }
            if (rbtno.Checked)
            {

                string actualizar = "puesto='" + cbpuestodelempleado.Text + "'";
                if (con.actualizar("empleados", actualizar, "codigo=" + txtcodigo.Text))
                {
                    MessageBox.Show("Cambio de puesto actualizado");


                }
                else
                {
                    MessageBox.Show("Error al actualizar, codigo invalido");
                }
            }
        }

        private void rbtno_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtno.Checked)
            {
                btbaceptar2.Enabled = true;
                btbaceptar.Enabled = false;
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

        private void txtsueldo_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
            