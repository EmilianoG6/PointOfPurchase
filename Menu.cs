using System.Runtime.InteropServices;
namespace PIA_PoP
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();            
        }

        CRUD CRUD = new CRUD();
        bool menuClick = false;
        bool ventaClick = false;
        bool faturaClick = false;
        bool ordenClick = false;
        bool detailOrdenClick = false;
        bool productoClick = false;
        bool empleadoClick = false;
        bool clienteClick = false;
        bool proveedorClick = false;
        bool categoriaClick = false;
        bool marcaClick = false;
        bool unidadClick = false;
        
        #region Funcionalidad de la ventana
        private void pictureBoxXMark_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBoxMax.Visible = false;
            pictureBoxRestaurar.Visible = true;
        }

        private void pictureBoxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pictureBoxMax.Visible = true;
            pictureBoxRestaurar.Visible = false;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void paneltop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void AbrirFormHijo(int opRead)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);                
            }
            CRUD.TopLevel = false;
            this.panelContenedor.Controls.Add(CRUD);
            this.panelContenedor.Tag = CRUD;
            CRUD.Show();
            panelCRUD.Visible = true;
            switch (opRead)
            {
                case 0:
                    {
                        CRUD.toRead(opRead); 
                        panelCRUD.Visible = false;
                        break;
                    }
                case 1:
                    {
                        CRUD.toRead(opRead);                        
                        break;
                    }
                case 2:
                    {
                        CRUD.toRead(opRead);
                        break;
                    }
                case 3:
                    {
                        CRUD.toRead(opRead);
                        break;
                    }
                case 4:
                    {
                        CRUD.toRead(opRead);
                        break;
                    }
                case 5:
                    {
                        CRUD.toRead(opRead);
                        break;
                    }
                case 6:
                    {
                        CRUD.toRead(opRead);
                        break;
                    }
                case 7:
                    {
                        CRUD.toRead(opRead);
                        break;
                    }
                case 8:
                    {
                        CRUD.toRead(opRead);
                        break;
                    }
                case 9:
                    {
                        CRUD.toRead(opRead);
                        break;
                    }
                case 10:
                    {
                        CRUD.toRead(opRead);
                        break;
                    }
            }
        }        

        private void pictureBoxMenuFAST1Logo_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(0);
            menuClick = true;
            ventaClick = false;
            productoClick = false;
            empleadoClick = false;
            clienteClick = false;
            proveedorClick = false;
            categoriaClick = false;
            marcaClick = false;
            unidadClick = false;
            faturaClick = false;
            ordenClick = false;
        }

        private void buttonVentas_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(1);
            menuClick = false;
            ventaClick = true;
            productoClick = false;
            empleadoClick = false;
            clienteClick = false;
            proveedorClick = false;
            categoriaClick = false;
            marcaClick = false;
            unidadClick = false;
            faturaClick = false;
            ordenClick = false;
        }

        private void buttonFactura_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(9);
            menuClick = false;
            ventaClick = false;
            productoClick = false;
            empleadoClick = false;
            clienteClick = false;
            proveedorClick = false;
            categoriaClick = false;
            marcaClick = false;
            unidadClick = false;
            faturaClick = true;
            ordenClick = false;
        }

        private void buttonOrden_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(10);
            menuClick = false;
            ventaClick = false;
            productoClick = false;
            empleadoClick = false;
            clienteClick = false;
            proveedorClick = false;
            categoriaClick = false;
            marcaClick = false;
            unidadClick = false;
            faturaClick = false;
            ordenClick = true;
        }

        private void buttonProductos_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(2);
            menuClick = false;
            ventaClick = false;
            productoClick = true;
            empleadoClick = false;
            clienteClick = false;
            proveedorClick = false;
            categoriaClick = false;
            marcaClick = false;
            unidadClick = false;
            faturaClick = false;
            ordenClick = false;
        }

        private void buttonEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(3);
            menuClick = false;
            ventaClick = false;
            productoClick = false;
            empleadoClick = true;
            clienteClick = false;
            proveedorClick = false;
            categoriaClick = false;
            marcaClick = false;
            unidadClick = false;
            faturaClick = false;
            ordenClick = false;
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(4);
            menuClick = false;
            ventaClick = false;
            productoClick = false;
            empleadoClick = false;
            clienteClick = true;
            proveedorClick = false;
            categoriaClick = false;
            marcaClick = false;
            unidadClick = false;
            faturaClick = false;
            ordenClick = false;
        }

        private void buttonProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(5);
            menuClick = false;
            ventaClick = false;
            productoClick = false;
            empleadoClick = false;
            clienteClick = false;
            proveedorClick = true;
            categoriaClick = false;
            marcaClick = false;
            unidadClick = false;
            faturaClick = false;
            ordenClick = false;
        }

        private void buttonCategoría_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(6);
            menuClick = false;
            ventaClick = false;
            productoClick = false;
            empleadoClick = false;
            clienteClick = false;
            proveedorClick = false;
            categoriaClick = true;
            marcaClick = false;
            unidadClick = false;
            faturaClick = false;
            ordenClick = false;
        }

        private void buttonMarca_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(7);
            menuClick = false;
            ventaClick = false;
            productoClick = false;
            empleadoClick = false;
            clienteClick = false;
            proveedorClick = false;
            categoriaClick = false;
            marcaClick = true;
            unidadClick = false;
            faturaClick = false;
            ordenClick = false;
        }

        private void buttonUnidad_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(8);
            menuClick = false;
            ventaClick = false;
            productoClick = false;
            empleadoClick = false;
            clienteClick = false;
            proveedorClick = false;
            categoriaClick = false;
            marcaClick = false;
            unidadClick = true;
            faturaClick = false;
            ordenClick = false;
        }        

        private void buttonAgregar_Click(object sender, EventArgs e)
        {            
            if (ventaClick == true)
            {
                if (this.panelContenedor.Controls.Count > 0)
                {
                    this.panelContenedor.Controls.RemoveAt(0);
                }
                FormVenta FormVenta = new FormVenta();
                FormVenta.TopLevel = false;
                this.panelContenedor.Controls.Add(FormVenta);
                this.panelContenedor.Tag = FormVenta;
                FormVenta.Show();
            }
            else if(productoClick == true)
            {
               if (this.panelContenedor.Controls.Count > 0)
                {
                    this.panelContenedor.Controls.RemoveAt(0);
                }
                FormProducto FormProducto = new FormProducto();
                FormProducto.TopLevel = false;
                this.panelContenedor.Controls.Add(FormProducto);
                this.panelContenedor.Tag = FormProducto;
                FormProducto.Show();                
            }
            else if (empleadoClick == true)
            {
                if (this.panelContenedor.Controls.Count > 0)
                {
                    this.panelContenedor.Controls.RemoveAt(0);
                }
                FormEmpleado FormEmpleado = new FormEmpleado();
                FormEmpleado.TopLevel = false;
                this.panelContenedor.Controls.Add(FormEmpleado);
                this.panelContenedor.Tag = FormEmpleado;
                FormEmpleado.Show();
                
            }
            else if(clienteClick == true)
            {
                if (this.panelContenedor.Controls.Count > 0)
                {
                    this.panelContenedor.Controls.RemoveAt(0);
                }
                FormCliente FormCliente = new FormCliente();
                FormCliente.TopLevel = false;
                this.panelContenedor.Controls.Add(FormCliente);
                this.panelContenedor.Tag = FormCliente;
                FormCliente.Show();                
            }
            else if(proveedorClick == true)
            {
                if (this.panelContenedor.Controls.Count > 0)
                {
                    this.panelContenedor.Controls.RemoveAt(0);
                }
                FormProveedor FormProveedor = new FormProveedor();
                FormProveedor.TopLevel = false;
                this.panelContenedor.Controls.Add(FormProveedor);
                this.panelContenedor.Tag = FormProveedor;
                FormProveedor.Show();               
            }
            else if (categoriaClick == true)
            {
                if (this.panelContenedor.Controls.Count > 0)
                {
                    this.panelContenedor.Controls.RemoveAt(0);
                }
                FormCategoria FormCategoria = new FormCategoria();
                FormCategoria.TopLevel = false;
                this.panelContenedor.Controls.Add(FormCategoria);
                this.panelContenedor.Tag = FormCategoria;
                FormCategoria.Show();                
            }
            else if (marcaClick == true)
            {
                if (this.panelContenedor.Controls.Count > 0)
                {
                    this.panelContenedor.Controls.RemoveAt(0);
                }
                FormMarca FormMarca = new FormMarca();
                FormMarca.TopLevel = false;
                this.panelContenedor.Controls.Add(FormMarca);
                this.panelContenedor.Tag = FormMarca;
                FormMarca.Show();                
            }
            else if (unidadClick == true)
            {
                if (this.panelContenedor.Controls.Count > 0)
                {
                    this.panelContenedor.Controls.RemoveAt(0);
                }
                FormUnidad FormUnidad = new FormUnidad();
                FormUnidad.TopLevel = false;
                this.panelContenedor.Controls.Add(FormUnidad);
                this.panelContenedor.Tag = FormUnidad;
                FormUnidad.Show();                
            }
            else if (faturaClick == true)
            {
                if (this.panelContenedor.Controls.Count > 0)
                {
                    this.panelContenedor.Controls.RemoveAt(0);
                }
                FormFactura FormFactura = new FormFactura();
                FormFactura.TopLevel = false;
                this.panelContenedor.Controls.Add(FormFactura);
                this.panelContenedor.Tag = FormFactura;
                FormFactura.Show();                
            }
            else if (ordenClick == true)
            {
                if (this.panelContenedor.Controls.Count > 0)
                {
                    this.panelContenedor.Controls.RemoveAt(0);
                }
                FormOrden FormOrden = new FormOrden();
                FormOrden.TopLevel = false;
                this.panelContenedor.Controls.Add(FormOrden);
                this.panelContenedor.Tag = FormOrden;
                FormOrden.Show();
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (ventaClick == true)
            {               
                int? id = CRUD.GetID();
                if (id != null)
                {
                    if (this.panelContenedor.Controls.Count > 0)
                    {
                        this.panelContenedor.Controls.RemoveAt(0);
                    }
                    FormVenta FormVenta = new FormVenta();
                    FormVenta.TopLevel = false;
                    this.panelContenedor.Controls.Add(FormVenta);
                    this.panelContenedor.Tag = FormVenta;
                    FormVenta.Show();
                    FormVenta.mostrarPanelBusquedaEdit();
                    FormVenta.mostrarPanelBusquedaEdit();
                    detailOrdenClick = false;
                }                
            }            
            else if (productoClick == true)
            {
                int? id = CRUD.GetID();
                if (id != null)
                {
                    if (this.panelContenedor.Controls.Count > 0)
                    {
                        this.panelContenedor.Controls.RemoveAt(0);
                    }
                    FormProducto FormProducto = new FormProducto();
                    FormProducto.TopLevel = false;
                    this.panelContenedor.Controls.Add(FormProducto);
                    this.panelContenedor.Tag = FormProducto;
                    FormProducto.Show();
                    FormProducto.mostrarPanelBusquedaEdit();
                }
            }
            else if (empleadoClick == true)
            {
                int? id = CRUD.GetID();
                if (id != null)
                {
                    if (this.panelContenedor.Controls.Count > 0)
                    {
                        this.panelContenedor.Controls.RemoveAt(0);
                    }
                    FormEmpleado FormEmpleado = new FormEmpleado();
                    FormEmpleado.TopLevel = false;
                    this.panelContenedor.Controls.Add(FormEmpleado);
                    this.panelContenedor.Tag = FormEmpleado;
                    FormEmpleado.Show();
                    FormEmpleado.mostrarPanelBusquedaEdit();
                }
            }
            else if (clienteClick == true)
            {
                int? id = CRUD.GetID();
                if (id != null)
                {
                    if (this.panelContenedor.Controls.Count > 0)
                    {
                        this.panelContenedor.Controls.RemoveAt(0);
                    }
                    FormCliente FormCliente = new FormCliente();
                    FormCliente.TopLevel = false;
                    this.panelContenedor.Controls.Add(FormCliente);
                    this.panelContenedor.Tag = FormCliente;
                    FormCliente.Show();
                    FormCliente.mostrarPanelBusquedaEdit();
                }
            }
            else if (proveedorClick == true)
            {
                int? id = CRUD.GetID();
                if (id != null)
                {
                    if (this.panelContenedor.Controls.Count > 0)
                    {
                        this.panelContenedor.Controls.RemoveAt(0);
                    }
                    FormProveedor FormProveedor = new FormProveedor();
                    FormProveedor.TopLevel = false;
                    this.panelContenedor.Controls.Add(FormProveedor);
                    this.panelContenedor.Tag = FormProveedor;
                    FormProveedor.Show();                   
                    FormProveedor.mostrarPanelBusquedaEdit();
                }
            }
            else if (categoriaClick == true)
            {
                int? id = CRUD.GetID();
                if (id != null)
                {
                    if (this.panelContenedor.Controls.Count > 0)
                    {
                        this.panelContenedor.Controls.RemoveAt(0);
                    }
                    FormCategoria FormCategoria = new FormCategoria();
                    FormCategoria.TopLevel = false;
                    this.panelContenedor.Controls.Add(FormCategoria);
                    this.panelContenedor.Tag = FormCategoria;
                    FormCategoria.Show();
                    FormCategoria.mostrarPanelBusquedaEdit();
                }             
            }
            else if (marcaClick == true)
            {
                int? id = CRUD.GetID();
                if (id != null)
                {
                    if (this.panelContenedor.Controls.Count > 0)
                    {
                        this.panelContenedor.Controls.RemoveAt(0);
                    }
                    FormMarca FormMarca = new FormMarca();
                    FormMarca.TopLevel = false;
                    this.panelContenedor.Controls.Add(FormMarca);
                    this.panelContenedor.Tag = FormMarca;
                    FormMarca.Show();
                    FormMarca.mostrarPanelBusquedaEdit();
                }
                
            }
            else if (unidadClick == true)
            {
                int? id = CRUD.GetID();
                if (id != null)
                {
                    if (this.panelContenedor.Controls.Count > 0)
                    {
                        this.panelContenedor.Controls.RemoveAt(0);
                    }
                    FormUnidad FormUnidad = new FormUnidad();
                    FormUnidad.TopLevel = false;
                    this.panelContenedor.Controls.Add(FormUnidad);
                    this.panelContenedor.Tag = FormUnidad;
                    FormUnidad.Show();
                    FormUnidad.mostrarPanelBusquedaEdit();
                }
            }
            else if (faturaClick == true)
            {
                int? id = CRUD.GetID();
                if (id != null)
                {
                    if (this.panelContenedor.Controls.Count > 0)
                    {
                        this.panelContenedor.Controls.RemoveAt(0);
                    }
                    FormFactura FormFactura = new FormFactura();
                    FormFactura.TopLevel = false;
                    this.panelContenedor.Controls.Add(FormFactura);
                    this.panelContenedor.Tag = FormFactura;
                    FormFactura.Show();
                    FormFactura.mostrarPanelBusquedaEdit();
                    FormFactura.mostrarPanelBusquedaEdit();
                    detailOrdenClick = false;
                }
            }
            else if (ordenClick == true)
            {
                int? id = CRUD.GetID();
                if (id != null)
                {
                    if (this.panelContenedor.Controls.Count > 0)
                    {
                        this.panelContenedor.Controls.RemoveAt(0);
                    }
                    FormOrden FormOrden = new FormOrden();
                    FormOrden.TopLevel = false;
                    this.panelContenedor.Controls.Add(FormOrden);
                    this.panelContenedor.Tag = FormOrden;
                    FormOrden.Show();
                    FormOrden.mostrarPanelBusquedaEdit();
                    detailOrdenClick = false;
                }
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (ventaClick == true)
            {
                int? id = CRUD.GetID();
                if (id != null)
                {
                    if (this.panelContenedor.Controls.Count > 0)
                    {
                        this.panelContenedor.Controls.RemoveAt(0);
                    }
                    FormVenta FormVenta = new FormVenta();
                    FormVenta.TopLevel = false;
                    this.panelContenedor.Controls.Add(FormVenta);
                    this.panelContenedor.Tag = FormVenta;
                    FormVenta.Show();
                    FormVenta.mostrarPanelBusquedaDelete();
                    detailOrdenClick = true;
                    FormVenta.toDetail(detailOrdenClick);
                }
            }
            else if (productoClick == true)
            {
                int? id = CRUD.GetID();
                if (id != null)
                {
                    if (this.panelContenedor.Controls.Count > 0)
                    {
                        this.panelContenedor.Controls.RemoveAt(0);
                    }
                    FormProducto FormProducto = new FormProducto();
                    FormProducto.TopLevel = false;
                    this.panelContenedor.Controls.Add(FormProducto);
                    this.panelContenedor.Tag = FormProducto;
                    FormProducto.Show();
                    FormProducto.mostrarPanelBusquedaDelete();
                }
            }
            else if (empleadoClick == true)
            {
                int? id = CRUD.GetID();
                if (id != null)
                {
                    if (this.panelContenedor.Controls.Count > 0)
                    {
                        this.panelContenedor.Controls.RemoveAt(0);
                    }
                    FormEmpleado FormEmpleado = new FormEmpleado();
                    FormEmpleado.TopLevel = false;
                    this.panelContenedor.Controls.Add(FormEmpleado);
                    this.panelContenedor.Tag = FormEmpleado;
                    FormEmpleado.Show();
                    FormEmpleado.mostrarPanelBusquedaDelete();
                }
            }
            else if (clienteClick == true)
            {
                int? id = CRUD.GetID();
                if (id != null)
                {
                    if (this.panelContenedor.Controls.Count > 0)
                    {
                        this.panelContenedor.Controls.RemoveAt(0);
                    }
                    FormCliente FormCliente = new FormCliente();
                    FormCliente.TopLevel = false;
                    this.panelContenedor.Controls.Add(FormCliente);
                    this.panelContenedor.Tag = FormCliente;
                    FormCliente.Show();
                    FormCliente.mostrarPanelBusquedaDelete();
                }
            }
            else if (proveedorClick == true)
            {
                int? id = CRUD.GetID();
                if (id != null)
                {
                    if (this.panelContenedor.Controls.Count > 0)
                    {
                        this.panelContenedor.Controls.RemoveAt(0);
                    }
                    FormProveedor FormProveedor = new FormProveedor();
                    FormProveedor.TopLevel = false;
                    this.panelContenedor.Controls.Add(FormProveedor);
                    this.panelContenedor.Tag = FormProveedor;
                    FormProveedor.Show();                   
                    FormProveedor.mostrarPanelBusquedaDelete();
                }
            }
            else if (categoriaClick == true)
            {
                int? id = CRUD.GetID();
                if (id != null)
                {
                    if (this.panelContenedor.Controls.Count > 0)
                    {
                        this.panelContenedor.Controls.RemoveAt(0);
                    }
                    FormCategoria FormCategoria = new FormCategoria();
                    FormCategoria.TopLevel = false;
                    this.panelContenedor.Controls.Add(FormCategoria);
                    this.panelContenedor.Tag = FormCategoria;
                    FormCategoria.Show();
                    FormCategoria.mostrarPanelBusquedaDelete();
                }
            }
            else if (marcaClick == true)
            {
                int? id = CRUD.GetID();
                if (id != null)
                {
                    if (this.panelContenedor.Controls.Count > 0)
                    {
                        this.panelContenedor.Controls.RemoveAt(0);
                    }
                    FormMarca FormMarca = new FormMarca();
                    FormMarca.TopLevel = false;
                    this.panelContenedor.Controls.Add(FormMarca);
                    this.panelContenedor.Tag = FormMarca;
                    FormMarca.Show();
                    FormMarca.mostrarPanelBusquedaDelete();
                }
            }
            else if (unidadClick == true)
            {
                int? id = CRUD.GetID();
                if (id != null)
                {
                    if (this.panelContenedor.Controls.Count > 0)
                    {
                        this.panelContenedor.Controls.RemoveAt(0);
                    }
                    FormUnidad FormUnidad = new FormUnidad();
                    FormUnidad.TopLevel = false;
                    this.panelContenedor.Controls.Add(FormUnidad);
                    this.panelContenedor.Tag = FormUnidad;
                    FormUnidad.Show();
                    FormUnidad.mostrarPanelBusquedaDelete();
                }
            }
            else if (faturaClick == true)
            {
                int? id = CRUD.GetID();
                if (id != null)
                {
                    if (this.panelContenedor.Controls.Count > 0)
                    {
                        this.panelContenedor.Controls.RemoveAt(0);
                    }
                    FormFactura FormFactura = new FormFactura();
                    FormFactura.TopLevel = false;
                    this.panelContenedor.Controls.Add(FormFactura);
                    this.panelContenedor.Tag = FormFactura;
                    FormFactura.Show();
                    FormFactura.mostrarPanelBusquedaDelete();
                    detailOrdenClick = true;
                    FormFactura.toDetail(detailOrdenClick);
                }
            }
            else if (ordenClick == true)
            {
                int? id = CRUD.GetID();
                if (id != null)
                {
                    if (this.panelContenedor.Controls.Count > 0)
                    {
                        this.panelContenedor.Controls.RemoveAt(0);
                    }
                    FormOrden FormOrden = new FormOrden();
                    FormOrden.TopLevel = false;
                    this.panelContenedor.Controls.Add(FormOrden);
                    this.panelContenedor.Tag = FormOrden;
                    FormOrden.Show();
                    FormOrden.mostrarPanelBusquedaDelete();
                    detailOrdenClick = true;
                    FormOrden.toDetail(detailOrdenClick);
                }
            }
        }        
    }
}