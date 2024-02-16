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
    public partial class Fmain : Form
    {
        public Fmain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bConsulta_Click(object sender, EventArgs e)
        {
            Form1 FTablas = new Form1();
            FTablas.ShowDialog();       //metodo para que aparesca el formulario
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas salir", "Salir", MessageBoxButtons.OKCancel)==DialogResult.OK)
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void bHabitaciones_Click(object sender, EventArgs e)
        {
            Fhabitaciones Fhabitaciones = new Fhabitaciones();
            Fhabitaciones.ShowDialog();       //metodo para que aparesca el formulario
        }
    }
}
