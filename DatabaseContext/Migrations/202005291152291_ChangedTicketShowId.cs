﻿namespace DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedTicketShowId : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Tickets", name: "Show_ShowId", newName: "ShowId");
            RenameIndex(table: "dbo.Tickets", name: "IX_Show_ShowId", newName: "IX_ShowId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Tickets", name: "IX_ShowId", newName: "IX_Show_ShowId");
            RenameColumn(table: "dbo.Tickets", name: "ShowId", newName: "Show_ShowId");
        }
    }
}
