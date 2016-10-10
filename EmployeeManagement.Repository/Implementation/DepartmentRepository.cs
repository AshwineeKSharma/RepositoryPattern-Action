using EmployeeManagement.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EmployeeManagement.Data.Models;
using EmployeeManagement.Data.Contexts;

namespace EmployeeManagement.Repository.Implementation
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private MyDbContext db = new MyDbContext();
        public void DeleteDepartment(int id)
        {
            Department existing = db.Departments.Find(id);
            db.Departments.Remove(existing);
        }

        public Department GetDepartment(int id)
        {
            return db.Departments.Find(id);
        }

        public List<Department> GetDepartments()
        {
            return db.Departments.Include("Employees").ToList();
        }

        public void InsertDepartment(Department department)
        {
            db.Departments.Add(department);
        }

        public void SaveDepartment()
        {
            db.SaveChanges();
        }

        public void UpdateDepartment(Department department)
        {
            db.Entry(department).State = EntityState.Modified;
        }
    }
}
