namespace Programaderecursoshumanos
{
    partial class frmcambiodepuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcambiodepuesto));
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lblpuesto = new System.Windows.Forms.Label();
            this.cbpuestodelempleado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.rbtno = new System.Windows.Forms.RadioButton();
            this.rbtsi = new System.Windows.Forms.RadioButton();
            this.txtsueldo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btbcancelar = new System.Windows.Forms.Button();
            this.btbtabla = new System.Windows.Forms.Button();
            this.btbaceptar = new System.Windows.Forms.Button();
            this.btbaceptar2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(21, 22);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(43, 13);
            this.lblcodigo.TabIndex = 0;
            this.lblcodigo.Text = "Codigo:";
            // 
            // lblpuesto
            // 
            this.lblpuesto.AutoSize = true;
            this.lblpuesto.Location = new System.Drawing.Point(21, 55);
            this.lblpuesto.Name = "lblpuesto";
            this.lblpuesto.Size = new System.Drawing.Size(92, 13);
            this.lblpuesto.TabIndex = 2;
            this.lblpuesto.Text = "Puesto a cambiar:";
            // 
            // cbpuestodelempleado
            // 
            this.cbpuestodelempleado.FormattingEnabled = true;
            this.cbpuestodelempleado.Items.AddRange(new object[] {
            "Presidente",
            "vice-Presidente",
            "Acesor del Precidente",
            "Ascesor Financiero",
            "Programador",
            "Comtable",
            "Secretario/a",
            "Conserge",
            "Portero",
            "Seguridad",
            "Caja",
            "Preventa",
            "Analista",
            "Electricista",
            "Constructor"});
            this.cbpuestodelempleado.Location = new System.Drawing.Point(119, 52);
            this.cbpuestodelempleado.Name = "cbpuestodelempleado";
            this.cbpuestodelempleado.Size = new System.Drawing.Size(135, 21);
            this.cbpuestodelempleado.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "¿ Aumento de sueldo ?";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(70, 19);
            this.txtcodigo.MaxLength = 10;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(184, 20);
            this.txtcodigo.TabIndex = 5;
            this.txtcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigo_KeyPress);
            // 
            // rbtno
            // 
            this.rbtno.AutoSize = true;
            this.rbtno.Location = new System.Drawing.Point(323, 41);
            this.rbtno.Name = "rbtno";
            this.rbtno.Size = new System.Drawing.Size(39, 17);
            this.rbtno.TabIndex = 6;
            this.rbtno.TabStop = true;
            this.rbtno.Text = "No";
            this.rbtno.UseVisualStyleBackColor = true;
            this.rbtno.CheckedChanged += new System.EventHandler(this.rbtno_CheckedChanged);
            // 
            // rbtsi
            // 
            this.rbtsi.AutoSize = true;
            this.rbtsi.Location = new System.Drawing.Point(376, 41);
            this.rbtsi.Name = "rbtsi";
            this.rbtsi.Size = new System.Drawing.Size(34, 17);
            this.rbtsi.TabIndex = 7;
            this.rbtsi.TabStop = true;
            this.rbtsi.Text = "Si";
            this.rbtsi.UseVisualStyleBackColor = true;
            this.rbtsi.CheckedChanged += new System.EventHandler(this.rbtsi_CheckedChanged);
            // 
            // txtsueldo
            // 
            this.txtsueldo.Location = new System.Drawing.Point(298, 87);
            this.txtsueldo.MaxLength = 15;
            this.txtsueldo.Name = "txtsueldo";
            this.txtsueldo.Size = new System.Drawing.Size(112, 20);
            this.txtsueldo.TabIndex = 8;
            this.txtsueldo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtsueldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigo_KeyPress);
            this.txtsueldo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtsueldo_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nuevo sueldo:";
            // 
            // btbcancelar
            // 
            this.btbcancelar.Location = new System.Drawing.Point(6, 157);
            this.btbcancelar.Name = "btbcancelar";
            this.btbcancelar.Size = new System.Drawing.Size(75, 23);
            this.btbcancelar.TabIndex = 10;
            this.btbcancelar.Text = "Cancelar";
            this.btbcancelar.UseVisualStyleBackColor = true;
            this.btbcancelar.Click += new System.EventHandler(this.btbcancelar_Click);
            // 
            // btbtabla
            // 
            this.btbtabla.Location = new System.Drawing.Point(6, 128);
            this.btbtabla.Name = "btbtabla";
            this.btbtabla.Size = new System.Drawing.Size(89, 23);
            this.btbtabla.TabIndex = 11;
            this.btbtabla.Text = "Mostrar tabla";
            this.btbtabla.UseVisualStyleBackColor = true;
            this.btbtabla.Click += new System.EventHandler(this.btbtabla_Click);
            // 
            // btbaceptar
            // 
            this.btbaceptar.Location = new System.Drawing.Point(274, 128);
            this.btbaceptar.Name = "btbaceptar";
            this.btbaceptar.Size = new System.Drawing.Size(136, 23);
            this.btbaceptar.TabIndex = 12;
            this.btbaceptar.Text = "Aceptar con aumento";
            this.btbaceptar.UseVisualStyleBackColor = true;
            this.btbaceptar.Click += new System.EventHandler(this.btbaceptar_Click);
            // 
            // btbaceptar2
            // 
            this.btbaceptar2.Location = new System.Drawing.Point(274, 157);
            this.btbaceptar2.Name = "btbaceptar2";
            this.btbaceptar2.Size = new System.Drawing.Size(136, 23);
            this.btbaceptar2.TabIndex = 13;
            this.btbaceptar2.Text = "Aceptar sin aumento";
            this.btbaceptar2.UseVisualStyleBackColor = true;
            this.btbaceptar2.Click += new System.EventHandler(this.btbaceptar2_Click);
            // 
            // frmcambiodepuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(430, 199);
            this.Controls.Add(this.btbaceptar2);
            this.Controls.Add(this.btbaceptar);
            this.Controls.Add(this.btbtabla);
            this.Controls.Add(this.btbcancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsueldo);
            this.Controls.Add(this.rbtsi);
            this.Controls.Add(this.rbtno);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbpuestodelempleado);
            this.Controls.Add(this.lblpuesto);
            this.Controls.Add(this.lblcodigo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmcambiodepuesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambio de puesto";
            this.Load += new System.EventHandler(this.frmcambiodepuesto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lblpuesto;
        private System.Windows.Forms.ComboBox cbpuestodelempleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.RadioButton rbtno;
        private System.Windows.Forms.RadioButton rbtsi;
        private System.Windows.Forms.TextBox txtsueldo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btbcancelar;
        private System.Windows.Forms.Button btbtabla;
        private System.Windows.Forms.Button btbaceptar;
        private System.Windows.Forms.Button btbaceptar2;
    }
}