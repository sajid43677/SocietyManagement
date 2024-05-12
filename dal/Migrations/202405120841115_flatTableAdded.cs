namespace dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class flatTableAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.flats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        flat_number = c.String(nullable: false),
                        building_number = c.String(nullable: false),
                        rent = c.Double(nullable: false),
                        status = c.String(nullable: false),
                        owner_id = c.Int(),
                        manager_id = c.Int(),
                        tenant_id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.users", t => t.manager_id)
                .ForeignKey("dbo.users", t => t.owner_id)
                .ForeignKey("dbo.users", t => t.tenant_id)
                .Index(t => t.owner_id)
                .Index(t => t.manager_id)
                .Index(t => t.tenant_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.flats", "tenant_id", "dbo.users");
            DropForeignKey("dbo.flats", "owner_id", "dbo.users");
            DropForeignKey("dbo.flats", "manager_id", "dbo.users");
            DropIndex("dbo.flats", new[] { "tenant_id" });
            DropIndex("dbo.flats", new[] { "manager_id" });
            DropIndex("dbo.flats", new[] { "owner_id" });
            DropTable("dbo.flats");
        }
    }
}
