using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProcecc
{
    interface IBank
    {
        public string Name { get; }
        public string Adress { get; }
        public int CustomerCount {get;}
    }
}
