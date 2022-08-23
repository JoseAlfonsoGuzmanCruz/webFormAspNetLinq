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
    }
}
