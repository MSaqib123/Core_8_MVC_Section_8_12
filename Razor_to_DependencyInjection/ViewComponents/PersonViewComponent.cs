using Microsoft.AspNetCore.Mvc;
using Razor_to_DependencyInjection.Models;

namespace Razor_to_DependencyInjection.ViewComponents
{
    public class PersonViewComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(List<Person> p)
        {
            return View("Person",p);
        }
    }
}
