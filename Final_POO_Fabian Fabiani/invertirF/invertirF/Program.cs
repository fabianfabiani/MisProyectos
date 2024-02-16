using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;



namespace invertirF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tipo coc = new Tipo(1, "CocaCola","coc");
            Cliente Fabian = new Cliente("Fabian", "Fabiani", 25863126);
            Empresa cocacola = new Empresa("CocaCola", "Quilmes",coc,1500);
            Compra nuevaCompra = new Compra(001, cocacola, Fabian);
            nuevaCompra.detalle();
            Console.ReadLine();
        }
    }
}    
