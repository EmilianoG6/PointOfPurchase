namespace PIA_PoP
{
    public partial class FormEmpleado : Form
    {
        public FormEmpleado()
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
            textBoxIDArea.Enabled = false;
            textBoxNombreEmp.Enabled = false;
            textBoxApellidoEmp.Enabled = false;
            textBoxSexoEmp.Enabled = false;
            textBoxEstadoEmp.Enabled = false;
            textBoxCiudadEmp.Enabled = false;
            textBoxCodigoPostal.Enabled = false;
            textBoxCalleEmp.Enabled = false;
            textBoxNumExtEmp.Enabled = false;
            textBoxTelefono.Enabled = false;
            textBoxEmailEmp.Enabled = false;
            textBoxFechaContratacion.Enabled = false;
        }

        public void toCreate()
        {
            SQL SQL = new SQL();
            try
            {
                SQL.CreateEmpleado(int.Parse(textBoxIDArea.Text), textBoxNombreEmp.Text, textBoxApellidoEmp.Text, textBoxSexoEmp.Text, textBoxEstadoEmp.Text, textBoxCiudadEmp.Text, int.Parse(textBoxCodigoPostal.Text), textBoxCalleEmp.Text, textBoxNumExtEmp.Text, textBoxTelefono.Text, textBoxEmailEmp.Text, DateTime.Parse(textBoxFechaContratacion.Text));
                CRUD.toRead(3);
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
                SQL.UpdateEmpleado(int.Parse(textBoxIDEmpleado.Text), int.Parse(textBoxIDArea.Text), textBoxNombreEmp.Text, textBoxApellidoEmp.Text, textBoxSexoEmp.Text, textBoxEstadoEmp.Text, textBoxCiudadEmp.Text, int.Parse(textBoxCodigoPostal.Text), textBoxCalleEmp.Text, textBoxNumExtEmp.Text, textBoxTelefono.Text, textBoxEmailEmp.Text, DateTime.Parse(textBoxFechaContratacion.Text));
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
                SQL.DeleteEmpleado(int.Parse(textBoxIDEmpleado.Text));
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
                Empleado empleado = SQL.LoadEmpleado(int.Parse(textBoxIDEmpleado.Text));
                textBoxIDEmpleado.Text = empleado.IDEmpleado.ToString();
                textBoxIDArea.Text = empleado.IDArea.ToString();
                textBoxNombreEmp.Text = empleado.NombreEmp.ToString();
                textBoxApellidoEmp.Text = empleado.ApellidoEmp.ToString();
                textBoxSexoEmp.Text = empleado.SexoEmp.ToString();
                textBoxEstadoEmp.Text = empleado.EstadoEmp.ToString();
                textBoxCiudadEmp.Text = empleado.CiudadEmp.ToString();
                textBoxCodigoPostal.Text = empleado.CodigoPostalEmp.ToString();
                textBoxCalleEmp.Text = empleado.CalleEmp.ToString();
                textBoxNumExtEmp.Text = empleado.NumExtEmp.ToString();
                textBoxTelefono.Text = empleado.TelefonoEmp.ToString();
                textBoxEmailEmp.Text = empleado.EmailEmp.ToString();
                textBoxFechaContratacion.Text = empleado.FechaContratacion.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontró el registro deseado. " + ex.Message);
            }
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            textBoxIDEmpleado.Text = "";
            textBoxIDArea.Text = "";
            textBoxNombreEmp.Text = "";
            textBoxApellidoEmp.Text = "";
            textBoxSexoEmp.Text = "";
            textBoxEstadoEmp.Text = "";
            textBoxCiudadEmp.Text = "";
            textBoxCodigoPostal.Text = "";
            textBoxCalleEmp.Text = "";
            textBoxNumExtEmp.Text = "";
            textBoxTelefono.Text = "";
            textBoxEmailEmp.Text = "";
            textBoxFechaContratacion.Text = "";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.toCreate();
            buttonCancelar_Click(sender, e);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
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
