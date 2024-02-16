using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invertirF
{
    public class Tipo
    {
        private int id;
        private string nombre;
        private string siglas;

        public Tipo(int id, string nombre, string siglas)
        {
            this.id = id;
            this.nombre = nombre;
            this.siglas = siglas;   
        }

        public string getSiglas()
        {
            return this.siglas;
        }
    }
}
