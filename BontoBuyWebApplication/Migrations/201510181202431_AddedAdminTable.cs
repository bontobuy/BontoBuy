namespace BontoBuyWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAdminTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admin",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        AdminId = c.Int(nullable: false, identity: true),
                        AdminName = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.AdminId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
           
        }
    }
}
