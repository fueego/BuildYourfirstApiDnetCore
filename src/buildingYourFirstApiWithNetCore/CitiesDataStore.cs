using buildingYourFirstApiWithNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace buildingYourFirstApiWithNetCore
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            //dummy data
            Cities = new List<CityDto>
            {
                new CityDto { Id = 1, Name="New York City", Description="The one with big Aple"},
                new CityDto { Id = 2, Name="Antwerp", Description = "The one with non finished catedral" },
                new CityDto { Id = 3, Name="Tarnow", Description = "Moje Miasto a w nim ;)" }
            };
        }
    }
}
