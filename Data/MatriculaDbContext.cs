using Microsoft.EntityFrameworkCore;
using MvcMatricula.Models;

namespace MvcMatricula.Data
{
    public class MatriculaDbContext : DbContext
    {
        public DbSet<Materia> Materias {get;set;}
    }
}