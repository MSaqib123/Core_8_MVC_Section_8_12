using Microsoft.AspNetCore.Mvc;

namespace Razor_to_DependencyInjection.ViewComponents
{
    public class GridViewComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            //Different name of partialView("Grid")
            return View("Grid");
        }
    }
}
