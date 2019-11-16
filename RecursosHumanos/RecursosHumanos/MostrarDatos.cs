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
    class MostrarDatos
    {
        
        SqlConnection con = new SqlConnection("Data Source = (localdb)\\JMASTER03; Initial Catalog=RecursosHumanos; Integrated Security=True");
        SqlDataAdapter adapt;
        SqlCommand cmd;
        int id = 0;

       


    }
}
