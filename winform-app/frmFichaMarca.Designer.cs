namespace App
{
    partial class frmFichaMarca
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
            this.btnSalirEditorMarca = new System.Windows.Forms.Button();
            this.btnGuardaMarca = new System.Windows.Forms.Button();
            this.txbDescripcionMarca = new System.Windows.Forms.TextBox();
            this.lblDescripcionMarca = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalirEditorMarca
            // 
            this.btnSalirEditorMarca.Location = new System.Drawing.Point(333, 117);
            this.btnSalirEditorMarca.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalirEditorMarca.Name = "btnSalirEditorMarca";
            this.btnSalirEditorMarca.Size = new System.Drawing.Size(145, 28);
            this.btnSalirEditorMarca.TabIndex = 2;
            this.btnSalirEditorMarca.Text = "Volver";
            this.btnSalirEditorMarca.UseVisualStyleBackColor = true;
            this.btnSalirEditorMarca.Click += new System.EventHandler(this.btnSalirEditorMarca_Click_1);
            // 
            // btnGuardaMarca
            // 
            this.btnGuardaMarca.Location = new System.Drawing.Point(39, 117);
            this.btnGuardaMarca.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardaMarca.Name = "btnGuardaMarca";
            this.btnGuardaMarca.Size = new System.Drawing.Size(145, 28);
            this.btnGuardaMarca.TabIndex = 1;
            this.btnGuardaMarca.Text = "Guardar";
            this.btnGuardaMarca.UseVisualStyleBackColor = true;
            this.btnGuardaMarca.Click += new System.EventHandler(this.btnGuardaMarca_Click);
            // 
            // txbDescripcionMarca
            // 
            this.txbDescripcionMarca.Location = new System.Drawing.Point(111, 30);
            this.txbDescripcionMarca.Margin = new System.Windows.Forms.Padding(4);
            this.txbDescripcionMarca.Name = "txbDescripcionMarca";
            this.txbDescripcionMarca.Size = new System.Drawing.Size(365, 22);
            this.txbDescripcionMarca.TabIndex = 0;
            // 
            // lblDescripcionMarca
            // 
            this.lblDescripcionMarca.AutoSize = true;
            this.lblDescripcionMarca.Location = new System.Drawing.Point(36, 30);
            this.lblDescripcionMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcionMarca.Name = "lblDescripcionMarca";
            this.lblDescripcionMarca.Size = new System.Drawing.Size(62, 16);
            this.lblDescripcionMarca.TabIndex = 4;
            this.lblDescripcionMarca.Text = "Nombre: ";
            // 
            // frmFichaMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 174);
            this.Controls.Add(this.btnSalirEditorMarca);
            this.Controls.Add(this.btnGuardaMarca);
            this.Controls.Add(this.txbDescripcionMarca);
            this.Controls.Add(this.lblDescripcionMarca);
            this.Name = "frmFichaMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFichaMarca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalirEditorMarca;
        private System.Windows.Forms.Button btnGuardaMarca;
        private System.Windows.Forms.TextBox txbDescripcionMarca;
        private System.Windows.Forms.Label lblDescripcionMarca;
    }
}