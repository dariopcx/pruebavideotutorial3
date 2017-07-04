namespace Programaderecursoshumanos
{
    partial class frmayudaenlinea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmayudaenlinea));
            this.lblmensaje = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btbir = new System.Windows.Forms.Button();
            this.btbregresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Location = new System.Drawing.Point(21, 16);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(338, 26);
            this.lblmensaje.TabIndex = 0;
            this.lblmensaje.Text = "Para obtener ayuda en linea, conocer nuevas versiones del programa \r\ny obtener ma" +
    "s detalles, visite nuestra pagina web:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(66, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "https://www.DarioSPSoftware.com/ayudaenlinea\r\n";
            // 
            // btbir
            // 
            this.btbir.Location = new System.Drawing.Point(290, 113);
            this.btbir.Name = "btbir";
            this.btbir.Size = new System.Drawing.Size(100, 23);
            this.btbir.TabIndex = 2;
            this.btbir.Text = "Ir al navegador";
            this.btbir.UseVisualStyleBackColor = true;
            this.btbir.Click += new System.EventHandler(this.btbir_Click);
            // 
            // btbregresar
            // 
            this.btbregresar.Location = new System.Drawing.Point(12, 113);
            this.btbregresar.Name = "btbregresar";
            this.btbregresar.Size = new System.Drawing.Size(75, 23);
            this.btbregresar.TabIndex = 3;
            this.btbregresar.Text = "Regresar";
            this.btbregresar.UseVisualStyleBackColor = true;
            this.btbregresar.Click += new System.EventHandler(this.btbregresar_Click);
            // 
            // frmayudaenlinea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(413, 155);
            this.Controls.Add(this.btbregresar);
            this.Controls.Add(this.btbir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblmensaje);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmayudaenlinea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayuda en linea";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btbir;
        private System.Windows.Forms.Button btbregresar;


    }
}