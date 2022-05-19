namespace PIA_PoP
{
    public partial class FormProveedor : Form
    {
        public FormProveedor()
        {
            InitializeComponent();
        }

        CRUD CRUD = new CRUD();

        public void mostrarPanelBusquedaEdit()
        {
            panelSearch.Visible = true;
            buttonConfirmarAdd.Visible = false;
            buttonConfirmarEdit.Visible = true;
            buttonDelete.Visible = false;
        }

        public void mostrarPanelBusquedaDelete()
        {
            panelSearch.Visible = true;
            buttonConfirmarAdd.Visible = false;
            buttonConfirmarEdit.Visible = false;
            buttonDelete.Visible = true;
            textBoxIDMarca.Enabled = false;
            textBoxNombre.Enabled = false;
            textBoxEmpresa.Enabled = false;
            textBoxProveedorRFC.Enabled = false;

        }


        public void toCreate()
        {
            SQL toCreateProveedor = new SQL();
            try
            {
                toCreateProveedor.CreateProveedor(int.Parse(textBoxIDMarca.Text), textBoxNombre.Text, textBoxEmpresa.Text, textBoxProveedorRFC.Text);
                CRUD.toRead(5);
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
                SQL.UpdateProveedor(int.Parse(textBoxIDProveedor.Text), int.Parse(textBoxIDMarca.Text), textBoxNombre.Text, textBoxEmpresa.Text, textBoxProveedorRFC.Text);
                MessageBox.Show("Registro editado.");
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la edición del registro. " + ex.Message);
            }
        }

        public void toDelete()
        {
            try
            {
                SQL SQL = new SQL();
                SQL.DeleteProveedor(int.Parse(textBoxIDProveedor.Text));
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
                panelSearch.Visible = true;
                Proveedor proveedor = SQL.LoadProveedor(int.Parse(textBoxIDProveedor.Text));
                textBoxIDProveedor.Text = proveedor.IDProveedor.ToString();
                textBoxIDMarca.Text = proveedor.IDMarca.ToString();
                textBoxNombre.Text = proveedor.NombreProveedor.ToString();
                textBoxEmpresa.Text = proveedor.EmpresaProveniente.ToString();
                textBoxProveedorRFC.Text = proveedor.ProveedorRFC.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontró el registro deseado. " + ex.Message);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            textBoxIDProveedor.Text = "";
            textBoxIDMarca.Text = "";
            textBoxNombre.Text = "";
            textBoxEmpresa.Text = "";
            textBoxProveedorRFC.Text = "";
        }        

        private void buttonConfirmarAdd_Click(object sender, EventArgs e)
        {
            this.toCreate();
            buttonCancelar_Click(sender, e);
        }

        private void buttonConfirmarEdit_Click(object sender, EventArgs e)
        {
            this.toEdit();
            buttonCancelar_Click(sender, e);

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            this.toDelete();
            buttonCancelar_Click(sender, e);
        }
    }
}