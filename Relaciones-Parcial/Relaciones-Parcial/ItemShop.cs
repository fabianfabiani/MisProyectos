using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relaciones_Parcial
{
    public class ItemShop: Item
    {
        // No estoy usando estos atributos 
        private DateTime fechaVencimiento;  
        private string ubicacion;

        
        public ItemShop(string descripcion, int cantidad, float precio) : base(descripcion, cantidad, precio)
        {
            this.fechaVencimiento = DateTime.Now;
            this.ubicacion = "Estanteria";
        }

        //ni sus metodos Set
        public void setFechaVencimiento(DateTime fechaVencimiento)
        {
            this.fechaVencimiento = fechaVencimiento;
        }
        public void setUbicacion(string ubicacion)
        {
            this.ubicacion = ubicacion; 
        }
        
    }
}
