namespace Programaderecursoshumanos
{
    partial class frmcalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcalculadora));
            this.lblvalor1 = new System.Windows.Forms.Label();
            this.lblvalor2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.txtvalor1 = new System.Windows.Forms.TextBox();
            this.txtvalor2 = new System.Windows.Forms.TextBox();
            this.txtor = new System.Windows.Forms.TextBox();
            this.btbsuma = new System.Windows.Forms.Button();
            this.btbresta = new System.Windows.Forms.Button();
            this.btbdivision = new System.Windows.Forms.Button();
            this.btbmultiplicacion = new System.Windows.Forms.Button();
            this.btbcerrar = new System.Windows.Forms.Button();
            this.btblimpiar = new System.Windows.Forms.Button();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblvalor1
            // 
            this.lblvalor1.AutoSize = true;
            this.lblvalor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalor1.Location = new System.Drawing.Point(37, 19);
            this.lblvalor1.Name = "lblvalor1";
            this.lblvalor1.Size = new System.Drawing.Size(47, 13);
            this.lblvalor1.TabIndex = 0;
            this.lblvalor1.Text = "Valor 1";
            // 
            // lblvalor2
            // 
            this.lblvalor2.AutoSize = true;
            this.lblvalor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalor2.Location = new System.Drawing.Point(37, 50);
            this.lblvalor2.Name = "lblvalor2";
            this.lblvalor2.Size = new System.Drawing.Size(47, 13);
            this.lblvalor2.TabIndex = 1;
            this.lblvalor2.Text = "Valor 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Operacion Realizada:";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(37, 138);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(68, 13);
            this.lblresultado.TabIndex = 6;
            this.lblresultado.Text = "Resultado:";
            // 
            // txtvalor1
            // 
            this.txtvalor1.Location = new System.Drawing.Point(110, 19);
            this.txtvalor1.MaxLength = 15;
            this.txtvalor1.Name = "txtvalor1";
            this.txtvalor1.Size = new System.Drawing.Size(151, 20);
            this.txtvalor1.TabIndex = 2;
            this.txtvalor1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalor1_KeyPress);
            // 
            // txtvalor2
            // 
            this.txtvalor2.Location = new System.Drawing.Point(110, 50);
            this.txtvalor2.MaxLength = 15;
            this.txtvalor2.Name = "txtvalor2";
            this.txtvalor2.Size = new System.Drawing.Size(151, 20);
            this.txtvalor2.TabIndex = 3;
            this.txtvalor2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalor1_KeyPress);
            // 
            // txtor
            // 
            this.txtor.BackColor = System.Drawing.Color.White;
            this.txtor.Enabled = false;
            this.txtor.Location = new System.Drawing.Point(161, 86);
            this.txtor.Name = "txtor";
            this.txtor.Size = new System.Drawing.Size(100, 20);
            this.txtor.TabIndex = 5;
            // 
            // btbsuma
            // 
            this.btbsuma.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbsuma.Location = new System.Drawing.Point(68, 187);
            this.btbsuma.Name = "btbsuma";
            this.btbsuma.Size = new System.Drawing.Size(75, 23);
            this.btbsuma.TabIndex = 8;
            this.btbsuma.Text = "Suma";
            this.btbsuma.UseVisualStyleBackColor = true;
            this.btbsuma.Click += new System.EventHandler(this.btbsuma_Click);
            // 
            // btbresta
            // 
            this.btbresta.Location = new System.Drawing.Point(149, 187);
            this.btbresta.Name = "btbresta";
            this.btbresta.Size = new System.Drawing.Size(75, 23);
            this.btbresta.TabIndex = 9;
            this.btbresta.Text = "Resta";
            this.btbresta.UseVisualStyleBackColor = true;
            this.btbresta.Click += new System.EventHandler(this.btbresta_Click);
            // 
            // btbdivision
            // 
            this.btbdivision.Location = new System.Drawing.Point(230, 187);
            this.btbdivision.Name = "btbdivision";
            this.btbdivision.Size = new System.Drawing.Size(75, 23);
            this.btbdivision.TabIndex = 10;
            this.btbdivision.Text = "Division";
            this.btbdivision.UseVisualStyleBackColor = true;
            this.btbdivision.Click += new System.EventHandler(this.btbdivision_Click);
            // 
            // btbmultiplicacion
            // 
            this.btbmultiplicacion.Location = new System.Drawing.Point(137, 216);
            this.btbmultiplicacion.Name = "btbmultiplicacion";
            this.btbmultiplicacion.Size = new System.Drawing.Size(94, 23);
            this.btbmultiplicacion.TabIndex = 11;
            this.btbmultiplicacion.Text = "Multiplicacion";
            this.btbmultiplicacion.UseVisualStyleBackColor = true;
            this.btbmultiplicacion.Click += new System.EventHandler(this.btbmultiplicacion_Click);
            // 
            // btbcerrar
            // 
            this.btbcerrar.Location = new System.Drawing.Point(46, 255);
            this.btbcerrar.Name = "btbcerrar";
            this.btbcerrar.Size = new System.Drawing.Size(75, 23);
            this.btbcerrar.TabIndex = 13;
            this.btbcerrar.Text = "Cerrar";
            this.btbcerrar.UseVisualStyleBackColor = true;
            this.btbcerrar.Click += new System.EventHandler(this.btbcerrar_Click);
            // 
            // btblimpiar
            // 
            this.btblimpiar.Location = new System.Drawing.Point(256, 255);
            this.btblimpiar.Name = "btblimpiar";
            this.btblimpiar.Size = new System.Drawing.Size(75, 23);
            this.btblimpiar.TabIndex = 12;
            this.btblimpiar.Text = "Limpiar";
            this.btblimpiar.UseVisualStyleBackColor = true;
            this.btblimpiar.Click += new System.EventHandler(this.btblimpiar_Click);
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(117, 131);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(144, 20);
            this.txtresultado.TabIndex = 7;
            // 
            // frmcalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(355, 289);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.btblimpiar);
            this.Controls.Add(this.btbcerrar);
            this.Controls.Add(this.btbmultiplicacion);
            this.Controls.Add(this.btbdivision);
            this.Controls.Add(this.btbresta);
            this.Controls.Add(this.btbsuma);
            this.Controls.Add(this.txtor);
            this.Controls.Add(this.txtvalor2);
            this.Controls.Add(this.txtvalor1);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblvalor2);
            this.Controls.Add(this.lblvalor1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmcalculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.frmcalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblvalor1;
        private System.Windows.Forms.Label lblvalor2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.TextBox txtvalor1;
        private System.Windows.Forms.TextBox txtvalor2;
        private System.Windows.Forms.TextBox txtor;
        private System.Windows.Forms.Button btbsuma;
        private System.Windows.Forms.Button btbresta;
        private System.Windows.Forms.Button btbdivision;
        private System.Windows.Forms.Button btbmultiplicacion;
        private System.Windows.Forms.Button btbcerrar;
        private System.Windows.Forms.Button btblimpiar;
        private System.Windows.Forms.TextBox txtresultado;
    }
}