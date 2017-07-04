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
    public partial class frmjuvilaciones : Form
    {
        conexion con = new conexion();
        string estadoresult = "", juvilado = "";

        public frmjuvilaciones()
        {
            InitializeComponent();
        }
        private void frmjuvilaciones_Load(object sender, EventArgs e)
        {
            con.conectar();
            btbaceptar.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblcancelar_Click(object sender, EventArgs e)
        {
            Frmmenuprincipal frm = new Frmmenuprincipal();
            frm.Show();
            this.Hide();
        }

        private void btbmostrartabla_Click(object sender, EventArgs e)
        {
            frmlistadodelpersonal frm = new frmlistadodelpersonal();
            frm.Show();
        }

        private void lblcalendario_Click(object sender, EventArgs e)
        {
            frmcalendario frm = new frmcalendario();
            frm.Show();
        }

        private void btbnavegador_Click(object sender, EventArgs e)
        {
            frmnavegador frm = new frmnavegador();
            frm.Show();
        }

        private void btbcalculadora_Click(object sender, EventArgs e)
        {
            frmcalculadora frm = new frmcalculadora();
            frm.Show();
        }

        private void btbaceptar_Click(object sender, EventArgs e)
        {
            if (rbactivo.Checked)
            {
                estadoresult = rbactivo.Text;
                juvilado = "";
            }
            if (rbjuvilado.Checked)
            {
                estadoresult = rbjuvilado.Text;
                juvilado = "Si";
            }
            string actualizar = "estadodelempleado='" + estadoresult + "',sueldo='" + txtsueldo.Text + "',comentario='" + txtcomentario + "',juvilacion='" + juvilado + "'";
            if (con.actualizar("empleados", actualizar, "codigo=" + txtcodigo.Text))
            {
                MessageBox.Show("Datos actualizados");

            }
            else
            {
                MessageBox.Show("Error al actualizar, codigo invalido");
            }
        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {

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

        private void txtcomentario_TextChanged(object sender, EventArgs e)
        {
            if(txtcomentario.Text != String.Empty)
            {
                btbaceptar.Enabled = true;
            }
        }
    }
}
        