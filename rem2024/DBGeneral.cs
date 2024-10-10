using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace rem2024
{
    public class DBGeneral
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-VEPREGL;Initial Catalog=remunerations;Integrated Security=True");
            conexion.Open();
            return conexion;
        }
    }
}
