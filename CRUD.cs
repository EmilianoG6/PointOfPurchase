namespace PIA_PoP
{
    public partial class CRUD : Form
    {
        public CRUD()
        {
            InitializeComponent();
        }

        public void buttonMostrar_Click(object sender, EventArgs e)
        {          
            //dataGridView.DataSource = toRead.ReadVentas();
        }

        public void toReadVenta()
        {
            SQL toReadVenta = new SQL();
            dataGridView.DataSource = toReadVenta.ReadVentas();
        }

        public void toReadProducto()
        {
            SQL toReadProducto = new SQL();
            dataGridView.DataSource = toReadProducto.ReadProductos();
        }

        public void toReadEmpleado()
        {
            SQL toReadProducto = new SQL();
            dataGridView.DataSource = toReadProducto.ReadProductos();
        }

    }
}
