using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Programaderecursoshumanos
{
    class conexion
    {

        SqlConnection con = new SqlConnection("Data Source=PCXONE;Initial Catalog=datosempleadosbd;Integrated Security=True");
        private SqlCommandBuilder cmb;
        public DataSet ds = new DataSet();
        public SqlDataAdapter da;
        public SqlCommand comando;
        public void conectar()
        {
            try
            {
                con.Open();
                MessageBox.Show("Conectado");
            }
            catch
            {
                MessageBox.Show("Error al conectar");
            }
            finally
            {
                con.Close();
            }
        }
        public void consulta(string sql, string tabla)

        
        {
            ds.Tables.Clear();
            da = new SqlDataAdapter(sql, con);
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, tabla);

        }
        public bool insertar(string sql)
        {
            con.Open();
            comando = new SqlCommand(sql, con);
            int i = comando.ExecuteNonQuery();
            con.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool eliminar(string tabla, string condicion)
        {
            con.Open();
            string elimina = " delete from " + tabla + " where " + condicion;
            comando = new SqlCommand(elimina, con);
            int i = comando.ExecuteNonQuery();
            con.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool actualizar(string tabla, string campos, string condicion)
        {
            con.Open();
            string actualizar = " update " + tabla + " set " + campos + " where " + condicion;
            comando = new SqlCommand(actualizar, con);
            int i = comando.ExecuteNonQuery();
            con.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
            
            
    















