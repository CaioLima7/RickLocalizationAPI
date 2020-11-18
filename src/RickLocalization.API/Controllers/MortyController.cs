using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace RickLocalization.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class MortyController : Controller
    {
        //[HttpGet(Name = "ListingMorty")]
        //[ProducesResponseType(typeof(MortyEntity), (int)HttpStatusCode.OK)]
        //public IActionResult ListingMorty()
        //{
        //    //using (var db = new Context())
        //    //{
        //    //    var teste = db.Morty.Where(m => m.Name == "teste").ToList();
        //    //    return Ok(teste);
        //    //}

        //    return Ok("");
        //}
    }
}
