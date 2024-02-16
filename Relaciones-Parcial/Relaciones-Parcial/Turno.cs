using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relaciones_Parcial
{
    public class Turno : Iimpresion
    {
        private int cantHoras;
        private float costoHora;
        private DateTime fecha;
        private Empleado empleado;
        private Cancha cancha;

        public Turno(int cantHoras, float costoHoras, DateTime fecha, Empleado empleado)
        {
            this.cantHoras = cantHoras;
            this.costoHora = costoHoras;
            this.fecha = fecha;
            this.empleado = empleado;
        }
        public void agregarCancha(int id, bool estado, string tipo)
        {
            Cancha cancha = new Cancha(id, estado, tipo);
            this.cancha = cancha;
        }

        public void imprimir()
        {
            Console.WriteLine(" ");
            Console.WriteLine("*****  DETALLES DEL TURNO  *****");
            Console.WriteLine("Cant.Horas   Costo Hora   Fecha                Total");
            Console.WriteLine("      " + this.cantHoras + "       " + this.costoHora + "       " + this.fecha + "    " + getTotal());
        
            Console.WriteLine("Empleado " + this.empleado.getEmpleado());
            Console.WriteLine("Cancha ");
            this.cancha.getCancha();
        }

        public float getTotal()
        {
            return this.costoHora * cantHoras;
        }


    }
}
