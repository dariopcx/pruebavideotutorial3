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
    public partial class Frmmenuprincipal : Form
    {
        public Frmmenuprincipal()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmacercade frm = new frmacercade();
          
            frm.Show();
        }

        private void agregManualmenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmagregarempleado frm = new frmagregarempleado();
            this.Hide();
            frm.Show();
        }

        private void ayudaEnLineaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmayudaenlinea frm = new frmayudaenlinea();
            frm.Show();

        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcalculadora frm = new frmcalculadora();
            frm.Show();
        }

        private void calendarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcalendario frm = new frmcalendario();
            frm.Show();
        }

        private void navegadorWEBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnavegador frm = new frmnavegador();
            frm.Show();
        }

        private void Frmmenuprincipal_Load(object sender, EventArgs e)
        {
            conexion c = new conexion();
        }

        private void estadoDelEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmestadodelempleado frm = new frmestadodelempleado();
            frm.Show();
        }

        private void consultarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void listadoDelPersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmlistadodelpersonal frm = new frmlistadodelpersonal();
            frm.Show();
            this.Hide();
        }

        private void vacacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmvacaciones frm = new frmvacaciones();
            frm.Show();
            this.Close();
        }

        private void leerManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process a = new System.Diagnostics.Process();
            a.StartInfo.FileName = "C:\\factoriaproyecto\\Manual de usuario\\Manual_de_Usuario.docx";
            a.Start();
        }

        private void despidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdespidos frm = new frmdespidos();
            frm.Show();
            this.Hide();

        }

        private void licMedicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmlicenciamedica frm = new frmlicenciamedica();
            frm.Show();
            this.Hide();
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcambiodepuesto frm = new frmcambiodepuesto();
            frm.Show();
            this.Hide();
        }

        private void renunciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmrenuncia frm = new frmrenuncia();
            frm.Show();
            this.Hide();
        }

        private void imprimirEstadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La operacion se realizara en unos momentos, espere por favor.....");
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La operacion se realizara en unos momentos, espere por favor.....");
        }

        private void modificarYEliminarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmodificaryeliminar frm = new frmmodificaryeliminar();
            frm.Show();
            this.Hide();
        }

        private void reiniciarProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El programa se reiniciara");
            Frminicio frm = new Frminicio();
            frm.Show();
            this.Hide();
        }

        private void juvilacionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmjuvilaciones frm = new frmjuvilaciones();
            frm.Show();
            this.Hide();
        }
    }
}
