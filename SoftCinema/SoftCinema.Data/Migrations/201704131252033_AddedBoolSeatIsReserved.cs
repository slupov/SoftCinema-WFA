namespace SoftCinema.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedBoolSeatIsReserved : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Seats", "IsReserved", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Seats", "IsReserved");
        }
    }
}
