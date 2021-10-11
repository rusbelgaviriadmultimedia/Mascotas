using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mascotas.App.Dominio.Entidades
{
    public class ClaseEmpresa
    {
        [ForeignKey(nameof(Nit))]
        public string Nit { get; set;}
        public string RazonSocial {get;set;}        
        public string Direccion { get; set; }
        ///public ClaseListaMedicos listaMedicos { get; set; }
    }
}