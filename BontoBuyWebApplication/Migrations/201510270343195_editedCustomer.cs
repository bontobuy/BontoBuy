namespace BontoBuyWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editedCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customer", "City", c => c.String());
            AddColumn("dbo.Customer", "DateUpdated", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AddColumn("dbo.Customer", "Street", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customer", "Street");
            DropColumn("dbo.Customer", "DateUpdated");
            DropColumn("dbo.Customer", "City");
        }
    }
}
