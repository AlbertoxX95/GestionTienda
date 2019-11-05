using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
namespace Dominio
{
    public class Articulo : IEquatable<Articulo>, InterfazID
    {   
        private String idArticulo;
        private String descripcion;
        private double thisprecioCoste;
        private String tipo;
        private Proveedor proveedor;
        private double precioVenta;
        //CATALOGO?
  
        public Articulo(String id, String desc, double pc, String t, Proveedor pro)
        {
            this.idArticulo = id;
            this.descripcion = desc;
            this.thisprecioCoste = pc;
            this.tipo = t;
            this.proveedor = pro;


            if (this.tipo.Contains("Normal")) {
                this.precioVenta = this.thisprecioCoste + (this.thisprecioCoste*0.21);
            }
            if (this.tipo.Contains("Reducido"))
            {
                this.precioVenta = this.thisprecioCoste + (this.thisprecioCoste * 0.10);
            }
            if (this.tipo.Contains("Superreducido"))
            {
                this.precioVenta = this.thisprecioCoste + (this.thisprecioCoste * 0.04);
            }
        }
        public String Id
        {
            get
            {
                return this.idArticulo;
            }
        }
        public String Descripcion
        {
            get
            {
                return this.descripcion;
            }
            set
            {
                this.descripcion = value;
            }
        }
        public double PrecioDeCoste
        {
            get
            {
                return this.thisprecioCoste;
            }
            set
            {
                this.thisprecioCoste = value;
            }
        }
        public String TipoDeIva
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }
        public Proveedor Proveedor
        {
            get
            {
                return this.proveedor;
            }
        }
        public double PrecioDeVenta
        {
            get
            {
                return this.precioVenta;
            }
        }

        public bool Equals(Articulo other)
        {
            return this.idArticulo == other.Id;
        }

        public String toString()
        {
            return "Artículo " + this.idArticulo + " " + this.descripcion + " Precio: " + this.thisprecioCoste;
        }
    }
}
