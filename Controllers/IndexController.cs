using Microsoft.AspNetCore.Mvc;
using WebApplicationAlumnos.Models;

namespace WebApplicationAlumnos.Controllers
{
    public class IndexController : Controller
    {
        AlumnoDatos alumnos = new AlumnoDatos();
        
        public IActionResult Index()
        {
            List<AlumnoModelo> lista = alumnos.alumnos();
            return View(lista);
        }
    }
}
