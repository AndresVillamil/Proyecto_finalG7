using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProySGA.App.Dominio;
using ProySGA.App.Dominio.Entidades;
using ProySGA.App.Persistencia.AppRepositorios;

namespace ProySGA.App.Frontend
{
    public class ListEstudiantesModel : PageModel
    {
        private readonly IRepositorioEstudiante repositorioEstudiante;
        public IEnumerable<Estudiante> estudiantes{get;set;}
        public string searchString;
        public ListEstudiantesModel(IRepositorioEstudiante repositorioEstudiante)
        {
           /* estudiantes = new List<Estudiante>()
            {
                new Estudiante{id=1, nombres="Andrés", apellidos="Villamil"},
                new Estudiante{id=2, nombres="Diana", apellidos="Pachón"},
                new Estudiante{id=3, nombres="Martha", apellidos="Gómez"},
            };*/
            this.repositorioEstudiante = repositorioEstudiante;
        }
        /*public void OnGet(int estudianteId)*/
        public void OnGet(string filtroBusqueda)
        {
            estudiantes=repositorioEstudiante.GetAllEstudiantes(null);
        }

        public IActionResult OnPost(string? searchString)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            estudiantes=repositorioEstudiante.GetAllEstudiantes(searchString);
            return Page();
        }
    }
}
