namespace PIA_PoP
{
    public partial class FormOrden : Form
    {
        public FormOrden()
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
            textBoxIDProveedor.Enabled = false;
            textBoxFecha.Enabled = false;
        }

        public void toCreate()
        {
            SQL SQL = new SQL();
            try
            {
                SQL.CreateOrden(int.Parse(textBoxIDProveedor.Text), DateTime.Parse(textBoxFecha.Text));
                CRUD.toRead(10);
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
                SQL.UpdateOrden(int.Parse(textBoxIDOrdenCompra.Text), int.Parse(textBoxIDProveedor.Text), DateTime.Parse(textBoxFecha.Text));
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
                SQL.DeleteVenta(int.Parse(textBoxIDOrdenCompra.Text));
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
                Orden orden = SQL.LoadOrden(int.Parse(textBoxIDOrdenCompra.Text));
                textBoxIDOrdenCompra.Text = orden.IDOrdenCompra.ToString();
                textBoxIDProveedor.Text = orden.IDProveedor.ToString();
                textBoxFecha.Text = orden.FechaOrden.ToString();
                buttonDetalle.Visible = detailClick;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontró el registro deseado. " + ex.Message);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            textBoxIDOrdenCompra.Text = "";
            textBoxIDProveedor.Text = "";
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
                    FormDetalleOrden detalleOrden = new FormDetalleOrden();
                    detalleOrden.TopLevel = false;
                    this.panelContenedor.Controls.Add(detalleOrden);
                    this.panelContenedor.Tag = detalleOrden;
                    detalleOrden.Show();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se puede crear el detalle de la orden de compra porque no se pudo crear la orden. " + ex.Message);
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
            FormDetalleOrden detalleOrden = new FormDetalleOrden();
            detalleOrden.TopLevel = false;
            this.panelContenedor.Controls.Add(detalleOrden);
            this.panelContenedor.Tag = detalleOrden;
            detalleOrden.Show();
            detalleOrden.mostrarPanelBusquedaDelete();
        }
    }
}
