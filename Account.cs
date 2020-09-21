using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProcecc
{
    public class Account
    {
        private static int _numberOfAcc = 0;
        private readonly int _accountNumber;
        private readonly Customer _accountOwner;
        private int _maxMinusAllowed;

        public int AccountNumber
        {
            get
            {
                return _accountNumber;
            }
        }

        public int Balance { get; private set; }
        public Customer AccountOwner
        {
            get
            {
                return _accountOwner;
            }
        }

        public int MaxMinusAllowed
        {
            get
            {
                return _maxMinusAllowed;
            };
        }


        public Account(Customer customer, int monthlyincome)
        {
            _accountOwner = customer;
            Balance = monthlyincome;
            _accountNumber = customer.CustomerID;
            _maxMinusAllowed = monthlyincome*3;
        }

        public void Add (int amount)
        {

        }

        public void Subtract(int amount)
        {

        }


        public static bool operator ==(Account account1, Account account2)
        {
            if (account1 is null && account2 is null)
                return true;
            if (account2 is null || account1 is null)
                return false;

            return account1._accountNumber == account2._accountNumber;
        }

        public static bool operator !=(Account account1, Account account2)
        {
            return !(account1 == account2);
        }

        public override bool Equals(object obj)
        {
            return this._accountNumber.Equals(obj as Account);
        }

        public override int GetHashCode()
        {
            return this._accountNumber;
        }
    }
}
