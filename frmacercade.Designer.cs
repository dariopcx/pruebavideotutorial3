namespace Programaderecursoshumanos
{
    partial class frmacercade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmacercade));
            this.btbdetalles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblcreador = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btbocultar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btbdetalles
            // 
            this.btbdetalles.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbdetalles.Location = new System.Drawing.Point(334, 30);
            this.btbdetalles.Name = "btbdetalles";
            this.btbdetalles.Size = new System.Drawing.Size(75, 23);
            this.btbdetalles.TabIndex = 0;
            this.btbdetalles.Text = "Detalles";
            this.btbdetalles.UseVisualStyleBackColor = true;
            this.btbdetalles.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Programa de Administracion de Recursos Humanos";
            // 
            // lblcreador
            // 
            this.lblcreador.AutoSize = true;
            this.lblcreador.Location = new System.Drawing.Point(113, 88);
            this.lblcreador.Name = "lblcreador";
            this.lblcreador.Size = new System.Drawing.Size(172, 13);
            this.lblcreador.TabIndex = 2;
            this.lblcreador.Text = "Creado por Dario Santana Paredes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Version 1.1";
            // 
            // btbocultar
            // 
            this.btbocultar.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbocultar.Location = new System.Drawing.Point(334, 174);
            this.btbocultar.Name = "btbocultar";
            this.btbocultar.Size = new System.Drawing.Size(75, 23);
            this.btbocultar.TabIndex = 4;
            this.btbocultar.Text = "Ocultar";
            this.btbocultar.UseVisualStyleBackColor = true;
            this.btbocultar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Todos los derechos reservados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha de creacion: 20-10-2016";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Programa para la gestion del personal de tu empresa";
            // 
            // frmacercade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(438, 224);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btbocultar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblcreador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btbdetalles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmacercade";
            this.Text = "Acerca de...";
            this.Load += new System.EventHandler(this.frmacercade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btbdetalles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblcreador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btbocultar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}