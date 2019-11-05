using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Dependiente : IEquatable<Dependiente>, InterfazID
    {

        private String nombre;
        private String apellidos;
        private String NSS;
        private List<Venta> ventas;
        private List<Proveedor> proveedores;
        
        public Dependiente(String n, String a, String NSS)
        {
            this.nombre = n;
            this.apellidos = a;
            this.NSS = NSS;
            this.ventas = new List<Venta>();
            this.proveedores = new List<Proveedor>();
        }
        public String Id
        {
            get
            {
                return this.NSS;
            }
        }
        public String Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        public String Apellidos
        {
            get
            {
                return this.apellidos;
            }
        }
        public List<Venta> Ventas
        {
            get
            {
                return this.ventas;
            }
        }
        public List<Proveedor> Proveedores
        {
            get
            {
                return this.proveedores;
            }
        }
        public double comision(double porcentaje)
        {
            int contador = 0;
            foreach(Venta v in ventas)
            {
                if(v.Fecha.Month == DateTime.Today.Month)
                {
                    contador = contador + 1;
                }
            }
            return porcentaje * contador;
        }

        public bool Equals(Dependiente other)
        {
            //ID o NSS?
            return this.NSS== other.Id;
        }

        public String toString()
        {
            return "Dependiente: " + this.nombre + " " + this.apellidos + "NSS: " + this.NSS;
        }
    }
}
