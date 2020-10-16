using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMatricula.Models
{
    [Table("Materias")]
    public class Materia 
    {
        public int Id {get;set;}
        [Column("Codigo_Materia")]
        public string CodigoMateria {get;set;}
        [Column("Nombre_Materia")]
        public string NombreMateria {get;set;}
        [Column("Horas_Totales")]
        public int HorasTotales {get;set;}
        
        [Column("Borrado_Materia")]
        public bool EstaBorrado {get;set;} 
    }
}