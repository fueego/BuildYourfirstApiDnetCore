using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace buildingYourFirstApiWithNetCore.Controllers
{
    [Route("api/cities")]
    public class PointsOfInterestController : Controller
    {
        [HttpGet("{cityId}/pointsofinterest")]
        public IActionResult GetPointsOfInterest(int cityId)
        {
            var City = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);

            if(City == null)
            {
                return NotFound();
            }

            return Ok(City.PointsOfInterest);
        }

        //decorator for indywidual point of interest
        [HttpGet("{cityId}/pointsofinterest/{id}")]
        public IActionResult GetPointOfInterest(int cityId, int id)
        {
            var City = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);

            if (City == null)
            {
                return NotFound();
            }

            var PointOfInterest = City.PointsOfInterest.FirstOrDefault(p => p.Id == id);

            if(PointOfInterest == null)
            {
                return NotFound();
            }

            return Ok(PointOfInterest);
        }
    }
}
