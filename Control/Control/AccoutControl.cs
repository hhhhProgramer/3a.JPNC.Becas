using System.Linq;
using Control;
using Control.Repositories;
using Model;

namespace Control {
    public class AccoutControl : SQLRepository<Account>, IAccoutRepository {

        public AccoutControl (AppDbContext context) : base (context) {

        }

        public bool IsRegister(Account account)
        {
            bool result = context.Set<Account> ().Any( x => 
                x.Correo == account.Correo
            );

            return result;
        }

        public Account Validate (Account account) {
            Account result = context.Set<Account> ().FirstOrDefault (x =>
                x.Correo == account.Correo &&
                x.Password == account.Password
            ) ?? new Account ();

            return result;
        }
    }
}