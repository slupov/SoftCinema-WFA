namespace SoftCinema.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class RemovedSeatsCountFromAuditorium : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Auditoriums", "SeatsCount");
        }

        public override void Down()
        {
            AddColumn("dbo.Auditoriums", "SeatsCount", c => c.Int(nullable: false));
        }
    }
}