using Microsoft.EntityFrameworkCore;
using MvcMatricula.Models;

namespace MvcMatricula.Data
{
    public class MatriculaDbContext : DbContext
    {
        public DbSet<Materia> Materias {get;set;}

        string connectionString = @"Data Source=127.0.0.1,1433;Database=dbmatriculal;User Id=SA;Password=Alajuela200*";
    }
}