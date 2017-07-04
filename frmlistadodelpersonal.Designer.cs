namespace Programaderecursoshumanos
{
    partial class frmlistadodelpersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlistadodelpersonal));
            this.btbcerrar = new System.Windows.Forms.Button();
            this.dgvlistado = new System.Windows.Forms.DataGridView();
            this.btbrefrescar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistado)).BeginInit();
            this.SuspendLayout();
            // 
            // btbcerrar
            // 
            this.btbcerrar.Location = new System.Drawing.Point(819, 244);
            this.btbcerrar.Name = "btbcerrar";
            this.btbcerrar.Size = new System.Drawing.Size(75, 23);
            this.btbcerrar.TabIndex = 1;
            this.btbcerrar.Text = "Cerrar";
            this.btbcerrar.UseVisualStyleBackColor = true;
            this.btbcerrar.Click += new System.EventHandler(this.btbcerrar_Click);
            // 
            // dgvlistado
            // 
            this.dgvlistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlistado.Location = new System.Drawing.Point(2, 12);
            this.dgvlistado.Name = "dgvlistado";
            this.dgvlistado.Size = new System.Drawing.Size(907, 221);
            this.dgvlistado.TabIndex = 2;
            this.dgvlistado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlistado_CellContentClick);
            // 
            // btbrefrescar
            // 
            this.btbrefrescar.Location = new System.Drawing.Point(23, 243);
            this.btbrefrescar.Name = "btbrefrescar";
            this.btbrefrescar.Size = new System.Drawing.Size(75, 23);
            this.btbrefrescar.TabIndex = 3;
            this.btbrefrescar.Text = "Refrescar";
            this.btbrefrescar.UseVisualStyleBackColor = true;
            this.btbrefrescar.Click += new System.EventHandler(this.btbrefrescar_Click);
            // 
            // frmlistadodelpersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(906, 279);
            this.Controls.Add(this.btbrefrescar);
            this.Controls.Add(this.dgvlistado);
            this.Controls.Add(this.btbcerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmlistadodelpersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado del personal";
            this.Load += new System.EventHandler(this.frmlistadodelpersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btbcerrar;
        private System.Windows.Forms.DataGridView dgvlistado;
        private System.Windows.Forms.Button btbrefrescar;
    }
}