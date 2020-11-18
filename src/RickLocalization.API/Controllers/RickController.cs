using System;
using System.Collections;
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
    public class RickController : Controller
    {
        readonly IRick _rick;

        public RickController(IRick rick)
        {
            _rick = rick;
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult ListingCards()
        {
            var search = _rick.GetCards();
            if (search != null)
            {
                return Ok(search);
            }
            else
            {
                return NoContent();
            }
        }
        [HttpGet]
        [Route("[action]/{id}")]
        public IActionResult RickHistoric(int id)
        {
            var search = _rick.GetHistoric(id);
            if (search != null)
            {
                return Ok(search);
            }
            else
            {
                return NoContent();
            }
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult RickNavigations()
        {
            //var search = _rick.GetNavigations(id);
            var search = _rick.GetNavigations();
            if (search != null)
            {
                return Ok(new { items = search, total_count = search.Count });
            }
            else
            {
                return NoContent();
            }
        }

        [HttpGet]
        [Route("[action]/{sort}/{order}/{page}/{rickId}")]
        public IActionResult RickNavigationsWithPagination(string sort, string order, int page, int rickId)
        {
            Tuple<IEnumerable<NavigationEntity>, int> search = _rick.GetNavigationsWithPagination(sort, order, page, rickId);
            bool isOk = int.Parse(search.Item2.ToString()) ==  0 ? false : true;

            if (search != null && isOk)
            {
                return Ok(new { items = search.Item1, total_count = search.Item2 });
            }
            else
            {
                return NoContent();
            }
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public IActionResult RickNavigationById(int id)
        {
            //var search = _rick.GetNavigations(id);
            var search = _rick.GetNavigations();
            if (search != null)
            {
                return Ok(new { items = search, total_count = search.Count });
            }
            else
            {
                return NoContent();
            }
        }
        [HttpGet]
        [Route("[action]/{id}")]
        public IActionResult RickDetails(int id)
        {
            var search = _rick.GetRickDetails(id);
            if (search != null)
            {
                return Ok(search); 
            }
            else
            {
                return NoContent();
            }
        }
    }
}
