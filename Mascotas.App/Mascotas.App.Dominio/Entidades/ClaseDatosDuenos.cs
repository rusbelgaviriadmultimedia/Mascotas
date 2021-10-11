using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mascotas.App.Dominio.Entidades
{
    public class ClaseDatosDuenos:ClasePersona
    {
        public int Id { get;set; }
        public string direccion { get;set; }
        public ClaseListaMascota listaMascotas { get;set; }
    }
}