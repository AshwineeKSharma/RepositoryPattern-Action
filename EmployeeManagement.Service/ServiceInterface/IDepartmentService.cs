using EmployeeManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Service.ServiceInterface
{
    public interface IDepartmentService
    {

        List<Department> GetDepartments();
        Department GetDepartment(int id);
        void InsertDepartment(Department department);
        void UpdateDepartment(Department department);
        void DeleteDepartment(int id);
        void SaveDepartment();

    }
}
