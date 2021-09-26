using Microsoft.EntityFrameworkCore;

namespace Mascotas.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas {get;set;}
    }
}