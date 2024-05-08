using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Entities.Excepitions
{
    internal class DomaineExceptions : ApplicationException
    {
        public DomaineExceptions(string message) : base(message)
        {
        }

    }
}
