namespace PIA_PoP
{
    partial class FormOrden
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
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.buttonDetalle = new System.Windows.Forms.Button();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.labelIDOrdenCompra = new System.Windows.Forms.Label();
            this.textBoxIDOrdenCompra = new System.Windows.Forms.TextBox();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.buttonConfirmarEdit = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelIDProveedor = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.textBoxIDProveedor = new System.Windows.Forms.TextBox();
            this.buttonConfirmarAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.panelContenedor.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.panelAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.panelContainer);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(813, 625);
            this.panelContenedor.TabIndex = 0;
            // 
            // panelContainer
            // 
            this.panelContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelContainer.Controls.Add(this.buttonDetalle);
            this.panelContainer.Controls.Add(this.panelSearch);
            this.panelContainer.Controls.Add(this.panelAdd);
            this.panelContainer.Location = new System.Drawing.Point(26, 28);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(760, 569);
            this.panelContainer.TabIndex = 12;
            // 
            // buttonDetalle
            // 
            this.buttonDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.buttonDetalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonDetalle.FlatAppearance.BorderSize = 0;
            this.buttonDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDetalle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDetalle.ForeColor = System.Drawing.Color.White;
            this.buttonDetalle.Location = new System.Drawing.Point(19, 480);
            this.buttonDetalle.Name = "buttonDetalle";
            this.buttonDetalle.Size = new System.Drawing.Size(152, 64);
            this.buttonDetalle.TabIndex = 16;
            this.buttonDetalle.Text = "Detalles";
            this.buttonDetalle.UseVisualStyleBackColor = false;
            this.buttonDetalle.Visible = false;
            this.buttonDetalle.Click += new System.EventHandler(this.buttonDetalle_Click);
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.buttonBuscar);
            this.panelSearch.Controls.Add(this.labelIDOrdenCompra);
            this.panelSearch.Controls.Add(this.textBoxIDOrdenCompra);
            this.panelSearch.Location = new System.Drawing.Point(3, 33);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(394, 226);
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
            this.buttonBuscar.Location = new System.Drawing.Point(205, 117);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(152, 64);
            this.buttonBuscar.TabIndex = 11;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // labelIDOrdenCompra
            // 
            this.labelIDOrdenCompra.AutoSize = true;
            this.labelIDOrdenCompra.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelIDOrdenCompra.ForeColor = System.Drawing.Color.White;
            this.labelIDOrdenCompra.Location = new System.Drawing.Point(77, 45);
            this.labelIDOrdenCompra.Name = "labelIDOrdenCompra";
            this.labelIDOrdenCompra.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelIDOrdenCompra.Size = new System.Drawing.Size(91, 23);
            this.labelIDOrdenCompra.TabIndex = 5;
            this.labelIDOrdenCompra.Text = "ID Orden";
            this.labelIDOrdenCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxIDOrdenCompra
            // 
            this.textBoxIDOrdenCompra.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxIDOrdenCompra.Location = new System.Drawing.Point(205, 40);
            this.textBoxIDOrdenCompra.Name = "textBoxIDOrdenCompra";
            this.textBoxIDOrdenCompra.Size = new System.Drawing.Size(152, 28);
            this.textBoxIDOrdenCompra.TabIndex = 6;
            this.textBoxIDOrdenCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelAdd
            // 
            this.panelAdd.Controls.Add(this.buttonConfirmarEdit);
            this.panelAdd.Controls.Add(this.buttonCancelar);
            this.panelAdd.Controls.Add(this.labelIDProveedor);
            this.panelAdd.Controls.Add(this.labelFecha);
            this.panelAdd.Controls.Add(this.textBoxFecha);
            this.panelAdd.Controls.Add(this.textBoxIDProveedor);
            this.panelAdd.Controls.Add(this.buttonConfirmarAdd);
            this.panelAdd.Controls.Add(this.buttonDelete);
            this.panelAdd.Location = new System.Drawing.Point(403, 33);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(336, 511);
            this.panelAdd.TabIndex = 9;
            // 
            // buttonConfirmarEdit
            // 
            this.buttonConfirmarEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.buttonConfirmarEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonConfirmarEdit.FlatAppearance.BorderSize = 0;
            this.buttonConfirmarEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmarEdit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonConfirmarEdit.ForeColor = System.Drawing.Color.White;
            this.buttonConfirmarEdit.Location = new System.Drawing.Point(167, 162);
            this.buttonConfirmarEdit.Name = "buttonConfirmarEdit";
            this.buttonConfirmarEdit.Size = new System.Drawing.Size(152, 64);
            this.buttonConfirmarEdit.TabIndex = 14;
            this.buttonConfirmarEdit.Text = "Confirmar";
            this.buttonConfirmarEdit.UseVisualStyleBackColor = false;
            this.buttonConfirmarEdit.Visible = false;
            this.buttonConfirmarEdit.Click += new System.EventHandler(this.buttonConfirmarEdit_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.buttonCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCancelar.FlatAppearance.BorderSize = 0;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelar.ForeColor = System.Drawing.Color.White;
            this.buttonCancelar.Location = new System.Drawing.Point(167, 249);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(152, 64);
            this.buttonCancelar.TabIndex = 12;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // labelIDProveedor
            // 
            this.labelIDProveedor.AutoSize = true;
            this.labelIDProveedor.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelIDProveedor.ForeColor = System.Drawing.Color.White;
            this.labelIDProveedor.Location = new System.Drawing.Point(3, 45);
            this.labelIDProveedor.Name = "labelIDProveedor";
            this.labelIDProveedor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelIDProveedor.Size = new System.Drawing.Size(128, 23);
            this.labelIDProveedor.TabIndex = 0;
            this.labelIDProveedor.Text = "ID Proveedor";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFecha.ForeColor = System.Drawing.Color.White;
            this.labelFecha.Location = new System.Drawing.Point(3, 105);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelFecha.Size = new System.Drawing.Size(67, 23);
            this.labelFecha.TabIndex = 2;
            this.labelFecha.Text = "Fecha";
            this.labelFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxFecha
            // 
            this.textBoxFecha.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxFecha.Location = new System.Drawing.Point(90, 100);
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.Size = new System.Drawing.Size(229, 28);
            this.textBoxFecha.TabIndex = 6;
            this.textBoxFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxIDProveedor
            // 
            this.textBoxIDProveedor.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxIDProveedor.Location = new System.Drawing.Point(151, 40);
            this.textBoxIDProveedor.Name = "textBoxIDProveedor";
            this.textBoxIDProveedor.Size = new System.Drawing.Size(168, 28);
            this.textBoxIDProveedor.TabIndex = 4;
            this.textBoxIDProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonConfirmarAdd
            // 
            this.buttonConfirmarAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.buttonConfirmarAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonConfirmarAdd.FlatAppearance.BorderSize = 0;
            this.buttonConfirmarAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmarAdd.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonConfirmarAdd.ForeColor = System.Drawing.Color.White;
            this.buttonConfirmarAdd.Location = new System.Drawing.Point(167, 162);
            this.buttonConfirmarAdd.Name = "buttonConfirmarAdd";
            this.buttonConfirmarAdd.Size = new System.Drawing.Size(152, 64);
            this.buttonConfirmarAdd.TabIndex = 8;
            this.buttonConfirmarAdd.Text = "Confirmar";
            this.buttonConfirmarAdd.UseVisualStyleBackColor = false;
            this.buttonConfirmarAdd.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(167, 162);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(152, 64);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.Text = "Eliminar";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // FormOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(813, 625);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOrden";
            this.Text = "Orden";
            this.panelContenedor.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelContenedor;
        private Panel panelContainer;
        private Button buttonDetalle;
        private Panel panelSearch;
        private Button buttonBuscar;
        private Label labelIDOrdenCompra;
        private TextBox textBoxIDOrdenCompra;
        private Panel panelAdd;
        private Button buttonConfirmarEdit;
        private Button buttonCancelar;
        private Label labelIDProveedor;
        private Label labelFecha;
        private TextBox textBoxFecha;
        private TextBox textBoxIDProveedor;
        private Button buttonConfirmarAdd;
        private Button buttonDelete;
    }
}