namespace EL
{
    public class ContactoEtiqueta
    {
        public int ContactoId { get; set; }
        public int EtiquetaId { get; set; }

        public virtual Contacto Contacto { get; set; }
        public virtual Etiqueta Etiqueta { get; set; }
    }
}
