using DAL;
using EL;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class TipoContactoBLL
    {
        public List<TipoContacto> ObtenerTodos()
        {
            using (var db = new AgendaContext())
            {
                return db.TiposContacto.ToList();
            }
        }

    }
}
