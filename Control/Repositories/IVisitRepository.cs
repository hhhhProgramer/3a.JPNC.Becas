using Model;

namespace Control.Repositories
{
    public interface IVisitRepository : IRepository<Visit>
    {
         bool IsReserved(Account account);
    }
}