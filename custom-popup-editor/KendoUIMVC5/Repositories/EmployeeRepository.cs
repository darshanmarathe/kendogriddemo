using KendoUIMVC5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KendoUIMVC5.Repositories
{
    public class EmployeeRepository
    {

        public static List<Employee> employees;

        public EmployeeRepository()
        {
            employees = new List<Employee>();
            employees.Add(new Employee { Id = 1, Name = "Mayur", DesignationId = 2 });
            employees.Add(new Employee { Id = 2, Name = "Umesh", DesignationId = 2 });
            employees.Add(new Employee { Id = 3, Name = "Rupali", DesignationId = 1 });
            employees.Add(new Employee { Id = 4, Name = "Rani", DesignationId = 1 });
            employees.Add(new Employee { Id = 5, Name = "Bhagawat", DesignationId = 3 });
            employees.Add(new Employee { Id = 6, Name = "Yogesh", DesignationId = 3 });
            employees.Add(new Employee { Id = 7, Name = "Darshan", DesignationId = 3 });
        }

        public List<Employee> GetEmployees(int? DesignationID)
        {
            if (DesignationID == null)
            {
                return employees;
            }
            return employees.Where(x => x.DesignationId == DesignationID.Value).ToList();

        }
    }
}