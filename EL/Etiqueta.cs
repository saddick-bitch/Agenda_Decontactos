using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EL
{
    public class Etiqueta
    {
        public int Id { get; set; }

        [Required, StringLength(20)]
        public string Nombre { get; set; }

        public virtual List<ContactoEtiqueta> ContactoEtiquetas { get; set; } = new List<ContactoEtiqueta>();
    }
}
