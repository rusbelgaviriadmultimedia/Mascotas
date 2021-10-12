using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Mascotas.App.Dominio.Entidades
{
    public class ClaseMascota
    {
        ///[Key]
        public long Id { get;set; }
        public string Nombre { get; set;}
        public string ColorDeOjos { get;set; }
        public string ColorDePiel { get;set; }
        public float Estatura{get; set;}
        public string Raza { get; set;} 
        public ClaseTipoAnimal tipoAnimal { get; set;} 

        public ClaseMascota(){}  
    }
}