using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Dominio;

namespace Persistencia
{
    public class Singleton<T> where T : InterfazID
    {
        private static Collection<T> coleccion;
        private Singleton() {

        }

        internal static Collection<T> Coleccion
        {
            get
            {
                if(coleccion != null)
                {
                    return coleccion;
                }else
                {
                    coleccion = new Collection<T>();
                    return coleccion;
                }
            }
        }
    }
}
