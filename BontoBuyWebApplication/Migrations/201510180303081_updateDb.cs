namespace BontoBuyWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateDb : DbMigration
    {
        public override void Up()
        {
            
            CreateTable(
                "dbo.Supplier",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        SupplierId = c.Int(nullable: false, identity: true),
                        SupplierName = c.String(),
                        Street = c.String(),
                        Website = c.String(),
                        Status = c.String(),
                        City = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        DateUpdated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SupplierId)
                .Index(t => t.UserId);
            
     
        }
        
        public override void Down()
        {
           
        }
    }
}
