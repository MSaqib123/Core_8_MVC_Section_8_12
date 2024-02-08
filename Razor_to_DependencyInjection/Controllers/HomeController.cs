using Microsoft.AspNetCore.Mvc;
using Razor_to_DependencyInjection.Models;
using ServiceDL;
using ServiceInterfaces;
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

        //=========================================================================
        //========================== Section = PartialView ==========================
        //=========================================================================
        #region PartialView
        //Time bacaaoo or agaaa nekal jaoo
        #endregion

        //=========================================================================
        //========================== Section = ViewComponent ==========================
        //=========================================================================
        #region View_Compoentn
        //======= Class 1 =======
        //Create View_Comonent (async)
        //Add partialView of compnete Default.cshtml
        //Change name of  partialView --> then Add name from component return
        //=======================

        //======= class 5 =====
        //showing Viewcompanent using Jquery
        public IActionResult ViewComponentByActinResul()
        {
            Person p = new Person();
            List<Person> pList = new List<Person>()
            {
                new Person(){Id = 1,Name = "Saqib" , Address = "abc"},
                new Person(){Id = 2,Name = "A" , Address = "abc"},
                new Person(){Id = 3,Name = "B" , Address = "abc"},
                new Person(){Id = 4,Name = "C" , Address = "abc"},
                new Person(){Id = 5,Name = "D" , Address = "abc"},
            };

            return ViewComponent("Person",pList);
        }
        #endregion


        //=========================================================================
        //========================== Section = Dependency Inject ==========================
        //=========================================================================
        #region DI
        //======= Class 1 =======
        private readonly ICitiesService _cities;
        public HomeController(ICitiesService cities)
        {
            _cities = cities;
        }
        public IActionResult GetCityList()
        {
            //CitiesService _citiesService = new CitiesService();
            //var list = _citiesService.getAllList();
            var list = _cities.getAllList();
            return View(list);
        }
        #endregion


        //=========================================================================
        //========================== Section = Envirment ==========================
        //=========================================================================
        #region Envirment
        //Enirment are used in Working ,with  Program (startup) file
        //===== 1. Developement Enirment =========
        //This environment is where software developers write, test, and debug code. It is often a local setup on developers' machines or a dedicated development server. In this environment, developers have the flexibility to experiment, make changes, and troubleshoot without affecting the actual users or the live system

        //===== 2. Staging Enirment =========
        //The staging environment is used as a pre-production environment that closely resembles the production environment. It serves as a testing ground where the application is deployed before being released to production. 

        //===== 3. Production Enirment =========
        //The production environment is where the application is deployed and made available to end-users.
        #endregion


        //=========================================================================
        //========================== Section = Configuration (Importent) ==========================
        //=========================================================================
        #region Configuration_in_ProgramFile
        //Please go to program file
        #endregion
    }
}