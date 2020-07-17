
using System.Linq;
using Control.Repositories;
using Microsoft.EntityFrameworkCore;
using Model;

namespace Control
{
    public class EvaluatorControl : SQLRepository<Evaluator> ,IEvaluatorRepository
    {
        public EvaluatorControl(AppDbContext context) : base(context)
        {
            
        }

        public Evaluator GetEvaluator(int AccountId)
        {
            Evaluator evaluator =  context.Evaluators
            .Include(b => b.Visits)
                .ThenInclude(x => x.Tutor)
                    .ThenInclude(x => x.student)
            .FirstOrDefault(b => b.AccountId == AccountId)
            ?? new Evaluator();
 
            
            return evaluator;
        }
    }
}