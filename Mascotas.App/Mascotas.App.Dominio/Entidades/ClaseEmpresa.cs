using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mascotas.App.Dominio.Entidades
{
    public class ClaseEmpresa
    {
        ///[ForeignKey(nameof(Nit))]
        ///[Key]
        /// 
        public int Id { get; set;}
        public string Nit { get; set;}
        public string RazonSocial {get;set;}        
        public string Direccion { get; set; }
        ///public ClaseListaMedicos listaMedicos { get; set; }

        //Constructor
        public ClaseEmpresa(){}
    }
}