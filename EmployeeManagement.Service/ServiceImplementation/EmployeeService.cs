using EmployeeManagement.Service.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Data.Models;
using EmployeeManagement.Repository.Interfaces;
using EmployeeManagement.Repository.Implementation;

namespace EmployeeManagement.Service.ServiceImplementation
{
    
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository repo = new EmployeeRepository();
        public void DeleteEmployee(int id)
        {
            repo.DeleteEmployee(id);
        }

        public Employee GetEmployee(int id)
        {
            return repo.GetEmployee(id);
        }

        public List<Employee> GetEmployees()
        {
            return repo.GetEmployees();
        }

        public void InsertEmployee(Employee employee)
        {
            repo.InsertEmployee(employee);
        }

        public void SaveEmployee()
        {
            repo.SaveEmployees();
        }

        public void UpdateEmployee(Employee employee)
        {
            repo.UpdateEmployee(employee);
        }
    }
}
