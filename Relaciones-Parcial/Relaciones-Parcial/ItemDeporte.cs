using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relaciones_Parcial
{
    public class ItemDeporte : Item
    {
        private bool alquiler;
        private float precioVenta;
        private float precioAlquiler;
        private float precioDeporte;

        public ItemDeporte(string descripcion, int cantidad, float precio, bool alquiler) : base(descripcion, cantidad, precio)
        {
            if(alquiler == true)
            {
                this.precioDeporte = precio;
            }
            else if(alquiler == false)
            {
                this.precioDeporte = precio * 3;
            }
        }
        //No estoy usando estos metodos set precio y set venta
        public void setPrecioAlquiler(float precioAlquiler)
        {
            this.precioAlquiler = precioAlquiler;
        }
        public void setPrecioVenta(float precioVenta)
        {
            this.precioVenta = precioVenta;
        }

        public float getPrecioDeporte()
        { 
            return this.precioDeporte * this.getCantidad(); ;
        }

         
    }
}
