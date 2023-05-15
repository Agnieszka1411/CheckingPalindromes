using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Palindromes.Logic.Providers;
using Palindromes.Models.ContractData;

namespace Palindromes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForController : ControllerBase
    {

        [HttpGet]
        [Route("/ForController")]
        public ForResponse GetForController([FromBody] ForRequest request)
        {
       
            var result = new ForProvider().CheckString(request.StringToCheck);

            return new ForResponse
            {
                Result = result,
                Message = result ? "yes, it's a palindrome" : "oh no, but nice try!"
            };
        }
    }
}
