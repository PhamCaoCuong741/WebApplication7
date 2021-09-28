namespace WebApplication7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Column_Acccount_Address : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Accounts", "Address", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Accounts", "Address");
        }
    }
}
