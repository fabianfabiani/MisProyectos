using Negocio;

namespace FrontEnd
{
    public partial class Form1 : Form
    {
        Tablas objeto = new Negocio.Tablas();
        
        public Form1()
        {
            InitializeComponent();
        }
        private void MostrarConsulta()
        {
            dataGridView1.DataSource = objeto.MostrarConsulta();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarConsulta();
            
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}