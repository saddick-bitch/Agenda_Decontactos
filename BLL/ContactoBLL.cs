using DAL;
using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;


namespace BLL
{
    public class ContactoBLL
    {
        public bool Insertar(Contacto contacto)
        {
            try
            {
                using (var context = new AgendaContext())
                {
                    context.Contactos.Add(contacto);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar el contacto", ex);
            }
        }

        public List<Contacto> ObtenerTodos()
        {
            using (var context = new AgendaContext())
            {
                return context.Contactos
                    .Include("TipoContacto")
                    .Include("Direcciones")
                    .Include("ContactoEtiquetas.Etiqueta")
                    .ToList();
            }
        }

        public bool Eliminar(int id)
        {
            try
            {
                using (var context = new AgendaContext())
                {
                    var contacto = context.Contactos.Find(id);
                    if (contacto != null)
                    {
                        context.Contactos.Remove(contacto);
                        context.SaveChanges();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar contacto", ex);
            }
            return false;
        }

    }
}
