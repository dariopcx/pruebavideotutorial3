namespace Programaderecursoshumanos
{
    partial class Frmregistrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmregistrar));
            this.btbconfirmar = new System.Windows.Forms.Button();
            this.txtconfirmarcontraseña = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombredeusuario = new System.Windows.Forms.Label();
            this.txtnuevousuario = new System.Windows.Forms.TextBox();
            this.txtnuevacontraseña = new System.Windows.Forms.TextBox();
            this.txtnuevacontraseñaconfirmar = new System.Windows.Forms.TextBox();
            this.btbcancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btbconfirmar
            // 
            this.btbconfirmar.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbconfirmar.Location = new System.Drawing.Point(286, 195);
            this.btbconfirmar.Name = "btbconfirmar";
            this.btbconfirmar.Size = new System.Drawing.Size(75, 23);
            this.btbconfirmar.TabIndex = 0;
            this.btbconfirmar.Text = "Confirmar";
            this.btbconfirmar.UseVisualStyleBackColor = true;
            this.btbconfirmar.Click += new System.EventHandler(this.btbconfirmar_Click);
            // 
            // txtconfirmarcontraseña
            // 
            this.txtconfirmarcontraseña.AutoSize = true;
            this.txtconfirmarcontraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconfirmarcontraseña.Location = new System.Drawing.Point(57, 148);
            this.txtconfirmarcontraseña.Name = "txtconfirmarcontraseña";
            this.txtconfirmarcontraseña.Size = new System.Drawing.Size(131, 13);
            this.txtconfirmarcontraseña.TabIndex = 1;
            this.txtconfirmarcontraseña.Text = "Confirmar contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña:";
            // 
            // txtnombredeusuario
            // 
            this.txtnombredeusuario.AutoSize = true;
            this.txtnombredeusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombredeusuario.Location = new System.Drawing.Point(12, 47);
            this.txtnombredeusuario.Name = "txtnombredeusuario";
            this.txtnombredeusuario.Size = new System.Drawing.Size(176, 15);
            this.txtnombredeusuario.TabIndex = 3;
            this.txtnombredeusuario.Text = "Nombre de nuevo usuario:";
            // 
            // txtnuevousuario
            // 
            this.txtnuevousuario.Location = new System.Drawing.Point(194, 47);
            this.txtnuevousuario.MaxLength = 15;
            this.txtnuevousuario.Name = "txtnuevousuario";
            this.txtnuevousuario.Size = new System.Drawing.Size(167, 20);
            this.txtnuevousuario.TabIndex = 4;
            // 
            // txtnuevacontraseña
            // 
            this.txtnuevacontraseña.Location = new System.Drawing.Point(194, 96);
            this.txtnuevacontraseña.MaxLength = 5;
            this.txtnuevacontraseña.Name = "txtnuevacontraseña";
            this.txtnuevacontraseña.PasswordChar = '*';
            this.txtnuevacontraseña.Size = new System.Drawing.Size(167, 20);
            this.txtnuevacontraseña.TabIndex = 5;
            // 
            // txtnuevacontraseñaconfirmar
            // 
            this.txtnuevacontraseñaconfirmar.Location = new System.Drawing.Point(194, 145);
            this.txtnuevacontraseñaconfirmar.MaxLength = 5;
            this.txtnuevacontraseñaconfirmar.Name = "txtnuevacontraseñaconfirmar";
            this.txtnuevacontraseñaconfirmar.PasswordChar = '*';
            this.txtnuevacontraseñaconfirmar.Size = new System.Drawing.Size(167, 20);
            this.txtnuevacontraseñaconfirmar.TabIndex = 6;
            // 
            // btbcancelar
            // 
            this.btbcancelar.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbcancelar.Location = new System.Drawing.Point(42, 195);
            this.btbcancelar.Name = "btbcancelar";
            this.btbcancelar.Size = new System.Drawing.Size(75, 23);
            this.btbcancelar.TabIndex = 7;
            this.btbcancelar.Text = "Cancelar";
            this.btbcancelar.UseVisualStyleBackColor = true;
            this.btbcancelar.Click += new System.EventHandler(this.btbcancelar_Click);
            // 
            // Frmregistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(404, 262);
            this.Controls.Add(this.btbcancelar);
            this.Controls.Add(this.txtnuevacontraseñaconfirmar);
            this.Controls.Add(this.txtnuevacontraseña);
            this.Controls.Add(this.txtnuevousuario);
            this.Controls.Add(this.txtnombredeusuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtconfirmarcontraseña);
            this.Controls.Add(this.btbconfirmar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmregistrar";
            this.Text = "Nuevo usuario";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btbconfirmar;
        private System.Windows.Forms.Label txtconfirmarcontraseña;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtnombredeusuario;
        private System.Windows.Forms.TextBox txtnuevousuario;
        private System.Windows.Forms.TextBox txtnuevacontraseña;
        private System.Windows.Forms.TextBox txtnuevacontraseñaconfirmar;
        private System.Windows.Forms.Button btbcancelar;
    }
}