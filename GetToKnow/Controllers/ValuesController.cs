using GetToKnow.Entitties;
using GetToKnow.Service;
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
        // GET: api/
        [HttpGet]
        public Person Get()
        {
            var service = new BusinessLogic();
            var data = service.GetPerson();
            return data;
        }
    }
}
