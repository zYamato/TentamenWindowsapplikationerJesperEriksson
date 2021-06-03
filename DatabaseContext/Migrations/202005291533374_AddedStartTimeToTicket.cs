namespace DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedStartTimeToTicket : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tickets", "StartTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tickets", "StartTime");
        }
    }
}
