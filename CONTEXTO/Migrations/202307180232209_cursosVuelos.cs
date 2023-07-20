namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cursosVuelos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cursoes", "horasCumplidas", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Cursoes", "categoria", c => c.String());
            AddColumn("dbo.Cursoes", "estado", c => c.String());
            AddColumn("dbo.Cursoes", "fechaInicio", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AddColumn("dbo.Cursoes", "fechaFin", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AddColumn("dbo.Cursoes", "instructor_ID_socio", c => c.Int());
            AddColumn("dbo.Vueloes", "curso_ID_curso", c => c.Int());
            CreateIndex("dbo.Cursoes", "instructor_ID_socio");
            CreateIndex("dbo.Vueloes", "curso_ID_curso");
            AddForeignKey("dbo.Cursoes", "instructor_ID_socio", "dbo.Socios", "ID_socio");
            AddForeignKey("dbo.Vueloes", "curso_ID_curso", "dbo.Cursoes", "ID_curso");
            DropColumn("dbo.Cursoes", "activo");
            DropColumn("dbo.Cursoes", "horasVoladas");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cursoes", "horasVoladas", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Cursoes", "activo", c => c.Boolean(nullable: false));
            DropForeignKey("dbo.Vueloes", "curso_ID_curso", "dbo.Cursoes");
            DropForeignKey("dbo.Cursoes", "instructor_ID_socio", "dbo.Socios");
            DropIndex("dbo.Vueloes", new[] { "curso_ID_curso" });
            DropIndex("dbo.Cursoes", new[] { "instructor_ID_socio" });
            DropColumn("dbo.Vueloes", "curso_ID_curso");
            DropColumn("dbo.Cursoes", "instructor_ID_socio");
            DropColumn("dbo.Cursoes", "fechaFin");
            DropColumn("dbo.Cursoes", "fechaInicio");
            DropColumn("dbo.Cursoes", "estado");
            DropColumn("dbo.Cursoes", "categoria");
            DropColumn("dbo.Cursoes", "horasCumplidas");
        }
    }
}
