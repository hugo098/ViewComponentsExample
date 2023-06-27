using Microsoft.AspNetCore.Mvc;
using ViewComponentsExample.Models;

namespace ViewComponentsExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View("Home");
        }

        [Route("about")]
        public IActionResult About()
        {
            return View();
        }

        [Route("MyViewComponent")]
        public IActionResult MyViewComponent()
        {
            return ViewComponent("Grid");
        }

        [Route("friends-list")]
        public IActionResult LoadFriendList()
        {
            PersonGridModel personGridModel = new PersonGridModel()
            {
                GridTitle = "Persons List",
                Persons = new List<Person>()
                {
                    new Person() {PersonName = "Hugo", JobTitle = "BE"},
                    new Person() {PersonName = "Ivan", JobTitle = "FE"},
                    new Person() {PersonName = "Hugo Ivan", JobTitle = "FS"}
                }
            };

            return ViewComponent("Grid", new { grid = personGridModel });
        }
    }
}
