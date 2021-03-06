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
        [Column("identificacion")]
        public int identificacion { get;set; }
        [Required]
        [Column("nombre")]
        [StringLength(30,MinimumLength=5)]
        public string nombre { get;set; }
        [Required]
        [Column("apellido")]
        [StringLength(30,MinimumLength=5)]
        public string apellido { get;set; }
        [Required]
        [Column("numeroTelefono")]
        [StringLength(12,MinimumLength=5)]
        public string numeroTelefono { get;set; }
        
        public ClasePersona(){}
    }
}