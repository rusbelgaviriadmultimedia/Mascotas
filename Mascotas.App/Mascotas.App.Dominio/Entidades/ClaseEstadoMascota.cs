using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mascotas.App.Dominio.Entidades
{
    public class ClaseEstadoMascota
    {
        public string temperatura { get;set; }
        public string peso { get;set; }
        public string frecuenciaRespiratoria { get;set; }
        public string frecuenciaCardiaca { get;set; }
        public string EstadoDeAnimo { get;set; }
    }
}