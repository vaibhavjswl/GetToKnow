using GetToKnow.Entitties;
using GetToKnow.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetToKnow.Controllers
{
    [Route("api/")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // POST: api/
        [HttpPost]
        public IActionResult Read()
        {
            var service = new BusinessLogic();
            var data = service.GetPerson();
            if (data.Item2){
                return Ok(data.Item1);
            }
            return new ObjectResult(data.Item1)
            {
                StatusCode=StatusCodes.Status500InternalServerError,
            };
        }
    }
}
