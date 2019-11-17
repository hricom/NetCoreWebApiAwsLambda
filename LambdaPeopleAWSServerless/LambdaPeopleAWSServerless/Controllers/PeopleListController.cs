using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LambdaPeopleAWSServerless.Models;
using LambdaPeopleAWSServerless.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LambdaPeopleAWSServerless.Controllers
{
    [Route("api/PeopleList")]
    [ApiController]
    public class PeopleListController : ControllerBase
    {
        private readonly IPeopleListService _peopleListService;
        public PeopleListController(IPeopleListService peopleListService)
        {
            this._peopleListService = peopleListService;
        }

        [HttpGet]
        public IActionResult GetPeopleList()
        {
            var resul = _peopleListService.GetItemsFromPeopleList();
            return Ok(resul);            
        }
        [HttpPost]
        public IActionResult AddItemToPeopleList([FromBody] PeopleListModel peopleList) 
        {
            _peopleListService.AddItemsToPeopleList(peopleList);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteItemsFromPeopleList([FromBody] PeopleListModel peopleList)
        {
            _peopleListService.RemoveItem(peopleList.Name);
            return Ok();
        }
    }
}