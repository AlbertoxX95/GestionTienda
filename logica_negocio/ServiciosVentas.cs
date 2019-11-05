using Dominio;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
   public class ServiciosVentas
    {

        //precondicion: No existe una venta igual que el pasado por parámetro
        //postcondicion: Se añade la nueva venta en la persistencia
        public bool añadirVenta(Venta v)
        {
            if (!Persistencia<Venta>.contiene(v))
            {
                PersVenta.Alta(v);
                return true;
            }
            else
            {
                //    MessageBox.Show("¡Ya existe!");
                return false;
            }
        }

        //precondicion: Existe la venta
        //postcondicion: Se devuelve la venta cuyo codigo es pasado por parámetro
        public Venta getVenta(string codigo)
        {
            Collection<Venta> ventas = Persistencia<Venta>.Coleccion();
            foreach (Venta ven in ventas)
            {
                if (ven.Id == codigo)
                {
                    return ven;
                }
            }
            return null;
        }
        public Collection<Venta> listaVentas()
        {
            return Persistencia<Venta>.Coleccion();
        }
    }
    
}
