namespace SpecialBranch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sb1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RpoLogins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RpoId = c.Int(nullable: false),
                        UserId = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Rpoes", t => t.RpoId, cascadeDelete: true)
                .Index(t => t.RpoId);
            
            CreateTable(
                "dbo.Rpoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SbDispatches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SbDsbId = c.Int(nullable: false),
                        EId = c.String(nullable: false, maxLength: 15),
                        DrDate = c.DateTime(nullable: false),
                        DrTime = c.DateTime(nullable: false),
                        Status = c.String(),
                        Remarks = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SbDsbs", t => t.SbDsbId, cascadeDelete: true)
                .Index(t => t.SbDsbId);
            
            CreateTable(
                "dbo.SbDsbs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RpoId = c.Int(nullable: false),
                        Name = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Rpoes", t => t.RpoId, cascadeDelete: true)
                .Index(t => t.RpoId);
            
            CreateTable(
                "dbo.SbReceives",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SbDsbId = c.Int(nullable: false),
                        EId = c.String(nullable: false, maxLength: 15),
                        DrDate = c.DateTime(nullable: false),
                        DrTime = c.DateTime(nullable: false),
                        Status = c.String(),
                        Remarks = c.String(),
                        DId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SbDsbs", t => t.SbDsbId, cascadeDelete: true)
                .Index(t => t.SbDsbId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SbReceives", "SbDsbId", "dbo.SbDsbs");
            DropForeignKey("dbo.SbDispatches", "SbDsbId", "dbo.SbDsbs");
            DropForeignKey("dbo.SbDsbs", "RpoId", "dbo.Rpoes");
            DropForeignKey("dbo.RpoLogins", "RpoId", "dbo.Rpoes");
            DropIndex("dbo.SbReceives", new[] { "SbDsbId" });
            DropIndex("dbo.SbDsbs", new[] { "RpoId" });
            DropIndex("dbo.SbDispatches", new[] { "SbDsbId" });
            DropIndex("dbo.RpoLogins", new[] { "RpoId" });
            DropTable("dbo.SbReceives");
            DropTable("dbo.SbDsbs");
            DropTable("dbo.SbDispatches");
            DropTable("dbo.Rpoes");
            DropTable("dbo.RpoLogins");
        }
    }
}
