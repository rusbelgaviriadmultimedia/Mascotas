using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mascotas.App.Dominio.Entidades;
namespace Mascotas.App.Persistencia.AppRepositorios
{
    public class RepositorioDuenoMascota:IRepositorioDuenoMascota
    {
        /// <summary>
        /// Referencia al contexto de ClaseDuenoMascota
        /// <summary>
        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo constructor utiliza
        /// Inyección de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="AppContext"></param>//
        public RepositorioDuenoMascota(AppContext appContext)
        {
            _appContext = appContext;
        }
       
        ClaseDuenoMascota IRepositorioDuenoMascota.AddClaseDuenoMascota(ClaseDuenoMascota DuenoMascota)
        {
            var  DuenoMascotaAdicionado = _appContext.ClaseDuenoMascota.Add(DuenoMascota);
            _app.Context.SaveChanges();
            return DuenoMascotaAdicionado.Entity;
        }
        ClaseDuenoMascota IRepositorioDuenoMascota.DeleteClaseDuenoMascota(int IdDuenoMascota)
        {
            var DuenoMascotaEncontrado = _appContext.ClaseDuenoMascota.FirstOrDefault(p => p.Id==IdDuenoMascota);
            if(DuenoMascotaEncontrado==null)
            return;
            _appContext.DuenoMascota.Remove(DuenoMascotaEncontrado);
            _app.Context.SaveChanges();

        }
        IEnumerable<ClaseDuenoMascota> IRepositorioDuenoMascota.GetAllDuenoMascota()
        {
            return _appContext.DuenoMascota;
        }
        
        ClaseDuenoMascota IRepositorioDuenoMascota.GetClaseDuenoMascota(int Id)
        {
            return  _appContext.ClaseDuenoMascota.FirstOrDefault(p => p.Id==IdDuenoMascota);
            
        }
        
        ClaseDuenoMascota IRepositorioDuenoMascota.UpdateClaseDuenoMascota(ClaseDuenoMascota DuenoMascota)
        {
            var DuenoMascotaEncontrado = _appContext.ClaseDuenoMascota.FirstOrDefault(p => p.Id == IdDuenoMascota);
            if(DuenoMascotaEncontrado != null)
            {
                DuenoMascotaEncontrado.Nombre=DuenoMascota.Nombre;
                DuenoMascotaEncontrado.Apellido=DuenoMascota.Apellido;
                DuenoMascotaEncontrado.NumeroTelefono=DuenoMascota.NumeroTelefono;
                DuenoMascotaEncontrado.Direccion=DuenoMascota.Direccion;
                DuenoMascotaEncontrado.UpdateDuenoMasscota=DuenoMascota.UpdateDuenoMasscota;
            }

        }
    }
}