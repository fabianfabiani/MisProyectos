using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Datos;

namespace Negocio
{
    public class Habitaciones
    {
        private D_Habitaciones objeto = new D_Habitaciones();
        public DataTable MostrarHabitaciones()
        {
            DataTable tabla = new DataTable();
            tabla = objeto.MostrarHabitaciones();
            return tabla;
        }
    }
}
