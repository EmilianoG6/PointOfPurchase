namespace PIA_PoP
{
    public partial class FormUnidad : Form
    {
        public FormUnidad()
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
            textBoxMagnitud.Enabled = false;
            textBoxCantidad.Enabled = false;
            textBoxUnidad.Enabled = false;
            textBoxSimbolo.Enabled = false;
        }

        public void toCreate()
        {
            SQL SQL = new SQL();
            try
            {
                SQL.CreateUnidad(textBoxMagnitud.Text, int.Parse(textBoxCantidad.Text), textBoxUnidad.Text, textBoxSimbolo.Text);
                CRUD.toRead(8);
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
                SQL.UpdateUnidad(int.Parse(textBoxIDUnidad.Text), textBoxMagnitud.Text, int.Parse(textBoxCantidad.Text), textBoxUnidad.Text, textBoxSimbolo.Text);
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
                SQL.DeleteUnidad(int.Parse(textBoxIDUnidad.Text));
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
                UnidadMedida unidad = SQL.LoadUnidad(int.Parse(textBoxIDUnidad.Text));
                textBoxIDUnidad.Text = unidad.IDUnidad.ToString();
                textBoxMagnitud.Text = unidad.Magnitud.ToString();
                textBoxCantidad.Text = unidad.Cantidad.ToString();
                textBoxUnidad.Text = unidad.Unidad.ToString();
                textBoxSimbolo.Text = unidad.Simbolo.ToString();               
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontró el registro deseado. " + ex.Message);
            }
        }


        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            textBoxIDUnidad.Text = "";
            textBoxMagnitud.Text = "";
            textBoxCantidad.Text = "";
            textBoxUnidad.Text = "";
            textBoxSimbolo.Text = "";
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
