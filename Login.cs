using System.Runtime.InteropServices;
namespace PIA_PoP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBoxLoginUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                textBoxLoginContraseña.Focus();
            }

        }

        private void textBoxLoginContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                buttonLogin_Click(sender, e);
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxLoginUsuario.Text == "admin" && textBoxLoginContraseña.Text == "admin") {
                SQL toConnect = new SQL();
                if (toConnect.GetConnection())
                {
                    Menu menu = new Menu();
                    this.Hide(); menu.Show();
                }
                else
                {
                    MessageBox.Show("Connection Error!");
                }
            }else if(textBoxLoginUsuario.Text == "user" && textBoxLoginContraseña.Text == "user")
            {
                SQL toConnect = new SQL();
                if (toConnect.GetConnection())
                {
                    Menu menu = new Menu();
                    this.Hide(); menu.Show();
                    menu.panelUser();
                }
                else
                {
                    MessageBox.Show("Connection Error!");
                }
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos.");
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void GUI_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBoxXMark_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}