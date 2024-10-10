using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace rem2024
{
    internal class Prevision
    {
        private int id;
        private string forecastName;
        private float forecastPercent;

        public Prevision(string forecastName, float forecastPercent)
        {
            this.forecastName = forecastName;
            this.forecastPercent = forecastPercent;
        }

        public int AgregarIsapre(){

            using (SqlConnection conexion = DBGeneral.ObtenerConexion())
            {
                string querySql = "INSERT INTO forecast (forecastName, forecastPercent) VALUES (@nombre, @porcentaje)";
                SqlCommand consulta =  new SqlCommand(querySql, conexion);

                consulta.Parameters.AddWithValue("nombre", forecastName);
                consulta.Parameters.AddWithValue("porcentaje", forecastPercent);
            
                int filasAfectadas = consulta.ExecuteNonQuery();

                return filasAfectadas;
            }
        } 

        public static List<PrevisionClass> MostrarTodasIsapres()
        {
            List<PrevisionClass> ListaPrevision = new List<PrevisionClass>();
            using (SqlConnection conexion = DBGeneral.ObtenerConexion())
            {
                SqlCommand consulta = new SqlCommand("SELECT * FROM forecast", conexion);
                SqlDataReader registro = consulta.ExecuteReader();

                while (registro.Read())
                {
                    PrevisionClass company = new PrevisionClass();
                    company.id = registro.GetInt32(0);
                    company.forecastName = registro.GetString(1);
                    company.forecastPercent = registro.GetFloat(2);
                    ListaPrevision.Add(company);
                }

                conexion.Close();
            }
            return ListaPrevision;
        }


    }
}
