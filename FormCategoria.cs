namespace PIA_PoP
{
    public partial class FormCategoria : Form
    {
        public FormCategoria()
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
            textBoxPresentacion.Enabled = false;
        }

        public void toCreate()
        {
            SQL SQL = new SQL();
            try
            {
                SQL.CreateCategoria(textBoxNombre.Text, textBoxPresentacion.Text);
                CRUD.toRead(6);
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
                SQL.UpdateCategoria(int.Parse(textBoxIDCategoria.Text), textBoxNombre.Text, textBoxPresentacion.Text);
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
                SQL.DeleteCategoria(int.Parse(textBoxIDCategoria.Text));
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
                Categoria categoria = SQL.LoadCategoria(int.Parse(textBoxIDCategoria.Text));
                textBoxIDCategoria.Text = categoria.IDCategoria.ToString();
                textBoxNombre.Text = categoria.NombreCategoria.ToString();
                textBoxPresentacion.Text = categoria.Presentacion.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontró el registro deseado. " + ex.Message);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            textBoxIDCategoria.Text = "";
            textBoxNombre.Text = "";
            textBoxPresentacion.Text = "";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
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
