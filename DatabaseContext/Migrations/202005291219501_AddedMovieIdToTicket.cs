namespace DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMovieIdToTicket : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tickets", "MovieId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tickets", "MovieId");
        }
    }
}
