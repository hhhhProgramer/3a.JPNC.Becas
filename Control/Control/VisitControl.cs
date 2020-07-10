using System;
using System.Collections.Generic;
using System.Linq;
using Control.Repositories;
using Microsoft.EntityFrameworkCore;
using Model;

namespace Control {
    public class VisitControl : SQLRepository<Visit>, IVisitRepository {
        
        private readonly IRepository<Evaluator> eval; 
        public VisitControl (AppDbContext context, IRepository<Evaluator> eval) : base (context) { 
                this.eval = eval;
        }

        

        public void Resrved (Account account) {
            
            IEnumerable<Evaluator> evaluator = eval.GetAll();
            //context.Dispose();
            IEnumerable<Visit>  Visits = GetAll();

            if(!evaluator.Any())
                return;
            
            bool send = true;
            int day = 0;
            Visit visit = new Visit();
            DateTime DateOfVisit = DateTime.Now;

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
<<<<<<< HEAD
=======
                            visit.account = account;
>>>>>>> 60f20aaa57d4b0c51e44fd19f6bbb4e69828bb5b
                            visit.evaluator = item;
                            visit.EconomicStudy = new EconomicStudy () { Status = false };
                            break;
                        }
                }
                day++; //si todos los evaluadores estan ocupados ese dia pasa al siguiente
            }
            Insert (visit);
        }

        

    }
}