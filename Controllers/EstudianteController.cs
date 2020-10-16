
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcMatricula.Data;
using MvcMatricula.Models;

namespace MvcMatricula.Controllers
{

    public class EstudianteController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public IMatriculaRepositorio Repositorio { get; private set; }
        public EstudianteController(ILogger<HomeController> logger, IMatriculaRepositorio repositorio)
        {
            _logger = logger;
            Repositorio = repositorio;
        }

        public IActionResult Index()
        {
            IEnumerable<Estudiante> _estudiantes = Repositorio.ObtenerEstudiantes();
            return View(_estudiantes.ToList());
        }
    }
}