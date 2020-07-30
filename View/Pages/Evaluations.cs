using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Control;
using Control.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Model;

namespace Proyecto
{
    public class EvaluationsModel : PageModel
    {
        private readonly IRepository<EconomicStudy> ReposStudies;
        private readonly IRepository<Student> ReposStudents;
        private readonly IVisitRepository Visits;

        public List<EconomicStudy> Studies { get; set; }
        public Visit visit { get; set; }
        public EconomicStudy Study { get; set; }
        [BindProperty]
        public int Discount { get; set; }

        public EvaluationsModel(IRepository<EconomicStudy> ReposStudies,IVisitRepository Visits,IRepository<Student> ReposStudents)
        {
            this.ReposStudies = ReposStudies;
            this.ReposStudents = ReposStudents;
            this.Visits = Visits;
            Study = new EconomicStudy();
            visit = new Visit();
            Studies = new List<EconomicStudy>();
        }
        public void OnGet()
        {
            Studies =   ReposStudies.GetAll()
                        .Where(x => x.Status == (int)StudyStatus.PROCESS)
                        .ToList();
        }

        public void OnPost(int Id){
            visit = Visits.GetOfStudy(Id);
            Study = ReposStudies.Get(Id);
        }

        public void OnPostTerminate(int StudyId)
        {
            Console.WriteLine(Discount);
            visit = Visits.GetOfStudy(StudyId);
            visit.EconomicStudy.Status  = (int)StudyStatus.COMPLETE;           
            visit.Tutor.student.Discount = this.Discount;
            ReposStudies.Update(visit.EconomicStudy);
            ReposStudents.Update(visit.Tutor.student);
            visit= new Visit();
            Studies =   ReposStudies.GetAll()
                    .Where(x => x.Status == (int)StudyStatus.PROCESS)
                    .ToList();
        }
    }
}
