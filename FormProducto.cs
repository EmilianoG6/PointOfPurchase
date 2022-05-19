namespace PIA_PoP
{
    public partial class FormProducto : Form
    {
        public FormProducto()
        {
            InitializeComponent();
        }

        CRUD CRUD = new CRUD();

        public void mostrarPanelBusquedaEdit()
        {
            panelSearch.Visible = true;
            buttonAdd.Visible = false;
            buttonEdit.Visible = true;
            buttonDelete.Visible = false;
        }

        public void mostrarPanelBusquedaDelete()
        {
            panelSearch.Visible = true;
            buttonAdd.Visible = false;
            buttonEdit.Visible = false;
            buttonDelete.Visible = true;
            textBoxIDCategoria.Enabled = false;
            textBoxIDMarca.Enabled = false;
            textBoxIDProveedor.Enabled = false;
            textBoxIDUnidad.Enabled = false;
            textBoxDescripcion.Enabled = false;
            textBoxPrecioUnitario.Enabled = false;
            textBoxUnidadEnStock.Enabled = false;
            textBoxDescontinuado.Enabled = false;
        }

        public void toCreate()
        {
            SQL SQL = new SQL();
            try
            {
                SQL.CreateProducto(int.Parse(textBoxIDCategoria.Text), int.Parse(textBoxIDMarca.Text), int.Parse(textBoxIDProveedor.Text), int.Parse(textBoxIDUnidad.Text), textBoxDescripcion.Text, int.Parse(textBoxPrecioUnitario.Text), int.Parse(textBoxUnidadEnStock.Text), bool.Parse(textBoxDescontinuado.Text));
                CRUD.toRead(2);
                MessageBox.Show("Registro agregado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hay un error en la creación del registro. " + ex.Message);
            }
        }

        public void toEdit()
        {
            try
            {
                SQL SQL = new SQL();
                SQL.UpdateProducto(int.Parse(textBoxIDProducto.Text), int.Parse(textBoxIDCategoria.Text), int.Parse(textBoxIDMarca.Text), int.Parse(textBoxIDProveedor.Text), int.Parse(textBoxIDUnidad.Text), textBoxDescripcion.Text, int.Parse(textBoxPrecioUnitario.Text), int.Parse(textBoxUnidadEnStock.Text), bool.Parse(textBoxDescontinuado.Text));
                MessageBox.Show("Registro editado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hay un error en la edición del registro. " + ex.Message);
            }
        }

        public void toDelete()
        {
            try
            {
                SQL SQL = new SQL();
                SQL.DeleteProducto(int.Parse(textBoxIDProducto.Text));
                MessageBox.Show("Registro eliminado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hay un error en la eliminación del registro. " + ex.Message);
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                SQL SQL = new SQL();
                panelSearch.Visible = true;
                Producto producto = SQL.LoadProducto(int.Parse(textBoxIDProducto.Text));
                textBoxIDProducto.Text = producto.IDProducto.ToString();
                textBoxIDCategoria.Text = producto.IDCategoria.ToString();
                textBoxIDMarca.Text = producto.IDMarca.ToString();
                textBoxIDProveedor.Text = producto.IDProveedor.ToString();
                textBoxIDUnidad.Text = producto.IDUnidad.ToString();
                textBoxDescripcion.Text = producto.Descripcion.ToString();
                textBoxPrecioUnitario.Text = producto.PrecioUnitario.ToString();
                textBoxUnidadEnStock.Text = producto.UnidadEnStock.ToString();
                textBoxDescontinuado.Text = producto.Descontinuado.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontró el registro deseado. " + ex.Message);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            textBoxIDProducto.Text = "";
            textBoxIDCategoria.Text = "";
            textBoxIDMarca.Text = "";
            textBoxIDProveedor.Text = "";
            textBoxIDUnidad.Text = "";
            textBoxDescripcion.Text = "";
            textBoxPrecioUnitario.Text = "";
            textBoxUnidadEnStock.Text = "";
            textBoxDescontinuado.Text = "";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.toCreate();
            buttonCancelar_Click(sender, e);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            this.toDelete();
            buttonCancelar_Click(sender, e);
        }

        private void buttonConfirmarEdit_Click(object sender, EventArgs e)
        {
            this.toEdit();
            buttonCancelar_Click(sender, e);
        }        
    }
}
