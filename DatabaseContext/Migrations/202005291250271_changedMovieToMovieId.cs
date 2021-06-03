namespace DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedMovieToMovieId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Shows", "Movie_MovieId", "dbo.Movies");
            DropIndex("dbo.Shows", new[] { "Movie_MovieId" });
            AddColumn("dbo.Shows", "MovieId", c => c.Int(nullable: false));
            DropColumn("dbo.Shows", "Movie_MovieId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Shows", "Movie_MovieId", c => c.Int(nullable: false));
            DropColumn("dbo.Shows", "MovieId");
            CreateIndex("dbo.Shows", "Movie_MovieId");
            AddForeignKey("dbo.Shows", "Movie_MovieId", "dbo.Movies", "MovieId", cascadeDelete: true);
        }
    }
}
