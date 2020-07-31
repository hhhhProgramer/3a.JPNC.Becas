using System.Collections.Generic;
using Model;

namespace Control.Repositories
{
    public interface IVisitRepository : IRepository<Visit>
    {
         int Resrved(Tutor tutor);
         Visit GetComplete(int id);
         IEnumerable<Visit> GetOfEvaluator(int id);
         IEnumerable<Visit> GetAllComplete();
         Visit GetOfStudy(int id);
    }
}