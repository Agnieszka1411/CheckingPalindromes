using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes.Models.ContractData
{
    public class DoWhileResponse
    {
        public bool Result { get; set; }
        public string Message { get; set; }

        public string Key { get; set; }
        public string Value { get; set; }

        public List<string> PalindormeList { get; set; }

    }
}
