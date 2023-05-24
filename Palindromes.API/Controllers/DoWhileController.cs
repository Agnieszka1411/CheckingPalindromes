using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Palindromes.Logic.Providers;
using Palindromes.Models.ContractData;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace Palindromes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoWhileController : ControllerBase
    {
        private Dictionary<string, string> palindromeList = new Dictionary<string, string>();
        private DictionaryDoWhileResponse<string, string> dictionaryList = new DictionaryDoWhileResponse<string, string>();

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


        [HttpPost]
        [Route("/DoWhileController/PostReturningList")]
        public List<string> AddPalindormeToList([FromBody] DoWhileRequest request)
        {
            List<string> list = new List<string>();
            list.Add(request.StringToCheck);
             return list;

        }

        [HttpPost]
        [Route("/DoWhileController/PostReturningDictionary")]
        public Dictionary <string, string> AddPalindormeToDictionary([FromBody] DoWhileRequest request)
        {
                var name = "Name";
                palindromeList.Add(name, request.StringToCheck);

                return palindromeList;
        }


        [HttpPost]
        [Route("/DoWhileController/PostReturningDictionaryv2")]
        public DictionaryDoWhileResponse <string, string> AddPalindormeToDictionaryv2([FromBody] DoWhileRequest request)
        {
            foreach (var item in palindromeList)
            {
                request.Name = "Name";
                dictionaryList.Add(request.Name, request.StringToCheck);
            }
            return dictionaryList;
        }


    }
}


        //[Route("/DoWhileController/PostReturningDictionary")]
        //public List<string> AddPalindormeToList([FromBody] DoWhileRequest request)
        //{
        //    List<string> list = new List<string>();
        //    list.Add(request.StringToCheck);

        //    return list;

        //}







//[HttpPost]
//[Route("/DoWhileController/PostReturningJson")]
//public PalindormeList AddPalindrome([FromBody] DoWhileRequest request)
//{
//    List<PalindormeList> list = new List<PalindormeList>();
//    var testPalindrome = new DoWhileResponse
//    {
//        Key = "string",
//        Value = request.ToString()
//    };

//    object jsonString = JsonSerializer.Serialize(testPalindrome);

//    list.Add((PalindormeList)jsonString);


//    return new PalindormeList
//    {
//        palindromeList = list,

//    };
//}




