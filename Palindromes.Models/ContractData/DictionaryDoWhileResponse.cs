using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes.Models.ContractData
{
    public class DictionaryDoWhileResponse <TKey, TValue> : Dictionary <TKey, TValue>
    {
        public Dictionary <string, string> palindromeResult { get; set; } = new Dictionary<string, string>();
    }
}
