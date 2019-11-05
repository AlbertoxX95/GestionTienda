using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Persistencia
{
    public class PersDependiente : Persistencia<Dependiente>
    {
        public static void Baja(Dependiente d)
        {
            Singleton<Dependiente>.Coleccion.Remove(d);
        }
        public static void Alta(Dependiente d)
        {
            Singleton<Dependiente>.Coleccion.Add(d);
        }
    }
}

