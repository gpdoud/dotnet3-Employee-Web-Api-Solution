namespace EmployeeWebApiProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedDepartement : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 80),
                        Budget = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EmployeeId = c.Int(),
                        Employee = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Departments");
        }
    }
}
