using Microsoft.AspNetCore.Mvc;

namespace Razor_to_DependencyInjection.ViewComponents
{
    public class NameViewComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
            //this component search or invoke partialView at this location
            //shared/Components/NameASMatch/Default.cshtml
            //________ Note _____
            //if we gave different name to view then we have to gave complete 
        }
    }
}
