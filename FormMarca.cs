namespace PIA_PoP
{
    public partial class FormMarca : Form
    {
        public FormMarca()
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
            textBoxNombre.Enabled = false;
            textBoxTelefono.Enabled = false;
        }

        public void toCreate()
        {
            SQL SQL = new SQL();
            try
            {
                SQL.CreateMarca(textBoxNombre.Text, textBoxTelefono.Text);
                CRUD.toRead(7);
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
                SQL.UpdateMarca(int.Parse(textBoxIDMarca.Text), textBoxNombre.Text, textBoxTelefono.Text);
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
                SQL.DeleteMarca(int.Parse(textBoxIDMarca.Text));
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
                Marca marca = SQL.LoadMarca(int.Parse(textBoxIDMarca.Text));
                textBoxIDMarca.Text = marca.IDMarca.ToString();
                textBoxNombre.Text = marca.NombreMarca.ToString();
                textBoxTelefono.Text = marca.TelefonoEmpresa.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontró el registro deseado. " + ex.Message);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            textBoxIDMarca.Text = "";
            textBoxNombre.Text = "";
            textBoxTelefono.Text = "";
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
