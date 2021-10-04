using System;

namespace Mascotas.App.Dominio
{
    public class Clase_VisitaVeterinaria
    {
        public int IdVisitaVeterinaria { get;set; }
        public string Fechavisita { get; set;}
        public float TemperaturaMascota { get; set;}
        public float PesoMascota { get; set;}
        public int FrecuenciaRespiratoria { get; set;}
        public float FrecuanciaCardiacaMascota { get; set;}
        public string EstadoAnimoMascota { get; set;}
        public int IdVeterinario { get; set;}
        public string Recomendaciones { get; set;}     
    }
}