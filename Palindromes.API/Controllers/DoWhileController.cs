using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Palindromes.Logic.Providers;
using Palindromes.Models.ContractData;
using System.Net;

namespace Palindromes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoWhileController : ControllerBase
    {
        [HttpGet]
        [Route("/DoWhileController")]
        public DoWhileResponse GetDoWhileController([FromBody] DoWhileRequest request)
        {
            var result = new DoWhileProvider().CheckString(request.StringToCheck);

            return new DoWhileResponse
            {
                Result = result,
                Message = result ? "yes, it's a palindrome" : "oh no, but nice try!"
            };
        }

        [HttpPost]
        [Route("/DoWhileController/Add")]
        public ActionResult<DoWhileResponse> PostDoWhileController([FromBody] DoWhileRequest request)
        {
            DoWhileRequest test = new DoWhileRequest();
            test.StringToCheck = request.ToString();
            
            //try
            //{
               return Ok(test);
            //    var returnMessage = Request.
            //        CreateResponse(HttpStatusCode.Created, c);
            //    returnMessage.Headers.Location = new Uri(Request.RequestUri.ToString() + c.ClientId.ToString());
            //    return returnMessage;
            //}
            //catch (Exception ex)
            //{
            //    var returnErrMessage = Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            //    return returnErrMessage;
            //}
            return NotFound();
        }
    }
}
