using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Data;
using System.Data.SqlClient;
using TeleCare.Repository.Base;
using TeleCare.Models;

namespace TeleCare.Repository
{
    public class EmployeeRepository : BaseRepository<Employee> , IEmployeeRepository
    {       
      
        public Employee Update(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Employee AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Employee> GetAllEmployees()
        {
            throw new NotImplementedException();
        }
    }
}