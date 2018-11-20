using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServerProgram.Entities;

namespace ServerProgram.Mappers
{
    class AccountMapper
    {
        // Account CRUD operations

        public static void CreateAccount(Account acc)
        {
            var context = new CampusContext();
            context.Account.Add(acc);
            context.SaveChanges();
        }

        public static List<Account> ReadAllAccounts()
        {
            List<Account> accounts = new List<Account>();
            var context = new CampusContext();
            accounts = context.Account.ToList();
            return accounts;
        }
    }
}
