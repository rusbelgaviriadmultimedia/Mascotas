using Microsoft.EntityFrameworkCore;
using Mascotas.App.Dominio.Entidades;

namespace Mascotas.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<ClasePersona> Persona {get;set;}
        public DbSet<ClaseMedicoVeterinario> MedicoVeterinario {get;set;}
        public DbSet<ClaseDatosDuenos> DuenoMascota {get;set;}
        public DbSet<ClaseSolicitudDeVisita> SolicitudDeVisita {get;set;}
        ///El tipo 'ClaseTipoAnimal' debe ser un tipo de referencia para poder usarlo como parámetro
        /// ///public DbSet<ClaseTipoAnimal> TipoAnimal {get;set;}
        public DbSet<ClaseMascota > Mascota {get;set;}
        public DbSet<ClaseVisitaVeterinaria > VisitaVeterinaria {get;set;}
        public DbSet<ClaseEmpresa> Empresa {get;set;}
        public DbSet<ClaseEstadoMascota> estadoMascota {get;set;}
        public DbSet<ClaseListaMascota> listaMascota {get;set;}
        public DbSet<ClaseListaMedicos> listaMedicos {get;set;}
        public DbSet<ClaseListaVisitas> ListaVisitas {get;set;}
    }
}