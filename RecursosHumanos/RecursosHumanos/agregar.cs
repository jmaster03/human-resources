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



    class agregar
    {
        SqlConnection con = new SqlConnection("Data Source = (localdb)\\JMASTER03; Initial Catalog=RecursosHumanos; Integrated Security=True");
        SqlDataAdapter adapt;
        SqlCommand cmd;
        int id = 0;

        
        public void nuevoEmpleado()
        {
           empleados emp = new empleados();
            if (emp.txtCodigoE.Text != "" && emp.txtNombreE.Text != "" && emp.txtApellidoE.Text != "" && emp.txtTelefonoE.Text != "" && emp.txtDepartamentoE.Text != "" && emp.txtCodigoE.Text != "" && emp.txtSalarioE.Text != "" && emp.txtEstatusE.Text != "" && emp.dtpIngreso.Text != "")
            {
                con.Open();
                cmd = new SqlCommand("EXECUTE nuevoEmpleado @code_empleado, @nombre, @apellido, @telefono, @departamento, @cargo, @fecha_ingreso, @salario, @estatus", con);
                this.cmd.Parameters.AddWithValue("@code_empleado", emp.txtCodigoE.Text);
                this.cmd.Parameters.AddWithValue("@nombre", emp.txtNombreE.Text);
                this.cmd.Parameters.AddWithValue("@apellido", emp.txtApellidoE.Text);
                this.cmd.Parameters.AddWithValue("@telefono", emp.txtTelefonoE.Text);
                this.cmd.Parameters.AddWithValue("@departamento", Int32.Parse(emp.txtDepartamentoE.Text));
                this.cmd.Parameters.AddWithValue("@cargo", Int32.Parse(emp.txtCargoE.Text));
                this.cmd.Parameters.AddWithValue("@fecha_ingreso", emp.dtpIngreso.Value.Date);
                this.cmd.Parameters.AddWithValue("@salario", Int32.Parse(emp.txtSalarioE.Text));
                this.cmd.Parameters.AddWithValue("@estatus", emp.txtEstatusE.Text);
                this.cmd.ExecuteNonQuery();
                this.con.Close();
                MessageBox.Show("Empleado agregado satisfactoriamente!");

            }
            else
            {
                MessageBox.Show("Error al agregar empleado");

            }


        }
    }
}
