using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rem2024
{
    internal class Empleados
    {
        private int id;
        private int employeesCode;
        private string employeesDNI;
        private string employeesFirstName;
        private string employeeslastName;
        private DateTime employeesBirthday;
        private string employeesEmail;
        private string employeesPhone;
        private string employeesAddress;
        private int id_positions;
        private int id_afp;
        private int id_forecast;
        private string afpName;
        private string forecastName;
        private string positionName;
        
        public Empleados() { }

        public Empleados(int id, int employeesCode, string employeesDNI, string employeesFirstName, string employeeslastName, DateTime employeesBirthday, string employeesEmail, string employeesPhone, string employeesAddress, int id_positions, int id_afp, int id_forecast, string afpName, string forecastName, string positionName)
        {
            this.id = id;
            this.employeesCode = employeesCode;
            this.employeesDNI = employeesDNI;
            this.employeesFirstName = employeesFirstName;
            this.employeeslastName = employeeslastName;
            this.employeesBirthday = employeesBirthday;
            this.employeesEmail = employeesEmail;
            this.employeesPhone = employeesPhone;
            this.employeesAddress = employeesAddress;
            this.id_positions = id_positions;
            this.id_afp = id_afp;
            this.id_forecast = id_forecast;
            this.afpName = afpName;
            this.forecastName = forecastName;
            this.positionName = positionName;
        }

        public static List<EmpleadoClass> MostrarTodosEmpleados()
        {
            List<EmpleadoClass> ListEmployees = new List<EmpleadoClass>();

            using (SqlConnection conexion = DBGeneral.ObtenerConexion())
            {
                SqlCommand consulta = new SqlCommand("SELECT * FROM Empleados", conexion);
                SqlDataReader registro = consulta.ExecuteReader();

                while (registro.Read())
                {
                    EmpleadoClass employee = new EmpleadoClass();
                    employee.employeeCode = registro.GetInt32(0);
                    employee.employeeDNI = registro.GetString(1);
                    employee.employeeFirstName = registro.GetString(2);
                    employee.employeeLastName = registro.GetString(3);
                    employee.employeeBirthday = registro.GetDateTime(4);
                    employee.employeeAddress = registro.GetString(5);
                    employee.employeeEmail = registro.GetString(6);
                    employee.afpName = registro.GetString(7);
                    employee.forecastName = registro.GetString(8);
                    employee.positionName = registro.GetString(9);

                    ListEmployees.Add(employee);
                }

                conexion.Close();
            }
            return ListEmployees;
        }
    }
}
