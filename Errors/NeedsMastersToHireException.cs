using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Sharp.Errors
{
    internal class NeedsMastersToHireException : ArgumentException
    {
        public int QuantityOfMastersToHire { get; private set; }
        public NeedsMastersToHireException(string message, int quantityOfMastersToHire)
            : base(message)
        {
            QuantityOfMastersToHire = quantityOfMastersToHire;
        }
    }
}
