namespace Programaderecursoshumanos
{
    partial class Frmlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmlogin));
            this.btbentrar = new System.Windows.Forms.Button();
            this.nombredeusuario = new System.Windows.Forms.Label();
            this.contraseña = new System.Windows.Forms.Label();
            this.txtnombredeusuario = new System.Windows.Forms.TextBox();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btbcancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btbentrar
            // 
            this.btbentrar.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbentrar.Location = new System.Drawing.Point(272, 159);
            this.btbentrar.Name = "btbentrar";
            this.btbentrar.Size = new System.Drawing.Size(87, 23);
            this.btbentrar.TabIndex = 0;
            this.btbentrar.Text = "Acceder";
            this.btbentrar.UseVisualStyleBackColor = true;
            this.btbentrar.Click += new System.EventHandler(this.btbacceder_Click);
            // 
            // nombredeusuario
            // 
            this.nombredeusuario.AutoSize = true;
            this.nombredeusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombredeusuario.Location = new System.Drawing.Point(3, 58);
            this.nombredeusuario.Name = "nombredeusuario";
            this.nombredeusuario.Size = new System.Drawing.Size(116, 15);
            this.nombredeusuario.TabIndex = 1;
            this.nombredeusuario.Text = "Nombre de usuario:";
            this.nombredeusuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // contraseña
            // 
            this.contraseña.AutoSize = true;
            this.contraseña.BackColor = System.Drawing.Color.Cyan;
            this.contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseña.Location = new System.Drawing.Point(12, 97);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(73, 15);
            this.contraseña.TabIndex = 2;
            this.contraseña.Text = "Contraseña:";
            // 
            // txtnombredeusuario
            // 
            this.txtnombredeusuario.Location = new System.Drawing.Point(125, 57);
            this.txtnombredeusuario.MaxLength = 10;
            this.txtnombredeusuario.Name = "txtnombredeusuario";
            this.txtnombredeusuario.Size = new System.Drawing.Size(198, 20);
            this.txtnombredeusuario.TabIndex = 3;
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Location = new System.Drawing.Point(125, 96);
            this.txtcontraseña.MaxLength = 5;
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.PasswordChar = '*';
            this.txtcontraseña.Size = new System.Drawing.Size(198, 20);
            this.txtcontraseña.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(329, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btbcancelar
            // 
            this.btbcancelar.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbcancelar.Location = new System.Drawing.Point(82, 159);
            this.btbcancelar.Name = "btbcancelar";
            this.btbcancelar.Size = new System.Drawing.Size(87, 23);
            this.btbcancelar.TabIndex = 6;
            this.btbcancelar.Text = "Cancelar";
            this.btbcancelar.UseVisualStyleBackColor = true;
            this.btbcancelar.Click += new System.EventHandler(this.btbcancelar_Click);
            // 
            // Frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(430, 221);
            this.Controls.Add(this.btbcancelar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.txtnombredeusuario);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.nombredeusuario);
            this.Controls.Add(this.btbentrar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceder";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btbentrar;
        private System.Windows.Forms.Label nombredeusuario;
        private System.Windows.Forms.Label contraseña;
        private System.Windows.Forms.TextBox txtnombredeusuario;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btbcancelar;
    }
}