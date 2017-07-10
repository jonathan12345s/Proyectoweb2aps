namespace ProyectoWEB2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nombre : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reunions",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        diayhora = c.DateTime(nullable: false),
                        usuarios = c.String(),
                        Virtual = c.String(),
                        clientes = c.String(),
                        ClienteNombre = c.String(),
                        Clientecontacto_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Clientes", t => t.Clientecontacto_id)
                .Index(t => t.Clientecontacto_id);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Titulo = c.String(),
                        detalle = c.String(),
                        reportado = c.String(),
                        clienye = c.String(),
                        estado = c.String(),
                        Clientecontacto_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Clientes", t => t.Clientecontacto_id)
                .Index(t => t.Clientecontacto_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tickets", "Clientecontacto_id", "dbo.Clientes");
            DropForeignKey("dbo.Reunions", "Clientecontacto_id", "dbo.Clientes");
            DropIndex("dbo.Tickets", new[] { "Clientecontacto_id" });
            DropIndex("dbo.Reunions", new[] { "Clientecontacto_id" });
            DropTable("dbo.Tickets");
            DropTable("dbo.Reunions");
        }
    }
}
