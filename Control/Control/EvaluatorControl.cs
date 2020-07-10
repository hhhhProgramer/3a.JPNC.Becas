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
            Evaluator evaluator =  context.Evaluators.Include(x => x.Visits).FirstOrDefault(x =>
                x.AccountId == AccountId
            ) ?? new Evaluator();
            
            return evaluator;
        }

    }
}