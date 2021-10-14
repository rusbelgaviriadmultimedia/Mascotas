using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mascotas.App.Dominio.Entidades
{
    public class ClaseVisitaVeterinaria
    {
        ///[ForeignKey(nameof(Id))]
        ///[Key]
        public long Id { get;set; }
        public string FechaVisita { get; set;}
        public ClaseEstadoMascota EstadoMascota { get; set;}
        [ForeignKey(Lecture)]
        public virtual int IdVeterinario { get; set;}
        public string Recomendaciones { get; set;} 
        public string medicamentos { get;set; }  


        public ClaseVisitaVeterinaria(){}
    }
}