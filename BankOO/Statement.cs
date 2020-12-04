using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankOO
{
    public class Statement
    {
        private YearAndMonth _yearAndMonth;
        public Transaction[] Transactions { get; }

        public Statement(YearAndMonth yearAndMonth, IEnumerable<Transaction> transactions)
        {
            _yearAndMonth = yearAndMonth;
            Transactions = transactions.ToArray();
        }
    }
}
