﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TallerCRUD_LINQ.Moduls
{
    public class Areas
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public string Nombre { get; set; }
    }
}
