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
    public class DetailsEstudiantesModel : PageModel
    {
       private readonly IRepositorioEstudiante repositorioEstudiante;

       public Estudiante Estudiante{get; set;}

       public DetailsEstudiantesModel(IRepositorioEstudiante repositorioEstudiante)
       {
           this.repositorioEstudiante = repositorioEstudiante;
       }
        public IActionResult OnGet(int estudianteId)
        {
            Estudiante = repositorioEstudiante.GetEstudiante(estudianteId);
            if(Estudiante==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();
        }
    }
}
