namespace DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addSeatNums : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tickets", "SeatNum", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tickets", "SeatNum");
        }
    }
}
