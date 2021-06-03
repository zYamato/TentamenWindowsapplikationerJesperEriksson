namespace DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        Ssn = c.Int(nullable: false),
                        FName = c.String(),
                        LName = c.String(),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        TicketId = c.Int(nullable: false, identity: true),
                        CustomerId_CustomerId = c.Int(nullable: false),
                        Show_ShowId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TicketId)
                .ForeignKey("dbo.Customers", t => t.CustomerId_CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Shows", t => t.Show_ShowId, cascadeDelete: true)
                .Index(t => t.CustomerId_CustomerId)
                .Index(t => t.Show_ShowId);
            
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
                .PrimaryKey(t => t.SeatId)
                .ForeignKey("dbo.Shows", t => t.ShowId_ShowId, cascadeDelete: true)
                .ForeignKey("dbo.Tickets", t => t.Ticket_TicketId)
                .Index(t => t.ShowId_ShowId)
                .Index(t => t.Ticket_TicketId);
            
            CreateTable(
                "dbo.Shows",
                c => new
                    {
                        ShowId = c.Int(nullable: false, identity: true),
                        RoomNum = c.Int(nullable: false),
                        wheelChair = c.Boolean(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        Movie_MovieId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ShowId)
                .ForeignKey("dbo.Movies", t => t.Movie_MovieId, cascadeDelete: true)
                .Index(t => t.Movie_MovieId);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        MovieId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Info = c.String(),
                        PicPath = c.String(),
                    })
                .PrimaryKey(t => t.MovieId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tickets", "Show_ShowId", "dbo.Shows");
            DropForeignKey("dbo.Seats", "Ticket_TicketId", "dbo.Tickets");
            DropForeignKey("dbo.Seats", "ShowId_ShowId", "dbo.Shows");
            DropForeignKey("dbo.Shows", "Movie_MovieId", "dbo.Movies");
            DropForeignKey("dbo.Tickets", "CustomerId_CustomerId", "dbo.Customers");
            DropIndex("dbo.Shows", new[] { "Movie_MovieId" });
            DropIndex("dbo.Seats", new[] { "Ticket_TicketId" });
            DropIndex("dbo.Seats", new[] { "ShowId_ShowId" });
            DropIndex("dbo.Tickets", new[] { "Show_ShowId" });
            DropIndex("dbo.Tickets", new[] { "CustomerId_CustomerId" });
            DropTable("dbo.Movies");
            DropTable("dbo.Shows");
            DropTable("dbo.Seats");
            DropTable("dbo.Tickets");
            DropTable("dbo.Customers");
        }
    }
}
