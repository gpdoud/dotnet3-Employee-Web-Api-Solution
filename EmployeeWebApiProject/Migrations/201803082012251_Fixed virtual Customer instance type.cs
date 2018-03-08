namespace EmployeeWebApiProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixedvirtualCustomerinstancetype : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Departments", "EmployeeId");
            AddForeignKey("dbo.Departments", "EmployeeId", "dbo.Employees", "Id");
            DropColumn("dbo.Departments", "Employee");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Departments", "Employee", c => c.Int(nullable: false));
            DropForeignKey("dbo.Departments", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.Departments", new[] { "EmployeeId" });
        }
    }
}
