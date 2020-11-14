namespace Eagle.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editedcontactform : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ContactForms", "Name", c => c.String(nullable: false, maxLength: 600));
            AlterColumn("dbo.ContactForms", "Phone", c => c.String(nullable: false, maxLength: 600));
            AlterColumn("dbo.ContactForms", "Email", c => c.String(nullable: false, maxLength: 600));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ContactForms", "Email", c => c.String(maxLength: 600));
            AlterColumn("dbo.ContactForms", "Phone", c => c.String(maxLength: 600));
            AlterColumn("dbo.ContactForms", "Name", c => c.String(maxLength: 600));
        }
    }
}
