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
    public partial class frmayudaenlinea : Form
    {
        public frmayudaenlinea()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btbir_Click(object sender, EventArgs e)
        {
            frmnavegador frm = new frmnavegador();

            this.Hide();

            frm.Show();
        }

        private void btbregresar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
           
            
            