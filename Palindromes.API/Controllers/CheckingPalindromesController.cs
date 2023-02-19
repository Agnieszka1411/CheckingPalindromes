using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Palindromes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckingPalindromesController : ControllerBase
    {
        private static readonly string[] palidromesToCheck = new[]
       {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching", "Kobyła ma mały bok"
        };

        private readonly ILogger<CheckingPalindromesController> _logger;

        private readonly string[] _invalidCharacters = new[] { " ", ".", ",", ";", "/", "\\" };

        protected string GetCleanedString(string stringToClean)
        {
            return _invalidCharacters.Aggregate(stringToClean, (current, c) => current.Replace(c, string.Empty));
        }

        public CheckingPalindromesController(ILogger<CheckingPalindromesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public bool CheckString(string stringToCheck)
        {
            if (string.IsNullOrWhiteSpace(stringToCheck))
                return false;

            var cleanedString = GetCleanedString(stringToCheck.ToLower());
            var index = cleanedString.Length - 1;
            var i = 0;

            while (i <= index)
            {
                if (cleanedString[i] == cleanedString[index])
                {
                    i++;
                    index--;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

    }
}
