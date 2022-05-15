namespace PIA_PoP
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQL toConnect = new SQL();
            if (toConnect.GetConnection())
            {
                MessageBox.Show("Connection Open!");
            }
            else
            {
                MessageBox.Show("Connection no!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SQL toReadVenta = new SQL();
            dataGridView1.DataSource = toReadVenta.ReadVentas();
        }
    }
}