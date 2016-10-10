namespace EmployeeManagement.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class one : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.EmployeeDepartments", "Employee_Id", "dbo.Employees");
            DropForeignKey("dbo.EmployeeDepartments", "Department_Id", "dbo.Departments");
            DropIndex("dbo.EmployeeDepartments", new[] { "Employee_Id" });
            DropIndex("dbo.EmployeeDepartments", new[] { "Department_Id" });
            CreateIndex("dbo.Employees", "DepartmentId");
            AddForeignKey("dbo.Employees", "DepartmentId", "dbo.Departments", "Id", cascadeDelete: true);
            DropTable("dbo.EmployeeDepartments");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.EmployeeDepartments",
                c => new
                    {
                        Employee_Id = c.Int(nullable: false),
                        Department_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Employee_Id, t.Department_Id });
            
            DropForeignKey("dbo.Employees", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "DepartmentId" });
            CreateIndex("dbo.EmployeeDepartments", "Department_Id");
            CreateIndex("dbo.EmployeeDepartments", "Employee_Id");
            AddForeignKey("dbo.EmployeeDepartments", "Department_Id", "dbo.Departments", "Id", cascadeDelete: true);
            AddForeignKey("dbo.EmployeeDepartments", "Employee_Id", "dbo.Employees", "Id", cascadeDelete: true);
        }
    }
}
