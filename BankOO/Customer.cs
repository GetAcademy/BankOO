using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace BankOO
{
    public class Customer
    {
        private string _name;
        private Bank _bank;
        private List<Account> _accounts;

        public IEnumerable<Account> Accounts => _accounts.ToArray();

        public Customer(string name, Bank bank)
        {
            _bank = bank;
            _name = name;
            _accounts = new List<Account>();
        }

        public IEnumerable<Statement> GetLatestStatements()
        {
            var latestCompletedMonth = YearAndMonth.GetLatestMonth();
            return GetStatements(latestCompletedMonth);
        }

        public IEnumerable<Statement> GetStatements(YearAndMonth yearAndMonth)
        {
            return _accounts.Select(a => a.GetStatement(yearAndMonth));
        }

        public void AddAccount(Account account)
        {
            _accounts.Add(account);
        }
    }
}
