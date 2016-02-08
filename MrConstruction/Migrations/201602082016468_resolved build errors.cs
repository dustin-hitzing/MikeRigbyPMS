namespace MrConstruction.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class resolvedbuilderrors : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Title", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Title");
        }
    }
}
