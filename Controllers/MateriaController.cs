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

        public IActionResult AgregarOEditar(int id = 0) 
        {
            if ( id == 0 )
                return View(new Materia());
            return View( Repositorio.ObtenerMateria(id) );
        }
        [HttpPost]
        public IActionResult AgregarOEditar(Materia model) 
        {
            Repositorio.AgregarMateria(model);
            Repositorio.Commit();
            return View("Index",Repositorio.ObtenerMaterias().ToList());
        }
    
        public  IActionResult Eliminar(int id)
        {

            Repositorio.EliminarMateria(id);
            Repositorio.Commit();
            return View("Index", Repositorio.ObtenerMaterias().ToList());
   
        }
    }
}