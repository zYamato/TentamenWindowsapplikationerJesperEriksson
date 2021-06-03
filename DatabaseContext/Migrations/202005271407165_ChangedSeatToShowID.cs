namespace DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedSeatToShowID : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Seats", "TicketId_TicketId", "dbo.Tickets");
            DropIndex("dbo.Seats", new[] { "TicketId_TicketId" });
            AddColumn("dbo.Seats", "ShowId_ShowId", c => c.Int(nullable: false));
            CreateIndex("dbo.Seats", "ShowId_ShowId");
            AddForeignKey("dbo.Seats", "ShowId_ShowId", "dbo.Shows", "ShowId", cascadeDelete: true);
            DropColumn("dbo.Seats", "TicketId_TicketId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Seats", "TicketId_TicketId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Seats", "ShowId_ShowId", "dbo.Shows");
            DropIndex("dbo.Seats", new[] { "ShowId_ShowId" });
            DropColumn("dbo.Seats", "ShowId_ShowId");
            CreateIndex("dbo.Seats", "TicketId_TicketId");
            AddForeignKey("dbo.Seats", "TicketId_TicketId", "dbo.Tickets", "TicketId", cascadeDelete: true);
        }
    }
}
