using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mascotas.App.Dominio.Entidades
{
    public class ClaseVisitaVeterinaria
    {
        public int Id { get;set; }
        public string FechaVisita { get; set;}
        public ClaseEstadoMascota estadoMascota { get; set;}
        public int IdVeterinario { get; set;}
        public string Recomendaciones { get; set;} 
        public string medicamentos { get;set; }    
    }
}