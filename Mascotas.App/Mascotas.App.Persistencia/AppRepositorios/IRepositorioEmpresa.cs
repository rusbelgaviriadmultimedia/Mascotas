using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mascotas.App.Dominio.Entidades;


namespace Mascotas.App.Persistencia.AppRepositorios
{
    public interface IRepositorioEmpresa
    {
        
        IEnumerable<ClaseEmpresa> GetAllDatosDuenos();
        ClaseEmpresa AppClaseDatosDueno(ClaseEmpresa DuenoMascota);
        ClaseEmpresa UpdateClaseDatosDueno(ClaseEmpresa DuenoMascota);
        void DeleteClaseDatosDueno(int Id);
        ClaseEmpresa GetClaseDatosDuenos(int Id);
    
    }
}