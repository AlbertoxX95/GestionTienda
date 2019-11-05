using Dominio;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    //Aqui implementamos los servicios que hay de un articulo
    public class ServiciosArticulos
    {

        //precondicion: No existe un articulo igual que el pasado por parámetro
        //postcondicion: Se añade el nuevo articulo en la persistencia
        public bool añadirArticulo(Articulo a)
        {
            if(!Persistencia<Articulo>.contiene(a))
             {
                 PersArticulo.Alta(a);
                return true;
             }
             else{

                //    MessageBox.Show("¡Ya existe!");
                return false;
             }
        }

        //precondicion: Existe el articulo
        //postcondicion: Se elimina el articulo pasado por parámetros de la persistencia
        public bool eliminarArticulo(Articulo a)
        {
            if (!Persistencia<Articulo>.contiene(a))
            {
                PersArticulo.Baja(a);
                return true;
            }
            else
            {
                //    MessageBox.Show("¡No existe este articulo!");
                return false;
            }
        }

        //precondicion: Existe el articulo
        //postcondicion: Se devuelve el articulo cuyo codigo es pasado por parámetro
        public Articulo getArticulo(string codigo)
        {
            Collection<Articulo> articulos = Persistencia<Articulo>.Coleccion();
            foreach (Articulo art in articulos)
            {
                if (art.Id == codigo)
                {
                    return art;
                }
            }
            return null;
        }
        /// <summary>
        /// devuelve la lista de articulos
        /// </summary>
        /// <returns></returns>
        public Collection<Articulo> listaArticulo()
        {
            return Persistencia<Articulo>.Coleccion();
        }




    }
}
