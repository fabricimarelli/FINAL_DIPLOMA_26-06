namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tercera_updatClases : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cursoes",
                c => new
                    {
                        ID_curso = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        activo = c.Boolean(nullable: false),
                        horasVoladas = c.Decimal(nullable: false, precision: 18, scale: 2),
                        aeronave_ID_aeronave = c.Int(),
                        alumno_ID_socio = c.Int(),
                    })
                .PrimaryKey(t => t.ID_curso)
                .ForeignKey("dbo.Aeronaves", t => t.aeronave_ID_aeronave)
                .ForeignKey("dbo.Socios", t => t.alumno_ID_socio)
                .Index(t => t.aeronave_ID_aeronave)
                .Index(t => t.alumno_ID_socio);
            
            CreateTable(
                "dbo.Socios",
                c => new
                    {
                        ID_socio = c.Int(nullable: false, identity: true),
                        fechaAdmision = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        nombre = c.String(),
                        apellido = c.String(),
                        DNI = c.Int(nullable: false),
                        fechaNacimiento = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        domicilio = c.String(),
                        celular = c.String(),
                        email = c.String(),
                        fotoPersona = c.Binary(),
                        esPiloto = c.Boolean(),
                        horasVoladas = c.Decimal(precision: 18, scale: 2),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ID_socio);
            
            CreateTable(
                "dbo.Mantenimientoes",
                c => new
                    {
                        ID_mantenimiento = c.Int(nullable: false, identity: true),
                        fechaInicio = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        fechaFin = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        trabajos = c.String(),
                        estado = c.String(),
                        aeronave_ID_aeronave = c.Int(),
                    })
                .PrimaryKey(t => t.ID_mantenimiento)
                .ForeignKey("dbo.Aeronaves", t => t.aeronave_ID_aeronave)
                .Index(t => t.aeronave_ID_aeronave);
            
            CreateTable(
                "dbo.Reservas",
                c => new
                    {
                        ID_reserva = c.Int(nullable: false, identity: true),
                        fecha = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        desde = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        hasta = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        aeronave_ID_aeronave = c.Int(),
                        Piloto_ID_socio = c.Int(),
                    })
                .PrimaryKey(t => t.ID_reserva)
                .ForeignKey("dbo.Aeronaves", t => t.aeronave_ID_aeronave)
                .ForeignKey("dbo.Socios", t => t.Piloto_ID_socio)
                .Index(t => t.aeronave_ID_aeronave)
                .Index(t => t.Piloto_ID_socio);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        ID_usuario = c.Int(nullable: false, identity: true),
                        nombreUsuario = c.String(),
                        email = c.String(),
                        admin = c.Boolean(nullable: false),
                        password = c.String(),
                        socio_ID_socio = c.Int(),
                    })
                .PrimaryKey(t => t.ID_usuario)
                .ForeignKey("dbo.Socios", t => t.socio_ID_socio)
                .Index(t => t.socio_ID_socio);
            
            CreateTable(
                "dbo.Vueloes",
                c => new
                    {
                        ID_vuelo = c.Int(nullable: false, identity: true),
                        taquimSalida = c.Decimal(nullable: false, precision: 18, scale: 2),
                        taquimLlegada = c.Decimal(nullable: false, precision: 18, scale: 2),
                        tiempo = c.Decimal(nullable: false, precision: 18, scale: 2),
                        tarifa = c.Decimal(nullable: false, precision: 18, scale: 2),
                        fechaVuelo = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        observaciones = c.String(),
                        tarifaIns = c.Decimal(precision: 18, scale: 2),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        aeronave_ID_aeronave = c.Int(),
                        piloto_ID_socio = c.Int(),
                        alumno_ID_socio = c.Int(),
                    })
                .PrimaryKey(t => t.ID_vuelo)
                .ForeignKey("dbo.Aeronaves", t => t.aeronave_ID_aeronave)
                .ForeignKey("dbo.Socios", t => t.piloto_ID_socio)
                .ForeignKey("dbo.Socios", t => t.alumno_ID_socio)
                .Index(t => t.aeronave_ID_aeronave)
                .Index(t => t.piloto_ID_socio)
                .Index(t => t.alumno_ID_socio);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vueloes", "alumno_ID_socio", "dbo.Socios");
            DropForeignKey("dbo.Vueloes", "piloto_ID_socio", "dbo.Socios");
            DropForeignKey("dbo.Vueloes", "aeronave_ID_aeronave", "dbo.Aeronaves");
            DropForeignKey("dbo.Usuarios", "socio_ID_socio", "dbo.Socios");
            DropForeignKey("dbo.Reservas", "Piloto_ID_socio", "dbo.Socios");
            DropForeignKey("dbo.Reservas", "aeronave_ID_aeronave", "dbo.Aeronaves");
            DropForeignKey("dbo.Mantenimientoes", "aeronave_ID_aeronave", "dbo.Aeronaves");
            DropForeignKey("dbo.Cursoes", "alumno_ID_socio", "dbo.Socios");
            DropForeignKey("dbo.Cursoes", "aeronave_ID_aeronave", "dbo.Aeronaves");
            DropIndex("dbo.Vueloes", new[] { "alumno_ID_socio" });
            DropIndex("dbo.Vueloes", new[] { "piloto_ID_socio" });
            DropIndex("dbo.Vueloes", new[] { "aeronave_ID_aeronave" });
            DropIndex("dbo.Usuarios", new[] { "socio_ID_socio" });
            DropIndex("dbo.Reservas", new[] { "Piloto_ID_socio" });
            DropIndex("dbo.Reservas", new[] { "aeronave_ID_aeronave" });
            DropIndex("dbo.Mantenimientoes", new[] { "aeronave_ID_aeronave" });
            DropIndex("dbo.Cursoes", new[] { "alumno_ID_socio" });
            DropIndex("dbo.Cursoes", new[] { "aeronave_ID_aeronave" });
            DropTable("dbo.Vueloes");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Reservas");
            DropTable("dbo.Mantenimientoes");
            DropTable("dbo.Socios");
            DropTable("dbo.Cursoes");
        }
    }
}
