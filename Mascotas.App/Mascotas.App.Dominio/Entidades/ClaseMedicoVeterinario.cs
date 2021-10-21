using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mascotas.App.Dominio.Entidades
{
    public class ClaseMedicoVeterinario:ClasePersona
    {
        ///[ForeignKey(nameof(TarjetaProfesional))]
        ///[
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