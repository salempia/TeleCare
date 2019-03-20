using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeleCare.Models;

namespace TeleCare.Service.FactoryService
{
    public interface IEmployeeService
    {
        IQueryable<Employee> GetAll();
        Employee Add(string Name, string Address, string City, string State);
    }
}