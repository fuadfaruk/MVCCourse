using Microsoft.AspNetCore.Mvc;

namespace MVCCourse.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            //return View();
            return "Hello World!!!!!!!!!!!";
        }
        
        public string About()
        {
            return "This is the about page.";
        }
    }
}
