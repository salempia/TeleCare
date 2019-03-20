using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeleCare.Models
{
    public class Employee
    {
        public Employee()
        {
            
        }

        public int? EmployeeId { get; set; }

        private string EmployeeName { get; set; }    

        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        
    }
}