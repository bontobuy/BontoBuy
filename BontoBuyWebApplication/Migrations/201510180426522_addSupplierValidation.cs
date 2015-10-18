namespace BontoBuyWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addSupplierValidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Supplier", "SupplierName", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Supplier", "Street", c => c.String(nullable: false));
            AlterColumn("dbo.Supplier", "City", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Supplier", "City", c => c.String());
            AlterColumn("dbo.Supplier", "Street", c => c.String());
            AlterColumn("dbo.Supplier", "SupplierName", c => c.String());
        }
    }
}
