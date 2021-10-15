using Microsoft.EntityFrameworkCore;
using Mascotas.App.Dominio.Entidades;

namespace Mascotas.App.Persistencia
{
    /// <summary>
    //Propiedad
    /// </summary>
    public class ApplicationDbContext : DbContext
    {
        public DbSet<ClaseMedicoVeterinario> MedicoVeterinario {get;set;}
        public DbSet<ClaseDatosDuenos> DuenoMascota {get;set;}
        ///El tipo 'ClaseTipoAnimal' debe ser un tipo de referencia para poder usarlo como parámetro
        /// ///public DbSet<ClaseTipoAnimal> TipoAnimal {get;set;}
        public DbSet<ClaseMascota > Mascota {get;set;}
        public DbSet<ClaseVisitaVeterinaria > VisitaVeterinaria {get;set;}
        public DbSet<ClaseEmpresa> Empresa {get;set;}
        public DbSet<ClaseEstadoMascota> estadoMascota {get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            //cadena de conexion
            {
                ///optionsBuilder.UseSqlServer("Data Source = FINA; Initial Catalog = HospiEnCasa;User Id=FINA\Familia; password=''")
                //optionsBuilder.UseSqlServer(@"Server = (localdb)\\mssqllocaldb; Database = Mascotas");
                optionsBuilder.UseSqlServer(" Data Source = FINA; Initial Catalog = Mascotas; User=Root;Password= ");
            }
        }
    }
}