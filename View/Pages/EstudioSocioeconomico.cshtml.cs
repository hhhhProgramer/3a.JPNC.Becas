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
        public Visit visit;

        public EstudioSocioeconomicoModel(IVisitRepository ReposVisits,IEvaluatorRepository evaluators)
        {
            this.ReposVisits = ReposVisits;
            this.evaluators = evaluators;
            visit = new Visit();
            evaluator = new Evaluator();
        }
        
        public void OnGet(Account account)
        {
            evaluator = evaluators.GetEvaluator(account.Id) ?? new Evaluator();
            if(evaluator.Id <= 0)
                Console.WriteLine("Error");
            else    
                Console.WriteLine("Exito");     
        }

        public void OnPost(Visit visit){
            this.visit = visit;
            Console.WriteLine(visit.Id);
        }

        public void OnPostTerminate(){
            Console.WriteLine("Terminado");
        }

        public void test(){
            Console.WriteLine("Test");
        }
    }
}
