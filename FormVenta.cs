namespace PIA_PoP
{
    public partial class FormVenta : Form
    {
        public FormVenta()
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
            textBoxIDCliente.Enabled = false;
            textBoxIDEmpleado.Enabled = false;
            textBoxFecha.Enabled = false;
        }

        public void toCreate()
        {
            SQL SQL = new SQL();
            try
            {
                SQL.CreateVenta(int.Parse(textBoxIDCliente.Text), int.Parse(textBoxIDEmpleado.Text), DateTime.Parse(textBoxFecha.Text));
                CRUD.toRead(1);
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
                SQL.UpdateVenta(int.Parse(textBoxIDTicket.Text), int.Parse(textBoxIDCliente.Text), int.Parse(textBoxIDEmpleado.Text), DateTime.Parse(textBoxFecha.Text));
                MessageBox.Show("Registro editado.");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hay un error en la edición del registro. " + ex.Message);
            }
        }        

        public void toDelete()
        {
            try
            {
                SQL SQL = new SQL();
                SQL.DeleteVenta(int.Parse(textBoxIDTicket.Text));
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
                Venta venta = SQL.LoadVenta(int.Parse(textBoxIDTicket.Text));
                textBoxIDTicket.Text = venta.IDTicket.ToString();
                textBoxIDCliente.Text = venta.IDCliente.ToString();
                textBoxIDEmpleado.Text = venta.IDEmpleado.ToString();
                textBoxFecha.Text = venta.FechaVenta.ToString();
                buttonDetalle.Visible = detailClick;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontró el registro deseado. " + ex.Message);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            textBoxIDTicket.Text = "";
            textBoxIDCliente.Text = "";
            textBoxIDEmpleado.Text = "";
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
                    FormDetalleTicket detalleTicket = new FormDetalleTicket();
                    detalleTicket.TopLevel = false;
                    this.panelContenedor.Controls.Add(detalleTicket);
                    this.panelContenedor.Tag = detalleTicket;
                    detalleTicket.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede crear el detalle del ticket de venta porque no se pudo crear la venta. " + ex.Message);
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
            FormDetalleTicket detalleTicket = new FormDetalleTicket();
            detalleTicket.TopLevel = false;
            this.panelContenedor.Controls.Add(detalleTicket);
            this.panelContenedor.Tag = detalleTicket;
            detalleTicket.Show();
            detalleTicket.mostrarPanelBusquedaDelete();
        }
    }
}