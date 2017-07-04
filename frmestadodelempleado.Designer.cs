namespace Programaderecursoshumanos
{
    partial class frmestadodelempleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmestadodelempleado));
            this.btbcambiar = new System.Windows.Forms.Button();
            this.btblimpiar = new System.Windows.Forms.Button();
            this.btbcancelar = new System.Windows.Forms.Button();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lblestado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtcomentario = new System.Windows.Forms.TextBox();
            this.cbestadodelempleado = new System.Windows.Forms.ComboBox();
            this.dgvestadoempleado = new System.Windows.Forms.DataGridView();
            this.btbmostrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvestadoempleado)).BeginInit();
            this.SuspendLayout();
            // 
            // btbcambiar
            // 
            this.btbcambiar.Location = new System.Drawing.Point(586, 14);
            this.btbcambiar.Name = "btbcambiar";
            this.btbcambiar.Size = new System.Drawing.Size(75, 23);
            this.btbcambiar.TabIndex = 0;
            this.btbcambiar.Text = "Cambiar";
            this.btbcambiar.UseVisualStyleBackColor = true;
            this.btbcambiar.Click += new System.EventHandler(this.btbcambiar_Click);
            // 
            // btblimpiar
            // 
            this.btblimpiar.Location = new System.Drawing.Point(586, 72);
            this.btblimpiar.Name = "btblimpiar";
            this.btblimpiar.Size = new System.Drawing.Size(75, 23);
            this.btblimpiar.TabIndex = 1;
            this.btblimpiar.Text = "Limpiar";
            this.btblimpiar.UseVisualStyleBackColor = true;
            // 
            // btbcancelar
            // 
            this.btbcancelar.Location = new System.Drawing.Point(586, 43);
            this.btbcancelar.Name = "btbcancelar";
            this.btbcancelar.Size = new System.Drawing.Size(75, 23);
            this.btbcancelar.TabIndex = 2;
            this.btbcancelar.Text = "Cancelar";
            this.btbcancelar.UseVisualStyleBackColor = true;
            this.btbcancelar.Click += new System.EventHandler(this.btbcancelar_Click);
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(29, 14);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(43, 13);
            this.lblcodigo.TabIndex = 3;
            this.lblcodigo.Text = "Codigo:";
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(20, 61);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(75, 13);
            this.lblestado.TabIndex = 4;
            this.lblestado.Text = "Añadir estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Comentario:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(78, 11);
            this.txtcodigo.MaxLength = 10;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(163, 20);
            this.txtcodigo.TabIndex = 6;
            this.txtcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigo_KeyPress);
            // 
            // txtcomentario
            // 
            this.txtcomentario.Location = new System.Drawing.Point(89, 109);
            this.txtcomentario.MaxLength = 90;
            this.txtcomentario.Name = "txtcomentario";
            this.txtcomentario.Size = new System.Drawing.Size(466, 20);
            this.txtcomentario.TabIndex = 8;
            this.txtcomentario.TextChanged += new System.EventHandler(this.txtcomentario_TextChanged);
            // 
            // cbestadodelempleado
            // 
            this.cbestadodelempleado.FormattingEnabled = true;
            this.cbestadodelempleado.Items.AddRange(new object[] {
            "Inactivo",
            "Activo",
            "Permiso"});
            this.cbestadodelempleado.Location = new System.Drawing.Point(101, 58);
            this.cbestadodelempleado.Name = "cbestadodelempleado";
            this.cbestadodelempleado.Size = new System.Drawing.Size(121, 21);
            this.cbestadodelempleado.TabIndex = 9;
            // 
            // dgvestadoempleado
            // 
            this.dgvestadoempleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvestadoempleado.Location = new System.Drawing.Point(12, 146);
            this.dgvestadoempleado.Name = "dgvestadoempleado";
            this.dgvestadoempleado.Size = new System.Drawing.Size(683, 150);
            this.dgvestadoempleado.TabIndex = 10;
            this.dgvestadoempleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvestadoempleado_CellContentClick);
            // 
            // btbmostrar
            // 
            this.btbmostrar.Location = new System.Drawing.Point(573, 107);
            this.btbmostrar.Name = "btbmostrar";
            this.btbmostrar.Size = new System.Drawing.Size(100, 23);
            this.btbmostrar.TabIndex = 11;
            this.btbmostrar.Text = "Mostrar tabla";
            this.btbmostrar.UseVisualStyleBackColor = true;
            this.btbmostrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmestadodelempleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(708, 312);
            this.Controls.Add(this.btbmostrar);
            this.Controls.Add(this.dgvestadoempleado);
            this.Controls.Add(this.cbestadodelempleado);
            this.Controls.Add(this.txtcomentario);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.btbcancelar);
            this.Controls.Add(this.btblimpiar);
            this.Controls.Add(this.btbcambiar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmestadodelempleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estado del empleado";
            this.Load += new System.EventHandler(this.frmestadodelempleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvestadoempleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btbcambiar;
        private System.Windows.Forms.Button btblimpiar;
        private System.Windows.Forms.Button btbcancelar;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtcomentario;
        private System.Windows.Forms.ComboBox cbestadodelempleado;
        private System.Windows.Forms.DataGridView dgvestadoempleado;
        private System.Windows.Forms.Button btbmostrar;
    }
}