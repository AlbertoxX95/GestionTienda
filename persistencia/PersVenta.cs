using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Persistencia
{
    public class PersVenta : Persistencia<Venta>
    {
        public static void Alta(Venta v)
        {
            Singleton<Venta>.Coleccion.Add(v);
            //Igual hay que añadirlo a un listado de ventas que tenga el dependiente.
        }
    }
}
