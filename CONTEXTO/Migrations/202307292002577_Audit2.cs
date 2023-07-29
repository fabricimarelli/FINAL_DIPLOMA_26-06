namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Audit2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Auditorias", "usuario_ID_usuario", "dbo.Usuarios");
            DropIndex("dbo.Auditorias", new[] { "usuario_ID_usuario" });
            AddColumn("dbo.Auditorias", "usuario", c => c.String());
            DropColumn("dbo.Auditorias", "usuario_ID_usuario");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Auditorias", "usuario_ID_usuario", c => c.Int());
            DropColumn("dbo.Auditorias", "usuario");
            CreateIndex("dbo.Auditorias", "usuario_ID_usuario");
            AddForeignKey("dbo.Auditorias", "usuario_ID_usuario", "dbo.Usuarios", "ID_usuario");
        }
    }
}
