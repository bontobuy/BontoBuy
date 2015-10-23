namespace BontoBuyWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDateNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Supplier", "DateCreated", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Supplier", "DateUpdated", c => c.DateTime(precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Supplier", "DateUpdated", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Supplier", "DateCreated", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
    }
}
