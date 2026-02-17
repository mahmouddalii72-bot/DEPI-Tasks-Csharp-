using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Day8
{
    struct Account
    {
        private int accountId;
        private string accountHolder;
        private double balance;

        // Properties
        public int AccountId
        {
            get { return accountId; }
            set { accountId = value; }
        }

        public string AccountHolder
        {
            get { return accountHolder; }
            set { accountHolder = value; }
        }

        public double Balance
        {
            get { return balance; }
            set
            {
                if (value >= 0)
                    balance = value;
            }
        }

        public void Display()
        {
            Console.WriteLine($"ID: {accountId}, Holder: {accountHolder}, Balance: {balance}");
        }
    }
}
