using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EL
{
    public class Direccion
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Calle { get; set; }

        [Required, StringLength(50)]
        public string Ciudad { get; set; }

        [Required, StringLength(50)]
        public string Estado { get; set; }

        [Required, StringLength(10)]
        public string CodigoPostal { get; set; }

        [ForeignKey("Contacto")]
        public int ContactoId { get; set; }

        public virtual Contacto Contacto { get; set; }
    }
}
