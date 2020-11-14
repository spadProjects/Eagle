namespace Eagle.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Edited_serviceIncludes : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ServiceIncludes", "Service_Id", "dbo.Services");
            DropIndex("dbo.ServiceIncludes", new[] { "Service_Id" });
            RenameColumn(table: "dbo.ServiceIncludes", name: "Service_Id", newName: "ServiceId");
            AlterColumn("dbo.ServiceIncludes", "Title", c => c.String(nullable: false, maxLength: 700));
            AlterColumn("dbo.ServiceIncludes", "ServiceId", c => c.Int(nullable: false));
            CreateIndex("dbo.ServiceIncludes", "ServiceId");
            AddForeignKey("dbo.ServiceIncludes", "ServiceId", "dbo.Services", "Id", cascadeDelete: true);
            DropColumn("dbo.ServiceIncludes", "ServcieId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ServiceIncludes", "ServcieId", c => c.Int(nullable: false));
            DropForeignKey("dbo.ServiceIncludes", "ServiceId", "dbo.Services");
            DropIndex("dbo.ServiceIncludes", new[] { "ServiceId" });
            AlterColumn("dbo.ServiceIncludes", "ServiceId", c => c.Int());
            AlterColumn("dbo.ServiceIncludes", "Title", c => c.String(maxLength: 700));
            RenameColumn(table: "dbo.ServiceIncludes", name: "ServiceId", newName: "Service_Id");
            CreateIndex("dbo.ServiceIncludes", "Service_Id");
            AddForeignKey("dbo.ServiceIncludes", "Service_Id", "dbo.Services", "Id");
        }
    }
}
