using System;
using System.Collections.Generic;
using System.Linq;
using Control.Repositories;
using Microsoft.EntityFrameworkCore;
using Model;

namespace Control {
    public class VisitControl : SQLRepository<Visit>, IVisitRepository {
        
        private readonly IRepository<Evaluator> eval; 
        private readonly IRepository<Visit> ReposVisit;
        private readonly IRepository<EconomicStudy> ReposEvaluation;
        public VisitControl (
            AppDbContext context, 
            IRepository<Evaluator> eval,
            IRepository<Visit> ReposVisit,
            IRepository<EconomicStudy> ReposEvaluation
        ) : base (context) { 
                this.eval = eval;
                this.ReposVisit = ReposVisit;
                this.ReposEvaluation = ReposEvaluation;
        }

        public IEnumerable<Visit> GetAllComplete()
        {
            return  context.Visits
                    .Include(x => x.Tutor)
                        .ThenInclude(c => c.Account)
                    .Include(x => x.Tutor)
                        .ThenInclude(x => x.student)
                    .Include(y => y.EconomicStudy)
                    .Include(z => z.Evaluator)
                    .AsEnumerable();
        }

        public Visit GetComplete(int id)
        {
            return  context.Visits
                    .Include(x => x.Tutor)
                        .ThenInclude(c => c.student)
                    .Include(y => y.EconomicStudy)
                    .Include(z => z.Evaluator)
                    .FirstOrDefault(v => v.Id == id) ?? new Visit();
        }

        public IEnumerable<Visit> GetOfEvaluator(int id)
        {
            return  context.Visits
                    .Include(x => x.Tutor)
                        .ThenInclude(c => c.student)
                    .Include(y => y.EconomicStudy)
                    .Include(z => z.Evaluator)
                    .Where(x => x.EvaluatorId == id)
                    .AsEnumerable();
        }

        public Visit GetOfStudy(int id)
        {
            return  context.Visits
                    .Include(x => x.Tutor)
                        .ThenInclude(c => c.student)
                    .Include(y => y.EconomicStudy)
                    .Include(z => z.Evaluator)
                    .FirstOrDefault(x => x.EconomicStudy.Id == id)
                    ?? new Visit();
        }

        public int Resrved (Tutor tutor) {
            
            IEnumerable<Evaluator> evaluator = eval.GetAll();
            IEnumerable<Visit>  Visits = GetAll();

            if(!evaluator.Any())
                return 0;
            
            bool send = true;
            int day = 0;
            Visit visit = new Visit();
            DateTime DateOfVisit = DateTime.Now;
            visit.Tutor = tutor;
            
            //cabiar a una consulta con linq 
            while (send) {
                foreach (var item in evaluator) {
                        DateOfVisit = DateTime.Now.AddDays(day);
                        visit = GetAll().FirstOrDefault( x =>
                            x.EvaluatorId == item.Id &&
                            x.Date.Date == DateOfVisit.Date
                        ) ?? new Visit();

                        if (visit.Id <= 0) { //si no hay un evaluador registrado ese dia lo registra
                            send = false;
                            visit.Evaluator = item;
                            visit.TutorId = tutor.Id;
                            break;
                        }
                }
                day++; //si todos los evaluadores estan ocupados ese dia pasa al siguiente
            }
            var id = ReposVisit.Insert(new Visit(){
                EvaluatorId = visit.Evaluator.Id,
                Date = DateOfVisit,
                TutorId = tutor.Id,
                EconomicStudy = new EconomicStudy(){
                    Status = (int)StudyStatus.REGISTER
                } 
            });
            return id;
        }
    }
}