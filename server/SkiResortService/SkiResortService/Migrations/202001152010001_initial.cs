namespace SkiResortService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Mountains",
                c => new
                    {
                        _id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        description = c.String(),
                        country = c.String(),
                        highest_point = c.String(),
                        top_elevation_m = c.Int(nullable: false),
                        base_elevation_m = c.Int(nullable: false),
                        picture = c.String(),
                    })
                .PrimaryKey(t => t._id);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        _id = c.Int(nullable: false, identity: true),
                        mountain_id = c.Int(nullable: false),
                        firstName = c.String(),
                        lastName = c.String(),
                        from_day = c.Int(nullable: false),
                        from_month = c.Int(nullable: false),
                        from_year = c.Int(nullable: false),
                        to_day = c.Int(nullable: false),
                        to_month = c.Int(nullable: false),
                        to_year = c.Int(nullable: false),
                        price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t._id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Skipasses",
                c => new
                    {
                        _id = c.Int(nullable: false, identity: true),
                        mountain_id = c.Int(nullable: false),
                        duration = c.Int(nullable: false),
                        price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t._id);
            
            CreateTable(
                "dbo.Skiresorts",
                c => new
                    {
                        _id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t._id);
            
            CreateTable(
                "dbo.Tracks",
                c => new
                    {
                        _id = c.Int(nullable: false, identity: true),
                        mountain_id = c.Int(nullable: false),
                        name = c.String(),
                        length_km = c.Decimal(nullable: false, precision: 18, scale: 2),
                        rating = c.Decimal(nullable: false, precision: 18, scale: 2),
                        color = c.String(),
                    })
                .PrimaryKey(t => t._id);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Weathers",
                c => new
                    {
                        _id = c.Int(nullable: false, identity: true),
                        mountain_id = c.Int(nullable: false),
                        date = c.String(),
                        temperature_min = c.Int(nullable: false),
                        temperature_max = c.Int(nullable: false),
                        wind = c.Decimal(nullable: false, precision: 18, scale: 2),
                        outlook = c.String(),
                    })
                .PrimaryKey(t => t._id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropTable("dbo.Weathers");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Tracks");
            DropTable("dbo.Skiresorts");
            DropTable("dbo.Skipasses");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Reservations");
            DropTable("dbo.Mountains");
        }
    }
}
