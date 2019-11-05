using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Venta : IEquatable<Venta>, InterfazID
    {
        private String idVenta;
        private DateTime fecha;
        private double importe;
        private String tarjeta;
        private Dependiente dependiente;
        private List<Articulo> artVenta;

        public Venta(String id, DateTime f, double i, String t, Dependiente d,List<Articulo> lista)
        {
            this.idVenta = id;
            this.fecha = f;
            this.importe = i;
            this.tarjeta = t;
            this.dependiente = d;
            this.artVenta = lista;
        }
        public Venta(String id, DateTime f, double i, Dependiente d, List<Articulo> a)
        {
            this.idVenta = id;
            this.fecha = f;
            this.importe = i;
            this.tarjeta = "";
            this.dependiente = d;
            this.artVenta = a;
        }
        public String Id
        {
            get
            {
                return this.idVenta;
            }
        }
        public DateTime Fecha
        {
            get
            {
                return this.fecha;
            }
        }
        public double Importe
        {
            get
            {
                return this.importe;
            }
        }
        public String Tarjeta
        {
            get
            {
                return this.tarjeta;
            }
        }
        public Dependiente Dependiente
        {
            get
            {
                return this.dependiente;
            }
        }
        public List<Articulo> ArtVenta
        {
            get
            {
                return this.artVenta;
            }
        }
        public bool Equals(Venta other)
        {
            return this.idVenta == other.Id;
        }

        public String toString()
        {
            return "Venta: " + this.idVenta + " " + this.fecha + "Precio: " + this.importe;
        }
    }
}
