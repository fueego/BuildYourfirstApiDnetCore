using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace buildingYourFirstApiWithNetCore.Controllers
{
    [Route("api/[controller]")]
    public class CitiesController : Controller
    {
        [HttpGet()]
        public IActionResult GetCities()
        {
            return Ok(CitiesDataStore.Current.Cities);
        }

        [HttpGet("{id}")]
        public IActionResult GetCity(int id)
        {
            var cityToreturn = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id);
            if(cityToreturn == null)
            {
                return NotFound();
            }

            return Ok(cityToreturn);
        }
    }
}
