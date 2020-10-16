using System.Collections.Generic;
using MvcMatricula.Models;

namespace MvcMatricula.Data
{
    public interface IMatriculaRepositorio
    {
        IEnumerable<Materia> ObtenerMaterias();
        Materia ObtenerMateria(int id);
        Materia AgregarMateria(Materia materia);
        Materia ActualizarMateria(Materia materia);
        Materia EliminarMateria(int id);
        IEnumerable<Materia> ObtenerMaterias(string nombre);
        
        //Estudiante
        IEnumerable<Estudiante> ObtenerEstudiantes();
        IEnumerable<Estudiante> ObtenerEstudiantes(string nombre);
        Estudiante ObtenerEstudiante(int id);
        Estudiante AgregarEstudiante(Estudiante estudiante);
        Estudiante ActualizarEstudiante(Estudiante estudiante);
        Estudiante EliminarEstudiante(int id);

        //Profesor
        IEnumerable<Profesor> ObtenerProfesores();
        IEnumerable<Profesor> ObtenerProfesores(string nombre);
        Profesor ObtenerProfesor(int id);
        Profesor AgregarProfesor(Profesor profesor);
        Profesor ActualizarProfesor(Profesor profesor);
        Profesor EliminarProfesor(int id);
        int Commit();

    }
}