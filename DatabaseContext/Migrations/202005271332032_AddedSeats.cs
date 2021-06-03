namespace DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedSeats : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Seats",
                c => new
                    {
                        SeatId = c.Int(nullable: false, identity: true),
                        Row = c.String(),
                        Num = c.Int(nullable: false),
                        TicketId_TicketId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SeatId)
                .ForeignKey("dbo.Tickets", t => t.TicketId_TicketId, cascadeDelete: true)
                .Index(t => t.TicketId_TicketId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Seats", "TicketId_TicketId", "dbo.Tickets");
            DropIndex("dbo.Seats", new[] { "TicketId_TicketId" });
            DropTable("dbo.Seats");
        }
    }
}
