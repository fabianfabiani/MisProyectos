using Relaciones_Parcial;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        //Creo un cliente, uso sus metodos
        Cliente Fabian = new Cliente("Fabian", "Fabiani", 27065412, "dni", 2027654);
        DateTime nacimiento_Fabian = new DateTime(1979, 03, 02);
        Fabian.setFechaNacimiento(nacimiento_Fabian);
        Console.WriteLine(Fabian.getNombreCompleto());
        Console.WriteLine(Fabian.getEdad());

        //Creo un empleado, creo un turno, agrego una cancha, imprimo detalles
        Empleado Juan = new Empleado("Juan", "Gonzales", 456132, "dni", "programador");
        Turno turno01 = new Turno(2, 2500, DateTime.Now, Juan);    //agregacion (en su constructor coloco el empleado)
        turno01.agregarCancha(1, true, "techada");  //composicion (creo la cancha atravez de su metodo)
        turno01.imprimir();
        //Console.WriteLine("El alquiler de la cancha es: " + turno01.getTotal());  esto lo puse dentro del metodo imprimir

        //movimiento de venta
        Movimiento venta01 = new Movimiento(Juan, Fabian, DateTime.Now);
        venta01.agregarItemShop("Coca 600", 1, 300);
        venta01.agregarItemDeporte("Raqueta", 2, 400, true);
        venta01.agregarItemDeporte("Raqueta", 2, 400, false);
        venta01.imprimir(); 
       

        

        //metodos de la clase Item
        //ItemDeporte paddle = new ItemDeporte("pelota", 1, 200, true);
        //paddle.setPrecioVenta(250);
        //paddle.setPrecioAlquiler(100);
        //paddle.getItem();
        


    }

} 