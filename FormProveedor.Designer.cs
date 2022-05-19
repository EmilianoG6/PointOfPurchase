namespace PIA_PoP
{
    partial class FormProveedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.labelIDProveedor = new System.Windows.Forms.Label();
            this.textBoxIDProveedor = new System.Windows.Forms.TextBox();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelIDMarca = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxProveedorRFC = new System.Windows.Forms.TextBox();
            this.labelEmpresa = new System.Windows.Forms.Label();
            this.textBoxEmpresa = new System.Windows.Forms.TextBox();
            this.labelRFC = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxIDMarca = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonConfirmarEdit = new System.Windows.Forms.Button();
            this.buttonConfirmarAdd = new System.Windows.Forms.Button();
            this.panelContainer.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.panelAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelContainer.Controls.Add(this.panelSearch);
            this.panelContainer.Controls.Add(this.panelAdd);
            this.panelContainer.Location = new System.Drawing.Point(33, 12);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(760, 569);
            this.panelContainer.TabIndex = 9;
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.buttonBuscar);
            this.panelSearch.Controls.Add(this.labelIDProveedor);
            this.panelSearch.Controls.Add(this.textBoxIDProveedor);
            this.panelSearch.Location = new System.Drawing.Point(26, 33);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(309, 226);
            this.panelSearch.TabIndex = 10;
            this.panelSearch.Visible = false;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.buttonBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonBuscar.FlatAppearance.BorderSize = 0;
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBuscar.ForeColor = System.Drawing.Color.White;
            this.buttonBuscar.Location = new System.Drawing.Point(149, 111);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(152, 64);
            this.buttonBuscar.TabIndex = 11;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // labelIDProveedor
            // 
            this.labelIDProveedor.AutoSize = true;
            this.labelIDProveedor.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelIDProveedor.ForeColor = System.Drawing.Color.White;
            this.labelIDProveedor.Location = new System.Drawing.Point(3, 39);
            this.labelIDProveedor.Name = "labelIDProveedor";
            this.labelIDProveedor.Size = new System.Drawing.Size(128, 23);
            this.labelIDProveedor.TabIndex = 5;
            this.labelIDProveedor.Text = "ID Proveedor";
            // 
            // textBoxIDProveedor
            // 
            this.textBoxIDProveedor.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxIDProveedor.Location = new System.Drawing.Point(149, 34);
            this.textBoxIDProveedor.Name = "textBoxIDProveedor";
            this.textBoxIDProveedor.Size = new System.Drawing.Size(152, 28);
            this.textBoxIDProveedor.TabIndex = 6;
            this.textBoxIDProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelAdd
            // 
            this.panelAdd.Controls.Add(this.buttonCancelar);
            this.panelAdd.Controls.Add(this.labelIDMarca);
            this.panelAdd.Controls.Add(this.labelNombre);
            this.panelAdd.Controls.Add(this.textBoxProveedorRFC);
            this.panelAdd.Controls.Add(this.labelEmpresa);
            this.panelAdd.Controls.Add(this.textBoxEmpresa);
            this.panelAdd.Controls.Add(this.labelRFC);
            this.panelAdd.Controls.Add(this.textBoxNombre);
            this.panelAdd.Controls.Add(this.textBoxIDMarca);
            this.panelAdd.Controls.Add(this.buttonDelete);
            this.panelAdd.Controls.Add(this.buttonConfirmarEdit);
            this.panelAdd.Controls.Add(this.buttonConfirmarAdd);
            this.panelAdd.Location = new System.Drawing.Point(341, 33);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(398, 511);
            this.panelAdd.TabIndex = 9;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.buttonCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCancelar.FlatAppearance.BorderSize = 0;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelar.ForeColor = System.Drawing.Color.White;
            this.buttonCancelar.Location = new System.Drawing.Point(225, 420);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(152, 64);
            this.buttonCancelar.TabIndex = 12;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // labelIDMarca
            // 
            this.labelIDMarca.AutoSize = true;
            this.labelIDMarca.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelIDMarca.ForeColor = System.Drawing.Color.White;
            this.labelIDMarca.Location = new System.Drawing.Point(177, 39);
            this.labelIDMarca.Name = "labelIDMarca";
            this.labelIDMarca.Size = new System.Drawing.Size(94, 23);
            this.labelIDMarca.TabIndex = 0;
            this.labelIDMarca.Text = "ID Marca";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNombre.ForeColor = System.Drawing.Color.White;
            this.labelNombre.Location = new System.Drawing.Point(10, 111);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(85, 23);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre";
            // 
            // textBoxProveedorRFC
            // 
            this.textBoxProveedorRFC.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxProveedorRFC.Location = new System.Drawing.Point(109, 258);
            this.textBoxProveedorRFC.Name = "textBoxProveedorRFC";
            this.textBoxProveedorRFC.Size = new System.Drawing.Size(268, 28);
            this.textBoxProveedorRFC.TabIndex = 7;
            // 
            // labelEmpresa
            // 
            this.labelEmpresa.AutoSize = true;
            this.labelEmpresa.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEmpresa.ForeColor = System.Drawing.Color.White;
            this.labelEmpresa.Location = new System.Drawing.Point(5, 187);
            this.labelEmpresa.Name = "labelEmpresa";
            this.labelEmpresa.Size = new System.Drawing.Size(90, 23);
            this.labelEmpresa.TabIndex = 2;
            this.labelEmpresa.Text = "Empresa";
            this.labelEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxEmpresa
            // 
            this.textBoxEmpresa.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEmpresa.Location = new System.Drawing.Point(109, 184);
            this.textBoxEmpresa.Name = "textBoxEmpresa";
            this.textBoxEmpresa.Size = new System.Drawing.Size(268, 28);
            this.textBoxEmpresa.TabIndex = 6;
            // 
            // labelRFC
            // 
            this.labelRFC.AutoSize = true;
            this.labelRFC.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRFC.ForeColor = System.Drawing.Color.White;
            this.labelRFC.Location = new System.Drawing.Point(50, 261);
            this.labelRFC.Name = "labelRFC";
            this.labelRFC.Size = new System.Drawing.Size(45, 23);
            this.labelRFC.TabIndex = 3;
            this.labelRFC.Text = "RFC";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNombre.Location = new System.Drawing.Point(109, 108);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(268, 28);
            this.textBoxNombre.TabIndex = 5;
            // 
            // textBoxIDMarca
            // 
            this.textBoxIDMarca.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxIDMarca.Location = new System.Drawing.Point(278, 34);
            this.textBoxIDMarca.Name = "textBoxIDMarca";
            this.textBoxIDMarca.Size = new System.Drawing.Size(99, 28);
            this.textBoxIDMarca.TabIndex = 4;
            this.textBoxIDMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(225, 333);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(152, 64);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.Text = "Eliminar";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonConfirmarEdit
            // 
            this.buttonConfirmarEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.buttonConfirmarEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonConfirmarEdit.FlatAppearance.BorderSize = 0;
            this.buttonConfirmarEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmarEdit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonConfirmarEdit.ForeColor = System.Drawing.Color.White;
            this.buttonConfirmarEdit.Location = new System.Drawing.Point(225, 333);
            this.buttonConfirmarEdit.Name = "buttonConfirmarEdit";
            this.buttonConfirmarEdit.Size = new System.Drawing.Size(152, 64);
            this.buttonConfirmarEdit.TabIndex = 14;
            this.buttonConfirmarEdit.Text = "Confirmar";
            this.buttonConfirmarEdit.UseVisualStyleBackColor = false;
            this.buttonConfirmarEdit.Visible = false;
            this.buttonConfirmarEdit.Click += new System.EventHandler(this.buttonConfirmarEdit_Click);
            // 
            // buttonConfirmarAdd
            // 
            this.buttonConfirmarAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.buttonConfirmarAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonConfirmarAdd.FlatAppearance.BorderSize = 0;
            this.buttonConfirmarAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmarAdd.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonConfirmarAdd.ForeColor = System.Drawing.Color.White;
            this.buttonConfirmarAdd.Location = new System.Drawing.Point(225, 333);
            this.buttonConfirmarAdd.Name = "buttonConfirmarAdd";
            this.buttonConfirmarAdd.Size = new System.Drawing.Size(152, 64);
            this.buttonConfirmarAdd.TabIndex = 8;
            this.buttonConfirmarAdd.Text = "Confirmar";
            this.buttonConfirmarAdd.UseVisualStyleBackColor = false;
            this.buttonConfirmarAdd.Click += new System.EventHandler(this.buttonConfirmarAdd_Click);
            // 
            // FormProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(815, 625);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProveedor";
            this.Text = "FormProveedor";
            this.panelContainer.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelContainer;
        private Panel panelSearch;
        private Button buttonBuscar;
        private Label labelIDProveedor;
        private TextBox textBoxIDProveedor;
        private Panel panelAdd;
        private Button buttonConfirmarEdit;
        private Button buttonCancelar;
        private Label labelIDMarca;
        private Label labelNombre;
        private TextBox textBoxProveedorRFC;
        private Label labelEmpresa;
        private TextBox textBoxEmpresa;
        private Label labelRFC;
        private TextBox textBoxNombre;
        private TextBox textBoxIDMarca;
        private Button buttonConfirmarAdd;
        private Button buttonDelete;
    }
}