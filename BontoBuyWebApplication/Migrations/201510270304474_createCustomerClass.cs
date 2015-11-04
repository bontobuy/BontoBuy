namespace BontoBuyWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createCustomerClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        CustomerId = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        DateCreated = c.DateTime(precision: 7, storeType: "datetime2"),
                        DateOfBirth = c.DateTime(precision: 7, storeType: "datetime2"),
                        Gender = c.String(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.CustomerId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            
        }
    }
}
