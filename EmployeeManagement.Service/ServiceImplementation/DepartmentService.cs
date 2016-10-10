using EmployeeManagement.Service.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Data.Models;
using EmployeeManagement.Repository.Implementation;
using EmployeeManagement.Repository.Interfaces;

namespace EmployeeManagement.Service.ServiceImplementation
{
    public class DepartmentService : IDepartmentService
    {
        IDepartmentRepository repo = new DepartmentRepository();
        public void DeleteDepartment(int id)
        {
            repo.DeleteDepartment(id);
        }

        public Department GetDepartment(int id)
        {
            return repo.GetDepartment(id);
        }

        public List<Department> GetDepartments()
        {
            return repo.GetDepartments();
        }

        public void InsertDepartment(Department department)
        {
            repo.InsertDepartment(department);
        }

        public void SaveDepartment()
        {
            repo.SaveDepartment();
        }

        public void UpdateDepartment(Department department)
        {
            repo.UpdateDepartment(department);
        }
    }
}
