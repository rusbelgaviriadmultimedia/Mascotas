using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mascotas.App.Dominio.Entidades
{
    public class ClasePersona
    {
        [ForeignKey(nameof(Identificacion))]
        public string Identificacion { get;set; }
        public string Nombre { get;set; }
        public string Apellido { get;set; }
        public string NumeroTelefono { get;set; }
    }
}