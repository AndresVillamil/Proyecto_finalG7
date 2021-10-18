using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using ProySGA.App.Dominio.Entidades;
using ProySGA.App.Persistencia.AppRepositorios;

namespace ProySGA.App.Frontend
{
    public class DeleteEstudiantesModel : PageModel
    {
        private readonly IRepositorioEstudiante _appContext;
        [BindProperty]
        public Estudiante estudiante {get; set;}

        public DeleteEstudiantesModel()
        {
            this._appContext = new RepositorioEstudiante(new ProySGA.App.Persistencia.AppRepositorios.AppContext());
        }
        public IActionResult OnGet(int estudianteId)
        {
            estudiante = _appContext.GetEstudiante(estudianteId);
            if(estudiante == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            {
                return Page();
            }

        }

        public IActionResult OnPost()
            {
                if(!ModelState.IsValid)
                {
                    return Page();
                }
                if(estudiante.id > 0)
                {
                    _appContext.DeleteEstudiante(estudiante.id);
                }
                return Page();
            }
    }
}
