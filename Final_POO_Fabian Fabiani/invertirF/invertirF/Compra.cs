using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;



namespace invertirF
{
    
    public class Compra
    {
        
        private int NumTransaccion;
        private Empresa empresa;
        private Cliente cliente;
        

        //agregacion con empresa y cliente
        public Compra(int numTransaccion, Empresa empresa, Cliente cliente)
        {
            NumTransaccion = numTransaccion;
            this.empresa = empresa;
            this.cliente = cliente;

        }
       
        public void detalle()
        {
            Console.WriteLine(this.NumTransaccion);
            Console.WriteLine(this.empresa.getNombre());
            Console.WriteLine(this.empresa.getTipo());
            Console.WriteLine(this.cliente.getNombreCompleto());
            Console.WriteLine(this.empresa.getPrecio());
        }
    }
}
