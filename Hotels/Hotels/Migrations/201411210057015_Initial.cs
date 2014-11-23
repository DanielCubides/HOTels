namespace Hotels.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reservas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        HabitacionID = c.Int(nullable: false),
                        UsuarioID = c.Int(nullable: false),
                        usuario_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Habitacions", t => t.HabitacionID, cascadeDelete: true)
                .ForeignKey("dbo.UserProfile", t => t.usuario_UserId)
                .Index(t => t.HabitacionID)
                .Index(t => t.usuario_UserId);
            
            CreateTable(
                "dbo.Habitacions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Avalible = c.Boolean(nullable: false),
                        StarDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.UserProfile",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Reservas", new[] { "usuario_UserId" });
            DropIndex("dbo.Reservas", new[] { "HabitacionID" });
            DropForeignKey("dbo.Reservas", "usuario_UserId", "dbo.UserProfile");
            DropForeignKey("dbo.Reservas", "HabitacionID", "dbo.Habitacions");
            DropTable("dbo.UserProfile");
            DropTable("dbo.Habitacions");
            DropTable("dbo.Reservas");
        }
    }
}
