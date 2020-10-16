
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

        public IActionResult AgregarOEditar(int id = 0) 
        {
            if ( id == 0 )
                return View(new Estudiante());
            return View( Repositorio.ObtenerEstudiante(id) );
        }
        [HttpPost]
        public IActionResult AgregarOEditar(Estudiante model) 
        {
            Repositorio.AgregarEstudiante(model);
            Repositorio.Commit();
            return View("Index",Repositorio.ObtenerEstudiantes().ToList());
        }
    
        public  IActionResult Eliminar(int id)
        {

            Repositorio.EliminarEstudiante(id);
            Repositorio.Commit();
            return View("Index", Repositorio.ObtenerEstudiantes().ToList());
   
        }
    }
}