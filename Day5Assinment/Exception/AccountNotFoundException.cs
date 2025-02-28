using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assinment.model
{
    internal class AccountNotFoundException : Exception
    {
        public AccountNotFoundException(String mesage) : base(mesage)
            { 
        }
    }
}
