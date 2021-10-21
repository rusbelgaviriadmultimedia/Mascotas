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
        ///[Key]
        public long Id { get; set;}
        public string Identificacion { get;set; }
        public string Nombre { get;set; }
        public string Apellido { get;set; }
        public string NumeroTelefono { get;set; }
        
        public ClasePersona(){}
    }
}