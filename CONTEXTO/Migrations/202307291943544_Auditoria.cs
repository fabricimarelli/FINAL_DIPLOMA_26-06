namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Auditoria : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Auditorias",
                c => new
                    {
                        ID_audit = c.Int(nullable: false, identity: true),
                        tipoOperacion = c.String(),
                        fechaHora = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        usuario_ID_usuario = c.Int(),
                    })
                .PrimaryKey(t => t.ID_audit)
                .ForeignKey("dbo.Usuarios", t => t.usuario_ID_usuario)
                .Index(t => t.usuario_ID_usuario);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Auditorias", "usuario_ID_usuario", "dbo.Usuarios");
            DropIndex("dbo.Auditorias", new[] { "usuario_ID_usuario" });
            DropTable("dbo.Auditorias");
        }
    }
}
