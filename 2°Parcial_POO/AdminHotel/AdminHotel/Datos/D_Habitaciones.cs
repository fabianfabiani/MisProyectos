using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{

    public class D_Habitaciones
    {
        private DB_Coneccion coneccion = new DB_Coneccion();
        SqlDataReader reader;
        DataTable tabla = new DataTable();
        SqlCommand query = new SqlCommand();

        public DataTable MostrarHabitaciones()
        {
            query.Connection = coneccion.AbrirConeccion();
            query.CommandText = "Select * from Habitaciones";
            reader = query.ExecuteReader();
            tabla.Load(reader);
            coneccion.CerrarConeccion();
            return tabla;
        }
    }
}
