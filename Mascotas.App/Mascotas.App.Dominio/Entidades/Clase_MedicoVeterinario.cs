namespace Mascotas.App.Dominio.Entidades
{
    public class Clase_MedicoVeterinario:Clase_Persona
    {
        public int IdMedicoVeterinario { get;set; }
        public string TarjetaProfesional { get; set; }
        public string Especializacion { get; set; }
    }
}