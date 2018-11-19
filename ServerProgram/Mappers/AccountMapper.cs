using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerProgram.Mappers
{
    class AccountMapper
    {
        // Account CRUD operations

        public void CreateAccount(Account acc)
        {
            var context = new CampusContext();
            context.Account.Add(acc);
            context.SaveChanges();
        }

        public List<Account> ReadAllAccounts()
        {
            List<Account> accounts = new List<Account>();
            var context = new CampusContext();
            accounts = context.Account.ToList();
            return accounts;
        }
    }
}
