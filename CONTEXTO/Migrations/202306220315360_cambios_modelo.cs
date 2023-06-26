namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cambios_modelo : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Usuarios", "socio_ID_socio", "dbo.Socios");
            DropIndex("dbo.Usuarios", new[] { "socio_ID_socio" });
            DropColumn("dbo.Usuarios", "socio_ID_socio");
            DropColumn("dbo.Vueloes", "tarifaIns");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Vueloes", "tarifaIns", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.Usuarios", "socio_ID_socio", c => c.Int());
            CreateIndex("dbo.Usuarios", "socio_ID_socio");
            AddForeignKey("dbo.Usuarios", "socio_ID_socio", "dbo.Socios", "ID_socio");
        }
    }
}
