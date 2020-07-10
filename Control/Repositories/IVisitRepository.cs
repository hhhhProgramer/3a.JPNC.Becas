using Model;

namespace Control.Repositories
{
    public interface IVisitRepository : IRepository<Visit>
    {
         void Resrved(Account account);
    }
}