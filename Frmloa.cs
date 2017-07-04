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
    public partial class Frmloa : Form
    {
        public Frmloa()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frmlogin frm = new Frmlogin();
            this.Hide();
            frm.ShowDialog();

        }

        private void btbregistrar_Click(object sender, EventArgs e)
        {
            Frmregistrar frm = new Frmregistrar();
            this.Hide();
            frm.ShowDialog();

        }

        private void btbcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
