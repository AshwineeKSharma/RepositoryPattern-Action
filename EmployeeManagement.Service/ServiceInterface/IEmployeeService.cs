using EmployeeManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Service.ServiceInterface
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployees();
        Employee GetEmployee(int id);
        void InsertEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(int id);
        void SaveEmployee();


    }
}
