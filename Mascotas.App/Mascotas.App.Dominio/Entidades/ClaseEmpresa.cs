using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mascotas.App.Dominio.Entidades
{
    [Table("EmpresaDb")] 
    public class ClaseEmpresa
    {
        ///[ForeignKey(nameof(Nit))]

        /// 
        //public int Id { get; set;}
         
        [Column("Nit")]
        [Key]
        public long Nit { get; set;}
        [Required]
        [Column("RazonSocial")]
        [StringLength(50,MinimumLength=5)]
        public string RazonSocial {get;set;} 
        [Required]
        [Column("DirecionEmpresa")]
        [StringLength(30,MinimumLength=5)]      
        public string Direccion { get; set; }
        [ForeignKey("TarjetaProfesional")]
        public virtual ClaseMedicoVeterinario MedicoVeterinario { get; set; }

        //Constructor
        public ClaseEmpresa(){}
    }
}