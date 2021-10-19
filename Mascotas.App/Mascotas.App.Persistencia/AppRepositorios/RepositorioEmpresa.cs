using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mascotas.App.Dominio.Entidades;

namespace Mascotas.App.Persistencia.AppRepositorios
{
    public class RepositorioEmpresa:IRepositorioEmpresa
    {
        ///<sumary>
        /// Referencia al contexto del paciente
        /// </sumary>
        
        private readonly AppContext appContext;
        ///<sumary>
        /// Metodo constructor a utilizar
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </sumary>
        ///<param name="appContext"></param>//

        /*public RepositorioEmpresa(AppContext appContext)
        {
            this._appContext=appContext;
        }*/

        //Implementando la funcionalidad al metodo de la interface
        public ClaseEmpresa AddEmpresa(ClaseEmpresa Empresa)
        {
            //Insert
            using( AppContext _appContext =new AppContext{} ){ 
                var EmpresaAdicionada= _appContext.Empresa.Add(Empresa);
                _appContext.SaveChanges();
                return EmpresaAdicionada.Entity;
            }
        }
        public void DeleteEmpresa(long IdEmpresa)
        {
            var EmpresaAdicionada= _appContext.Empresa.FirstOrDefault(ev => ev.Id==IdEmpresa);
            if (EmpresaAdicionada == null)
            return ;
            _appContext.Empresa.Remove(EmpresaAdicionada);
            _appContext.SaveChanges();
        }

        //Consultar todas las Personas
        public IEnumerable<ClaseEmpresa> GetAllEmpresa()
        {
            //return _appContext.Empresa;
             using( AppContext _appContext =new AppContext{} )
             { 
                var EmpresaAdicionada =(from em in _appContext.Empresa select em).Tolist;
                return EmpresaAdicionada;
             }
        }

        //Consultar una persona segun su Id y retornar
        public ClaseEmpresa GetEmpresa(int IdEmpresa)
        {
            //Estructura video:
           // return _appContext.Empresa.FirstOrDefault(ev => ev.Id==IdEmpresa);
             using( AppContext _appContext =new AppContext{} )
             { 
                var EmpresaAdicionada= _appContext.Empresa.FirstOrDefault(ev => ev.Id==Empresa.Id);
                return EmpresaAdicionada.Entity;
             }
        }

        //Implementar lo de actualizar para la Empresas
        public ClaseEmpresa UpdateEmpresa(ClaseEmpresa Empresa)
        {
            using( AppContext _appContext =new AppContext{} )
            {
                //var EmpresaAdicionada= _appContext.Empresa.FirstOrDefault(ev => ev.Id==Empresa.Id);
                //linq:Lenguaje estructurado
                var EmpresaAdicionada=(from p in _appContext.Empresa).where (em=>em.Id=Empresa.Id);
                //if (EmpresaEncontrada!= null)
                if (!(EmpresaEncontrada == null))
                {
                    EmpresaAdicionada.Nit=Empresa.Nit;
                    EmpresaAdicionada.RazonSocial=Empresa.RazonSocial;
                    EmpresaAdicionada.Direccion=Empresa.Direccion;
                }
                _appContext.SaveChanges();
                return EmpresaAdicionada;
                
            }
        }
        
    }
}