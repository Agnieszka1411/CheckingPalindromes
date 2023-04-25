using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Palindromes.Logic.Providers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Palindromes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoWhileController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> GetPalindromesLists()
        {
            var doWhileLoop = new DoWhileProvider();
            return new string[] {
            PalindromesInput = DoWhileProvider.
            IsPalindrome =;
            };
        }

        [HttpGet("{id}")]
        public bool GetPalindrome(int id)
        {
        IsPalindrome = 
        return isPalindorme;
        }

    }
}
