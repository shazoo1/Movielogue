namespace Movielogue.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakePosterlinkOptional : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "PosterLink", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "PosterLink", c => c.String(nullable: false));
        }
    }
}
