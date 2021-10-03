using System;

namespace Mascotas.App.Dominio
{
    public class MedicoVeterinario:persona
    {
        public int IdMedicoVeterinario { get;set; }
        public string TarjetaProfesional { get; set; }
        public string Especializacion { get; set; }
    }
}