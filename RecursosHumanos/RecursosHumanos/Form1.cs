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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source = (localdb)\\JMASTER03; Initial Catalog=RecursosHumanos; Integrated Security=True");
        SqlDataAdapter adapt;
        SqlCommand cmd;


        public Form1()
        {
            InitializeComponent();
        }

        private void AbrirFormHija(object formHija)
        {
            if (this.panelContainer.Controls.Count > 0)
                this.panelContainer.Controls.RemoveAt(0);
            Form fh = formHija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(fh);
            this.panelContainer.Tag = fh;
            fh.Show();
        }

        private void DepartamentosF_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Departamentos());
        }

        private void CargosF_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new cargos());
        }

        private void EmpleadosF_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new empleados());
        }

        private void btnNomina_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new nomina());
        }

       
        private void btnEmpleadosActivosR_Click(object sender, EventArgs e)
        {
            empladosAR reporteEmpA = new empladosAR();
            reporteEmpA.Show();

            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("exec empleadosActivos", con);
            adapt.Fill(dt);
            CrystalReport1 cr1 = new CrystalReport1();
            cr1.SetDataSource(dt);
            reporteEmpA.empleadosA.ReportSource = cr1;
            reporteEmpA.empleadosA.Refresh();
            con.Close();


        }

        private void empleadosInactivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            empleadosIR reportI = new empleadosIR();
            reportI.Show();
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("exec empleadosInactivos", con);
            adapt.Fill(dt);
            empleadosI cr1 = new empleadosI();
            cr1.SetDataSource(dt);
            reportI.empleadosIcrt.ReportSource =(cr1);
            reportI.empleadosIcrt.Refresh();
            con.Close();
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            departamentosR depart = new departamentosR();
            depart.Show();

            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("exec departamentosE", con);
            adapt.Fill(dt);
            departamentosrpt cr1 = new departamentosrpt();
            cr1.SetDataSource(dt);
            depart.departamentoscrt.ReportSource = (cr1);
            depart.departamentoscrt.Refresh();
            con.Close();

        }

        private void cargosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cargosR cargos = new cargosR();
            cargos.Show();

            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("exec CargosE", con);
            adapt.Fill(dt);
            Cargosrpt cr1 = new Cargosrpt();
            cr1.SetDataSource(dt);
            cargos.cargosrc.ReportSource = (cr1);
            cargos.cargosrc.Refresh();
            con.Close();
        }

        private void nominasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nominasR nomin = new nominasR();
            nomin.Show();

            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("exec nominas", con);
            adapt.Fill(dt);
            nominasrpt cr1 = new nominasrpt();
            cr1.SetDataSource(dt);
            nomin.nominacr.ReportSource = (cr1);
            nomin.nominacr.Refresh();
            con.Close();
        }

        private void permisosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            permisos permi = new permisos();
            permi.Show();


            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("exec MostrarPermisos", con);
            adapt.Fill(dt);
            permisosrpt cr1 = new permisosrpt();
            cr1.SetDataSource(dt);
            permi.permisosrc.ReportSource = (cr1);
            permi.permisosrc.Refresh();
            con.Close();

        }
    }
}
