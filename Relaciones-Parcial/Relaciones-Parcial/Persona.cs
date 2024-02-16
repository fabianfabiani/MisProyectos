using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relaciones_Parcial
{
    public abstract class Persona
    {
        string nombre;
        string apellido;
        int num_documento;
        string tipo_documento;
        DateTime fecha_nacimiento;
        public Persona(string nombre, string apellido, int num_documento, string tipo_documento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.num_documento = num_documento;
            this.tipo_documento = tipo_documento;
            this.fecha_nacimiento = DateTime.Now;
        }
        public void setFechaNacimiento(DateTime fecha)
        {
            this.fecha_nacimiento = fecha;
        }

        public string getNombreCompleto()
        {
            return this.apellido + " " + this.nombre;
        }

        public int getEdad()
        {
            DateTime fechaActual = DateTime.Now;
            int edad = fechaActual.Year - this.fecha_nacimiento.Year;
            return edad;
        }
    }
}
