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
    public partial class frmagregarempleado : Form
    {
        conexion con = new conexion();
        string sexoresult = "", estadocivilresult = "";
        public frmagregarempleado()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btbcancelar_Click(object sender, EventArgs e)
        {
            Frmmenuprincipal frm = new Frmmenuprincipal();
            this.Hide();
            frm.ShowDialog();
        }

        private void lblcursotecnico_Click(object sender, EventArgs e)
        {

        }

        private void frmagregarempleado_Load(object sender, EventArgs e)
        {
            btbguardar.Enabled = false;
            con.conectar();
            mostrarDatos();
            this.Size = new Size(767, 401);



        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            if (txtsueldo.Text != String.Empty)
            {

                btbguardar.Enabled = true;

            }

        }

        private void btbguardar_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text == string.Empty)
            {
                MessageBox.Show("Por favor ingrese el nombre del empleado");
            }
            
            {
                if (nupedad.Text == string.Empty)
                {
                    MessageBox.Show("Por favor ingrese la edad del nuevo empleado");
                    txtcodigo.Focus();
                }
             
                {
                    if (txtapellidos.Text == string.Empty)
                    {
                        MessageBox.Show("Por favor ingrese los apellidods del empleado");
                    }
                    else
                        if (txtcedula.Text == string.Empty)
                        {
                            MessageBox.Show("Por favor ingrese la cedula del empleado");
                        }
                        else
                        {
                            if (txtdireccion.Text == string.Empty)
                            {
                                MessageBox.Show("Por favor ingrese la direccion del empleado");
                            }
                            else
                            {
                                if (txtcorreo.Text == string.Empty)
                                {
                                    MessageBox.Show("Por favor ingrese el correo del empleado");
                                }
                                else
                                {
                                    if (txttelefono.Text == string.Empty)
            {
                MessageBox.Show("Por favor ingrese el numero de telefono del empleado");
            }
                                    else
                                    {
                                        if (cbnivelacademico.Text == string.Empty)
                                        {
                                            MessageBox.Show("Por favor seleccione el nivel academico del empleado");
                                        }
                                        else
                                        {
                                            if (cbpuesto.Text == string.Empty)
                                            {
                                                MessageBox.Show("Por favor seleccione un puesto empleado");
                                            }
                                            else
                                            {
                                                if (txtfechadeingreso.Text == string.Empty)
                                                {
                                                    MessageBox.Show("Por favor ingrese la fecha de ingreso del empleado");
                                                }
                                                else
                                                {
                                                    if (txtfechafinalizcontrato.Text == string.Empty)
                                                    {
                                                        MessageBox.Show("Por favor ingrese la fecha final del contrato");
                                                    }
                                                    else 
                                                    {
                                                        if (txtnacionalidad.Text == string.Empty)
                                                        {
                                                            MessageBox.Show("Por favor ingrese la nacionalidad del empleado");
                                                        }
                                                        else 
                                                        {
                                                            if (txtsueldo.Text == string.Empty)
                                                            {
                                                                MessageBox.Show("Por favor ingrese el sueldo del empleado");
                                                            }

                                                            else
                                                            {
                                                                if (lbseguromedico.Text == string.Empty)
                                                                {
                                                                    MessageBox.Show("Seleccione un seguro medico de la lista");
                                                                }
                                                                else
                                                                {
                                                                    if (cbestadodelempleado.Text == string.Empty)
                                                                    {
                                                                        MessageBox.Show("Seleccione el estado del empleado actualmente");
                                                                        cbestadodelempleado.Focus();

                                                                    }
                                                                  
                                                                    {
                                                                        if (txtcodigo.Text == string.Empty)
                                                                        {
                                                                            MessageBox.Show("Ingrese el codigo para el nuevo empleado");
                                                                            txtcomentario.Focus();
                                                                        }
                                                                        else
                                                                        {
                                                                            if (txtcomentario.Text == string.Empty)
                                                                            {
                                                                                MessageBox.Show("Ingrese un comentario acerca del empleado, es necesario!!");
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                    if (rbcasado.Checked)
                    {
                        estadocivilresult = rbcasado.Text;
                    }
                    if (rbsoltero.Checked)
                    {
                        estadocivilresult = rbsoltero.Text;
                    }
                    if (rbmasculino.Checked)
                    {
                        sexoresult = rbmasculino.Text;
                    }
                    if (rbfemenino.Checked)
                    {
                        sexoresult = rbfemenino.Text;
                    }

                    string agregar = "Insert into empleados values(" + txtcodigo.Text + ",'" + txtnombre.Text + "','" + txtapellidos.Text + "','" + txtdireccion.Text + "','" + txtcorreo.Text + "','" + sexoresult + "','" + nupedad.Text + "','" + estadocivilresult + "','" + cbnivelacademico.Text + "','" + txtcedula.Text + "','" + txttelefono.Text + "','" + txtnacionalidad.Text + "','" + cbpuesto.Text + "','" + txtfechadeingreso.Text + "','" + txtfechafinalizcontrato.Text + "','" + lbseguromedico.Text + "','" + txtsueldo.Text + "','" + cbestadodelempleado.Text + "','" + txtcomentario.Text + "','" + "" + "','" + "" + "','" + "" + "')";

                    if (con.insertar(agregar))
                    {
                        MessageBox.Show("Datos agregados");
                        mostrarDatos();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar");
                    }



                }
            }
        }
        public void mostrarDatos()
        {
            con.consulta("Select * from empleados", "empleados");
            dgvprueba.DataSource = con.ds.Tables["empleados"];
        }

        private void btbeliminar_Click(object sender, EventArgs e)
        {
            if (con.eliminar("empleados", "codigo = " + txtcodigo.Text))
            {
                MessageBox.Show("Datos eliminados");
                mostrarDatos();



            }
            else
            {
                MessageBox.Show("Error al eliminar");
            }
        }

        private void dgvprueba_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow dgv = dgvprueba.Rows[e.RowIndex];
            txtcodigo.Text = dgv.Cells[0].Value.ToString();
            txtnombre.Text = dgv.Cells[1].Value.ToString();
            txtapellidos.Text = dgv.Cells[2].Value.ToString();
            txtdireccion.Text = dgv.Cells[3].Value.ToString();
            txtcorreo.Text = dgv.Cells[4].Value.ToString();
            sexoresult = dgv.Cells[5].Value.ToString();
            nupedad.Text = dgv.Cells[6].Value.ToString();
            estadocivilresult = dgv.Cells[7].Value.ToString();
            cbnivelacademico.Text = dgv.Cells[8].Value.ToString();
            txtcedula.Text = dgv.Cells[9].Value.ToString();
            txttelefono.Text = dgv.Cells[10].Value.ToString();
            txtnacionalidad.Text = dgv.Cells[11].Value.ToString();
            cbpuesto.Text = dgv.Cells[12].Value.ToString();
            txtfechadeingreso.Text = dgv.Cells[13].Value.ToString();
            txtfechafinalizcontrato.Text = dgv.Cells[14].Value.ToString();
            lbseguromedico.Text = dgv.Cells[15].Value.ToString();
            txtsueldo.Text = dgv.Cells[16].Value.ToString();
            cbestadodelempleado.Text = dgv.Cells[17].Value.ToString();
            txtcomentario.Text = dgv.Cells[18].Value.ToString();




        }

        private void btbactualizar_Click(object sender, EventArgs e)
        {

        }

        private void gbsexo_Enter(object sender, EventArgs e)
        {

        }

        private void btbmostrar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(767, 601);
        }

        private void btbocultar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(767, 401);
        }

        private void cbestadodelempleado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbpuesto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btblimpiar_Click(object sender, EventArgs e)
        {
            txtapellidos.Clear();
            txtnombre.Clear();
            txtcedula.Clear();
            txtdireccion.Clear();
            txtcorreo.Clear();
            txttelefono.Clear();
            cbnivelacademico.ResetText();
            cbestadodelempleado.ResetText();
            cbpuesto.ResetText();
            txtcomentario.Clear();
            txtfechadeingreso.Clear();
            txtfechafinalizcontrato.Clear();
            txtnacionalidad.Clear();
            lbseguromedico.ResetText();
            txtsueldo.Clear();
            txtcodigo.Clear();
            nupedad.ResetText();

        }

        private void txtcedula_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
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

                                       