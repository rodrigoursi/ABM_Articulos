namespace App
{
    partial class frmFichaCategoria
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
            this.lblDescripcionCategoria = new System.Windows.Forms.Label();
            this.txbDescripcionCategoria = new System.Windows.Forms.TextBox();
            this.btnGuardaCateogiroa = new System.Windows.Forms.Button();
            this.btnSalirEditorCategoria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDescripcionCategoria
            // 
            this.lblDescripcionCategoria.AutoSize = true;
            this.lblDescripcionCategoria.Location = new System.Drawing.Point(33, 37);
            this.lblDescripcionCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcionCategoria.Name = "lblDescripcionCategoria";
            this.lblDescripcionCategoria.Size = new System.Drawing.Size(62, 16);
            this.lblDescripcionCategoria.TabIndex = 0;
            this.lblDescripcionCategoria.Text = "Nombre: ";
            // 
            // txbDescripcionCategoria
            // 
            this.txbDescripcionCategoria.Location = new System.Drawing.Point(109, 36);
            this.txbDescripcionCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.txbDescripcionCategoria.Name = "txbDescripcionCategoria";
            this.txbDescripcionCategoria.Size = new System.Drawing.Size(365, 22);
            this.txbDescripcionCategoria.TabIndex = 0;
            // 
            // btnGuardaCateogiroa
            // 
            this.btnGuardaCateogiroa.Location = new System.Drawing.Point(37, 123);
            this.btnGuardaCateogiroa.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardaCateogiroa.Name = "btnGuardaCateogiroa";
            this.btnGuardaCateogiroa.Size = new System.Drawing.Size(145, 28);
            this.btnGuardaCateogiroa.TabIndex = 1;
            this.btnGuardaCateogiroa.Text = "Guardar";
            this.btnGuardaCateogiroa.UseVisualStyleBackColor = true;
            this.btnGuardaCateogiroa.Click += new System.EventHandler(this.btnGuardaCateogiroa_Click);
            // 
            // btnSalirEditorCategoria
            // 
            this.btnSalirEditorCategoria.Location = new System.Drawing.Point(331, 123);
            this.btnSalirEditorCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalirEditorCategoria.Name = "btnSalirEditorCategoria";
            this.btnSalirEditorCategoria.Size = new System.Drawing.Size(145, 28);
            this.btnSalirEditorCategoria.TabIndex = 2;
            this.btnSalirEditorCategoria.Text = "Volver";
            this.btnSalirEditorCategoria.UseVisualStyleBackColor = true;
            this.btnSalirEditorCategoria.Click += new System.EventHandler(this.btnSalirEditorCategoria_Click);
            // 
            // frmFichaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 174);
            this.Controls.Add(this.btnSalirEditorCategoria);
            this.Controls.Add(this.btnGuardaCateogiroa);
            this.Controls.Add(this.txbDescripcionCategoria);
            this.Controls.Add(this.lblDescripcionCategoria);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmFichaCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFichaCategoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescripcionCategoria;
        private System.Windows.Forms.TextBox txbDescripcionCategoria;
        private System.Windows.Forms.Button btnGuardaCateogiroa;
        private System.Windows.Forms.Button btnSalirEditorCategoria;
    }
}