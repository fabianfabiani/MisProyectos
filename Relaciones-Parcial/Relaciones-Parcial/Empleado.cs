using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relaciones_Parcial
{
    public class Empleado : Persona // Herencia
    {
        private double sueldo;
        private DateTime fecha_inicio;
        private string puesto;
        private string categoria = null;

        public Empleado(string nombre, string apellido, int num_documento, string tipo_documento, string puesto) : base(nombre, apellido, num_documento, tipo_documento)
        {
            this.fecha_inicio = DateTime.Now;
            this.sueldo = 0;
            this.puesto = puesto;
        }

        public void setFechaInicio(DateTime fecha)
        {
            this.fecha_inicio = fecha;
        }

        public  string getEmpleado()
        {
            return this.getNombreCompleto();
        }
        /*public string getNombreEmpleado()
        {
            return this.nombre;
        }*/
    }
}
