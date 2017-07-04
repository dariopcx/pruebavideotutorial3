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
    public partial class frmlistadodelpersonal : Form
    {
        conexion con = new conexion();
        
        public frmlistadodelpersonal()
        {
           
           
            InitializeComponent();
            
        }

        private void btbcerrar_Click(object sender, EventArgs e)
        {
            Frmmenuprincipal frm = new Frmmenuprincipal();
            frm.Show();
            this.Close();
        }

        private void dgvlistadodelpersonal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
            

        }

        private void frmlistadodelpersonal_Load(object sender, EventArgs e)
        {
           

            con.conectar();
            mostrarDatos();
        }

        private void dgvlistado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = dgvlistado.Rows[e.RowIndex];


        }
        public void mostrarDatos()
        {
            con.consulta("Select * from empleados", "empleados");
            dgvlistado.DataSource = con.ds.Tables["empleados"];
        }

        private void btbrefrescar_Click(object sender, EventArgs e)
        {
           
            mostrarDatos();
        }
    }
}
