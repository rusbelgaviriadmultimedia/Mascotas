using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mascotas.App.Dominio.Entidades
{
    public class ClaseSolicitudDeVisita
    {
        public string IdentificacionDuenoMascota { get;set; }
        public ClaseListaMascota listaMascota { get;set; }
        public ClaseTipoAnimal tipoAnimal { get;set; }
        public ClaseListaMedicos listaMedicos { get;set; }
    }
}