namespace Password_Reset.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class relogin : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LoginModels",
                c => new
                    {
                        logid = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        RememberMe = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.logid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LoginModels");
        }
    }
}
