using CarPark.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CarPark.User.Controllers
{
    public class PersonalsController : Controller
    {
        private readonly IPersonalService _personalService;

        public PersonalsController(IPersonalService personalService)
        {
            _personalService = personalService;
        }

        public IActionResult Index()
        {
            return View(_personalService.GetPersonalsByAge().Result);
        }


    }
}
