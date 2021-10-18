using System.Collections.Generic;
using ProySGA.App.Dominio.Entidades;

namespace ProySGA.App.Persistencia.AppRepositorios
{
    public interface IRepositorioEstudiante
    {
          //Se define la firma de los metodos que retornan información de la BD
         //1. Obtener en una lista todos loss datos de la clase Estudiante
         IEnumerable<Estudiante> GetAllEstudiantes(string? nombres);
        //2. Retorna una persona para adicionar
        Estudiante AddEstudiante(Estudiante estudiante);
         //3. Acutalizar una persona UPDATE
         Estudiante UpdateEstudiante(Estudiante estudiante);
         //4. Borrar una persona
         void DeleteEstudiante(int idEstudiante);
         //5. Obtener una persona por el ID
         Estudiante GetEstudiante(int? idEstudiante);
         
        
         
        

         //Adicionar otros metodos con otros criterios
    }
}
