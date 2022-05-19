namespace PIA_PoP
{
    public partial class FormDetalleTicket : Form
    {
        public FormDetalleTicket()
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
            textBoxPrecioUnitario.Enabled = false;
            textBoxCantidad.Enabled = false;
        }

        public void toCreate()
        {
            SQL SQL = new SQL();
            try
            {
                SQL.CreateDetalleTicket(int.Parse(textBoxIDTicket.Text), int.Parse(textBoxIDProducto.Text), int.Parse(textBoxPrecioUnitario.Text), int.Parse(textBoxCantidad.Text));
                CRUD.toRead(11);
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
                SQL.DeleteDetalleTicket(int.Parse(textBoxIDTicket.Text));
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
                DetalleTicket detalleTicket = SQL.LoadDetalleTicket(int.Parse(textBoxIDTicket.Text));
                textBoxIDTicket.Text = detalleTicket.IDTicket.ToString();
                textBoxIDProducto.Text = detalleTicket.IDProducto.ToString();
                textBoxPrecioUnitario.Text = detalleTicket.PrecioUnitario.ToString();
                textBoxCantidad.Text = detalleTicket.Cantidad.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontró el registro deseado. " + ex.Message);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            textBoxIDTicket.Text = "";
            textBoxIDProducto.Text = "";
            textBoxPrecioUnitario.Text = "";
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
            CRUD.toRead(12);
        }
    }
}
