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
        public readonly IEconomicStudyRepository repository;
        [BindProperty]
        public string [] Services { get; set; } 

        [BindProperty]
        public EconomicStudy Study { get; set; }
        public Visit visit { get; set; }
        public List<Visit> Visits { get; set; }

        public EstudioSocioeconomicoModel(
            IEvaluatorRepository evaluators,
            IEconomicStudyRepository repository,
            IVisitRepository ReposVisits) 
        {
            this.evaluators = evaluators;
            this.repository = repository;
            this.ReposVisits = ReposVisits;
            Visits = new List<Visit>();
            visit = new Visit();
            Study = new EconomicStudy();
        }
        
        public void OnGet(Account account)
        {
            var  evaluator = evaluators.GetEvaluator(account.Id) ?? new Evaluator();
            if(evaluator.Id > 0)
                Visits  =  GetVisits(evaluator.Id);
            else
               RedirectToPage("Index");
        }
 
        public void OnPost(int VisitId)
        {
            this.visit = ReposVisits.GetComplete(VisitId);
            Console.WriteLine(visit.EconomicStudy.Id);
            Services = new string [7];
        }

        
        public void OnPostTerminate(int StudyId,int VisitId){
            Study.Id = StudyId;
            Study.Status  = (int)StudyStatus.PROCESS;
            Study.Services  = FormatToServices();            
            repository.Update(Study);
            Visits  =  GetVisits(VisitId);
            Console.WriteLine("Terminado");
        }

        public List<Visit> GetVisits(int Id){
            return  ReposVisits.GetOfEvaluator(Id)
                    .Where(x => x.EconomicStudy.Status == (int)StudyStatus.REGISTER)
                    .ToList(); 
        }

        public string FormatToServices(){
            string srv = "";
            for(int i=0 ; i < Services.Length;i++){
                if(i == Services.Length-1)
                    srv += Services[i];
                else
                    srv += Services[i] + ",";
            }
            Study.Services = srv;
            return srv;
        }
    }
}

