namespace SoftCinema.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class PasswordHashToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "PasswordHash", c => c.String(nullable: false));
            DropColumn("dbo.Users", "PasswordSalt");
        }

        public override void Down()
        {
            AddColumn("dbo.Users", "PasswordSalt", c => c.Binary());
            AlterColumn("dbo.Users", "PasswordHash", c => c.Binary(nullable: false));
        }
    }
}