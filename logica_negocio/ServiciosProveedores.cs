using Dominio;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
   public class ServiciosProveedores
    {

        //precondicion: No existe un proveedor igual que el pasado por parámetro
        //postcondicion: Se añade el nuevo proveedor en la persistencia
        public bool añadirProveedor(Proveedor p)
        {
            if (!Persistencia<Proveedor>.contiene(p))
            {
                PersProveedor.Alta(p);
                return true;
            }
            else
            {
                //    MessageBox.Show("¡Ya existe!");
                return false;
            }
        }

        //precondicion: Existe el proveedor
        //postcondicion: Se elimina el proveedor pasado por parámetros de la persistencia
        public bool eliminarProveedor(Proveedor p)
        {
           if (!Persistencia<Proveedor>.contiene(p))
            {
                PersProveedor.Baja(p);
                return true;
            }
            else
            {
                //    MessageBox.Show("¡No existe este proveedor!");
                return false;
            }
        }

        //precondicion: Existe el proveedor
        //postcondicion: Se devuelve el proveedor cuyo codigo es pasado por parámetro
        public Proveedor getProveedor(string codigo)
        {
            Collection<Proveedor> proveedores = Persistencia<Proveedor>.Coleccion();
            foreach (Proveedor prov in proveedores)
            {
                if (prov.Id == codigo)
                {
                    return prov;
                }
            }
            return null;
        }


    }
}
