using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes.Models.ContractData
{
    public class DoWhileRequest
    { 
        public string Name { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(255)]
        public string StringToCheck { get; set; }

        public override string ToString()
        {
            var tmp =base.ToString();
            return StringToCheck;
        }

     


    }
}
