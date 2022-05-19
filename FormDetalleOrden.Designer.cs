namespace PIA_PoP
{
    partial class FormDetalleOrden
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
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.labelIDOrdenCompra = new System.Windows.Forms.Label();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelIDProducto = new System.Windows.Forms.Label();
            this.labellMarca = new System.Windows.Forms.Label();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.labellCosto = new System.Windows.Forms.Label();
            this.textBoxCosto = new System.Windows.Forms.TextBox();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.textBoxIDProducto = new System.Windows.Forms.TextBox();
            this.buttonConfirmarAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.textBoxIDOrdenCompra = new System.Windows.Forms.TextBox();
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
            this.panelContainer.Controls.Add(this.buttonMostrar);
            this.panelContainer.Controls.Add(this.panelSearch);
            this.panelContainer.Controls.Add(this.labelIDOrdenCompra);
            this.panelContainer.Controls.Add(this.panelAdd);
            this.panelContainer.Controls.Add(this.textBoxIDOrdenCompra);
            this.panelContainer.Location = new System.Drawing.Point(26, 28);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(760, 569);
            this.panelContainer.TabIndex = 11;
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.buttonMostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonMostrar.FlatAppearance.BorderSize = 0;
            this.buttonMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMostrar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMostrar.ForeColor = System.Drawing.Color.White;
            this.buttonMostrar.Location = new System.Drawing.Point(20, 480);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(203, 64);
            this.buttonMostrar.TabIndex = 12;
            this.buttonMostrar.Text = "Mostrar tabla";
            this.buttonMostrar.UseVisualStyleBackColor = false;
            this.buttonMostrar.Click += new System.EventHandler(this.buttonMostrar_Click);
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.buttonBuscar);
            this.panelSearch.Location = new System.Drawing.Point(229, 135);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(157, 75);
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
            this.buttonBuscar.Location = new System.Drawing.Point(0, 5);
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
            this.labelIDOrdenCompra.Location = new System.Drawing.Point(20, 74);
            this.labelIDOrdenCompra.Name = "labelIDOrdenCompra";
            this.labelIDOrdenCompra.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelIDOrdenCompra.Size = new System.Drawing.Size(203, 23);
            this.labelIDOrdenCompra.TabIndex = 5;
            this.labelIDOrdenCompra.Text = "ID Orden de Compra";
            this.labelIDOrdenCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelAdd
            // 
            this.panelAdd.Controls.Add(this.buttonCancelar);
            this.panelAdd.Controls.Add(this.labelIDProducto);
            this.panelAdd.Controls.Add(this.labellMarca);
            this.panelAdd.Controls.Add(this.textBoxCantidad);
            this.panelAdd.Controls.Add(this.labellCosto);
            this.panelAdd.Controls.Add(this.textBoxCosto);
            this.panelAdd.Controls.Add(this.labelCantidad);
            this.panelAdd.Controls.Add(this.textBoxIDProducto);
            this.panelAdd.Controls.Add(this.buttonConfirmarAdd);
            this.panelAdd.Controls.Add(this.buttonDelete);
            this.panelAdd.Controls.Add(this.textBoxMarca);
            this.panelAdd.Location = new System.Drawing.Point(403, 33);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(336, 511);
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
            this.buttonCancelar.Location = new System.Drawing.Point(167, 391);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(152, 64);
            this.buttonCancelar.TabIndex = 12;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // labelIDProducto
            // 
            this.labelIDProducto.AutoSize = true;
            this.labelIDProducto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelIDProducto.ForeColor = System.Drawing.Color.White;
            this.labelIDProducto.Location = new System.Drawing.Point(20, 45);
            this.labelIDProducto.Name = "labelIDProducto";
            this.labelIDProducto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelIDProducto.Size = new System.Drawing.Size(116, 23);
            this.labelIDProducto.TabIndex = 0;
            this.labelIDProducto.Text = "ID Producto";
            // 
            // labellMarca
            // 
            this.labellMarca.AutoSize = true;
            this.labellMarca.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labellMarca.ForeColor = System.Drawing.Color.White;
            this.labellMarca.Location = new System.Drawing.Point(20, 107);
            this.labellMarca.Name = "labellMarca";
            this.labellMarca.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labellMarca.Size = new System.Drawing.Size(71, 23);
            this.labellMarca.TabIndex = 1;
            this.labellMarca.Text = "Marca";
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCantidad.Location = new System.Drawing.Point(194, 233);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(125, 28);
            this.textBoxCantidad.TabIndex = 7;
            // 
            // labellCosto
            // 
            this.labellCosto.AutoSize = true;
            this.labellCosto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labellCosto.ForeColor = System.Drawing.Color.White;
            this.labellCosto.Location = new System.Drawing.Point(104, 172);
            this.labellCosto.Name = "labellCosto";
            this.labellCosto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labellCosto.Size = new System.Drawing.Size(63, 23);
            this.labellCosto.TabIndex = 2;
            this.labellCosto.Text = "Costo";
            this.labellCosto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxCosto
            // 
            this.textBoxCosto.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCosto.Location = new System.Drawing.Point(194, 167);
            this.textBoxCosto.Name = "textBoxCosto";
            this.textBoxCosto.Size = new System.Drawing.Size(125, 28);
            this.textBoxCosto.TabIndex = 6;
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCantidad.ForeColor = System.Drawing.Color.White;
            this.labelCantidad.Location = new System.Drawing.Point(68, 238);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelCantidad.Size = new System.Drawing.Size(99, 23);
            this.labelCantidad.TabIndex = 3;
            this.labelCantidad.Text = "Cantidad";
            // 
            // textBoxIDProducto
            // 
            this.textBoxIDProducto.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxIDProducto.Location = new System.Drawing.Point(148, 40);
            this.textBoxIDProducto.Name = "textBoxIDProducto";
            this.textBoxIDProducto.Size = new System.Drawing.Size(171, 28);
            this.textBoxIDProducto.TabIndex = 4;
            this.textBoxIDProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonConfirmarAdd
            // 
            this.buttonConfirmarAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.buttonConfirmarAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonConfirmarAdd.FlatAppearance.BorderSize = 0;
            this.buttonConfirmarAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmarAdd.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonConfirmarAdd.ForeColor = System.Drawing.Color.White;
            this.buttonConfirmarAdd.Location = new System.Drawing.Point(167, 304);
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
            this.buttonDelete.Location = new System.Drawing.Point(167, 304);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(152, 64);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.Text = "Eliminar";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMarca.Location = new System.Drawing.Point(108, 102);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(211, 28);
            this.textBoxMarca.TabIndex = 5;
            // 
            // textBoxIDOrdenCompra
            // 
            this.textBoxIDOrdenCompra.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxIDOrdenCompra.Location = new System.Drawing.Point(229, 72);
            this.textBoxIDOrdenCompra.Name = "textBoxIDOrdenCompra";
            this.textBoxIDOrdenCompra.Size = new System.Drawing.Size(150, 28);
            this.textBoxIDOrdenCompra.TabIndex = 6;
            this.textBoxIDOrdenCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormDetalleOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(813, 625);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDetalleOrden";
            this.Text = "Orden";
            this.panelContenedor.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelContainer;
        private Panel panelSearch;
        private Button buttonBuscar;
        private Label labelIDOrdenCompra;
        private TextBox textBoxIDOrdenCompra;
        private Panel panelAdd;
        private Button buttonCancelar;
        private Label labelIDProducto;
        private Label labellMarca;
        private TextBox textBoxCantidad;
        private Label labellCosto;
        private TextBox textBoxCosto;
        private Label labelCantidad;
        private TextBox textBoxMarca;
        private TextBox textBoxIDProducto;
        private Button buttonConfirmarAdd;
        private Button buttonDelete;
        private Button buttonMostrar;
        private Panel panelContenedor;
    }
}