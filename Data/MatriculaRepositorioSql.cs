using System.Collections.Generic;
using MvcMatricula.Models;
using System.Linq;


namespace MvcMatricula.Data
{
    public class MatriculaRepositorioSql : IMatriculaRepositorio
    {

        public MatriculaDbContext db { get; private set; }
        public MatriculaRepositorioSql(MatriculaDbContext db)
        {
            this.db = db;
        }

        public Materia ActualizarMateria(Materia materia)
        {
            var entity = db.Materias.Attach(materia);
            entity.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return materia;
        }

        public Materia AgregarMateria(Materia materia)
        {
            db.Add(materia);
            return materia;
        }

        public int Commit()
        {
            return db.SaveChanges();
        }

        public Materia EliminarMateria(int id)
        {
            var materia = ObtenerMateria(id);
            if (materia != null)
            {
                db.Materias.Remove(materia);
            }
            return materia;
        }

        public Materia ObtenerMateria(int id)
        {
            return db.Materias.Find(id);
        }
        public IEnumerable<Materia> ObtenerMaterias()
        {
            return db.Materias;
        }
        public IEnumerable<Materia> ObtenerMaterias(string nombre)
        {
            var materias = from m in db.Materias
                           where m.NombreMateria.Contains(nombre) || string.IsNullOrEmpty(nombre)
                           orderby nombre
                           select m;
            return materias;
        }
        public IEnumerable<Estudiante> ObtenerEstudiantes()
        {
            return db.Estudiantes;
        }
        public IEnumerable<Estudiante> ObtenerEstudiantes(string nombre)
        {
            var estudiantes = from e in db.Estudiantes
                                where e.Nombre.Contains(nombre) || string.IsNullOrEmpty(nombre)
                                orderby nombre
                                select e;
            return estudiantes;
        }
        public Estudiante ObtenerEstudiante(int id)
        {
            return db.Estudiantes.Find(id);
        }
        public Estudiante AgregarEstudiante(Estudiante estudiante)
        {
            db.Add(estudiante);
            return estudiante;
        }

        public Estudiante ActualizarEstudiante(Estudiante estudiante)
        {
            var entity = db.Estudiantes.Attach(estudiante);
            entity.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return estudiante;
        }

        public Estudiante EliminarEstudiante(int id)
        {
            var estudiante = ObtenerEstudiante(id);
            if (estudiante != null)
            {
                db.Estudiantes.Remove(estudiante);
            }
            return estudiante;
        }
    }
}