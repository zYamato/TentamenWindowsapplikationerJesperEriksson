namespace DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testing : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Shows", "Movie_MovieId", c => c.Int(nullable: false));
            CreateIndex("dbo.Shows", "Movie_MovieId");
            AddForeignKey("dbo.Shows", "Movie_MovieId", "dbo.Movies", "MovieId", cascadeDelete: true);
            DropColumn("dbo.Shows", "MovieId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Shows", "MovieId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Shows", "Movie_MovieId", "dbo.Movies");
            DropIndex("dbo.Shows", new[] { "Movie_MovieId" });
            DropColumn("dbo.Shows", "Movie_MovieId");
        }
    }
}
