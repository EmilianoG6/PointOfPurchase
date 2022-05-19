namespace PIA_PoP
{
    partial class FormUnidad
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
            this.labelIDUnidad = new System.Windows.Forms.Label();
            this.textBoxIDUnidad = new System.Windows.Forms.TextBox();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelMagnitud = new System.Windows.Forms.Label();
            this.labelUnidad = new System.Windows.Forms.Label();
            this.labelSimbolo = new System.Windows.Forms.Label();
            this.textBoxSimbolo = new System.Windows.Forms.TextBox();
            this.textBoxUnidad = new System.Windows.Forms.TextBox();
            this.textBoxMagnitud = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
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
            this.panelContainer.Location = new System.Drawing.Point(26, 28);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(760, 569);
            this.panelContainer.TabIndex = 10;
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.buttonBuscar);
            this.panelSearch.Controls.Add(this.labelIDUnidad);
            this.panelSearch.Controls.Add(this.textBoxIDUnidad);
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
            // labelIDUnidad
            // 
            this.labelIDUnidad.AutoSize = true;
            this.labelIDUnidad.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelIDUnidad.ForeColor = System.Drawing.Color.White;
            this.labelIDUnidad.Location = new System.Drawing.Point(33, 45);
            this.labelIDUnidad.Name = "labelIDUnidad";
            this.labelIDUnidad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelIDUnidad.Size = new System.Drawing.Size(101, 23);
            this.labelIDUnidad.TabIndex = 5;
            this.labelIDUnidad.Text = "ID Unidad";
            this.labelIDUnidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxIDUnidad
            // 
            this.textBoxIDUnidad.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxIDUnidad.Location = new System.Drawing.Point(167, 45);
            this.textBoxIDUnidad.Name = "textBoxIDUnidad";
            this.textBoxIDUnidad.Size = new System.Drawing.Size(152, 28);
            this.textBoxIDUnidad.TabIndex = 6;
            this.textBoxIDUnidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelAdd
            // 
            this.panelAdd.Controls.Add(this.labelCantidad);
            this.panelAdd.Controls.Add(this.textBoxCantidad);
            this.panelAdd.Controls.Add(this.buttonCancelar);
            this.panelAdd.Controls.Add(this.labelMagnitud);
            this.panelAdd.Controls.Add(this.labelUnidad);
            this.panelAdd.Controls.Add(this.labelSimbolo);
            this.panelAdd.Controls.Add(this.textBoxSimbolo);
            this.panelAdd.Controls.Add(this.textBoxUnidad);
            this.panelAdd.Controls.Add(this.textBoxMagnitud);
            this.panelAdd.Controls.Add(this.buttonAdd);
            this.panelAdd.Controls.Add(this.buttonDelete);
            this.panelAdd.Controls.Add(this.buttonEdit);
            this.panelAdd.Location = new System.Drawing.Point(403, 33);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(336, 511);
            this.panelAdd.TabIndex = 9;
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCantidad.ForeColor = System.Drawing.Color.White;
            this.labelCantidad.Location = new System.Drawing.Point(100, 107);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelCantidad.Size = new System.Drawing.Size(99, 23);
            this.labelCantidad.TabIndex = 10;
            this.labelCantidad.Text = "Cantidad";
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCantidad.Location = new System.Drawing.Point(217, 102);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(102, 28);
            this.textBoxCantidad.TabIndex = 11;
            this.textBoxCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.buttonCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCancelar.FlatAppearance.BorderSize = 0;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelar.ForeColor = System.Drawing.Color.White;
            this.buttonCancelar.Location = new System.Drawing.Point(167, 376);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(152, 64);
            this.buttonCancelar.TabIndex = 12;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // labelMagnitud
            // 
            this.labelMagnitud.AutoSize = true;
            this.labelMagnitud.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMagnitud.ForeColor = System.Drawing.Color.White;
            this.labelMagnitud.Location = new System.Drawing.Point(3, 45);
            this.labelMagnitud.Name = "labelMagnitud";
            this.labelMagnitud.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelMagnitud.Size = new System.Drawing.Size(99, 23);
            this.labelMagnitud.TabIndex = 0;
            this.labelMagnitud.Text = "Magnitud";
            // 
            // labelUnidad
            // 
            this.labelUnidad.AutoSize = true;
            this.labelUnidad.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUnidad.ForeColor = System.Drawing.Color.White;
            this.labelUnidad.Location = new System.Drawing.Point(117, 169);
            this.labelUnidad.Name = "labelUnidad";
            this.labelUnidad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelUnidad.Size = new System.Drawing.Size(78, 23);
            this.labelUnidad.TabIndex = 1;
            this.labelUnidad.Text = "Unidad";
            // 
            // labelSimbolo
            // 
            this.labelSimbolo.AutoSize = true;
            this.labelSimbolo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSimbolo.ForeColor = System.Drawing.Color.White;
            this.labelSimbolo.Location = new System.Drawing.Point(110, 226);
            this.labelSimbolo.Name = "labelSimbolo";
            this.labelSimbolo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelSimbolo.Size = new System.Drawing.Size(85, 23);
            this.labelSimbolo.TabIndex = 2;
            this.labelSimbolo.Text = "Símbolo";
            this.labelSimbolo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxSimbolo
            // 
            this.textBoxSimbolo.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSimbolo.Location = new System.Drawing.Point(217, 221);
            this.textBoxSimbolo.Name = "textBoxSimbolo";
            this.textBoxSimbolo.Size = new System.Drawing.Size(102, 28);
            this.textBoxSimbolo.TabIndex = 6;
            this.textBoxSimbolo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxUnidad
            // 
            this.textBoxUnidad.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUnidad.Location = new System.Drawing.Point(217, 164);
            this.textBoxUnidad.Name = "textBoxUnidad";
            this.textBoxUnidad.Size = new System.Drawing.Size(102, 28);
            this.textBoxUnidad.TabIndex = 5;
            this.textBoxUnidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMagnitud
            // 
            this.textBoxMagnitud.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMagnitud.Location = new System.Drawing.Point(117, 40);
            this.textBoxMagnitud.Name = "textBoxMagnitud";
            this.textBoxMagnitud.Size = new System.Drawing.Size(202, 28);
            this.textBoxMagnitud.TabIndex = 4;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(167, 289);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(152, 64);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Confirmar";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(167, 289);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(152, 64);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.Text = "Eliminar";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.buttonEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(167, 289);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(152, 64);
            this.buttonEdit.TabIndex = 14;
            this.buttonEdit.Text = "Confirmar";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Visible = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonConfirmarEdit_Click);
            // 
            // FormUnidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(813, 625);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUnidad";
            this.Text = "FormUnidad";
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
        private Label labelIDUnidad;
        private TextBox textBoxIDUnidad;
        private Panel panelAdd;
        private Label labelCantidad;
        private Button buttonEdit;
        private TextBox textBoxCantidad;
        private Button buttonCancelar;
        private Label labelMagnitud;
        private Label labelUnidad;
        private Label labelSimbolo;
        private TextBox textBoxSimbolo;
        private TextBox textBoxUnidad;
        private TextBox textBoxMagnitud;
        private Button buttonAdd;
        private Button buttonDelete;
    }
}