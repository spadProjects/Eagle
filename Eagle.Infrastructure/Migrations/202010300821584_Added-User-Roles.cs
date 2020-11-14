namespace Eagle.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedUserRoles : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUserRoles", "Id", c => c.Int());
            AddColumn("dbo.AspNetUserRoles", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.AspNetUserRoles", "Role_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.AspNetUserRoles", "User_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.Permissions", "Name", c => c.String(maxLength: 300));
            CreateIndex("dbo.AspNetUserRoles", "Role_Id");
            CreateIndex("dbo.AspNetUserRoles", "User_Id");
            AddForeignKey("dbo.AspNetUserRoles", "Role_Id", "dbo.AspNetRoles", "Id");
            AddForeignKey("dbo.AspNetUserRoles", "User_Id", "dbo.AspNetUsers", "Id");
            DropColumn("dbo.AspNetRoles", "IsDefaultRole");
            DropColumn("dbo.AspNetRoles", "IsDelete");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetRoles", "IsDelete", c => c.Boolean());
            AddColumn("dbo.AspNetRoles", "IsDefaultRole", c => c.Boolean());
            DropForeignKey("dbo.AspNetUserRoles", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "Role_Id", "dbo.AspNetRoles");
            DropIndex("dbo.AspNetUserRoles", new[] { "User_Id" });
            DropIndex("dbo.AspNetUserRoles", new[] { "Role_Id" });
            DropColumn("dbo.Permissions", "Name");
            DropColumn("dbo.AspNetUserRoles", "User_Id");
            DropColumn("dbo.AspNetUserRoles", "Role_Id");
            DropColumn("dbo.AspNetUserRoles", "Discriminator");
            DropColumn("dbo.AspNetUserRoles", "Id");
        }
    }
}
