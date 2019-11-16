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
    public partial class empleados : Form
    {

        SqlConnection con = new SqlConnection("Data Source = (localdb)\\JMASTER03; Initial Catalog=RecursosHumanos; Integrated Security=True");
        SqlDataAdapter adapt;
        SqlCommand cmd;
        int id = 0;




        public void empleadosActivos()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("exec empleadosActivos", con);
            adapt.Fill(dt);
            dgvEmpleados.DataSource = dt;
            con.Close();
        }

        public void limpiar()
        {
            txtCodigoE.Text = "";
            txtNombreE.Text = "";
            txtApellidoE.Text = "";
            txtTelefonoE.Text = "";
            txtDepartamentoE.Text = "";
            txtCargoE.Text = "";
            dtpIngreso.Text = "";
            txtSalarioE.Text = "";
            txtEstatusE.Text = "";
            txtEmpleadoD.Text = "";
            txtMotivoSalida.Text = "";
            txtTipoSalida.Text = "";


        }

        public empleados()
        {
            InitializeComponent();
            empleadosActivos();

        }


           public void btnAgregarE_Click(object sender, EventArgs e)
           {
           
            if (txtCodigoE.Text != "" && txtNombreE.Text != "" && txtApellidoE.Text != "" && txtTelefonoE.Text != "" && txtDepartamentoE.Text != "" && txtCodigoE.Text != "" && txtSalarioE.Text != "" && txtEstatusE.Text != "" && dtpIngreso.Text != "")
            {
                con.Open();
                cmd = new SqlCommand("EXECUTE nuevoEmpleado @code_empleado, @nombre, @apellido, @telefono, @departamento, @cargo, @fecha_ingreso, @salario, @estatus", con);
                cmd.Parameters.AddWithValue("@code_empleado", txtCodigoE.Text);
                cmd.Parameters.AddWithValue("@nombre", txtNombreE.Text);
                cmd.Parameters.AddWithValue("@apellido", txtApellidoE.Text);
                cmd.Parameters.AddWithValue("@telefono", txtTelefonoE.Text);
                cmd.Parameters.AddWithValue("@departamento", Int32.Parse(txtDepartamentoE.Text));
                cmd.Parameters.AddWithValue("@cargo", Int32.Parse(txtCargoE.Text));
                cmd.Parameters.AddWithValue("@fecha_ingreso", dtpIngreso.Value.Date);
                cmd.Parameters.AddWithValue("@salario", Int32.Parse(txtSalarioE.Text));
                cmd.Parameters.AddWithValue("@estatus", txtEstatusE.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Empleado agregado satisfactoriamente!");
                limpiar();
            }
            else
            {
                MessageBox.Show("Error al agregar empleado");

            }
            empleadosActivos();
        }

        private void btnBuscarE_Click(object sender, EventArgs e)
        {
            con.Open();

            cmd = new SqlCommand("EXECUTE buscarEmpleado @codigo", con);
            cmd.Parameters.AddWithValue("@codigo", txtCodigoE.Text);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvEmpleados.DataSource = dt;
            con.Close();

        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            id = Convert.ToInt32(dgvEmpleados.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtCodigoE.Text = dgvEmpleados.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtNombreE.Text = dgvEmpleados.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtApellidoE.Text = dgvEmpleados.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtTelefonoE.Text = dgvEmpleados.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtDepartamentoE.Text = dgvEmpleados.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtCargoE.Text = dgvEmpleados.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtSalarioE.Text = dgvEmpleados.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtEstatusE.Text = dgvEmpleados.Rows[e.RowIndex].Cells[8].Value.ToString();
            dtpIngreso.Text = dgvEmpleados.Rows[e.RowIndex].Cells[9].Value.ToString();


            txtEmpleadoD.Text = dgvEmpleados.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btnActualizarE_Click(object sender, EventArgs e)
        {
            if (txtNombreE.Text != "" && txtApellidoE.Text != "" && txtTelefonoE.Text != "" && txtDepartamentoE.Text !="" && txtCargoE.Text!="" && txtSalarioE.Text!="")
            {
                con.Open();
                cmd = new SqlCommand("EXECUTE actualizarEmpleado @user, @nombre, @apellido, @telefono, @departamento, @cargo, @salario", con);
                cmd.Parameters.AddWithValue("@user", id);
                cmd.Parameters.AddWithValue("@nombre", txtNombreE.Text);
                cmd.Parameters.AddWithValue("@apellido", txtApellidoE.Text);
                cmd.Parameters.AddWithValue("@telefono", txtTelefonoE.Text);
                cmd.Parameters.AddWithValue("@departamento", Int32.Parse(txtDepartamentoE.Text));
                cmd.Parameters.AddWithValue("@cargo", Int32.Parse(txtCargoE.Text));
                cmd.Parameters.AddWithValue("@salario", Int32.Parse(txtSalarioE.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Datos actualizados correctamente");
                con.Close();
                limpiar();
            }
            else
            {
                MessageBox.Show("Error al actualizar");
            }
            empleadosActivos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("exec departamentosE", con);
            adapt.Fill(dt);
            dgvEmpleados.DataSource = dt;
            con.Close();
        }

        private void btnDespedir_Click(object sender, EventArgs e)
        {
            if(txtEmpleadoD.Text !="" && txtTipoSalida.Text !="" && txtMotivoSalida.Text != "")
            {
                if(MessageBox.Show("¿Estas seguro de despedir al empleado?", "Despido", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) { 
                con.Open();
                cmd = new SqlCommand("EXECUTE despedida @empleado, @tpsalida, @motivo, @fecha_Salida", con);
                cmd.Parameters.AddWithValue("@empleado", Int32.Parse(txtEmpleadoD.Text));
                cmd.Parameters.AddWithValue("@tpsalida", txtTipoSalida.Text);
                cmd.Parameters.AddWithValue("@motivo", txtMotivoSalida.Text);
                cmd.Parameters.AddWithValue("@fecha_salida", dtpSalida.Value.Date);
                cmd.ExecuteNonQuery();
                con.Close();
                }
                empleadosActivos();
            }
            else
            {
                MessageBox.Show("Error al despedir");
            }
            
        }

        private void btnDespedidos_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("exec empleadosInactivos", con);
            adapt.Fill(dt);
            dgvEmpleados.DataSource = dt;
            con.Close();
        }

        private void btnVacaciones_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Asignaras vacaciones?", "Vacaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                con.Open();
                cmd = new SqlCommand("EXECUTE insertarVacaciones @empleado, @inicio, @hasta, @comentarios", con);
                cmd.Parameters.AddWithValue("@empleado", Int32.Parse(txtEmpleadoD.Text));
                cmd.Parameters.AddWithValue("@inicio", dtpDesde.Value.Date);
                cmd.Parameters.AddWithValue("@hasta", dtpHasta.Value.Date);
                cmd.Parameters.AddWithValue("@comentarios", txtComentario.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Vacaciones asignadas (En hora buena:) )!");
                
            }
            else
            {
                MessageBox.Show("Vacaciones no asignadas :(");
            }
        }

        private void btnLicencia_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Otorgar licencia?", "Licencias", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                con.Open();
                cmd = new SqlCommand("EXECUTE insertarLicencia @empleado, @inicio, @hasta, @comentarios", con);
                cmd.Parameters.AddWithValue("@empleado", Int32.Parse(txtEmpleadoD.Text));
                cmd.Parameters.AddWithValue("@inicio", dtpDesde.Value.Date);
                cmd.Parameters.AddWithValue("@hasta", dtpHasta.Value.Date);
                cmd.Parameters.AddWithValue("@comentarios", txtComentario.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Licencia otorgada!");

            }
            else
            {
                MessageBox.Show("Licencia no otorgada :(");
            }
        }

        private void btnPermiso_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Otorgar permiso?", "Permisos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                con.Open();
                cmd = new SqlCommand("EXECUTE insertarPermiso @empleado, @inicio, @hasta, @comentarios", con);
                cmd.Parameters.AddWithValue("@empleado", Int32.Parse(txtEmpleadoD.Text));
                cmd.Parameters.AddWithValue("@inicio", dtpDesde.Value.Date);
                cmd.Parameters.AddWithValue("@hasta", dtpHasta.Value.Date);
                cmd.Parameters.AddWithValue("@comentarios", txtComentario.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Permiso otorgado!");

            }
            else
            {
                MessageBox.Show("Permiso no otorgado :(");
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
            empleadosActivos();
        }

        private void btnPorCargos_Click(object sender, EventArgs e)
        {
            con.Open();

            cmd = new SqlCommand("EXECUTE buscarPorCargo @cargo", con);
            cmd.Parameters.AddWithValue("@cargo", txtCargoE.Text);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvEmpleados.DataSource = dt;
            con.Close();
        }

        private void btnPorDepartamentos_Click(object sender, EventArgs e)
        {
                con.Open();
                cmd = new SqlCommand("EXECUTE buscarPorDepart @departamento", con);
                cmd.Parameters.AddWithValue("@departamento", txtDepartamentoE.Text);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvEmpleados.DataSource = dt;
                con.Close();
            
        }

        private void btnMostrarVacaciones_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("exec MostrarVacaciones", con);
            adapt.Fill(dt);
            dgvEmpleados.DataSource = dt;
            con.Close();
        }

        private void btnMostrarLicencias_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("exec MostrarLicencias", con);
            adapt.Fill(dt);
            dgvEmpleados.DataSource = dt;
            con.Close();
        }

        private void btnMostrarPermisos_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("exec MostrarPermisos", con);
            adapt.Fill(dt);
            dgvEmpleados.DataSource = dt;
            con.Close();
        }
    }
    }

