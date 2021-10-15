using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mascotas.App.Dominio.Entidades
{
    public class ClaseDuenoMascota:ClasePersona
    {
        ///[ForeignKey(nameof(Id))]
        ///[Key]
        public string Direccion { get;set; }
        public ClaseMascota Mascotas { get; set;}

        //Constructor
        public ClaseDuenoMascota(){}
    }
}