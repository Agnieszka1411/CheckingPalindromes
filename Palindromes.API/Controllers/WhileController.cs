using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Palindromes.Logic.Providers;
using Palindromes.Models.ContractData;

namespace Palindromes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WhileController : ControllerBase
    {
        [HttpGet]
        [Route("/WhileController")]
        public WhileResponse GetWhileController([FromBody] WhileRequest request)
        {
            var result = new WhileProvider().CheckString(request.StringToCheck);

            return new WhileResponse
            {
                Result = result,
                Message = result ? "yes, it's a palindrome" : "oh no, but nice try!"
            };
        }
    }
}
