using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    class Account
    {
        private double balance;                             // the account balance
        private double overdraftLimit;

        // construct a bank acocunt with specified opening
        // balance and overdraft limit
        public Account(double balance, double overdraftLimit)
        {
            if (balance >= 0)
            {
                this.balance = balance;
            }
            else
            {
                throw new ArgumentException("overdraft limit must be >= 0");
            }
            this.OverdraftLimit = overdraftLimit;
        }

        // chain, 0 balance and overdraft
        public Account() : this(0, 0)
        {

        }

        // read-only property
        public double Balance
        {
            get
            {
                return balance;
            }
        }

        // property
        public double OverdraftLimit
        {
            get
            {
                return overdraftLimit;
            }
            set
            {
                if (value >= 0)
                {
                    this.overdraftLimit = value;
                }
                else
                {
                    throw new ArgumentException("overdraft limit must be >= 0");
                }
            }
        }

        // deposit some money
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
            else
            {
                throw new ArgumentException("amount must be > 0");
            }
        }

        // withdraw some money if sufficient funds
        public void Withdraw(double amount)
        {
            if (amount > 0)
            {
                if (balance + overdraftLimit >= amount)
                {
                    balance -= amount;
                }
                else
                {
                    throw new ArgumentException("Insufficent funds for this transaction");
                }
            }
            else
            {
                throw new ArgumentException("amount must be > 0");
            }
        }

        public override string ToString()
        {
            return String.Format("Bank Account Details:\nBalance: {0:00.00}, OverDraft: {1:00.00} ",
                               balance, overdraftLimit);
        }

    }
}
