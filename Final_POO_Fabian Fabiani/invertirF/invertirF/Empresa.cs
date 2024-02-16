using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace invertirF
{
    public class Empresa
    {
        private string nombre;
        private string ubicacion;
        private Tipo tipo;
        private float precio;

        //Agregacion tipo
        public Empresa(string nombre, string ubicacion, Tipo tipo, float precio)
        {
            this.nombre = nombre;
            this.ubicacion = ubicacion;
            this.tipo = tipo;
            this.precio = precio;
        }
        public string getNombre()
        {
            return this.nombre;
        }
        public float getPrecio()
        {
            return this.precio;
        }
        public string getTipo()
        {
            return this.tipo.getSiglas();
        }


        
    }

}
