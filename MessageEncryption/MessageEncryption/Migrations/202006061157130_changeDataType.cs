namespace MessageEncryption.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeDataType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Replacements", "OldSymb", c => c.String(nullable: false, maxLength: 1));
            AddColumn("dbo.Replacements", "NewSymb", c => c.String(nullable: false, maxLength: 1));
            AlterColumn("dbo.Messages", "Text", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Messages", "Text", c => c.String());
            DropColumn("dbo.Replacements", "NewSymb");
            DropColumn("dbo.Replacements", "OldSymb");
        }
    }
}
