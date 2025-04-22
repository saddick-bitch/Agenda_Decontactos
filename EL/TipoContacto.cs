using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EL
{
    public class TipoContacto
    {
        public int Id { get; set; }

        [Required, StringLength(30)]
        public string Nombre { get; set; }

        public virtual List<Contacto> Contactos { get; set; } = new List<Contacto>();
    }
}
