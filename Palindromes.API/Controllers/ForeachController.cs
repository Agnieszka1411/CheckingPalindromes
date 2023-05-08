using Microsoft.AspNetCore.Mvc;
using Palindromes.Logic.Providers;
using Palindromes.Models.ContractData;

namespace Palindromes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForeachController : ControllerBase
    {

        [HttpGet]
        [Route("/v1")]
        public bool Get(string stringToCheck)
        {
            return  new ForeachProvider().CheckString(stringToCheck);
        }

        [HttpGet]
        [Route("/v2")]
        public ForeachResponse Get([FromBody] ForeachRequest request)
        {
            var result = new ForeachProvider().CheckString(request.StringToCheck);

            return new ForeachResponse
            {
                Result = result,
                Message = result? "yes, it's a palindrome" : "oh no, but nice try!"
            };
        }
    }
}
