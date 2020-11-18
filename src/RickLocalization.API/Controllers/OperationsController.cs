using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace RickLocalization.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class OperationsController : Controller
    {
        readonly IOperations _operations;

        public OperationsController(IOperations operations)
        {
            _operations = operations;
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult RegisterNavigation(NavigationEntity navigation)
        {
            var result = _operations.Register(navigation);
            if(result >= 1)
            {
                return Ok(result);
            }
            else
            {
                return NoContent();
            }
        }
    }
}
