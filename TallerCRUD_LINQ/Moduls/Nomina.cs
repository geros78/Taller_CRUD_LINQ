using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TallerCRUD_LINQ.Moduls
{
    public class Nomina
    {
        [Key]
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int IdEmpleado { get; set; }
        public decimal Sueldo { get; set; }
        public int Dias { get; set; }
        public decimal Otros { get; set; }

    }
}
