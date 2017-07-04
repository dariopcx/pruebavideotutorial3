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
    public partial class Frmlogin : Form
    {
        public Frmlogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            txtnombredeusuario.Select();

        }

        private void btbacceder_Click(object sender, EventArgs e)
        {
            string nombredeusario1 = "pedro";

            if (txtnombredeusuario.Text == string.Empty)
            {
                MessageBox.Show("El Nombre de usuario no debe estar en blanco,digite un nombre");
                txtnombredeusuario.Focus();
                txtnombredeusuario.Select();
            }
            if (txtcontraseña.Text == String.Empty)
            {
                MessageBox.Show("Contraseña no puede estar en blanco, digite una");
                txtcontraseña.Focus();
            }
            else
            {
                if (txtnombredeusuario.Text != "pedro")
                {
                    MessageBox.Show("Nombre de usuario incorrecto, digite uno valido");
                    txtnombredeusuario.Clear();
                    txtnombredeusuario.Select();
                }
                else
                {

                 
                    if (txtcontraseña.Text != "12345")
                    {
                        MessageBox.Show("Contraseña incorrecta");
                        txtcontraseña.Clear();
                        txtcontraseña.Select();
                    }


                    else
                    {
                        if (txtnombredeusuario.Text == nombredeusario1)
                        {
                            MessageBox.Show("Usuario corecto");
                            Frmmenuprincipal frm = new Frmmenuprincipal();
                            frm.Show();
                            this.Hide();
                        }
                    }
                }
            }
        }
  

             

           
        

        private void btbcancelar_Click(object sender, EventArgs e)
           

        {
            Frmloa frm = new Frmloa();
            frm.Show();
            this.Hide();
  

        }
    }
}