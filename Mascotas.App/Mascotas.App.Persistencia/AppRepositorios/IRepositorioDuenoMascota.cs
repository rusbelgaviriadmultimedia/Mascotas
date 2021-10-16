using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mascotas.App.Dominio.Entidades;

namespace Mascotas.App.Persistencia.AppRepositorios
{
    public interface IRepositorioDuenoMascota
    {
        IEnumerable<ClaseDuenoMascota> GetAllDuenoMascota();
        ClaseDuenoMascota AppClaseDuenoMascota(ClaseDuenoMascota DuenoMascota);
        ClaseDuenoMascota UpdateClaseDuenoMascota(ClaseDuenoMascota DuenoMascota);
        void DeleteClaseDuenoMascota(int Id);
        ClaseDuenoMascota GetClaseDDuenoMascota(int Id);
    }
}