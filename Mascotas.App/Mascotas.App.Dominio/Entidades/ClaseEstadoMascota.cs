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
        [Key]
        public long Id {get; set;}
         [Required]
        [Column("TemperaturaMascota")]
        [StringLength(10,MinimumLength=2)]
        public string Temperatura { get;set; }
        [Required]
        [Column("PesoMascota")]
        [StringLength(10,MinimumLength=2)]
        public string Peso { get;set; }
        [Required]
        [Column("FrecuenciaRepiratoriaMascota")]
        [StringLength(10,MinimumLength=2)]
        public string FrecuenciaRespiratoria { get;set; }
        [Required]
        [Column("FrecuenciaCardiacaMascota")]
        [StringLength(10,MinimumLength=2)]
        public string FrecuenciaCardiaca { get;set; }
        [Required]
        [Column("EstadoAnimoMascota")]
        [StringLength(20,MinimumLength=5)]
        public string EstadoDeAnimo { get;set; }

        //Constructor
        public ClaseEstadoMascota(){}
    }
}