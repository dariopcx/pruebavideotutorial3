namespace Programaderecursoshumanos
{
    partial class frmvacaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmvacaciones));
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lblestado = new System.Windows.Forms.Label();
            this.lbldias = new System.Windows.Forms.Label();
            this.btbcancelar = new System.Windows.Forms.Button();
            this.btbaceptar = new System.Windows.Forms.Button();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtdias = new System.Windows.Forms.TextBox();
            this.lblcomentario = new System.Windows.Forms.Label();
            this.txtcomentario = new System.Windows.Forms.TextBox();
            this.btbmostrartabla = new System.Windows.Forms.Button();
            this.dgvvacaciones = new System.Windows.Forms.DataGridView();
            this.cbestadodelempleado = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvacaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(23, 24);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(43, 13);
            this.lblcodigo.TabIndex = 0;
            this.lblcodigo.Text = "Codigo:";
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(23, 51);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(109, 13);
            this.lblestado.TabIndex = 1;
            this.lblestado.Text = "Estado del empleado:";
            // 
            // lbldias
            // 
            this.lbldias.AutoSize = true;
            this.lbldias.Location = new System.Drawing.Point(23, 80);
            this.lbldias.Name = "lbldias";
            this.lbldias.Size = new System.Drawing.Size(104, 13);
            this.lbldias.TabIndex = 2;
            this.lbldias.Text = "Dias de vacaciones:";
            // 
            // btbcancelar
            // 
            this.btbcancelar.Location = new System.Drawing.Point(327, 14);
            this.btbcancelar.Name = "btbcancelar";
            this.btbcancelar.Size = new System.Drawing.Size(75, 23);
            this.btbcancelar.TabIndex = 3;
            this.btbcancelar.Text = "Cancelar";
            this.btbcancelar.UseVisualStyleBackColor = true;
            this.btbcancelar.Click += new System.EventHandler(this.btbcancelar_Click);
            // 
            // btbaceptar
            // 
            this.btbaceptar.Location = new System.Drawing.Point(408, 14);
            this.btbaceptar.Name = "btbaceptar";
            this.btbaceptar.Size = new System.Drawing.Size(75, 23);
            this.btbaceptar.TabIndex = 4;
            this.btbaceptar.Text = "Aceptar";
            this.btbaceptar.UseVisualStyleBackColor = true;
            this.btbaceptar.Click += new System.EventHandler(this.btbaceptar_Click);
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(72, 21);
            this.txtcodigo.MaxLength = 10;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 20);
            this.txtcodigo.TabIndex = 6;
            this.txtcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigo_KeyPress);
            // 
            // txtdias
            // 
            this.txtdias.Location = new System.Drawing.Point(138, 77);
            this.txtdias.MaxLength = 2;
            this.txtdias.Name = "txtdias";
            this.txtdias.Size = new System.Drawing.Size(119, 20);
            this.txtdias.TabIndex = 8;
            this.txtdias.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblcomentario
            // 
            this.lblcomentario.AutoSize = true;
            this.lblcomentario.Location = new System.Drawing.Point(23, 111);
            this.lblcomentario.Name = "lblcomentario";
            this.lblcomentario.Size = new System.Drawing.Size(63, 13);
            this.lblcomentario.TabIndex = 9;
            this.lblcomentario.Text = "Comentario:";
            // 
            // txtcomentario
            // 
            this.txtcomentario.Location = new System.Drawing.Point(92, 108);
            this.txtcomentario.MaxLength = 90;
            this.txtcomentario.Name = "txtcomentario";
            this.txtcomentario.Size = new System.Drawing.Size(402, 20);
            this.txtcomentario.TabIndex = 10;
            // 
            // btbmostrartabla
            // 
            this.btbmostrartabla.Location = new System.Drawing.Point(355, 70);
            this.btbmostrartabla.Name = "btbmostrartabla";
            this.btbmostrartabla.Size = new System.Drawing.Size(94, 23);
            this.btbmostrartabla.TabIndex = 11;
            this.btbmostrartabla.Text = "Mostrar tabla";
            this.btbmostrartabla.UseVisualStyleBackColor = true;
            this.btbmostrartabla.Click += new System.EventHandler(this.btbmostrartabla_Click);
            // 
            // dgvvacaciones
            // 
            this.dgvvacaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvvacaciones.Location = new System.Drawing.Point(12, 148);
            this.dgvvacaciones.Name = "dgvvacaciones";
            this.dgvvacaciones.Size = new System.Drawing.Size(485, 128);
            this.dgvvacaciones.TabIndex = 12;
            this.dgvvacaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvvacaciones_CellContentClick);
            // 
            // cbestadodelempleado
            // 
            this.cbestadodelempleado.FormattingEnabled = true;
            this.cbestadodelempleado.Items.AddRange(new object[] {
            "Activo",
            "De vacaciones",
            ""});
            this.cbestadodelempleado.Location = new System.Drawing.Point(136, 47);
            this.cbestadodelempleado.Name = "cbestadodelempleado";
            this.cbestadodelempleado.Size = new System.Drawing.Size(121, 21);
            this.cbestadodelempleado.TabIndex = 13;
            // 
            // frmvacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(504, 327);
            this.Controls.Add(this.cbestadodelempleado);
            this.Controls.Add(this.dgvvacaciones);
            this.Controls.Add(this.btbmostrartabla);
            this.Controls.Add(this.txtcomentario);
            this.Controls.Add(this.lblcomentario);
            this.Controls.Add(this.txtdias);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.btbaceptar);
            this.Controls.Add(this.btbcancelar);
            this.Controls.Add(this.lbldias);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.lblcodigo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmvacaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar vacaciones";
            this.Load += new System.EventHandler(this.frmvacaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvvacaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.Label lbldias;
        private System.Windows.Forms.Button btbcancelar;
        private System.Windows.Forms.Button btbaceptar;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtdias;
        private System.Windows.Forms.Label lblcomentario;
        private System.Windows.Forms.TextBox txtcomentario;
        private System.Windows.Forms.Button btbmostrartabla;
        private System.Windows.Forms.DataGridView dgvvacaciones;
        private System.Windows.Forms.ComboBox cbestadodelempleado;
    }
}