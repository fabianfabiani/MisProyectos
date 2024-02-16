using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relaciones_Parcial
{
    public class Cliente : Persona //Herencia
    {
        private int numero_cuit;
        private string tipo_iva;

        public Cliente(string nombre, string apellido, int num_documento, string tipo_documento, int cuit) : base(nombre, apellido, num_documento, tipo_documento)
        {
            this.numero_cuit = cuit;
            this.tipo_iva = null;

            /* string getNombreCliente()
             {
                 return this.nombre + " " + this.apellido;
             }*/
        }
    }
}
