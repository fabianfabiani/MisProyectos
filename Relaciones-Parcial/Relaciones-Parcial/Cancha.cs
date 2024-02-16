using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relaciones_Parcial
{  
    class Cancha
    {
        private int id;
        private bool estado = true;
        private string tipo;
        private string uso;

        public Cancha(int id, bool estado, string tipo)
        {
            this.id = id;
            if (estado == true)
            {
                this.uso = "Disponible";
            }
            else
            {
                this.uso = "En uso";
            }
            this.tipo = tipo;
        }

        public void setDisponible(bool estado)
        {
            this.estado = estado;
        }
        public void getCancha()
        {
            Console.WriteLine(" ");
            Console.WriteLine("**** ACCEDE A CANCHA ****");
            Console.WriteLine("Cancha    Estado      Tipo");
            Console.WriteLine("  " + this.id + "      " + this.uso + "   " + this.tipo);

        }
    }
}
