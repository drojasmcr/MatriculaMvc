using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMatricula.Models
{
    [Table("Estudiantes")]
    public class Estudiante
    {
        [Column("ID_ESTUDIANTE")]
        public int Id {get;set;}
        [Column("CEDULA_ESTUDIANTE")]
        public string Cedula {get;set;}
        [Column("NOMBRE_ESTUDIANTE")]
        public string Nombre {get;set;}
        [Column("PRIMER_APELLIDO_E")]
        public String Apellido1 { get; set; }
        [Column("SEGUNDO_APELLIDO_E")]
        public String Apellido2 { get; set; }
        [Column("TELEFONO_ESTUDIANTE")]
        public String Telefono { get; set; }
        [Column("CORREO_ESTUDIANTE")]
        public String Correo { get; set; }
        [Column("FECHA_INGRESO")]
        public DateTime FechaIngreso {get;set;}
        [Column("ESTADO_ESTUDIANTE")]
        public String Estado { get; set; }
        
        [Column("BORRADO_ESTUDIANTE")]
        public bool EstaBorrado {get;set;} 
    }
}