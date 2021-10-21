using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mascotas.App.Dominio.Entidades
{
    public class ClasePersona
    {
        ///[ForeignKey(nameof(Identificacion))]
        [Key]
        [Column("Identificacion")]
        [StringLength(15,MinimumLength=5)]
        public long Identificacion { get;set; }
        [Required]
        [Column("Nombre")]
        [StringLength(30,MinimumLength=5)]
        public string Nombre { get;set; }
        [Required]
        [Column("Apellido")]
        [StringLength(30,MinimumLength=5)]
        public string Apellido { get;set; }
        [Required]
        [Column("NumeroTelefono")]
        [StringLength(12,MinimumLength=5)]
        public string NumeroTelefono { get;set; }
        
        public ClasePersona(){}
    }
}