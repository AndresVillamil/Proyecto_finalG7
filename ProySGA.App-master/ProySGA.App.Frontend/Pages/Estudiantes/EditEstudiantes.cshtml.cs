using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProySGA.App.Dominio;
using ProySGA.App.Dominio.Entidades;
using ProySGA.App.Persistencia.AppRepositorios;

namespace ProySGA.App.Frontend.Pages
{
    public class EditEstudiantesModel : PageModel
    {
        private readonly IRepositorioEstudiante repositorioEstudiante;
        [BindProperty]
        public Estudiante Estudiante{get; set;}

       public EditEstudiantesModel(IRepositorioEstudiante repositorioEstudiante)
       {
           this.repositorioEstudiante = repositorioEstudiante;
       }

        
         
          public IActionResult OnGet(int? estudianteId)
        {
            if(estudianteId.HasValue)
            {
                Estudiante = repositorioEstudiante.GetEstudiante(estudianteId.Value);
            }
            else
            {
                Estudiante = new Estudiante();
            }
            if(Estudiante==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }

            if(Estudiante.id > 0)
            {
                Estudiante = repositorioEstudiante.UpdateEstudiante(Estudiante);
            }
            else
            {
                repositorioEstudiante.AddEstudiante(Estudiante);
            }            
            return Page();
        }
    }
}

