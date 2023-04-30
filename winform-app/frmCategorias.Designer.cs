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
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(22, 90);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.RowHeadersWidth = 51;
            this.dgvCategorias.RowTemplate.Height = 24;
            this.dgvCategorias.Size = new System.Drawing.Size(1126, 554);
            this.dgvCategorias.TabIndex = 0;
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarCategoria.Image")));
            this.btnEliminarCategoria.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminarCategoria.Location = new System.Drawing.Point(227, 680);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(85, 60);
            this.btnEliminarCategoria.TabIndex = 7;
            this.btnEliminarCategoria.Text = "Eliminar";
            this.btnEliminarCategoria.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminarCategoria.UseVisualStyleBackColor = true;
            // 
            // btnNuevoCategoria
            // 
            this.btnNuevoCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoCategoria.Image")));
            this.btnNuevoCategoria.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevoCategoria.Location = new System.Drawing.Point(126, 680);
            this.btnNuevoCategoria.Name = "btnNuevoCategoria";
            this.btnNuevoCategoria.Size = new System.Drawing.Size(87, 60);
            this.btnNuevoCategoria.TabIndex = 6;
            this.btnNuevoCategoria.Text = "Nuevo";
            this.btnNuevoCategoria.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevoCategoria.UseVisualStyleBackColor = true;
            // 
            // btnEditarCategoria
            // 
            this.btnEditarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarCategoria.Image")));
            this.btnEditarCategoria.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditarCategoria.Location = new System.Drawing.Point(26, 680);
            this.btnEditarCategoria.Name = "btnEditarCategoria";
            this.btnEditarCategoria.Size = new System.Drawing.Size(87, 60);
            this.btnEditarCategoria.TabIndex = 5;
            this.btnEditarCategoria.Text = "Editar";
            this.btnEditarCategoria.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditarCategoria.UseVisualStyleBackColor = true;
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 769);
            this.Controls.Add(this.btnEliminarCategoria);
            this.Controls.Add(this.btnNuevoCategoria);
            this.Controls.Add(this.btnEditarCategoria);
            this.Controls.Add(this.dgvCategorias);
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
    }
}