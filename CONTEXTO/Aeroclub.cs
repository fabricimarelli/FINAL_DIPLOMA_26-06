using System;
using System.Data.Entity;
using System.Linq;

namespace CONTEXTO
{
    public class Aeroclub : DbContext
    {

        //AGREGO EL PATRON SINGLETON PARA TRABAJAR CON UNA UNICA INSTANCIA DEL CONTEXTO
        private static Aeroclub instancia;

        public static Aeroclub obtener_instancia()
        {
            if (instancia == null)
                instancia = new Aeroclub();

            return instancia;
        }
        // El contexto se ha configurado para usar una cadena de conexión 'Model1' del archivo 
        // de configuración de la aplicación (App.config o Web.config). De forma predeterminada, 
        // esta cadena de conexión tiene como destino la base de datos 'CONTEXTO.Model1' de la instancia LocalDb. 
        // 
        // Si desea tener como destino una base de datos y/o un proveedor de base de datos diferente, 
        // modifique la cadena de conexión 'Model1'  en el archivo de configuración de la aplicación.
        public Aeroclub()
            : base("name=Aeroclub")
        {
        }

        // Agregue un DbSet para cada tipo de entidad que desee incluir en el modelo. Para obtener más información 
        // sobre cómo configurar y usar un modelo Code First, vea http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<MODELO.Socio> Socios { get; set; }
        public virtual DbSet<MODELO.Usuario> Usuarios { get; set; }
        public virtual DbSet<MODELO.Aeronave> Aeronaves { get; set; }
        public virtual DbSet<MODELO.Mantenimiento> Mantenimientos { get; set; }
        public virtual DbSet<MODELO.Vuelo> Vuelos { get; set; }
        public virtual DbSet<MODELO.Reserva> Reservas { get; set; }
        public virtual DbSet<MODELO.Curso> Cursos { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MODELO.Socio>()
                .HasKey(_ => _.ID_socio);
            modelBuilder.Properties<DateTime>().Configure(c => c.HasColumnType("datetime2"));
            modelBuilder.Entity<MODELO.Usuario>()
                .HasKey(_ => _.ID_usuario);
            modelBuilder.Entity<MODELO.Aeronave>()
                .HasKey(_ => _.ID_aeronave);
            modelBuilder.Entity<MODELO.Mantenimiento>()
                .HasKey(_ => _.ID_mantenimiento);
            modelBuilder.Entity<MODELO.Vuelo>()
               .HasKey(_ => _.ID_vuelo);
            modelBuilder.Entity<MODELO.Reserva>()
               .HasKey(_ => _.ID_reserva);
            modelBuilder.Entity<MODELO.Curso>()
               .HasKey(_ => _.ID_curso);
        }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}