using Microsoft.EntityFrameworkCore;

namespace Mascotas.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas {get;set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionBuilder.IsConfigured)
        {
            optionBuilder

            .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Mascotas.Data");
        }
    }
    }
}