namespace App
{
    partial class frmCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategorias));
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            this.btnNuevoCategoria = new System.Windows.Forms.Button();
            this.btnEditarCategoria = new System.Windows.Forms.Button();
            this.btnBackOfCatalogo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(16, 73);
            this.dgvCategorias.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.ReadOnly = true;
            this.dgvCategorias.RowHeadersWidth = 51;
            this.dgvCategorias.RowTemplate.Height = 24;
            this.dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategorias.Size = new System.Drawing.Size(844, 450);
            this.dgvCategorias.TabIndex = 0;
            this.dgvCategorias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategorias_CellDoubleClick);
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarCategoria.Image")));
            this.btnEliminarCategoria.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminarCategoria.Location = new System.Drawing.Point(170, 552);
            this.btnEliminarCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(64, 49);
            this.btnEliminarCategoria.TabIndex = 7;
            this.btnEliminarCategoria.Text = "Eliminar";
            this.btnEliminarCategoria.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminarCategoria.UseVisualStyleBackColor = true;
            this.btnEliminarCategoria.Click += new System.EventHandler(this.btnEliminarCategoria_Click);
            // 
            // btnNuevoCategoria
            // 
            this.btnNuevoCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoCategoria.Image")));
            this.btnNuevoCategoria.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevoCategoria.Location = new System.Drawing.Point(94, 552);
            this.btnNuevoCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevoCategoria.Name = "btnNuevoCategoria";
            this.btnNuevoCategoria.Size = new System.Drawing.Size(65, 49);
            this.btnNuevoCategoria.TabIndex = 6;
            this.btnNuevoCategoria.Text = "Nuevo";
            this.btnNuevoCategoria.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevoCategoria.UseVisualStyleBackColor = true;
            this.btnNuevoCategoria.Click += new System.EventHandler(this.btnNuevoCategoria_Click);
            // 
            // btnEditarCategoria
            // 
            this.btnEditarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarCategoria.Image")));
            this.btnEditarCategoria.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditarCategoria.Location = new System.Drawing.Point(20, 552);
            this.btnEditarCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarCategoria.Name = "btnEditarCategoria";
            this.btnEditarCategoria.Size = new System.Drawing.Size(65, 49);
            this.btnEditarCategoria.TabIndex = 5;
            this.btnEditarCategoria.Text = "Editar";
            this.btnEditarCategoria.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditarCategoria.UseVisualStyleBackColor = true;
            this.btnEditarCategoria.Click += new System.EventHandler(this.btnEditarCategoria_Click);
            // 
            // btnBackOfCatalogo
            // 
            this.btnBackOfCatalogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackOfCatalogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackOfCatalogo.Image = ((System.Drawing.Image)(resources.GetObject("btnBackOfCatalogo.Image")));
            this.btnBackOfCatalogo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBackOfCatalogo.Location = new System.Drawing.Point(789, 552);
            this.btnBackOfCatalogo.Margin = new System.Windows.Forms.Padding(2);
            this.btnBackOfCatalogo.Name = "btnBackOfCatalogo";
            this.btnBackOfCatalogo.Size = new System.Drawing.Size(71, 49);
            this.btnBackOfCatalogo.TabIndex = 8;
            this.btnBackOfCatalogo.Text = "Volver";
            this.btnBackOfCatalogo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBackOfCatalogo.UseVisualStyleBackColor = true;
            this.btnBackOfCatalogo.Click += new System.EventHandler(this.btnBackOfCatalogo_Click);
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 625);
            this.Controls.Add(this.btnBackOfCatalogo);
            this.Controls.Add(this.btnEliminarCategoria);
            this.Controls.Add(this.btnNuevoCategoria);
            this.Controls.Add(this.btnEditarCategoria);
            this.Controls.Add(this.dgvCategorias);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCategorias";
            this.Load += new System.EventHandler(this.frmCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.Button btnEliminarCategoria;
        private System.Windows.Forms.Button btnNuevoCategoria;
        private System.Windows.Forms.Button btnEditarCategoria;
        private System.Windows.Forms.Button btnBackOfCatalogo;
    }
}