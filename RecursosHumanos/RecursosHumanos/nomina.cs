using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RecursosHumanos
{
    public partial class nomina : Form
    {
        SqlConnection con = new SqlConnection("Data Source = (localdb)\\JMASTER03; Initial Catalog=RecursosHumanos; Integrated Security=True");
        SqlDataAdapter adapt;
        SqlCommand cmd;
        int id = 0;


        public void nominaTabla()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from nomina", con);
            adapt.Fill(dt);
            dgvNomina.DataSource = dt;
            con.Close();

        }
        public nomina()
        {
            InitializeComponent();
            nominaTabla();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
        
            con.Open();
            cmd = new SqlCommand("set @total = (select SUM(salario) from empleados where estatus = 'A'); insert into nomina (mes, anio, total_Mnt) values (@mes, @anio, @total)", con);
            cmd.Parameters.AddWithValue("@mes", dtpMes.Value.Month);
            cmd.Parameters.AddWithValue("@anio", dtpAnio.Value.Year);
            cmd.Parameters.AddWithValue("@total", "@total");
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Calculo realizado satisfactoriamente!");
            nominaTabla();
        }
    }
}
