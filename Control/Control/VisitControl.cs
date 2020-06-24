
using System.Linq;
using Control.Repositories;
using Model;

namespace Control
{
    public class VisitControl : SQLRepository<Visit>, IVisitRepository
    {
        public VisitControl(AppDbContext context) : base(context)
        {
        }

        public bool IsReserved(Account account)
        {
            
            return true;
        }
    }
}