using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mascotas.App.Dominio.Entidades
{
    public class ClaseSolicitudDeVisita
    {
        ///[ForeignKey(nameof(IdentificacionDuenoMascota))]
        ///[Key]
        public long Id { get; set;}
        public string IdentificacionDuenoMascota { get;set; }
        public ClaseListaMascota listaMascota { get;set; }
        public ClaseTipoAnimal TipoAnimal { get;set; }
        public ClaseListaMedicos ListaMedicos { get;set; }
    }
}