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


    public partial class frmmodificaryeliminar : Form
    {
        conexion con = new conexion();
        string sexoresult = "", estadocivilresult = "", juvilacionresult = "";
        public frmmodificaryeliminar()
        {
            InitializeComponent();
        }
        public void mostrarDatos()
        {
            con.consulta("Select * from empleados", "empleados");
            dgvprueba.DataSource = con.ds.Tables["empleados"];
        }
        private void frmmodificaryeliminar_Load(object sender, EventArgs e)
        {
            btbagregar.Enabled = false;
            btbmodificar.Enabled = false;
            btbeliminar.Enabled = false;
            con.conectar();
            mostrarDatos();
        }

        private void rbagregar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbagregar.Checked)
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
                txtdias.Clear();
                txtfechadeingreso.Clear();
                txtfechafinalizcontrato.Clear();
                txtlicencia.Clear();
                txtnacionalidad.Clear();
                lbseguromedico.ResetText();
                txtsueldo.Clear();
                txtcodigo.Clear();
                nupedad.ResetText();
                btbagregar.Enabled = true;
                btbmodificar.Enabled = false;
                btbeliminar.Enabled = false;
                txtapellidos.Enabled = true;
                txtnombre.Enabled = true;
                txtcedula.Enabled = true;
                txtdireccion.Enabled = true;
                txtcorreo.Enabled = true;
                txttelefono.Enabled = true;
                cbnivelacademico.Enabled = true;
                cbestadodelempleado.Enabled = true;
                cbpuesto.Enabled = true;
                txtcomentario.Enabled = true;
                txtdias.Enabled = false;
                txtfechadeingreso.Enabled = true;
                txtfechafinalizcontrato.Enabled = true;
                txtlicencia.Enabled = false;
                txtnacionalidad.Enabled = true;
                nupedad.Enabled = true;
                rbcasado.Enabled = true;
                rbfemenino.Enabled = true;
                rbsoltero.Enabled = true;
                rbmasculino.Enabled = true;
                rbsi.Enabled = false;
                rbno.Enabled = false;
                lbseguromedico.Enabled = true;
                txtsueldo.Enabled = true;

            }
        }

        private void rbmodificar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbmodificar.Checked)
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
                txtdias.Clear();
                txtfechadeingreso.Clear();
                txtfechafinalizcontrato.Clear();
                txtlicencia.Clear();
                txtnacionalidad.Clear();
                lbseguromedico.ResetText();
                txtsueldo.Clear();
                txtcodigo.Clear();
                nupedad.ResetText();
                btbagregar.Enabled = false;
                btbmodificar.Enabled = true;
                btbeliminar.Enabled = false;
                txtapellidos.Enabled = true;
                txtnombre.Enabled = true;
                txtcedula.Enabled = true;
                txtdireccion.Enabled = true;
                txtcorreo.Enabled = true;
                txttelefono.Enabled = true;
                cbnivelacademico.Enabled = true;
                cbestadodelempleado.Enabled = true;
                cbpuesto.Enabled = true;
                txtcomentario.Enabled = true;
                txtdias.Enabled = true;
                txtfechadeingreso.Enabled = true;
                txtfechafinalizcontrato.Enabled = true;
                txtlicencia.Enabled = true;
                txtnacionalidad.Enabled = true;
                nupedad.Enabled = true;
                rbcasado.Enabled = true;
                rbfemenino.Enabled = true;
                rbsoltero.Enabled = true;
                rbmasculino.Enabled = true;
                rbsi.Enabled = true;
                rbno.Enabled = true;
                lbseguromedico.Enabled = true;
                txtsueldo.Enabled = true;
            }
        }

        private void rbeliminar_CheckedChanged(object sender, EventArgs e)
        {


            if (rbeliminar.Checked)
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
                txtdias.Clear();
                txtfechadeingreso.Clear();
                txtfechafinalizcontrato.Clear();
                txtlicencia.Clear();
                txtnacionalidad.Clear();
                lbseguromedico.ResetText();
                txtsueldo.Clear();
                txtcodigo.Clear();
                nupedad.ResetText();

                btbagregar.Enabled = false;
                btbmodificar.Enabled = false;
                btbeliminar.Enabled = true;
                txtapellidos.Enabled = false;
                txtnombre.Enabled = false;
                txtcedula.Enabled = false;
                txtdireccion.Enabled = false;
                txtcorreo.Enabled = false;
                txttelefono.Enabled = false;
                cbnivelacademico.Enabled = false;
                cbestadodelempleado.Enabled = false;
                cbpuesto.Enabled = false;
                txtcomentario.Enabled = false;
                txtdias.Enabled = false;
                txtfechadeingreso.Enabled = false;
                txtfechafinalizcontrato.Enabled = false;
                txtlicencia.Enabled = false;
                txtnacionalidad.Enabled = false;
                nupedad.Enabled = false;
                rbcasado.Enabled = false;
                rbfemenino.Enabled = false;
                rbsoltero.Enabled = false;
                rbmasculino.Enabled = false;
                rbsi.Enabled = false;
                rbno.Enabled = false;
                lbseguromedico.Enabled = false;
                txtsueldo.Enabled = false;

            }
        }

        private void rbcasado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lbljuvilar_Click(object sender, EventArgs e)
        {

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

        private void btbagregar_Click(object sender, EventArgs e)
        {
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
            txtdias.Clear();
            txtfechadeingreso.Clear();
            txtfechafinalizcontrato.Clear();
            txtlicencia.Clear();
            txtnacionalidad.Clear();
            lbseguromedico.ResetText();
            txtsueldo.Clear();
            txtcodigo.Clear();
            nupedad.ResetText();


        }

        private void btbmostrartabla_Click(object sender, EventArgs e)
        {

        }

        private void btbnavegador_Click(object sender, EventArgs e)
        {
            frmnavegador frm = new frmnavegador();
            frm.Show();

        }

        private void btbcalculadora_Click(object sender, EventArgs e)
        {
            frmcalculadora frm = new frmcalculadora();
            frm.Show();
        }

        private void btbcalendario_Click(object sender, EventArgs e)
        {
            frmcalendario frm = new frmcalendario();
            frm.Show();
        }

        private void btbcancelar_Click(object sender, EventArgs e)
        {
            Frmmenuprincipal frm = new Frmmenuprincipal();
            frm.Show();
            this.Hide();
        }

        private void btbmodificar_Click(object sender, EventArgs e)
        {
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
            if (rbsi.Checked)
            {
                juvilacionresult = rbsi.Text;
            }
            if (rbno.Checked)
            {
                juvilacionresult = "";
            }

            string actualizar = "nombre='" + txtnombre.Text + "',apellidos='" + txtapellidos.Text + "',correo='" + txtcorreo.Text + "',cedula='" + txtcedula.Text + "',estadocivil='" + estadocivilresult + "',sexo='" + sexoresult + "',edad='" + nupedad.Text + "',telefono='" + txttelefono.Text + "',nivelacademico='" + cbnivelacademico.Text + "',nacionalidad='" + txtnacionalidad.Text + "',puesto='" + cbpuesto.Text + "',fechadeingreso='" + txtfechadeingreso.Text + "',fechadetermino='" + txtfechafinalizcontrato.Text + "',seguromedico='" + lbseguromedico.Text + "',sueldo='" + txtsueldo.Text + "',estadodelempleado='" + cbestadodelempleado.Text + "',comentario='" + txtcomentario.Text + "',diasdevacaciones='" + txtdias.Text + "',juvilacion='" + juvilacionresult + "',diasdelicencia='" + txtlicencia.Text + "'";
            if (con.actualizar("empleados", actualizar, "codigo=" + txtcodigo.Text))
            {
                MessageBox.Show("Datos actualizados correctamente");
                mostrarDatos();


            }
            else
            {
                MessageBox.Show("Error al actualizar, codigo invalido");
            }
        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
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

                                                