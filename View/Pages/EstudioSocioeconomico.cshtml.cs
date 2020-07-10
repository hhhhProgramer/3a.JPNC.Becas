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
<<<<<<< HEAD
        private readonly IVisitRepository ReposVisits;
        public readonly IEvaluatorRepository evaluators;
        public Evaluator evaluator;


        public EstudioSocioeconomicoModel(IVisitRepository ReposVisits,IEvaluatorRepository evaluators)
        {
            this.ReposVisits = ReposVisits;
            this.evaluators = evaluators;
        }
        
        public void OnGet(Account account)
        {
            evaluator = evaluators.GetEvaluator(account.Id);
        }

        public void OnPost(){
=======
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

            
            
>>>>>>> 60f20aaa57d4b0c51e44fd19f6bbb4e69828bb5b
            
        }
    }
}
