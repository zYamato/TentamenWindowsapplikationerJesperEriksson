namespace DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedWheelChairToTicket : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tickets", "WheelChair", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tickets", "WheelChair");
        }
    }
}
