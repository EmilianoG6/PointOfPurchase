namespace PIA_PoP
{
    public partial class FormDetalleOrden : Form
    {
        public FormDetalleOrden()
        {
            InitializeComponent();
        }

        CRUD CRUD = new CRUD();

        public void mostrarPanelBusquedaDelete()
        {
            panelSearch.Visible = true;
            buttonConfirmarAdd.Visible = false;
            buttonDelete.Visible = true;
            textBoxIDProducto.Enabled = false;
            textBoxMarca.Enabled = false;
            textBoxCosto.Enabled = false;
            textBoxCantidad.Enabled = false;
        }

        public void toCreate()
        {
            SQL SQL = new SQL();
            try
            {
                SQL.CreateDetalleOrden(int.Parse(textBoxIDOrdenCompra.Text), int.Parse(textBoxIDProducto.Text), textBoxMarca.Text, int.Parse(textBoxCosto.Text), int.Parse(textBoxCantidad.Text));
                CRUD.toRead(13);
                MessageBox.Show("Registro agregado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hay un error en la creación del registro. " + ex.Message);
            }
        }

        public void toDelete()
        {
            try
            {
                SQL SQL = new SQL();
                SQL.DeleteDetalleOrden(int.Parse(textBoxIDOrdenCompra.Text));
                MessageBox.Show("Registro eliminado.");
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la eliminación del registro. " + ex.Message);
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                SQL SQL = new SQL();
                DetalleOrden detalleOrden = SQL.LoadDetalleOrden(int.Parse(textBoxIDOrdenCompra.Text));
                textBoxIDOrdenCompra.Text = detalleOrden.IDOrdenCompra.ToString();
                textBoxIDProducto.Text = detalleOrden.IDProducto.ToString();
                textBoxMarca.Text = detalleOrden.NombreMarca.ToString();
                textBoxCosto.Text = detalleOrden.Costo.ToString();
                textBoxCantidad.Text = detalleOrden.Cantidad.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontró el registro deseado. " + ex.Message);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            textBoxIDOrdenCompra.Text = "";
            textBoxIDOrdenCompra.Text = "";
            textBoxIDProducto.Text = "";
            textBoxMarca.Text = "";
            textBoxCosto.Text = "";
            textBoxCantidad.Text = "";
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            this.toCreate();
            buttonCancelar_Click(sender, e);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            this.toDelete();
            buttonCancelar_Click(sender, e);
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }            
            CRUD.TopLevel = false;
            this.panelContenedor.Controls.Add(CRUD);
            this.panelContenedor.Tag = CRUD;
            CRUD.Show();
            CRUD.toRead(13);
        }
    }
}
