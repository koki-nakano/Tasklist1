namespace Tasklist1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddVaridation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tasks", "Task", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tasks", "Task", c => c.String());
        }
    }
}
