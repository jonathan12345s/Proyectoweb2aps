namespace ProyectoWEB2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        cedulaJuridica = c.String(),
                        paginaWeb = c.String(),
                        numeroTelefono = c.Int(nullable: false),
                        Sector = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Contactoes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellidos = c.String(),
                        correo = c.String(),
                        telefono = c.String(),
                        puesto = c.String(),
                        ClienteNombre = c.String(),
                        Clientecontacto_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Clientes", t => t.Clientecontacto_id)
                .Index(t => t.Clientecontacto_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contactoes", "Clientecontacto_id", "dbo.Clientes");
            DropIndex("dbo.Contactoes", new[] { "Clientecontacto_id" });
            DropTable("dbo.Contactoes");
            DropTable("dbo.Clientes");
        }
    }
}
