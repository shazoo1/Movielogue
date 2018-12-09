namespace Movielogue.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLastUpdateTime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "LastUpdatedAt", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "LastUpdatedAt");
        }
    }
}
