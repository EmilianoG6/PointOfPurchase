using System.Runtime.InteropServices;
namespace PIA_PoP
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

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

        private void AbrirFormHijo(object formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
                Form fh = formHijo as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.panelContenedor.Controls.Add(fh);
                this.panelContenedor.Tag = fh;
                fh.Show();
            
        }

        private void buttonVentas_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new CRUD());
        }

        private void buttonProductos_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new CRUD());
        }

        private void buttonEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new CRUD());
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new CRUD());
        }

        private void buttonProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new CRUD());
        }
    }
}
