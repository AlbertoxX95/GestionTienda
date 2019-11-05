using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Proveedor : IEquatable<Proveedor>, InterfazID
    {
        private String idProveedor;
        private String nombreEmpresa;
        private String tlfn;
        private List<Dependiente> dependientes;
        private List<Articulo> articulos;

        public Proveedor(String id, String ne, String t)
        {
            this.idProveedor = id;
            this.nombreEmpresa = ne;
            this.tlfn = t;
            this.dependientes = new List<Dependiente>();
            this.articulos = new List<Articulo>();
        }
        public String Id
        {
            get
            {
                return this.idProveedor;
            }
        }
        public String NombreEmpresa
        {
            get
            {
                return this.nombreEmpresa;
            }
        }
        public String Tlfn
        {
            get
            {
                return this.tlfn;
            }
        }
        public List<Dependiente> Dependientes
        {
            get
            {
                return this.dependientes;
            }
        }
        public List<Articulo> Articulos
        {
            get
            {
                return this.articulos;
            }
        }

        public bool Equals(Proveedor other)
        {
            return this.idProveedor == other.Id;
        }
    }
}
