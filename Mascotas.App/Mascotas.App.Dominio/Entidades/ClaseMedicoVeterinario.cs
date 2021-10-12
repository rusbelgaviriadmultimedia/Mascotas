using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mascotas.App.Dominio.Entidades
{
    public class ClaseMedicoVeterinario:ClasePersona
    {
        ///[ForeignKey(nameof(TarjetaProfesional))]
        ///[Key]
        public long Id { get; set;}
        public string TarjetaProfesional { get; set; }
        public ClaseTipoAnimal TipoAnimal { get; set; }

        /**public string selectTipoMascota(int)
        { switch (select)
        {
            case "1":
               string tipo = ClaseTipoAnimal.Gato;
                break;
            case "2":
                string tipo = ClaseTipoAnimal.Pajaro;
                break;
            case "3":
                string tipo = ClaseTipoAnimal.perro;
                break;
            default:
               string tipo = string none;
                break;
        return tipo;
        }
        

        }*/
        public ClaseMedicoVeterinario(){}
    }
}