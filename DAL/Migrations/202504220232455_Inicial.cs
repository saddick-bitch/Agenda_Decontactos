namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Auditorias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Entidad = c.String(nullable: false),
                        Operacion = c.String(nullable: false),
                        Detalles = c.String(),
                        Fecha = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Contactoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Apellido = c.String(nullable: false, maxLength: 50),
                        Telefono = c.String(),
                        Correo = c.String(),
                        TipoContactoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TipoContactoes", t => t.TipoContactoId)
                .Index(t => t.TipoContactoId);
            
            CreateTable(
                "dbo.ContactoEtiquetas",
                c => new
                    {
                        ContactoId = c.Int(nullable: false),
                        EtiquetaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ContactoId, t.EtiquetaId })
                .ForeignKey("dbo.Contactoes", t => t.ContactoId)
                .ForeignKey("dbo.Etiquetas", t => t.EtiquetaId)
                .Index(t => t.ContactoId)
                .Index(t => t.EtiquetaId);
            
            CreateTable(
                "dbo.Etiquetas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Direccions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Calle = c.String(nullable: false, maxLength: 100),
                        Ciudad = c.String(nullable: false, maxLength: 50),
                        Estado = c.String(nullable: false, maxLength: 50),
                        CodigoPostal = c.String(nullable: false, maxLength: 10),
                        ContactoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contactoes", t => t.ContactoId)
                .Index(t => t.ContactoId);
            
            CreateTable(
                "dbo.TipoContactoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contactoes", "TipoContactoId", "dbo.TipoContactoes");
            DropForeignKey("dbo.Direccions", "ContactoId", "dbo.Contactoes");
            DropForeignKey("dbo.ContactoEtiquetas", "EtiquetaId", "dbo.Etiquetas");
            DropForeignKey("dbo.ContactoEtiquetas", "ContactoId", "dbo.Contactoes");
            DropIndex("dbo.Direccions", new[] { "ContactoId" });
            DropIndex("dbo.ContactoEtiquetas", new[] { "EtiquetaId" });
            DropIndex("dbo.ContactoEtiquetas", new[] { "ContactoId" });
            DropIndex("dbo.Contactoes", new[] { "TipoContactoId" });
            DropTable("dbo.TipoContactoes");
            DropTable("dbo.Direccions");
            DropTable("dbo.Etiquetas");
            DropTable("dbo.ContactoEtiquetas");
            DropTable("dbo.Contactoes");
            DropTable("dbo.Auditorias");
        }
    }
}
