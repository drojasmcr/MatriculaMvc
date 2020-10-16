
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMatricula.Models
{
    [Table("Estudiantes")]
    public class Profesor
    {
         [Column("ID_PROFESOR")]
        public int Id {get;set;}
        [Column("CEDULA_PROFESOR")]
        [MaxLength(20)]
        public String Cedula { get; set; }
        [Column("NOMBRE_PROFESOR")]
        [MaxLength(20)]
        public String Nombre { get; set; }
        [Column("PRIMER_APELLIDO_P")]
        [MaxLength(20)]
        public String Apellido1 { get; set; }

        [Column("SEGUNDO_APELLIDO_P")]
        [MaxLength(20)]
        public String Apellido2 { get; set; }

        [Column("TELEFONO_PROFESOR")]
        [MaxLength(8)]
        public String Telefono { get; set; }

        [Column("FECHA_INGRESO_PROFESOR")]
        public DateTime FechaIngreso { get; set; }

        [Column("ESTADO_PROFESOR")]
        [MaxLength(3)]
        public String Estado { get; set; }


        [Column("CORREO_PROFESOR")]
        [MaxLength(25)]
        public String Email { get; set; }

        [Column("BORRADO_PROFESOR")]
        public bool EstaBorrado {get;set;} 
    }
}