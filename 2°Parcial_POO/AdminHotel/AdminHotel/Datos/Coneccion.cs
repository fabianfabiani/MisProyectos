using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Datos
{
    public class DB_Coneccion
    {
        private SqlConnection Coneccion = new SqlConnection("Server=DESKTOP-MOVIA55\\MISQLSERVICIO;Initial Catalog=Hotel;Integrated Security=True");

        public SqlConnection AbrirConeccion()
        {
            if (Coneccion.State == ConnectionState.Closed)
            {
                Coneccion.Open();
            }
            return Coneccion;
        }

        public SqlConnection CerrarConeccion()
        {
            if (Coneccion.State == ConnectionState.Open)
            {
                Coneccion.Close();
            }
            return Coneccion;
        }
    }
}
