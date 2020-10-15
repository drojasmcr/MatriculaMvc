using System.Collections.Generic;
using MvcMatricula.Data;
using MvcMatricula.Models;
using System.Linq;

public class MatriculaSqlData : IMatriculaData
{

    public MatriculaDbContext db { get; private set; }
    public MatriculaSqlData(MatriculaDbContext db)
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
        if ( materia != null)
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
}