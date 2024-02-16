using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Relaciones_Parcial
{
    public class Movimiento : Iimpresion
    {
        private Empleado Empleado;
        private Cliente Cliente;
        private List<ItemShop> itemShop;
        private List<ItemDeporte> itemDeporte;
        private DateTime fechaVenta;
        private string estado;
        private float total = 0;

        public Movimiento(Empleado empleado, Cliente cliente, DateTime fechaVenta)
        {
            this.Empleado = empleado;
            this.Cliente = cliente;
            this.fechaVenta = DateTime.Now;
            this.itemShop = new List<ItemShop>();
            this.itemDeporte = new List<ItemDeporte>();
        }
        public void imprimir()
        {
            Console.WriteLine("");
            Console.WriteLine("***** INFORME DE FACTURA *****");
            Console.WriteLine("Descripcion    Cantidad    Precio ");
            foreach (var itemShop in this.getItemsShop())
            {
                Console.WriteLine(itemShop.getDescripcion() + "        " + itemShop.getCantidad() + "          " + itemShop.getPrecio());
                total += itemShop.getPrecio();

            }
            foreach (var itemDeporte in this.getItemDeportes())
            {
                Console.WriteLine(itemDeporte.getDescripcion() + "         " + itemDeporte.getCantidad() + "          " + itemDeporte.getPrecioDeporte());
                total += itemDeporte.getPrecioDeporte();
            }
            Console.WriteLine("----------  ---------   ----------");
            Console.WriteLine($"Total Productos:           {total}");

        }
        public void agregarItemShop(string descripcion, int cantidad, float precio)
        {
            ItemShop unItemShop = new ItemShop(descripcion, cantidad, precio);
            this.itemShop.Add(unItemShop);
        }
        public void agregarItemDeporte(string descripcion, int cantidad, float precio, bool alquiler)
        {
            ItemDeporte unItemDeporte = new ItemDeporte(descripcion, cantidad, precio, alquiler);
            this.itemDeporte.Add(unItemDeporte);
        }
        public List<ItemShop> getItemsShop()
        {
            return this.itemShop;
        }
        public List<ItemDeporte> getItemDeportes()
        {
            return this.itemDeporte;
        }
        
    }
}
