using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
///utilizar las listas
using System.Collections.Generic;


namespace Mascotas.App.Dominio.Entidades
{
    public class ClaseListaVisitas
    {
        [ForeignKey(nameof(IdVisitas))]
        public int IdVisitas { get;set; }
        [ForeignKey(nameof(IdentificacionMedico))]
        public int IdentificacionMedico { get;set; }
        public int NombreMascota { get;set; }
        [ForeignKey(nameof(IdDueno))]
        public int IdDueno { get;set; }
        /**public list<ClaseVisitaVeterinaria> listaVisita { get; set;}
        public void almacenasvisitas(id)
        {
            if id = IdVisitas{
                listaVisita.add(temperatura,peso,frecuenciaRespiratoria,frecuenciaCardiaca,EstadoDeAnimo,fechaVisita,IdVeterinario, Recomendaciones);
            }
        } */
    }
}