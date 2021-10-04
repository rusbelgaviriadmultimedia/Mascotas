using Microsoft.EntityFrameworkCore;
using Mascotas.App.Dominio.Entidades;

namespace Mascotas.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Clase_Persona> Persona {get;set;}
        public DbSet<Clase_MedicoVeterinario> MedicoVeterinario {get;set;}
        public DbSet<Clase_DuenoMascota> DuenoMascota {get;set;}
        public DbSet<Clase_SolicitudDeVisita> SolicitudDeVisita {get;set;}
        public DbSet<Clase_TipoAnimal> TipoAnimal {get;set;}
        public DbSet<Clase_Mascota > Mascota {get;set;}
        public DbSet<Clase_VisitaVeterinaria > VisitaVeterinaria {get;set;}
        public DbSet<Clase_Empresa> Empresa {get;set;}
        
    }
}