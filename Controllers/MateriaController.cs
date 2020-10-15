using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcMatricula.Data;
using MvcMatricula.Models;

namespace MvcMatricula.Controllers
{
    public class MateriaController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public IMatriculaRepositorio Repositorio { get; private set; }

        public MateriaController(ILogger<HomeController> logger, IMatriculaRepositorio repositorio)
        {
            _logger = logger;
            Repositorio = repositorio;
        }

        public IActionResult Index()
        {
            IEnumerable<Materia> _materias = Repositorio.ObtenerMaterias();
            return View(_materias.ToList());
        }

    }
}