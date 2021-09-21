namespace WebApplication7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Usename = c.String(nullable: false, maxLength: 128, unicode: false),
                        Password = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Usename);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Accounts");
        }
    }
}
