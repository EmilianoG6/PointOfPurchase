namespace PIA_PoP
{
    partial class FormVenta
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
            this.labelIDTicket = new System.Windows.Forms.Label();
            this.textBoxIDTicket = new System.Windows.Forms.TextBox();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.buttonConfirmarEdit = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelIDCliente = new System.Windows.Forms.Label();
            this.labelIDEmpleado = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.textBoxIDEmpleado = new System.Windows.Forms.TextBox();
            this.textBoxIDCliente = new System.Windows.Forms.TextBox();
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
            this.panelContainer.TabIndex = 9;
            // 
            // buttonDetalle
            // 
            this.buttonDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.buttonDetalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonDetalle.FlatAppearance.BorderSize = 0;
            this.buttonDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDetalle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDetalle.ForeColor = System.Drawing.Color.White;
            this.buttonDetalle.Location = new System.Drawing.Point(26, 480);
            this.buttonDetalle.Name = "buttonDetalle";
            this.buttonDetalle.Size = new System.Drawing.Size(152, 64);
            this.buttonDetalle.TabIndex = 18;
            this.buttonDetalle.Text = "Detalles";
            this.buttonDetalle.UseVisualStyleBackColor = false;
            this.buttonDetalle.Visible = false;
            this.buttonDetalle.Click += new System.EventHandler(this.buttonDetalle_Click);
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.buttonBuscar);
            this.panelSearch.Controls.Add(this.labelIDTicket);
            this.panelSearch.Controls.Add(this.textBoxIDTicket);
            this.panelSearch.Location = new System.Drawing.Point(26, 33);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(359, 226);
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
            this.buttonBuscar.Location = new System.Drawing.Point(167, 122);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(152, 64);
            this.buttonBuscar.TabIndex = 11;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // labelIDTicket
            // 
            this.labelIDTicket.AutoSize = true;
            this.labelIDTicket.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelIDTicket.ForeColor = System.Drawing.Color.White;
            this.labelIDTicket.Location = new System.Drawing.Point(52, 50);
            this.labelIDTicket.Name = "labelIDTicket";
            this.labelIDTicket.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelIDTicket.Size = new System.Drawing.Size(87, 23);
            this.labelIDTicket.TabIndex = 5;
            this.labelIDTicket.Text = "ID Ticket";
            this.labelIDTicket.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxIDTicket
            // 
            this.textBoxIDTicket.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxIDTicket.Location = new System.Drawing.Point(167, 45);
            this.textBoxIDTicket.Name = "textBoxIDTicket";
            this.textBoxIDTicket.Size = new System.Drawing.Size(152, 28);
            this.textBoxIDTicket.TabIndex = 6;
            this.textBoxIDTicket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelAdd
            // 
            this.panelAdd.Controls.Add(this.buttonConfirmarEdit);
            this.panelAdd.Controls.Add(this.buttonCancelar);
            this.panelAdd.Controls.Add(this.labelIDCliente);
            this.panelAdd.Controls.Add(this.labelIDEmpleado);
            this.panelAdd.Controls.Add(this.labelFecha);
            this.panelAdd.Controls.Add(this.textBoxFecha);
            this.panelAdd.Controls.Add(this.textBoxIDEmpleado);
            this.panelAdd.Controls.Add(this.textBoxIDCliente);
            this.panelAdd.Controls.Add(this.buttonConfirmarAdd);
            this.panelAdd.Controls.Add(this.buttonDelete);
            this.panelAdd.Location = new System.Drawing.Point(391, 33);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(348, 511);
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
            this.buttonConfirmarEdit.Location = new System.Drawing.Point(168, 245);
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
            this.buttonCancelar.Location = new System.Drawing.Point(168, 332);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(152, 64);
            this.buttonCancelar.TabIndex = 12;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // labelIDCliente
            // 
            this.labelIDCliente.AutoSize = true;
            this.labelIDCliente.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelIDCliente.ForeColor = System.Drawing.Color.White;
            this.labelIDCliente.Location = new System.Drawing.Point(101, 46);
            this.labelIDCliente.Name = "labelIDCliente";
            this.labelIDCliente.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelIDCliente.Size = new System.Drawing.Size(99, 23);
            this.labelIDCliente.TabIndex = 0;
            this.labelIDCliente.Text = "ID Cliente";
            // 
            // labelIDEmpleado
            // 
            this.labelIDEmpleado.AutoSize = true;
            this.labelIDEmpleado.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelIDEmpleado.ForeColor = System.Drawing.Color.White;
            this.labelIDEmpleado.Location = new System.Drawing.Point(71, 109);
            this.labelIDEmpleado.Name = "labelIDEmpleado";
            this.labelIDEmpleado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelIDEmpleado.Size = new System.Drawing.Size(129, 23);
            this.labelIDEmpleado.TabIndex = 1;
            this.labelIDEmpleado.Text = "ID Empleado";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFecha.ForeColor = System.Drawing.Color.White;
            this.labelFecha.Location = new System.Drawing.Point(17, 173);
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
            this.textBoxFecha.Location = new System.Drawing.Point(101, 168);
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.Size = new System.Drawing.Size(219, 28);
            this.textBoxFecha.TabIndex = 6;
            this.textBoxFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxIDEmpleado
            // 
            this.textBoxIDEmpleado.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxIDEmpleado.Location = new System.Drawing.Point(225, 104);
            this.textBoxIDEmpleado.Name = "textBoxIDEmpleado";
            this.textBoxIDEmpleado.Size = new System.Drawing.Size(95, 28);
            this.textBoxIDEmpleado.TabIndex = 5;
            this.textBoxIDEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxIDCliente
            // 
            this.textBoxIDCliente.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxIDCliente.Location = new System.Drawing.Point(225, 41);
            this.textBoxIDCliente.Name = "textBoxIDCliente";
            this.textBoxIDCliente.Size = new System.Drawing.Size(95, 28);
            this.textBoxIDCliente.TabIndex = 4;
            this.textBoxIDCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonConfirmarAdd
            // 
            this.buttonConfirmarAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.buttonConfirmarAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonConfirmarAdd.FlatAppearance.BorderSize = 0;
            this.buttonConfirmarAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmarAdd.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonConfirmarAdd.ForeColor = System.Drawing.Color.White;
            this.buttonConfirmarAdd.Location = new System.Drawing.Point(168, 245);
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
            this.buttonDelete.Location = new System.Drawing.Point(168, 245);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(152, 64);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.Text = "Eliminar";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(813, 625);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta";
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
        private Label labelIDTicket;
        private TextBox textBoxIDTicket;
        private Panel panelAdd;
        private Button buttonConfirmarEdit;
        private Button buttonCancelar;
        private Label labelIDCliente;
        private Label labelIDEmpleado;
        private Label labelFecha;
        private TextBox textBoxFecha;
        private TextBox textBoxIDEmpleado;
        private TextBox textBoxIDCliente;
        private Button buttonConfirmarAdd;
        private Button buttonDelete;
    }
}