using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Persistencia
{
    public class PersArticulo : Persistencia<Articulo>
    {
        public static void Baja(Articulo a)
        {
            Singleton<Articulo>.Coleccion.Remove(a);
        }
        public static void Alta(Articulo a)
        {
            Singleton<Articulo>.Coleccion.Add(a);
        }
    }
}
