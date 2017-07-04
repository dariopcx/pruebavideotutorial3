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
    public partial class Frmregistrar : Form
    {
        public Frmregistrar()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void btbcancelar_Click(object sender, EventArgs e)
        
        {
            Frmloa frm = new Frmloa();
            frm.Show();
            this.Hide();


        }

        private void btbconfirmar_Click(object sender, EventArgs e)
        {
            if (txtnuevousuario.Text == String.Empty)
            {
                MessageBox.Show("Digite un nombre para crear el usuario");
                txtnombredeusuario.Select();
            }
            if (txtnuevacontraseña.Text == String.Empty)
            {
                MessageBox.Show("Digite la contraseña");
                txtnuevacontraseña.Select();
            }
            else 
            { 
            if (txtnuevacontraseñaconfirmar.Text == String.Empty)
            {
                MessageBox.Show("Digite la contraseña para confirmar");
                    txtnuevacontraseñaconfirmar.Select();
            }
            }
        }
    }
    }
                
            