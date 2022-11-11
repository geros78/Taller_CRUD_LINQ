using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TallerCRUD_LINQ.Moduls
{
    public class Empleados
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Campo Requerido")]
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaIngreso { get; set; }
        [ForeignKey("IdArea")]
        public int IdArea { get; set; }
    }
}
