namespace SoftCinema.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAditionalUniqueIndices : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cinemas", "TownId", "dbo.Towns");
            DropIndex("dbo.Cinemas", new[] { "TownId" });
            DropIndex("dbo.Auditoriums", new[] { "CinemaId" });
            AddColumn("dbo.Movies", "Name", c => c.String(nullable: false));
            AddColumn("dbo.Users", "Username", c => c.String(nullable: false, maxLength: 25));
            AlterColumn("dbo.Cinemas", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Cinemas", "TownId", c => c.Int(nullable: false));
            AlterColumn("dbo.Categories", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Users", "Email", c => c.String(nullable: false, maxLength: 30));
            CreateIndex("dbo.Cinemas", new[] { "Name", "TownId" }, unique: true, name: "IX_CinemaTown");
            CreateIndex("dbo.Auditoriums", new[] { "Number", "CinemaId" }, unique: true, name: "IX_CinemaNumber");
            CreateIndex("dbo.Categories", "Name", unique: true);
            CreateIndex("dbo.Users", "Username", unique: true);
            CreateIndex("dbo.Users", "Email", unique: true);
            AddForeignKey("dbo.Cinemas", "TownId", "dbo.Towns", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cinemas", "TownId", "dbo.Towns");
            DropIndex("dbo.Users", new[] { "Email" });
            DropIndex("dbo.Users", new[] { "Username" });
            DropIndex("dbo.Categories", new[] { "Name" });
            DropIndex("dbo.Auditoriums", "IX_CinemaNumber");
            DropIndex("dbo.Cinemas", "IX_CinemaTown");
            AlterColumn("dbo.Users", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Categories", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Cinemas", "TownId", c => c.Int());
            AlterColumn("dbo.Cinemas", "Name", c => c.String(nullable: false));
            DropColumn("dbo.Users", "Username");
            DropColumn("dbo.Movies", "Name");
            CreateIndex("dbo.Auditoriums", "CinemaId");
            CreateIndex("dbo.Cinemas", "TownId");
            AddForeignKey("dbo.Cinemas", "TownId", "dbo.Towns", "Id");
        }
    }
}
