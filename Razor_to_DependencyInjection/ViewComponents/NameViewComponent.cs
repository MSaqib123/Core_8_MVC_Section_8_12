using Microsoft.AspNetCore.Mvc;

namespace Razor_to_DependencyInjection.ViewComponents
{
    public class NameViewComponent:ViewComponent
    {
        Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
