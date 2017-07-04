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
    public partial class frmacercade : Form
    {
        public frmacercade()
        {
            InitializeComponent();
        }

        private void frmacercade_Load(object sender, EventArgs e)
        {
            this.Size = new Size(454,121);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Size = new Size(454, 263);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Size = new Size(454, 121);
        }
    }
}
