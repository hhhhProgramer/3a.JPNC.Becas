using System.Collections.Generic;
using Model;

namespace Control.Repositories
{
    public interface IVisitRepository : IRepository<Visit>
    {
         void Resrved(Tutor tutor);
         Visit GetComplete(int id);
         IEnumerable<Visit> GetOfEvaluator(int id);
         Visit GetOfStudy(int id);
    }
}