using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invertirF
{
    public class Cliente
    {
        private string nombre;
        private string apellido;
        private int doc;


        public Cliente(string nombre, string apellido, int doc)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.doc = doc;
        }

        public string getNombreCompleto()
        {
            return this.apellido + " " + this.nombre;
        }
    }
}
