namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class permisos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Auditorias", "usuario_ID_usuario", c => c.Int());
            CreateIndex("dbo.Auditorias", "usuario_ID_usuario");
            AddForeignKey("dbo.Auditorias", "usuario_ID_usuario", "dbo.Usuarios", "ID_usuario");
            DropColumn("dbo.Auditorias", "usuario");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Auditorias", "usuario", c => c.String());
            DropForeignKey("dbo.Auditorias", "usuario_ID_usuario", "dbo.Usuarios");
            DropIndex("dbo.Auditorias", new[] { "usuario_ID_usuario" });
            DropColumn("dbo.Auditorias", "usuario_ID_usuario");
        }
    }
}
