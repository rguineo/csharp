using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Win32;

namespace rem2024
{
    public class Afp
    {
        private int id;
        private string afpName;
        private float afpPercent;

        
        public Afp(string afpName, float afpPercent)
        {
            this.afpName = afpName;
            this.afpPercent = afpPercent;
        }

        public int AgregarAfp()
        {
            using (SqlConnection conexion = DBGeneral.ObtenerConexion())
            {
                SqlCommand consulta = new SqlCommand("INSERT INTO afp(afpName, afpPercent) VALUES (@nameAfp, @percentAfp)", conexion);
                consulta.Parameters.AddWithValue("nameAfp", afpName);
                consulta.Parameters.AddWithValue("percentAfp", afpPercent);
                int filasAfectadas = consulta.ExecuteNonQuery();
                conexion.Close();
                return filasAfectadas;
            }
        }

        public static List<AfpClass> MostrarTodasAfp()
        {
            List<AfpClass> ListaAfp = new List<AfpClass>();

            using (SqlConnection conexion = DBGeneral.ObtenerConexion())
            {
                SqlCommand consulta = new SqlCommand("SELECT * FROM afp", conexion);
                SqlDataReader registro = consulta.ExecuteReader();

                while (registro.Read())
                {
                    AfpClass company = new AfpClass();
                    company.id = registro.GetInt32(0);
                    company.afpName = registro.GetString(1);
                    company.afpPercent = registro.GetFloat(2);
                    ListaAfp.Add(company); 
                }

                conexion.Close();
            }

            return ListaAfp;
        }
    }
}
