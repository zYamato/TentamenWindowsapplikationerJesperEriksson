namespace DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testMigration1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Shows", "Movie_MovieId", "dbo.Movies");
            DropIndex("dbo.Shows", new[] { "Movie_MovieId" });
            AlterColumn("dbo.Shows", "Movie_MovieId", c => c.Int());
            CreateIndex("dbo.Shows", "Movie_MovieId");
            AddForeignKey("dbo.Shows", "Movie_MovieId", "dbo.Movies", "MovieId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Shows", "Movie_MovieId", "dbo.Movies");
            DropIndex("dbo.Shows", new[] { "Movie_MovieId" });
            AlterColumn("dbo.Shows", "Movie_MovieId", c => c.Int(nullable: false));
            CreateIndex("dbo.Shows", "Movie_MovieId");
            AddForeignKey("dbo.Shows", "Movie_MovieId", "dbo.Movies", "MovieId", cascadeDelete: true);
        }
    }
}
