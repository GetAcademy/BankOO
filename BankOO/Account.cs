﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BankOO
{
    public class Account
    {
        public void Deposit(decimal @decimal)
        {
            throw new NotImplementedException();
        }

        public bool Balance { get; }

        public Statement GetLatestStatement()
        {
            var dateTime = DateTime.Now;
            return GetStatement(dateTime.Year, dateTime.Month - 1);
        }

        public Statement GetStatement(int year, int month)
        {
            throw new NotImplementedException();
        }
    }
}