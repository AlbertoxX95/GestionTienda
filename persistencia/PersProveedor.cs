using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Persistencia
{
    public class PersProveedor : Persistencia<Proveedor>
    {
        public static void Baja(Proveedor p)
        {
            Singleton<Proveedor>.Coleccion.Remove(p);
        }
        public static void Alta(Proveedor p)
        {
            Singleton<Proveedor>.Coleccion.Add(p);
        }
    }
}
