namespace SpartaHackVService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IDK : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Lists", "title");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Lists", "title", c => c.String());
        }
    }
}
