using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mascotas.App.Dominio.Entidades
{
    public class ClaseEstadoMascota
    {
        ///[ForeignKey(nameof(Id))]
        ///[Key]
        public long Id {get; set;}
        public string Temperatura { get;set; }
        public string Peso { get;set; }
        public string FrecuenciaRespiratoria { get;set; }
        public string FrecuenciaCardiaca { get;set; }
        public string EstadoDeAnimo { get;set; }

        //Constructor
        public ClaseEstadoMascota(){}
    }
}