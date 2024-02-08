using Microsoft.AspNetCore.Mvc;
using Razor_to_DependencyInjection.Models;
using System.Diagnostics;

namespace Razor_to_DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //=========================================================================
        //========================== Section = RazarPage ==========================
        //=========================================================================
        #region RazaarPage
        //========= class 1,2 =====
        //MVC Archetecure   Model , View , Controller
        //=========

        //========= class 3 CodeBlock in View =====
        //=========

        //========= class 4 ,5,6,7 ,8 =====
        //Switcht stetmtn
        //Foreach
        //forloop,
        //littral
        //loacl Fn

        //========= class 9, html.Raw() ========
        //html.Raw("<div><i>Pakistan</i></div>")
        //=========

        //========= class 10,11,12 ========
        //Send data from View To controller
        //=========

        //========= class 13,14, =========
        //strongly type model
        //=========

        //========= class 15 =========
        //VM
        //=========

        //========= class 16 =========
        //View IMport
        //=========
        #endregion

        //=========================================================================
        //========================== Section = Layout ==========================
        //=========================================================================
        #region Layout
        //Time bacaaoo or agaaa nekal jaoo
        #endregion

    }
}