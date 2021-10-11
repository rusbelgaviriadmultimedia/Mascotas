using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mascotas.App.Dominio.Entidades
{
    public class ClaseDatosDuenos:ClasePersona
    {
        ///[ForeignKey(nameof(Id))]
        ///[Key]
        public long Id { get;set; }
        public string Direccion { get;set; }
        public ClaseListaMascota ListaMascotas { get;set; }
    }
}