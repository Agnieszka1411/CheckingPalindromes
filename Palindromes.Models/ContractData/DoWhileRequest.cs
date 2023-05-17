using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes.Models.ContractData
{
    public class DoWhileRequest
    {
        public string StringToCheck { get; set; }


        public override string ToString()
        {
            var tmp =base.ToString();
            return StringToCheck;
        }

     


    }
}
