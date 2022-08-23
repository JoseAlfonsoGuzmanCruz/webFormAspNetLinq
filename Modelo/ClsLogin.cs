using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ClsLogin
    {
        public static int IniciarSesion(string cedula, string clave)
        {
            EntidadesDataContext context = new EntidadesDataContext();
            int usuarioId = 0;
            var query = context.persona.Where(p => p.cedula == cedula && p.clave == clave).Select(p => p);

            var query1 = from p in context.persona
                         where p.cedula == cedula && p.clave == clave
                         select p;

            if (query.Count() > 0)
            {
                usuarioId = query.First().id_persona;
            }
            return usuarioId;
        }
    }
}
