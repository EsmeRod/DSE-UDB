using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MVCPeliculas.Controllers
{
    public class HelloWorldController : Controller
    {
        //GET: /helloworld/Index/
        public ActionResult Index()
        {
            return View();
        }
        //GET: /helloworld/Welcome/
        public ActionResult Welcome(string Nombre, int numveces = 1)
        {
            ViewData["Nombre"] = "Hola" + Nombre;
            ViewData["numveces"] = numveces;
            return View();
        }
    }
}
