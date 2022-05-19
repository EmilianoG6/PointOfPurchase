namespace PIA_PoP
{
    public partial class CRUD : Form
    {        
        public CRUD()
        {
            InitializeComponent();            
        }
        
        public void toRead(int opRead)
        {
            SQL toRead = new SQL();
            switch (opRead)
            {
                case 0:
                    {
                        dataGridView.DataSource = toRead.ReadEmpresa();
                        break;
                    }
                case 1:
                    {
                        dataGridView.DataSource = toRead.ReadVentas();
                        break;
                    }
                case 2:
                    {
                        dataGridView.DataSource = toRead.ReadProductos();
                        break;
                    }
                case 3:
                    {
                        dataGridView.DataSource = toRead.ReadEmpleados();
                        break;
                    }
                case 4:
                    {
                        dataGridView.DataSource = toRead.ReadClientes();
                        break;
                    }
                case 5:
                    {
                        dataGridView.DataSource = toRead.ReadProveedores();
                        break;
                    }
                case 6:
                    {
                        dataGridView.DataSource = toRead.ReadCategorias();
                        break;
                    }
                case 7:
                    {
                        dataGridView.DataSource = toRead.ReadMarcas();
                        break;
                    }
                case 8:
                    {
                        dataGridView.DataSource = toRead.ReadUnidades();
                        break;
                    }
                case 9:
                    {
                        dataGridView.DataSource = toRead.ReadFacturas();
                        break;
                    }
                case 10:
                    {
                        dataGridView.DataSource = toRead.ReadOrdenes();
                        break;
                    }
                case 11:
                    {
                        dataGridView.DataSource = toRead.ReadDetalleTickets();
                        break;
                    }
                case 12:
                    {
                        dataGridView.DataSource = toRead.ReadDetalleFacturas();
                        break;
                    }
                case 13:
                    {
                        dataGridView.DataSource = toRead.ReadDetalleOrdenes();
                        break;
                    }
            }            
        }

        #region HELPER
        public int? GetID()
        {
            try
            {
                return int.Parse(dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hay un error en la edición de datos. " + ex.Message);
                return 1;
            }            
        }
        #endregion
    }
}