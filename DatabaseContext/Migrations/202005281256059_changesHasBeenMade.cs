namespace DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changesHasBeenMade : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Shows", "Movie_MovieId", "dbo.Movies");
            DropForeignKey("dbo.Seats", "ShowId_ShowId", "dbo.Shows");
            DropForeignKey("dbo.Seats", "Ticket_TicketId", "dbo.Tickets");
            DropIndex("dbo.Seats", new[] { "ShowId_ShowId" });
            DropIndex("dbo.Seats", new[] { "Ticket_TicketId" });
            DropIndex("dbo.Shows", new[] { "Movie_MovieId" });
            RenameColumn(table: "dbo.Tickets", name: "CustomerId_CustomerId", newName: "CustomerId");
            RenameIndex(table: "dbo.Tickets", name: "IX_CustomerId_CustomerId", newName: "IX_CustomerId");
            AddColumn("dbo.Shows", "MovieId", c => c.Int(nullable: false));
            AlterColumn("dbo.Customers", "Ssn", c => c.String());
            DropColumn("dbo.Shows", "Movie_MovieId");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Seats",
                c => new
                    {
                        SeatId = c.Int(nullable: false, identity: true),
                        Row = c.String(),
                        Num = c.Int(nullable: false),
                        ShowId_ShowId = c.Int(nullable: false),
                        Ticket_TicketId = c.Int(),
                    })
                .PrimaryKey(t => t.SeatId);
            
            AddColumn("dbo.Shows", "Movie_MovieId", c => c.Int(nullable: false));
            AlterColumn("dbo.Customers", "Ssn", c => c.Int(nullable: false));
            DropColumn("dbo.Shows", "MovieId");
            RenameIndex(table: "dbo.Tickets", name: "IX_CustomerId", newName: "IX_CustomerId_CustomerId");
            RenameColumn(table: "dbo.Tickets", name: "CustomerId", newName: "CustomerId_CustomerId");
            CreateIndex("dbo.Shows", "Movie_MovieId");
            CreateIndex("dbo.Seats", "Ticket_TicketId");
            CreateIndex("dbo.Seats", "ShowId_ShowId");
            AddForeignKey("dbo.Seats", "Ticket_TicketId", "dbo.Tickets", "TicketId");
            AddForeignKey("dbo.Seats", "ShowId_ShowId", "dbo.Shows", "ShowId", cascadeDelete: true);
            AddForeignKey("dbo.Shows", "Movie_MovieId", "dbo.Movies", "MovieId", cascadeDelete: true);
        }
    }
}
