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
    public class Tablas
    {
        private D_consulta objeto = new D_consulta();

        public DataTable MostrarConsulta()
        {
            DataTable tabla = new DataTable();
            tabla = objeto.Mostrar();
            return tabla;
        }
        
    }
}
