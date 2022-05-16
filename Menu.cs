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

        private void AbrirFormHijo(int op)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            CRUD.TopLevel = false;
            CRUD.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(CRUD);
            this.panelContenedor.Tag = CRUD;
            CRUD.Show();
            switch (op)
            {
                case 1:
                    {
                        CRUD.toReadVenta();
                        break;
                    }
                case 2:
                    {
                        CRUD.toReadProducto();
                        break;
                    }
                case 3:
                    {
                        MessageBox.Show("Empleados!");
                        break;
                    }
                case 4:
                    {
                        MessageBox.Show("Clientes!");
                        break;
                    }
                case 5:
                    {
                        MessageBox.Show("Proveedores!");
                        break;
                    }
            }
        }

        private void buttonVentas_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(1);
        }

        private void buttonProductos_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(2);
        }

        private void buttonEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(3);
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(4);
        }

        private void buttonProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(5);
        }
    }
}
