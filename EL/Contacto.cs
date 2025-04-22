using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EL
{
    public class Contacto
    {
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Nombre { get; set; }

        [Required, StringLength(50)]
        public string Apellido { get; set; }

        [Phone]
        public string Telefono { get; set; }

        [EmailAddress]
        public string Correo { get; set; }

        public int TipoContactoId { get; set; }
        public virtual TipoContacto TipoContacto { get; set; }

        public virtual List<Direccion> Direcciones { get; set; } = new List<Direccion>();
        public virtual List<ContactoEtiqueta> ContactoEtiquetas { get; set; } = new List<ContactoEtiqueta>();
    }
}
