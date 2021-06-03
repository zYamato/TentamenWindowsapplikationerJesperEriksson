namespace DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedMovieBackToShows : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Shows", "MovieId");
            AddForeignKey("dbo.Shows", "MovieId", "dbo.Movies", "MovieId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Shows", "MovieId", "dbo.Movies");
            DropIndex("dbo.Shows", new[] { "MovieId" });
        }
    }
}
