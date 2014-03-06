namespace BlogIt.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Visibilty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Articles", "Visibilty", c => c.Boolean(nullable: false));
            AddColumn("dbo.Posts", "Visibilty", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "Visibilty");
            DropColumn("dbo.Articles", "Visibilty");
        }
    }
}
