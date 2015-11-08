namespace BontoBuyWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedFkProduct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Product", "SupplierId", c => c.Int(nullable: false));
            AddForeignKey("dbo.Product", "SupplierId", "dbo.Supplier", "SupplierId");
        }
        
        public override void Down()
        {
            
        }
    }
}
