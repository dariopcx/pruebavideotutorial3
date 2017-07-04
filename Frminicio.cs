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
    public partial class Frminicio : Form
    {
        public Frminicio()
        {
            InitializeComponent();

        }

        int i = 0;




        private void Form1_Load(object sender, EventArgs e)
        {

            timer1.Start();


            {
                this.Size = new Size(this.Size.Width, 350);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i = 1 + i;
            
            progressBar1.Value = 100;
            if (i == 100)
            {
                timer1.Stop();
                Frmloa frm = new Frmloa();
                this.Hide();
                frm.ShowDialog();


            }
        }
    }
}
 

   

