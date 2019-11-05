using Dominio;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    //Aqui implementamos los servicios de un dependiente
    public class ServiciosDependientes
    {

        ///precondición: no existe un dependiente igual que el pasado por parámetro.
        ///postcondición: Se añade el nuevo dependiente en la persistencia
        public bool añadirDependiente(Dependiente d)
        {          
           if(!Persistencia<Dependiente>.contiene(d))
            {
                PersDependiente.Alta(d);
                return true;
            }
            else{
                //  MessageBox.Show("¡Ya existe!");
                return false;
            }
        }

        ///precondición: Existe el dependiente
        ///postcondición: Se elimina el dependiente pasado por parámetros de la persistencia
        public bool eliminarDependiente(Dependiente d)
        {
            if (Persistencia<Dependiente>.contiene(d))
           {
                PersDependiente.Baja(d);
                return true;
            }
            else
            {
                //MessageBox.Show("¡No existe este dependiente!");
                return false;
            }
        }

        ///precondición: Existe el dependiente
        ///postcondición: Se devuelve el dependiente cuyo codigo es pasado por parámetro
        public Dependiente getDependiente(string codigo)
        {

            Collection<Dependiente> dependientes = Persistencia< Dependiente>.Coleccion();
            foreach(Dependiente dep in dependientes)
            {
               if(dep.Id==codigo)
               {
                    return dep;
               }
            }
            return null;
        }
        public Collection<Dependiente> listaDependientes()
        {
            return Persistencia<Dependiente>.Coleccion();
        }



    }
}
