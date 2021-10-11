using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
///utilizar las listas
using System.Collections.Generic;


namespace Mascotas.App.Dominio.Entidades
{
    public class ClaseListaMedicos
    {   public int Id {get; set;}
        ///[ForeignKey(Lecture)]
        public int IdMedicos { get; set; }
        ///[ForeignKey(Lecture)]
        public string IdentificacionMedico { get; set; }
        /**public list<ClaseMedicoVeterinario> listaMedicoVeterinario{ get; set; }
        public void almacenasmedicos(id)
        {
            if id = idMedicos{
                listaMedicoVeterinario.add(Nombre,tipoAnimal);
            }
        } */
    }
}