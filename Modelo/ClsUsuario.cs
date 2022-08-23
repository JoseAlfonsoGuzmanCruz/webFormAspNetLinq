using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ClsUsuario
    {
        public static persona BuscarPorId(int usuarioId)
        {
            EntidadesDataContext context = new EntidadesDataContext();
            persona persona = null;
            var query = context.persona.Where(p => p.id_persona == usuarioId).Select(p => p);

            if(query.Count() > 0)
            {
                persona = query.First();
            }
            return persona;
        }
        public static object ListaUsuarios(int usuarioId)
        {
            EntidadesDataContext context = new EntidadesDataContext();
            var query = from u in context.persona
                        join c in context.ciudad
                        on u.ciudad_id equals c.id_ciudad
                        where u.id_persona != usuarioId
                        select new
                        {
                            Cedula = u.cedula,
                            Nombre = u.nombre,
                            Apellido = u.apellido,
                            Correo = u.correo,
                            Ciudad = c.nombre
                        };
            return query;
        }
    }
}
