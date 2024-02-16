using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class Fhabitaciones : Form
    {
        Habitaciones objeto = new Habitaciones();
        private void MostrarHabitaciones()
        {
            dataGridView1.DataSource = objeto.MostrarHabitaciones();
        }
        public Fhabitaciones()
        {
            InitializeComponent();
        }

        private void Fhabitaciones_Load(object sender, EventArgs e)
        {
            MostrarHabitaciones();
        }
    }
}
