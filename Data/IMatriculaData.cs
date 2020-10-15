using System.Collections.Generic;
using MvcMatricula.Models;

public interface IMatriculaData 
{
    IEnumerable<Materia> ObtenerMaterias();
    Materia ObtenerMateria( int id);
    Materia AgregarMateria(Materia materia);
    Materia ActualizarMateria(Materia materia);
    Materia EliminarMateria( int id);
    IEnumerable<Materia> ObtenerMaterias( string nombre);
    int Commit();

}