using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Persistencia
{
    public class Persistencia<T> where T : InterfazID
    {
        //Esto o por codigo
        public static T Buscar(T t)
        {
            return Singleton<T>.Coleccion[t.Id];
        }
        
        public static T BuscarCodigo (String codigo)
        {
            return Singleton<T>.Coleccion[codigo];
        }
        //t1 tiene que ser un objeto de la tienda y estar en la colección.
        public static void Modificar(T t1, T t2)
        {
            Singleton<T>.Coleccion.Remove(t1);
            Singleton<T>.Coleccion.Add(t2);
        }
        public static bool contiene(T t)
        {
            return Singleton<T>.Coleccion.Contains(t.Id);
        }
        public static Collection<T> Coleccion()
        {
            return Singleton<T>.Coleccion;
        }

    }
}
