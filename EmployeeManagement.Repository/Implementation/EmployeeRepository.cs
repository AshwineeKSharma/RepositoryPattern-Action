using EmployeeManagement.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Data.Models;
using EmployeeManagement.Data.Contexts;
using System.Data.Entity;
using System.Web.Mvc;

namespace EmployeeManagement.Repository.Implementation
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private MyDbContext db = new MyDbContext();
        public void DeleteEmployee(int id)
        {
            Employee existing = db.Employees.Find(id);
            db.Employees.Remove(existing);
        }

        public Employee GetEmployee(int id)
        {
            return db.Employees.Find(id);
        }

        public List<Employee> GetEmployees()
        {
            return db.Employees.Include(e=>e.Department).ToList();
        }

        public void InsertEmployee(Employee employee)
        {
            
            db.Employees.Add(employee);
        }

        public void SaveEmployees()
        {
            db.SaveChanges();
        }

        public void UpdateEmployee(Employee employee)
        {
            db.Entry(employee).State = EntityState.Modified;
        }
    }
}
