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
    public partial class frmnavegador : Form
    {
        public frmnavegador()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btbir_Click(object sender, EventArgs e)
        {
            webgoogle.Navigate(txturl.Text);
        }

        private void toolssalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolsbtbregresar_Click(object sender, EventArgs e)
        {
            webgoogle.GoBack();
        }

        private void toolsbtbvolver_Click(object sender, EventArgs e)
        {
            webgoogle.GoForward();
        }

        private void toolsbtbstop_Click(object sender, EventArgs e)
        {
            webgoogle.Stop();
        }

        private void toolsrecargar_Click(object sender, EventArgs e)
        {
            webgoogle.Refresh();
        }

        private void toolsmenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmnavegador_Load(object sender, EventArgs e)
        {
            txturl.Text = "https://www.google.com";
            webgoogle.Navigate("https://google.com");
        }
    }
}
