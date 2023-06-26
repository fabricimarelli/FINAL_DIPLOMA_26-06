namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Primera : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aeronaves",
                c => new
                    {
                        ID_aeronave = c.Int(nullable: false, identity: true),
                        matricula = c.String(),
                        marcaModelo = c.String(),
                        taquimetro = c.Decimal(nullable: false, precision: 18, scale: 2),
                        taquimetroFuturo = c.Decimal(nullable: false, precision: 18, scale: 2),
                        tarifaHora = c.Decimal(nullable: false, precision: 18, scale: 2),
                        enServicio = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID_aeronave);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Aeronaves");
        }
    }
}
