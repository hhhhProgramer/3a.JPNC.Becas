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
        public VisitControl (AppDbContext context, IRepository<Evaluator> eval,IRepository<Visit> ReposVisit) : base (context) { 
                this.eval = eval;
                this.ReposVisit = ReposVisit;
        }

        

        public void Resrved (Tutor tutor) {
            
            IEnumerable<Evaluator> evaluator = eval.GetAll();
            //context.Dispose();
            IEnumerable<Visit>  Visits = GetAll();

            if(!evaluator.Any())
                return;
            
            bool send = true;
            int day = 0;
            Visit visit = new Visit();
            DateTime DateOfVisit = DateTime.Now;
            visit.Tutor = tutor;
            
            //cabiar a una consulta con linq 
            while (send) {
                foreach (var item in evaluator) {
                        DateOfVisit = DateTime.Now.AddDays (day);
                        visit = GetAll().FirstOrDefault( x =>
                            x.EvaluatorId == item.Id &&
                            x.Date.Date == DateOfVisit.Date
                        ) ?? new Visit();
                        if (visit.Id <= 0) { //si no hay un evaluador registrado ese dia lo registra
                            send = false;
                            visit.Date = DateOfVisit;
                            visit.Evaluator = item;
                            visit.TutorId = tutor.Id;
                            break;
                        }
                }
                day++; //si todos los evaluadores estan ocupados ese dia pasa al siguiente
            }
            ReposVisit.Insert(new Visit(){
                EvaluatorId = visit.Evaluator.Id,
                TutorId = tutor.Id
            });
            Insert (visit); 
        }
    }
}