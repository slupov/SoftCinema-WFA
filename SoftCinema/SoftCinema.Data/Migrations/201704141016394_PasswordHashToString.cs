namespace SoftCinema.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class PasswordHashToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "PasswordHash", c => c.String(nullable: false));
        }

        public override void Down()
        {
            AlterColumn("dbo.Users", "PasswordHash", c => c.Binary(nullable: false));
        }
    }
}