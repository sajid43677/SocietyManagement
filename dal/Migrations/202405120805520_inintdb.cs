namespace dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inintdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false),
                        email = c.String(nullable: false),
                        password = c.String(nullable: false),
                        role = c.String(nullable: false),
                        nid = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.users");
        }
    }
}
