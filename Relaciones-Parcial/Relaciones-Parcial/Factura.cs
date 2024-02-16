using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relaciones_Parcial
{
    public class Factura
    {
        private Turno turno;
        private Cliente cliente;

        public Factura(Turno turno, Cliente cliente)
        {
            this.turno = turno;
            this.cliente = cliente;
        }
    }
}
