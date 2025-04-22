using System.Data.Entity;
using EL;

namespace DAL
{
    public class AgendaContext : DbContext
    {
        public AgendaContext() : base("name=ConexionAgenda") { }

        public DbSet<Contacto> Contactos { get; set; }
        public DbSet<TipoContacto> TiposContacto { get; set; }
        public DbSet<Direccion> Direcciones { get; set; }
        public DbSet<Etiqueta> Etiquetas { get; set; }
        public DbSet<ContactoEtiqueta> ContactosEtiquetas { get; set; }
        public DbSet<Auditoria> Auditorias { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactoEtiqueta>()
                .HasKey(c => new { c.ContactoId, c.EtiquetaId });

            modelBuilder.Entity<Contacto>()
                .HasRequired(c => c.TipoContacto)
                .WithMany(tc => tc.Contactos)
                .HasForeignKey(c => c.TipoContactoId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Direccion>()
                .HasRequired(d => d.Contacto)
                .WithMany(c => c.Direcciones)
                .HasForeignKey(d => d.ContactoId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ContactoEtiqueta>()
                .HasRequired(ce => ce.Contacto)
                .WithMany(c => c.ContactoEtiquetas)
                .HasForeignKey(ce => ce.ContactoId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ContactoEtiqueta>()
                .HasRequired(ce => ce.Etiqueta)
                .WithMany(e => e.ContactoEtiquetas)
                .HasForeignKey(ce => ce.EtiquetaId)
                .WillCascadeOnDelete(false);
        }
    }
}
