using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMatricula.Models
{
    [Table("Estudiantes")]
    public class Estudiante
    {
        [Column("ID_ESTUDIANTE")]
        public int Id {get;set;}
        [Column("CEDULA_ESTUDIANTE")]
        [MaxLength(20)]
        public string Cedula {get;set;}
        [Column("NOMBRE_ESTUDIANTE")]
        [MaxLength(20)]
        public string Nombre {get;set;}
        [Column("PRIMER_APELLIDO_E")]
        [MaxLength(20)]
        public String Apellido1 { get; set; }
        [Column("SEGUNDO_APELLIDO_E")]
        [MaxLength(20)]
        public String Apellido2 { get; set; }
        [Column("TELEFONO_ESTUDIANTE")]
        [MaxLength(8)]
        public String Telefono { get; set; }
        [Column("CORREO_ESTUDIANTE")]
        [MaxLength(25)]
        public String Correo { get; set; }
        [Column("FECHA_INGRESO")]
        public DateTime FechaIngreso {get;set;}
        [Column("ESTADO_ESTUDIANTE")]
        [MaxLength(3)]
        public String Estado { get; set; }
        
        [Column("BORRADO_ESTUDIANTE")]
        public bool EstaBorrado {get;set;} 
    }
}