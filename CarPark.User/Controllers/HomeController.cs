using CarPark.User.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace CarPark.User.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStringLocalizer<HomeController> _localizer;

        public HomeController(ILogger<HomeController> logger, IStringLocalizer<HomeController> localizer)
        {
            _localizer = localizer;
            _logger = logger;
        }

        public IActionResult Index()
        {
            //var database = client.GetDatabase("CarparkDb");
            //var jsonString = System.IO.File.ReadAllText("cities.json");

            //var cities = JsonConvert.DeserializeObject<List<Cities>>(jsonString);
            //var citiesCollection = database.GetCollection<City>("City");

            //foreach (var item in cities)
            //{
            //    var city = new City()
            //    {
            //        Id = ObjectId.GenerateNewId(),
            //        Name=item.name,
            //        Plate=item.plate,
            //        Latitude=item.latitude,
            //        Longitude=item.longitude,
            //        Counties= new List<County> { }
            //    };
            //    foreach (var item2 in item.counties)
            //    {
            //        city.Counties.Add(new County {
            //            Id= ObjectId.GenerateNewId(),
            //            Name=item2,
            //            Latitude="",
            //            Longitude="",
            //            PostCode=""
            //        });
            //    }
            //    citiesCollection.InsertOne(city);
            //}

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
