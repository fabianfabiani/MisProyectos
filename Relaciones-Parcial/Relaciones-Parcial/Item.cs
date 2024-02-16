using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relaciones_Parcial
{
    public abstract class Item
    {
        private string descripcion;
        private int cantidad;
        private float precio;
        private int cantMinima;
        private DateTime fechaIngreso;

        public Item(string descripcion, int cantidad, float precio)
        {
            this.descripcion = descripcion;
            this.cantidad = cantidad;
            this.precio = precio;
        }
        //Este metodo no se si usarlo getItem
        public void getItem()
        {
            Console.WriteLine("Descripcion: " + this.descripcion);
            Console.WriteLine("Cantidad: " + this.cantidad);
            Console.WriteLine("Precio: " + this.precio);
        }
        public void setFechaIngreso(DateTime fechaIngreso)
        {
            this.fechaIngreso = fechaIngreso;
        }
        public void setcantidadMinima(int cantidadMinima)
        {
            this.cantMinima = cantidadMinima;
        }
        public string getDescripcion()
        {
            return this.descripcion;
        }
        public int getCantidad()
        {
            return this.cantidad;
        }
        public float getPrecio()
        {
            return this.precio * this.cantidad;
        }
    }
}
