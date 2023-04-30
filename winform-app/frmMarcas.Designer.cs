namespace App
{
    partial class frmMarcas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMarcas));
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.btnEliminarMarca = new System.Windows.Forms.Button();
            this.btnNuevoMarca = new System.Windows.Forms.Button();
            this.btnEditarMarca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.Location = new System.Drawing.Point(36, 91);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.RowHeadersWidth = 51;
            this.dgvMarcas.RowTemplate.Height = 24;
            this.dgvMarcas.Size = new System.Drawing.Size(1131, 554);
            this.dgvMarcas.TabIndex = 0;
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMarca.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarMarca.Image")));
            this.btnEliminarMarca.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminarMarca.Location = new System.Drawing.Point(243, 686);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(83, 60);
            this.btnEliminarMarca.TabIndex = 7;
            this.btnEliminarMarca.Text = "Eliminar";
            this.btnEliminarMarca.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminarMarca.UseVisualStyleBackColor = true;
            // 
            // btnNuevoMarca
            // 
            this.btnNuevoMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoMarca.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoMarca.Image")));
            this.btnNuevoMarca.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevoMarca.Location = new System.Drawing.Point(145, 686);
            this.btnNuevoMarca.Name = "btnNuevoMarca";
            this.btnNuevoMarca.Size = new System.Drawing.Size(87, 60);
            this.btnNuevoMarca.TabIndex = 6;
            this.btnNuevoMarca.Text = "Nuevo";
            this.btnNuevoMarca.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevoMarca.UseVisualStyleBackColor = true;
            // 
            // btnEditarMarca
            // 
            this.btnEditarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarMarca.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarMarca.Image")));
            this.btnEditarMarca.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditarMarca.Location = new System.Drawing.Point(43, 686);
            this.btnEditarMarca.Name = "btnEditarMarca";
            this.btnEditarMarca.Size = new System.Drawing.Size(87, 60);
            this.btnEditarMarca.TabIndex = 5;
            this.btnEditarMarca.Text = "Editar";
            this.btnEditarMarca.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditarMarca.UseVisualStyleBackColor = true;
            // 
            // frmMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 769);
            this.Controls.Add(this.btnEliminarMarca);
            this.Controls.Add(this.btnNuevoMarca);
            this.Controls.Add(this.btnEditarMarca);
            this.Controls.Add(this.dgvMarcas);
            this.Name = "frmMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMarcas";
            this.Load += new System.EventHandler(this.frmMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.Button btnEliminarMarca;
        private System.Windows.Forms.Button btnNuevoMarca;
        private System.Windows.Forms.Button btnEditarMarca;
    }
}