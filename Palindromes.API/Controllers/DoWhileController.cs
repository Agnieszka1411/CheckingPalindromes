using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Palindromes.Logic.Providers;
using Palindromes.Models.ContractData;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Xml.Linq;

namespace Palindromes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoWhileController : ControllerBase
    {
        private Dictionary<string, string> palindromeList = new Dictionary<string, string>();
        private DictionaryDoWhileResponse<string, string> dictionaryList = new DictionaryDoWhileResponse<string, string>();
        private List<String> filledPalindromesList = new List<string> { "Kobyła ma mały bok.", "oko", "kobyła ma mały bok", "dupa" };
        private Dictionary<string, List<string>> palindromesDict = new Dictionary<string, List<string>>();

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
        public Dictionary<string, List<string>> AddPalindormeToDictionary([FromBody] DoWhileRequest request)
        {
            var name = "Name";
            if (palindromesDict.ContainsKey(name)) //sprawdzamy czy klucz już istnieje
            {
                palindromesDict[name].Add(request.StringToCheck); // jeśli istnieje, to dodaj nową wartość do listy. [Name] zapis słownikowy przez indeks.
            }
            else
            {
                palindromesDict.Add(name, new List<string>() { request.StringToCheck }); //jeżeli nie istnieje, to dodaj, ale zainicjuj listę
            }
            return palindromesDict;
        }

        [HttpPost]
        [Route("/DoWhileController/PostReturningDictionaryv2")]
        public DictionaryDoWhileResponse<string, string> AddPalindormeToDictionaryv2([FromBody] DoWhileRequest request)
        {
            foreach (var item in palindromeList)
            {
                request.Name = "Name";
                dictionaryList.Add(request.Name, request.StringToCheck);
            }
            return dictionaryList;
        }


        [HttpGet]
        [Route("/DoWhileController/GetPalindromesList")]
        public IEnumerable<string> GetPalindromesList()
        {
            return filledPalindromesList;
        }

        //[HttpGet]
        //[Route("/DoWhileController/GetPalindromesList/{id}")]
        //public List<string> GetPalindromesListById(int id)
        //{
        //    DoWhileResponseById doWhileResponse = new DoWhileResponseById();

        //    doWhileResponse.Id = id;
        //    //var test = filledPalindromesList.Where(p => doWhileResponse.Id == id);
        //    //return test.ToList();


        //}

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




