using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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