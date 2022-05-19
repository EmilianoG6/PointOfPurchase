namespace PIA_PoP
{
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        CRUD CRUD = new CRUD();

        public void mostrarPanelBusquedaEdit()
        {
            panelSearch.Visible = true;
            buttonAdd.Visible = false;
            buttonConfirmar.Visible = true;
            buttonDelete.Visible = false;
        }

        public void mostrarPanelBusquedaDelete()
        {
            panelSearch.Visible = true;
            buttonAdd.Visible = false;
            buttonConfirmar.Visible = false;
            buttonDelete.Visible = true;
            textBoxApellido.Enabled = false;
            textBoxCalle.Enabled = false;
            textBoxCiudad.Enabled = false;
            textBoxCP.Enabled = false;
            textBoxEmail.Enabled = false;
            textBoxEstado.Enabled = false;
            textBoxFechaNac.Enabled = false;
            textBoxNombre.Enabled = false;
            textBoxNumExt.Enabled = false;
            textBoxRFC.Enabled = false;
            textBoxTelefono.Enabled = false;
        }

        public void toCreate()
        {
            SQL SQL = new SQL();
            try
            {
                SQL.CreateCliente(textBoxNombre.Text, textBoxApellido.Text, DateTime.Parse(textBoxFechaNac.Text), textBoxTelefono.Text, textBoxRFC.Text, textBoxEmail.Text, textBoxEstado.Text, textBoxCiudad.Text, textBoxCP.Text, textBoxCalle.Text, textBoxNumExt.Text);
                CRUD.toRead(4);
                MessageBox.Show("Registro agregado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hay un error en la creación del registro. " + ex.Message);
            }
        }

        public void toEdit()
        {
            SQL SQL = new SQL();
            try
            {
                SQL.UpdateCliente(int.Parse(textBoxIDCliente.Text), textBoxNombre.Text, textBoxApellido.Text, DateTime.Parse(textBoxFechaNac.Text), textBoxTelefono.Text, textBoxRFC.Text, textBoxEmail.Text, textBoxEstado.Text, textBoxCiudad.Text, textBoxCP.Text, textBoxCalle.Text, textBoxNumExt.Text);
                MessageBox.Show("Registro editado");
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
                SQL.DeleteCliente(int.Parse(textBoxIDCliente.Text));
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
                Cliente cliente = SQL.LoadCliente(int.Parse(textBoxIDCliente.Text));
                textBoxApellido.Text = cliente.ApellidoCliente.ToString();
                textBoxCalle.Text = cliente.CalleCliente.ToString();
                textBoxCiudad.Text = cliente.CiudadCliente.ToString();
                textBoxCP.Text = cliente.CodigoPostalCliente.ToString();
                textBoxEmail.Text = cliente.EmailCliente.ToString();
                textBoxEstado.Text = cliente.EstadoCliente.ToString();
                textBoxFechaNac.Text = cliente.FechaNacCliente.ToString();
                textBoxIDCliente.Text = cliente.IDCliente.ToString();
                textBoxNombre.Text = cliente.NombreCliente.ToString();
                textBoxNumExt.Text = cliente.NumExtCliente.ToString();
                textBoxRFC.Text = cliente.ClienteRFC.ToString();
                textBoxTelefono.Text = cliente.TelefonoCliente.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontró el registro deseado. " + ex.Message);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            textBoxApellido.Text = "";
            textBoxCalle.Text = "";
            textBoxCiudad.Text = "";
            textBoxCP.Text = "";
            textBoxEmail.Text = "";
            textBoxEstado.Text = "";
            textBoxFechaNac.Text = "";
            textBoxIDCliente.Text = "";
            textBoxNombre.Text = "";
            textBoxNumExt.Text = "";
            textBoxRFC.Text = "";
            textBoxTelefono.Text = "";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.toCreate();
            buttonCancelar_Click(sender, e);
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
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