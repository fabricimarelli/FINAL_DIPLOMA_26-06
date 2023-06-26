namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class atributo_aeronave : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Mantenimientoes", "proximoMant", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Mantenimientoes", "proximoMant");
        }
    }
}
