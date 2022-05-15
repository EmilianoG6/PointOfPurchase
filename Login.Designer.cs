namespace PIA_PoP
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBoxFAST1Logo = new System.Windows.Forms.PictureBox();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLoginUsuario = new System.Windows.Forms.TextBox();
            this.textBoxLoginContraseña = new System.Windows.Forms.TextBox();
            this.pictureBoxXMark = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFAST1Logo)).BeginInit();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxXMark)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(188)))));
            this.buttonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(52, 190);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(248, 43);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.TabStop = false;
            this.buttonLogin.Text = "Acceder";
            this.buttonLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(162, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 1;
            this.button2.TabStop = false;
            this.button2.Text = "Mostrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(276, 269);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(199, 356);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.Visible = false;
            // 
            // pictureBoxFAST1Logo
            // 
            this.pictureBoxFAST1Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxFAST1Logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFAST1Logo.Image")));
            this.pictureBoxFAST1Logo.Location = new System.Drawing.Point(-76, -118);
            this.pictureBoxFAST1Logo.Name = "pictureBoxFAST1Logo";
            this.pictureBoxFAST1Logo.Size = new System.Drawing.Size(417, 557);
            this.pictureBoxFAST1Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFAST1Logo.TabIndex = 3;
            this.pictureBoxFAST1Logo.TabStop = false;
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.dataGridView1);
            this.panelLogin.Controls.Add(this.textBoxLoginUsuario);
            this.panelLogin.Controls.Add(this.textBoxLoginContraseña);
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Controls.Add(this.button2);
            this.panelLogin.Location = new System.Drawing.Point(341, 22);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(353, 308);
            this.panelLogin.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(119, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "LOGIN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxLoginUsuario
            // 
            this.textBoxLoginUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLoginUsuario.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBoxLoginUsuario.Location = new System.Drawing.Point(52, 93);
            this.textBoxLoginUsuario.Name = "textBoxLoginUsuario";
            this.textBoxLoginUsuario.PlaceholderText = "Usuario";
            this.textBoxLoginUsuario.Size = new System.Drawing.Size(248, 27);
            this.textBoxLoginUsuario.TabIndex = 4;
            this.textBoxLoginUsuario.TabStop = false;
            this.textBoxLoginUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLoginUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLoginUsuario_KeyPress);
            // 
            // textBoxLoginContraseña
            // 
            this.textBoxLoginContraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLoginContraseña.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBoxLoginContraseña.Location = new System.Drawing.Point(52, 142);
            this.textBoxLoginContraseña.Name = "textBoxLoginContraseña";
            this.textBoxLoginContraseña.PlaceholderText = "Contraseña";
            this.textBoxLoginContraseña.Size = new System.Drawing.Size(248, 27);
            this.textBoxLoginContraseña.TabIndex = 3;
            this.textBoxLoginContraseña.TabStop = false;
            this.textBoxLoginContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLoginContraseña.UseSystemPasswordChar = true;
            this.textBoxLoginContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLoginContraseña_KeyPress);
            // 
            // pictureBoxXMark
            // 
            this.pictureBoxXMark.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxXMark.Image")));
            this.pictureBoxXMark.Location = new System.Drawing.Point(667, 13);
            this.pictureBoxXMark.Name = "pictureBoxXMark";
            this.pictureBoxXMark.Size = new System.Drawing.Size(18, 19);
            this.pictureBoxXMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxXMark.TabIndex = 5;
            this.pictureBoxXMark.TabStop = false;
            this.pictureBoxXMark.Click += new System.EventHandler(this.pictureBoxXMark_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(694, 330);
            this.Controls.Add(this.pictureBoxXMark);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.pictureBoxFAST1Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUI";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GUI_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFAST1Logo)).EndInit();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxXMark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonLogin;
        private Button button2;
        private DataGridView dataGridView1;
        private PictureBox pictureBoxFAST1Logo;
        private Panel panelLogin;
        private Label label1;
        private TextBox textBoxLoginUsuario;
        private TextBox textBoxLoginContraseña;
        private PictureBox pictureBoxXMark;
    }
}