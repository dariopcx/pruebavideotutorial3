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
    public partial class frmlicenciamedica : Form
    {
        conexion con = new conexion();
        string activoresult = "";
        public frmlicenciamedica()
        {
            InitializeComponent();
        }


        private void btbaceptar_Click(object sender, EventArgs e)
        {


            if (rbtactivo.Checked)
            {
                activoresult = rbtactivo.Text;
            }
            if (rbtlicencia.Checked)
            {
                activoresult = rbtlicencia.Text;
            }

            string actualizar = "estadodelempleado='" + activoresult + "',diasdelicencia='" + txtdias.Text + "',comentario='" + txtcomentario.Text + "'";
            if (con.actualizar("empleados", actualizar, "codigo=" + txtcodigo.Text))
            {
                MessageBox.Show("Datos actualizados");


            }
            else
            {
                MessageBox.Show("Error al actualizar, codigo invalido");
            }
        }





        private void frmlicenciamedica_Load(object sender, EventArgs e)
        {
            con.conectar();
            btbaceptar.Enabled = false;
        }

        private void btbvolver_Click(object sender, EventArgs e)
        {
            Frmmenuprincipal frm = new Frmmenuprincipal();
            frm.Show();
            this.Hide();
        }

        private void lbllistado_Click(object sender, EventArgs e)
        {
            frmlistadodelpersonal frm = new frmlistadodelpersonal();
            frm.Show();
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
            if (txtcomentario.Text != String.Empty)
            {
                btbaceptar.Enabled = true;
            }
        }
    }
}




        