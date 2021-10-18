using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ProySGA.App.Dominio.Entidades;
using ProySGA.App.Persistencia;
using ProySGA.App.Persistencia.AppRepositorios;

namespace ProySGA.App.Persistencia.AppRepositorios
{

    public class RepositorioEstudiante : IRepositorioEstudiante
    {
        /// <summary>
        /// Referencia al contexto de Paciente
        /// </summary>
        private readonly AppContext _appContext;
        public IEnumerable<Estudiante> estudiantes {get; set;}
        /// <summary>
        /// Metodo Constructor Utiiza 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//
        public RepositorioEstudiante(AppContext appContext)
        {
            _appContext = appContext;
        }

        
        Estudiante IRepositorioEstudiante.AddEstudiante(Estudiante estudiante)
        {
            try
            {
            var estudianteAdicionado = _appContext.Estudiantes.Add(estudiante);
            _appContext.SaveChanges();
            return estudianteAdicionado.Entity;
            }catch
            {
                throw;
            }

        }

        void IRepositorioEstudiante.DeleteEstudiante(int idEstudiante)
        {
            var estudianteEncontrado = _appContext.Estudiantes.FirstOrDefault(p => p.id == idEstudiante);
            if (estudianteEncontrado == null)
                return;
            _appContext.Estudiantes.Remove(estudianteEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Estudiante> IRepositorioEstudiante.GetAllEstudiantes(string? searchString)
        {
            if(searchString == null)
            {
                estudiantes = _appContext.Estudiantes;
            }
            else
            {
                estudiantes = _appContext.Estudiantes.Where(s => s.nombres.Contains(searchString));
            }
            return estudiantes;//_appContext.Estudiantes;
        }

        Estudiante IRepositorioEstudiante.GetEstudiante(int? idEstudiante)
        {
            return _appContext.Estudiantes.FirstOrDefault(p => p.id == idEstudiante);
        }

       Estudiante IRepositorioEstudiante.UpdateEstudiante(Estudiante estudiante)
        {
            var estudianteEncontrado = _appContext.Estudiantes.FirstOrDefault(p => p.id == estudiante.id);
            if (estudianteEncontrado != null)
            {
                estudianteEncontrado.nombres = estudiante.nombres;
                estudianteEncontrado.apellidos = estudiante.apellidos;
                estudianteEncontrado.identificacion = estudiante.identificacion;
                estudianteEncontrado.telefono = estudiante.telefono;
                estudianteEncontrado.mail = estudiante.mail;
                estudianteEncontrado.direccion = estudiante.direccion;
                              

                _appContext.SaveChanges();


            }
            return estudianteEncontrado;
        }

        
         
        
    }
}
