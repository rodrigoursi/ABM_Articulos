﻿namespace App
{
    partial class frmCatalogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatalogo));
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.grbBuscarProducto = new System.Windows.Forms.GroupBox();
            this.txbBuscarProducto = new System.Windows.Forms.Button();
            this.txbDatoBuscarProducto = new System.Windows.Forms.TextBox();
            this.lblBuscarElemento = new System.Windows.Forms.Label();
            this.cmbBuscarPor = new System.Windows.Forms.ComboBox();
            this.lblBuscarPor = new System.Windows.Forms.Label();
            this.btnEditarProducto = new System.Windows.Forms.Button();
            this.btnNuevoProducto = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnBackOfCatalogo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.grbBuscarProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(23, 100);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.RowTemplate.Height = 24;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(1172, 560);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellDoubleClick);
            // 
            // grbBuscarProducto
            // 
            this.grbBuscarProducto.Controls.Add(this.txbBuscarProducto);
            this.grbBuscarProducto.Controls.Add(this.txbDatoBuscarProducto);
            this.grbBuscarProducto.Controls.Add(this.lblBuscarElemento);
            this.grbBuscarProducto.Controls.Add(this.cmbBuscarPor);
            this.grbBuscarProducto.Controls.Add(this.lblBuscarPor);
            this.grbBuscarProducto.Location = new System.Drawing.Point(23, 14);
            this.grbBuscarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbBuscarProducto.Name = "grbBuscarProducto";
            this.grbBuscarProducto.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbBuscarProducto.Size = new System.Drawing.Size(1172, 68);
            this.grbBuscarProducto.TabIndex = 1;
            this.grbBuscarProducto.TabStop = false;
            this.grbBuscarProducto.Text = "Buscar";
            // 
            // txbBuscarProducto
            // 
            this.txbBuscarProducto.Location = new System.Drawing.Point(861, 20);
            this.txbBuscarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbBuscarProducto.Name = "txbBuscarProducto";
            this.txbBuscarProducto.Size = new System.Drawing.Size(223, 38);
            this.txbBuscarProducto.TabIndex = 2;
            this.txbBuscarProducto.Text = "&Buscar";
            this.txbBuscarProducto.UseVisualStyleBackColor = true;
            this.txbBuscarProducto.Click += new System.EventHandler(this.txbTextoBuscarProducto_Click);
            // 
            // txbDatoBuscarProducto
            // 
            this.txbDatoBuscarProducto.Location = new System.Drawing.Point(531, 30);
            this.txbDatoBuscarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbDatoBuscarProducto.Name = "txbDatoBuscarProducto";
            this.txbDatoBuscarProducto.Size = new System.Drawing.Size(241, 22);
            this.txbDatoBuscarProducto.TabIndex = 1;
            // 
            // lblBuscarElemento
            // 
            this.lblBuscarElemento.AutoSize = true;
            this.lblBuscarElemento.Location = new System.Drawing.Point(429, 32);
            this.lblBuscarElemento.Name = "lblBuscarElemento";
            this.lblBuscarElemento.Size = new System.Drawing.Size(94, 16);
            this.lblBuscarElemento.TabIndex = 2;
            this.lblBuscarElemento.Text = "Dato a buscar:";
            // 
            // cmbBuscarPor
            // 
            this.cmbBuscarPor.FormattingEnabled = true;
            this.cmbBuscarPor.Items.AddRange(new object[] {
            "Codigo",
            "Descripcion",
            "Marca",
            "Categoria"});
            this.cmbBuscarPor.Location = new System.Drawing.Point(100, 30);
            this.cmbBuscarPor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBuscarPor.Name = "cmbBuscarPor";
            this.cmbBuscarPor.Size = new System.Drawing.Size(241, 24);
            this.cmbBuscarPor.TabIndex = 0;
            // 
            // lblBuscarPor
            // 
            this.lblBuscarPor.AutoSize = true;
            this.lblBuscarPor.Location = new System.Drawing.Point(20, 32);
            this.lblBuscarPor.Name = "lblBuscarPor";
            this.lblBuscarPor.Size = new System.Drawing.Size(75, 16);
            this.lblBuscarPor.TabIndex = 0;
            this.lblBuscarPor.Text = "Buscar por:";
            // 
            // btnEditarProducto
            // 
            this.btnEditarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarProducto.Image")));
            this.btnEditarProducto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditarProducto.Location = new System.Drawing.Point(29, 687);
            this.btnEditarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditarProducto.Name = "btnEditarProducto";
            this.btnEditarProducto.Size = new System.Drawing.Size(95, 60);
            this.btnEditarProducto.TabIndex = 2;
            this.btnEditarProducto.Text = "Editar";
            this.btnEditarProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditarProducto.UseVisualStyleBackColor = true;
            this.btnEditarProducto.Click += new System.EventHandler(this.btnEditarProducto_Click);
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoProducto.Image")));
            this.btnNuevoProducto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevoProducto.Location = new System.Drawing.Point(133, 687);
            this.btnNuevoProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(95, 60);
            this.btnNuevoProducto.TabIndex = 3;
            this.btnNuevoProducto.Text = "Nuevo";
            this.btnNuevoProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevoProducto.UseVisualStyleBackColor = true;
            this.btnNuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarProducto.Image")));
            this.btnEliminarProducto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminarProducto.Location = new System.Drawing.Point(237, 687);
            this.btnEliminarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(95, 60);
            this.btnEliminarProducto.TabIndex = 4;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnBackOfCatalogo
            // 
            this.btnBackOfCatalogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackOfCatalogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackOfCatalogo.Image = ((System.Drawing.Image)(resources.GetObject("btnBackOfCatalogo.Image")));
            this.btnBackOfCatalogo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBackOfCatalogo.Location = new System.Drawing.Point(1100, 687);
            this.btnBackOfCatalogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackOfCatalogo.Name = "btnBackOfCatalogo";
            this.btnBackOfCatalogo.Size = new System.Drawing.Size(95, 60);
            this.btnBackOfCatalogo.TabIndex = 5;
            this.btnBackOfCatalogo.Text = "Volver";
            this.btnBackOfCatalogo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBackOfCatalogo.UseVisualStyleBackColor = true;
            this.btnBackOfCatalogo.Click += new System.EventHandler(this.btnBackOfCatalogo_Click);
            // 
            // frmCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 769);
            this.Controls.Add(this.btnBackOfCatalogo);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.btnNuevoProducto);
            this.Controls.Add(this.btnEditarProducto);
            this.Controls.Add(this.grbBuscarProducto);
            this.Controls.Add(this.dgvArticulos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCatalogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo";
            this.Load += new System.EventHandler(this.frmCatalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.grbBuscarProducto.ResumeLayout(false);
            this.grbBuscarProducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.GroupBox grbBuscarProducto;
        private System.Windows.Forms.Button txbBuscarProducto;
        private System.Windows.Forms.TextBox txbDatoBuscarProducto;
        private System.Windows.Forms.Label lblBuscarElemento;
        private System.Windows.Forms.ComboBox cmbBuscarPor;
        private System.Windows.Forms.Label lblBuscarPor;
        private System.Windows.Forms.Button btnEditarProducto;
        private System.Windows.Forms.Button btnNuevoProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnBackOfCatalogo;
    }
}