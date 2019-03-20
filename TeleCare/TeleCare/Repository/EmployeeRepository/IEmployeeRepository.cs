using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleCare.Models;

namespace TeleCare.Repository
{
    public interface IEmployeeRepository
    {
        IQueryable<Employee> GetAllEmployees();
        Employee Update(Employee factory);
        void Delete(int id);
        Employee AddEmployee(Employee factory);        
    }
}
