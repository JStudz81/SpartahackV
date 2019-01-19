namespace SpartaHackVService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Lists : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Lists", "title", c => c.String());
            AddColumn("dbo.Lists", "date", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Lists", "date");
            DropColumn("dbo.Lists", "title");
        }
    }
}
