namespace Programaderecursoshumanos
{
    partial class frmlicenciamedica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlicenciamedica));
            this.btbaceptar = new System.Windows.Forms.Button();
            this.btbvolver = new System.Windows.Forms.Button();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtdias = new System.Windows.Forms.TextBox();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lblestado = new System.Windows.Forms.Label();
            this.lbldias = new System.Windows.Forms.Label();
            this.lblcomentario = new System.Windows.Forms.Label();
            this.txtcomentario = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtlicencia = new System.Windows.Forms.RadioButton();
            this.rbtactivo = new System.Windows.Forms.RadioButton();
            this.lbllistado = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btbaceptar
            // 
            this.btbaceptar.Location = new System.Drawing.Point(393, 138);
            this.btbaceptar.Name = "btbaceptar";
            this.btbaceptar.Size = new System.Drawing.Size(75, 23);
            this.btbaceptar.TabIndex = 0;
            this.btbaceptar.Text = "Aceptar";
            this.btbaceptar.UseVisualStyleBackColor = true;
            this.btbaceptar.Click += new System.EventHandler(this.btbaceptar_Click);
            // 
            // btbvolver
            // 
            this.btbvolver.Location = new System.Drawing.Point(12, 138);
            this.btbvolver.Name = "btbvolver";
            this.btbvolver.Size = new System.Drawing.Size(75, 23);
            this.btbvolver.TabIndex = 1;
            this.btbvolver.Text = "Volver";
            this.btbvolver.UseVisualStyleBackColor = true;
            this.btbvolver.Click += new System.EventHandler(this.btbvolver_Click);
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(99, 22);
            this.txtcodigo.MaxLength = 10;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(134, 20);
            this.txtcodigo.TabIndex = 2;
            this.txtcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigo_KeyPress);
            // 
            // txtdias
            // 
            this.txtdias.Location = new System.Drawing.Point(104, 53);
            this.txtdias.MaxLength = 10;
            this.txtdias.Name = "txtdias";
            this.txtdias.Size = new System.Drawing.Size(129, 20);
            this.txtdias.TabIndex = 4;
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(13, 25);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(80, 13);
            this.lblcodigo.TabIndex = 5;
            this.lblcodigo.Text = "Ingrese codigo:";
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(293, 22);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(109, 13);
            this.lblestado.TabIndex = 6;
            this.lblestado.Text = "Estado del empleado:";
            // 
            // lbldias
            // 
            this.lbldias.AutoSize = true;
            this.lbldias.Location = new System.Drawing.Point(9, 53);
            this.lbldias.Name = "lbldias";
            this.lbldias.Size = new System.Drawing.Size(85, 13);
            this.lbldias.TabIndex = 7;
            this.lbldias.Text = "Dias de licencia:";
            // 
            // lblcomentario
            // 
            this.lblcomentario.AutoSize = true;
            this.lblcomentario.Location = new System.Drawing.Point(13, 105);
            this.lblcomentario.Name = "lblcomentario";
            this.lblcomentario.Size = new System.Drawing.Size(63, 13);
            this.lblcomentario.TabIndex = 8;
            this.lblcomentario.Text = "Comentario:";
            // 
            // txtcomentario
            // 
            this.txtcomentario.Location = new System.Drawing.Point(94, 102);
            this.txtcomentario.MaxLength = 90;
            this.txtcomentario.Name = "txtcomentario";
            this.txtcomentario.Size = new System.Drawing.Size(364, 20);
            this.txtcomentario.TabIndex = 9;
            this.txtcomentario.TextChanged += new System.EventHandler(this.txtcomentario_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbtlicencia);
            this.groupBox1.Controls.Add(this.rbtactivo);
            this.groupBox1.Location = new System.Drawing.Point(265, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 35);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // rbtlicencia
            // 
            this.rbtlicencia.AutoSize = true;
            this.rbtlicencia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtlicencia.Location = new System.Drawing.Point(84, 9);
            this.rbtlicencia.Name = "rbtlicencia";
            this.rbtlicencia.Size = new System.Drawing.Size(97, 17);
            this.rbtlicencia.TabIndex = 12;
            this.rbtlicencia.TabStop = true;
            this.rbtlicencia.Text = "De Licencia M.";
            this.rbtlicencia.UseVisualStyleBackColor = true;
            // 
            // rbtactivo
            // 
            this.rbtactivo.AutoSize = true;
            this.rbtactivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtactivo.Location = new System.Drawing.Point(6, 9);
            this.rbtactivo.Name = "rbtactivo";
            this.rbtactivo.Size = new System.Drawing.Size(55, 17);
            this.rbtactivo.TabIndex = 11;
            this.rbtactivo.TabStop = true;
            this.rbtactivo.Text = "Activo";
            this.rbtactivo.UseVisualStyleBackColor = true;
            // 
            // lbllistado
            // 
            this.lbllistado.Location = new System.Drawing.Point(175, 138);
            this.lbllistado.Name = "lbllistado";
            this.lbllistado.Size = new System.Drawing.Size(119, 23);
            this.lbllistado.TabIndex = 11;
            this.lbllistado.Text = "Listado del personal";
            this.lbllistado.UseVisualStyleBackColor = true;
            this.lbllistado.Click += new System.EventHandler(this.lbllistado_Click);
            // 
            // frmlicenciamedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(479, 177);
            this.Controls.Add(this.lbllistado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtcomentario);
            this.Controls.Add(this.lblcomentario);
            this.Controls.Add(this.lbldias);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.txtdias);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.btbvolver);
            this.Controls.Add(this.btbaceptar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmlicenciamedica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados de Licencia Medica";
            this.Load += new System.EventHandler(this.frmlicenciamedica_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btbaceptar;
        private System.Windows.Forms.Button btbvolver;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtdias;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.Label lbldias;
        private System.Windows.Forms.Label lblcomentario;
        private System.Windows.Forms.TextBox txtcomentario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtactivo;
        private System.Windows.Forms.RadioButton rbtlicencia;
        private System.Windows.Forms.Button lbllistado;
    }
}