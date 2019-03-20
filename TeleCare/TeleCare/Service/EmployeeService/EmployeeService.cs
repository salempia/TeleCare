using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeleCare.CustomerException;
using TeleCare.Models;
using TeleCare.Repository;

namespace TeleCare.Service.FactoryService
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository employeeRepository;
        public EmployeeService()
        {
            employeeRepository = new EmployeeRepository();
        }
        public IQueryable<Employee> GetAll()
        {
            return employeeRepository.GetAllEmployees();
        }
        public Employee Add(string Name, string Address, string City, string State)
        {
            string s = @"$KUH% I*$)OFNlkfn$";
            var withoutSpecial = new string(s.Where(c => Char.IsLetterOrDigit(c)
                                                        || Char.IsWhiteSpace(c)).ToArray());
               

            string StateAllowed = "CA";
            string SpecialwordNotAllowed = "city";

            if (string.IsNullOrEmpty(Name))
            {
                throw new BaseException(ExceptionCode.IllegalParameters.ToString());
            }
            if (!StateAllowed.ToLower().Equals(State.ToLower()))
            {
                throw new BaseException(ExceptionCode.IllegalParameters.ToString());
            }
            if (City.ToLower().Contains(SpecialwordNotAllowed.ToLower()))
            {
                throw new BaseException(ExceptionCode.IllegalParameters.ToString());
            }
            if (City != withoutSpecial)
            {
                throw new BaseException(ExceptionCode.IllegalParameters.ToString());
            }
            Employee newEmployee = new Employee();

            newEmployee.EmployeeName = Name;
            newEmployee.Address = Address;
            newEmployee.City = City;
            newEmployee.State = State;
            employeeRepository.AddEmployee(newEmployee);

            return newEmployee;
        }
    }
}