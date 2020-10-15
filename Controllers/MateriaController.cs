using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MvcMatricula.Controllers
{
    public class MateriaController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public MateriaController(ILogger<HomeController> logger, IMatriculaRepositorio repositorio)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}