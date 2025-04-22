using System;
using System.ComponentModel.DataAnnotations;

namespace EL
{
    public class Auditoria
    {
        public int Id { get; set; }

        [Required]
        public string Entidad { get; set; }

        [Required]
        public string Operacion { get; set; }

        public string Detalles { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;
    }
}
