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
    public partial class frmcalculadora : Form
    {
        public frmcalculadora()
        {
            InitializeComponent();
        }

        private void btbcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btblimpiar_Click(object sender, EventArgs e)
        {
            txtvalor1.Clear();
            txtvalor2.Clear();
            txtor.Clear();
            txtresultado.Clear();
            txtvalor1.Select();
        }

        private void frmcalculadora_Load(object sender, EventArgs e)
        {

        }

        private void btbsuma_Click(object sender, EventArgs e)
        {
            {

            }
            if (txtvalor1.Text == String.Empty)
            {
                MessageBox.Show("Valor 1 requerdo");
                txtvalor1.Select();
            }
            if (txtvalor2.Text == String.Empty)
            {
                MessageBox.Show("Valor 2 requerdio");
                txtvalor2.Select();

            }
            else
            {
                string suma = "SUMA";
                double v1, v2, res;
                txtor.Text = suma.ToString();
                v1 = Convert.ToDouble(txtvalor1.Text);
                v2 = Convert.ToDouble(txtvalor2.Text);
                res = v1 + v2;
                txtresultado.Text = res.ToString();
            }
        }

        private void btbresta_Click(object sender, EventArgs e)
        {
            {

            }
            if (txtvalor1.Text == String.Empty)
            {
                MessageBox.Show("Valor 1 requerdo");
                txtvalor1.Select();
            }
            if (txtvalor2.Text == String.Empty)
            {
                MessageBox.Show("Valor 2 requerdio");
                txtvalor2.Select();

            }
            else
            {
                string resta = "RESTA";
                double v1, v2, res;
                txtor.Text = resta.ToString();
                v1 = Convert.ToDouble(txtvalor1.Text);
                v2 = Convert.ToDouble(txtvalor2.Text);
                res = v1 - v2;
                txtresultado.Text = res.ToString();
            }
        }

        private void btbmultiplicacion_Click(object sender, EventArgs e)
        {
            {

            }
            if (txtvalor1.Text == String.Empty)
            {
                MessageBox.Show("Valor 1 requerdo");
                txtvalor1.Select();
            }
            if (txtvalor2.Text == String.Empty)
            {
                MessageBox.Show("Valor 2 requerdio");
                txtvalor2.Select();

            }
            else
            {
                string multiplicacion = "MULTIPLICACION";
                double v1, v2, res;
                txtor.Text = multiplicacion.ToString();
                v1 = Convert.ToDouble(txtvalor1.Text);
                v2 = Convert.ToDouble(txtvalor2.Text);
                res = v1 * v2;
                txtresultado.Text = res.ToString();
            }
        }

        private void btbdivision_Click(object sender, EventArgs e)
        {
            {

            }
            if (txtvalor1.Text == String.Empty)
            {
                MessageBox.Show("Valor 1 requerdo");
                txtvalor1.Select();
            }
            if (txtvalor2.Text == String.Empty)
            {
                MessageBox.Show("Valor 2 requerdio");
                txtvalor2.Select();

            }
            else
            {
                string division = "DIVISION";
                double v1, v2, res;
                txtor.Text = division.ToString();
                v1 = Convert.ToDouble(txtvalor1.Text);
                v2 = Convert.ToDouble(txtvalor2.Text);
                res = v1 / v2;
                txtresultado.Text = res.ToString();
            }
        }

        private void txtvalor1_KeyPress(object sender, KeyPressEventArgs e)
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
        
               
        