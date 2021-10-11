using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
///utilizar las listas
using System.Collections.Generic;

namespace Mascotas.App.Dominio.Entidades
{
    public class ClaseListaMascota
    {
        public int Id { get; set;}
        ///[ForeignKey(nameof(IdDueno))]
        ///[Key]
        public int IdDueno { get;set; }
        ///[ForeignKey(nameof(Lecture))]
        ///[ForeignKey(Lecture)]
        public int IdMascotas { get;set; }    
        /**public list<ClaseMascotas> listaMascota { get;set; } 
        public void almacenasMascotasDueno(id)
        {
            if id = idDueño{
                listaMascota.add(id,Nombre);
            }
        }*/     
    }
}