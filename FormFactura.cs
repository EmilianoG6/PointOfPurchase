namespace PIA_PoP
{
    public partial class FormFactura : Form
    {
        public FormFactura()
        {
            InitializeComponent();
        }

        CRUD CRUD = new CRUD();
        bool detailClick = false;
        bool adelante = false;
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
            textBoxIDTicket.Enabled = false;
            textBoxIDCliente.Enabled = false;
            textBoxNombreNegocio.Enabled = false;
            textBoxFecha.Enabled = false;
        }

        public void toCreate()
        {
            SQL SQL = new SQL();
            try
            {
                SQL.CreateFactura(int.Parse(textBoxIDTicket.Text), int.Parse(textBoxIDCliente.Text), textBoxNombreNegocio.Text, DateTime.Parse(textBoxFecha.Text));
                CRUD.toRead(9);
                MessageBox.Show("Registro agregado.");
                adelante = true;
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
                SQL.UpdateFactura(int.Parse(textBoxIDFactura.Text), int.Parse(textBoxIDTicket.Text), int.Parse(textBoxIDCliente.Text), textBoxNombreNegocio.Text, DateTime.Parse(textBoxFecha.Text));
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
                SQL.DeleteFactura(int.Parse(textBoxIDFactura.Text));
                MessageBox.Show("Registro eliminado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hay un error en la eliminación del registro. " + ex.Message);
            }
        }

        public void toDetail(bool op)
        {
            detailClick = op;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                SQL SQL = new SQL();
                panelSearch.Visible = true;
                Factura factura = SQL.LoadFactura(int.Parse(textBoxIDFactura.Text));
                textBoxIDFactura.Text = factura.IDFactura.ToString();
                textBoxIDTicket.Text = factura.IDTicket.ToString();
                textBoxIDCliente.Text = factura.IDCliente.ToString();
                textBoxNombreNegocio.Text = factura.Nombre.ToString();
                textBoxFecha.Text = factura.FechaFactura.ToString();
                buttonDetalle.Visible = detailClick;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontró el registro deseado. " + ex.Message);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            textBoxIDFactura.Text = "";
            textBoxIDTicket.Text = "";
            textBoxIDCliente.Text = "";
            textBoxNombreNegocio.Text = "";
            textBoxFecha.Text = "";
            buttonDetalle.Visible = false;
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                this.toCreate();
                buttonCancelar_Click(sender, e);
                if (adelante == true)
                {
                    if (this.panelContenedor.Controls.Count > 0)
                    {
                        this.panelContenedor.Controls.RemoveAt(0);
                    }
                    FormDetalleFactura detalleFactura = new FormDetalleFactura();
                    detalleFactura.TopLevel = false;
                    this.panelContenedor.Controls.Add(detalleFactura);
                    this.panelContenedor.Tag = detalleFactura;
                    detalleFactura.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede crear el detalle de la factura porque no se pudo crear la misma. " + ex.Message);
            }
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

        private void buttonDetalle_Click(object sender, EventArgs e)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            FormDetalleFactura detalleFactura = new FormDetalleFactura();
            detalleFactura.TopLevel = false;
            this.panelContenedor.Controls.Add(detalleFactura);
            this.panelContenedor.Tag = detalleFactura;
            detalleFactura.Show();
            detalleFactura.mostrarPanelBusquedaDelete();
        }
    }
}
