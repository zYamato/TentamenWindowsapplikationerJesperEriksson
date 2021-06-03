namespace DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedSeatsToTicket : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Seats", "Ticket_TicketId", c => c.Int());
            CreateIndex("dbo.Seats", "Ticket_TicketId");
            AddForeignKey("dbo.Seats", "Ticket_TicketId", "dbo.Tickets", "TicketId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Seats", "Ticket_TicketId", "dbo.Tickets");
            DropIndex("dbo.Seats", new[] { "Ticket_TicketId" });
            DropColumn("dbo.Seats", "Ticket_TicketId");
        }
    }
}
