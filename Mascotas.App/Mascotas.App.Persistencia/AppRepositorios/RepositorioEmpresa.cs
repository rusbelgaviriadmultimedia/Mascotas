using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mascotas.App.Dominio.Entidades;
using Mascotas.App.Persistencia.AppRepositorios;


namespace Mascotas.App.Persistencia.AppRepositorios
{
    /*public class RepositorioEmpresa:IRepositorioEmpresa
    {
        ///<sumary>
        /// Referencia al contexto del paciente
        /// </sumary>
        
        //private readonly ApplicationDbContext appContext;
        ///<sumary>
        /// Metodo constructor a utilizar
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </sumary>
        ///<param name="appContext"></param>//

        public RepositorioEmpresa(AppContext appContext)
        {
            this._appContext=appContext;
        }*/

        //Implementando la funcionalidad al metodo de la interface
        /*public ClaseEmpresa AddClasEmpresa(ClaseEmpresa empresa)
        {
            //Insert
            using( ApplicationDbContext _appContext =new ApplicationDbContext{} ){ 
                //EmpresaAdicionada objEmpresa= -appContext.Empresas({
                    //Nit = 12345,
                    //RazonSocial = "Pepito",
                   // Direccion = "c343k23"

                //})
                //Persona._appContex.Add(Objpersona);
                //_appContext.SaveChanges();

                var EmpresaAdicionada= _appContext.empresas.Add(empresa);
                _appContext.SaveChanges();
                return EmpresaAdicionada.Entity;
            }
        }
        public void DeleteClaseEmpresa(int Id)
        {
            using( ApplicationDbContext _appContext =new ApplicationDbContext{} ){ 
                var EmpresaAdicionada=(from em in _appContext.empresas where em.Id==Id select em);
                //var EmpresaAdicionada= _appContext.Empresas.FirstOrDefault(ev => ev.Id==Id);
                if (EmpresaAdicionada == null)
                return;
                _appContext.empresas.Remove(EmpresaAdicionada);
                _appContext.SaveChanges();
            }
        }

        //Consultar todas las Personas
        public IEnumerable<ClaseEmpresa> GetAllEmpresa()
        {
            using( ApplicationDbContext _appContext =new ApplicationDbContext{} )
             { 
                 //Error Tolistt no esta implementada.
                //var ListaEmpresa =(from em in _appContext.Empresas select em).Tolist();
                //return ListaEmpresa;
                return _appContext.empresas;
             }
        }

        //Consultar una persona segun su Id y retornar
        public ClaseEmpresa GetClaseEmpresa(int Id)
        {
            //Estructura video:
           // return _appContext.Empresa.FirstOrDefault(ev => ev.Id==IdEmpresa);
             using( ApplicationDbContext _appContext =new ApplicationDbContext{} )
             { 
                //var EmpresaAdicionada= _appContext.Empresa.FirstOrDefault(ev => ev.Id==Empresa.Id);
                var EmpresaAdicionada=(from em in _appContext.empresas where em.Id==Id select em);
                //var EmpresEncontrada=(from em in _appContext.Empresas).where (em=>em.Id=Empresa.Id);                
                return EmpresaEncontrada.Entity;
             }
        }



        //Implementar lo de actualizar para la Empresas
        public ClaseEmpresa UpdateClasEmpresa(ClaseEmpresa empresas)
        {
            using( ApplicationDbContext _appContext =new ApplicationDbContext{} )
            {
                //var EmpresaAdicionada= _appContext.Empresas.FirstOrDefault(ev => ev.Id==Empresa.Id);
                //linq:Lenguaje estructurado
                //var EmpresEncontrada=(from em in _appContext.Empresas).where (em=>em.Id=Empresa.Id);
                var EmpresaAdicionada=(from em in _appContext.empresas where em.Id==Id select em);
                //if (EmpresaEncontrada!= null)
                if (!(EmpresaEncontrada == null))
                {
                    EmpresaEncontrada.Nit=empresa.Nit;
                    EmpresaEncontrada.RazonSocial=empresa.RazonSocial;
                    EmpresaEncontrada.Direccion=empresa.Direccion;
                }
                _appContext.SaveChanges();
                return EmpresaEncontrada;
                
            }
        }
        
    }*/
}