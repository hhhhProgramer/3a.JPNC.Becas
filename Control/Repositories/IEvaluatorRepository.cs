using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;

namespace Control
{
    public interface IEvaluatorRepository : IRepository<Evaluator>
    {
        Evaluator GetEvaluator(int AccountId);
    }
}