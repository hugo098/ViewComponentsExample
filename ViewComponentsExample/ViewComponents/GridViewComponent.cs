using Microsoft.AspNetCore.Mvc;
using ViewComponentsExample.Models;

namespace ViewComponentsExample.ViewComponents
{
    public class GridViewComponent: ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(PersonGridModel grid)
        {
            /*PersonGridModel personGridModel = new PersonGridModel()
            {
                GridTitle = "Persons List",
                Persons = new List<Person>()
                {
                    new Person() {PersonName = "Hugo", JobTitle = "BE"},
                    new Person() {PersonName = "Ivan", JobTitle = "FE"},
                    new Person() {PersonName = "Hugo Ivan", JobTitle = "FS"}
                }
            };*/
            await Task.Delay(1000);
            //ViewBag.Grid = model;
            return View("Default", grid); //invoked a partial view Views/Shared/Components/Grid/Default.cshtml
            
        }


    }
}
