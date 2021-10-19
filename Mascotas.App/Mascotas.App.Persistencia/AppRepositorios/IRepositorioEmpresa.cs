using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mascotas.App.Dominio.Entidades;


namespace Mascotas.App.Persistencia.AppRepositorios
{
   public interface IRepositorioEmpresa
    {
        //firma de los metodos
        // Ejemplo : descriptores de acceso (public, private, proted), valor de retorno tipo de variable, Nombre del metodo, variables de entrada. 
        
        //
        IEnumerable<ClaseEmpresa> GetAllEmpresa();

        //Ingresar información a la base de datos a la tabla E
        ClaseEmpresa AddClasEmpresa(ClaseEmpresa Empresa);

        //firma del metodo para actualizar información.
        ClaseEmpresa UpdateClasEmpresa(ClaseEmpresa Empresa);

        void DeleteClaseEmpresa(long Id);

        //Consultar una Empresa segun Id.
        ClaseEmpresa GetClaseEmpresa(long Id);
    
    }
}