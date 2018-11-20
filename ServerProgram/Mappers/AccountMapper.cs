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
        private static readonly CampusContext context = new CampusContext();

        public static void CreateAccount(Account acc)
        {
            context.Account.Add(acc);
            context.SaveChanges();
        }

        public static List<Account> ReadAllAccounts()
        {
            return context.Account.ToList();
        }

        public static Account ReadAccountByUserPass(string username, string password)
        {
            var acc = from account in context.Account
                      where account.Username == username &&
                            account.Password == password
                      select account;
            return acc.FirstOrDefault();
        }
    }
}
