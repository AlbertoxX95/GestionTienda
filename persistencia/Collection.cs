using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Collections.ObjectModel;

namespace Persistencia
{
    public class Collection<T> : KeyedCollection<String, T> where T : InterfazID
    {
        protected override String GetKeyForItem(T t)
        {
            return t.Id;
        }
    }
}
