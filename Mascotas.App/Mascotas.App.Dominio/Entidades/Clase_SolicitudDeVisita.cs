using System;

namespace Mascotas.App.Dominio
{
    public class Clase_DuenoMascota
    {
        public int IdSolicitudDeVisita { get;set; }
        public Int IdDueñoMascota { get; set;}
        public Mascota Mascota { get; set;}
        public MedicoVeterinario Veterinario {get; set;}
        public FechaEstimadaDeVisita FechaVisita{ get; set;}       
    }
}