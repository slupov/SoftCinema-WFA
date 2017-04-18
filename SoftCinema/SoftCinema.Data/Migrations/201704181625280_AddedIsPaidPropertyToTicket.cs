namespace SoftCinema.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedIsPaidPropertyToTicket : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tickets", "isPaid", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tickets", "isPaid");
        }
    }
}
