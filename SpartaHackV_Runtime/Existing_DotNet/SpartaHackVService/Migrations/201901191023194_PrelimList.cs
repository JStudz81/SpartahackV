namespace SpartaHackVService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PrelimList : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TodoItems", "List_ID", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TodoItems", "List_ID");
        }
    }
}
