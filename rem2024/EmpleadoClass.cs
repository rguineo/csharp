using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rem2024
{
    public class EmpleadoClass
    {
        public int id { get; set; }
        public int employeeCode { get; set; }
        public string employeeDNI { get; set; }
        public string employeeFirstName { get; set; }
        public string employeeLastName { get; set; }
        public DateTime employeeBirthday { get; set; }
        public string employeeAddress { get; set; }
        public string employeeEmail { get; set; }
        public string afpName { get; set; }
        public string forecastName { get; set; }
        public string positionName { get; set; }

        public EmpleadoClass() { }

        public EmpleadoClass(int id, int employeeCode, string employeeDNI, string employeeFirstName, string employeeLastName, DateTime employeeBirthday, string employeeAddress, string employeeEmail, string afpName, string forecastName, string positionName)
        {
            this.id = id;
            this.employeeCode = employeeCode;
            this.employeeDNI = employeeDNI;
            this.employeeFirstName = employeeFirstName;
            this.employeeLastName = employeeLastName;
            this.employeeBirthday = employeeBirthday;
            this.employeeAddress = employeeAddress;
            this.employeeEmail = employeeEmail;
            this.afpName = afpName;
            this.forecastName = forecastName;
            this.positionName = positionName;
        }
    }
}
