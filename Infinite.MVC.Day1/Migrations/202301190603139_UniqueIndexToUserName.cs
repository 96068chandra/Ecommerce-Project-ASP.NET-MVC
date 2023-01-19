namespace Infinite.MVC.Day1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UniqueIndexToUserName : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Users", "Username", true);
        }
        
        public override void Down()
        {
        }
    }
}
