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
            
        }
    }
}
