using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Model;
using Control;
using Control.Repositories;

namespace Proyecto
{
    public class EstudioSocioeconomicoModel : PageModel
    {
        private readonly IRepository<Visit> repository;
        private readonly IVisitRepository ReposVisits;

        public IEnumerable<Visit> Visits;

        [BindProperty]
         public Visit visit { get; set; }
         public string Message { get; set; }

        public EstudioSocioeconomicoModel(IRepository<Visit> repository,IVisitRepository ReposVisits)
        {
            this.repository = repository;
            visit = new Visit();
            this.ReposVisits = ReposVisits;
            this.Visits = ReposVisits.GetAll();
        }
        
        public void OnGet()
        {

        }

        public void OnPost(){
            visit = repository.Get(visit.Id) ?? new Visit();
            if(visit.Id <= 0)
                Message = "No se encontro ningun id con ese codigo, intentelo nuevamente";

            
            
            
        }
    }
}
