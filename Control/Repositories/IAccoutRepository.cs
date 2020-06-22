using Model;

namespace Control.Repositories
{
    public interface IAccoutRepository : IRepository<Account>
    {
        Account Validate(Account account);
    }
    
}