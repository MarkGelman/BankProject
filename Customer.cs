using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProcecc
{
    public class Customer
    {
        private static int   _numberOfCust = 0;
        private readonly int _customerID;
        private readonly int _customerNumber;

        public string Name { get; private set; }
        public int PhNumber { get; private set; }
        public int CustomerNumber { get; }

        public int CustomerID { get; }


        public Customer(int id, string name,int phone)
        {
            _customerID = id;
            Name = name;
            PhNumber = phone;
            CustomerID = ++_numberOfCust;
        }
        

        public static bool operator == (Customer customer1,Customer customer2)
        {
            if (customer1 is null && customer2 is null)
                return true;
            if (customer2 is null || customer1 is null)
                return false;

            return customer1.CustomerID == customer2.CustomerID;
        }

        public static bool  operator !=(Customer customer1, Customer customer2)
        {
            return !(customer1 == customer2);
        }

        public override bool Equals (object obj)
        {
            return this.CustomerID.Equals(obj as Customer);
        }

        public override int GetHashCode()
        {
            return this.CustomerID;
        }
    }
}
