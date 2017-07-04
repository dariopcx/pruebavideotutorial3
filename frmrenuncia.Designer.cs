namespace Programaderecursoshumanos
{
    partial class frmrenuncia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmrenuncia));
            this.lblcodigo = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lblestado = new System.Windows.Forms.Label();
            this.cbestadodelempleado = new System.Windows.Forms.ComboBox();
            this.clxmotivo = new System.Windows.Forms.CheckedListBox();
            this.lblmotivo = new System.Windows.Forms.Label();
            this.dgvrenuncia = new System.Windows.Forms.DataGridView();
            this.btbaceptar = new System.Windows.Forms.Button();
            this.btbcancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrenuncia)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(12, 15);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(43, 13);
            this.lblcodigo.TabIndex = 0;
            this.lblcodigo.Text = "Codigo:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(65, 12);
            this.txtcodigo.MaxLength = 10;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 20);
            this.txtcodigo.TabIndex = 1;
            this.txtcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigo_KeyPress);
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(12, 41);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(109, 13);
            this.lblestado.TabIndex = 2;
            this.lblestado.Text = "Estado del empleado:";
            // 
            // cbestadodelempleado
            // 
            this.cbestadodelempleado.FormattingEnabled = true;
            this.cbestadodelempleado.Items.AddRange(new object[] {
            "Activo",
            "Renuncia Formal"});
            this.cbestadodelempleado.Location = new System.Drawing.Point(127, 38);
            this.cbestadodelempleado.Name = "cbestadodelempleado";
            this.cbestadodelempleado.Size = new System.Drawing.Size(121, 21);
            this.cbestadodelempleado.TabIndex = 3;
            // 
            // clxmotivo
            // 
            this.clxmotivo.FormattingEnabled = true;
            this.clxmotivo.Items.AddRange(new object[] {
            "Estoy cansado de trabajar aqui",
            "Estoy incorforme con el pago",
            "Estoy incorforme con el puesto",
            "No era lo que esperaba del puesto",
            "Consegui un mejor empleo",
            "Me voy a mudar a otro lugar ",
            "No especificado"});
            this.clxmotivo.Location = new System.Drawing.Point(12, 238);
            this.clxmotivo.Name = "clxmotivo";
            this.clxmotivo.Size = new System.Drawing.Size(279, 64);
            this.clxmotivo.TabIndex = 4;
            // 
            // lblmotivo
            // 
            this.lblmotivo.AutoSize = true;
            this.lblmotivo.Location = new System.Drawing.Point(12, 212);
            this.lblmotivo.Name = "lblmotivo";
            this.lblmotivo.Size = new System.Drawing.Size(115, 13);
            this.lblmotivo.TabIndex = 5;
            this.lblmotivo.Text = "Motivo de su renuncia:";
            // 
            // dgvrenuncia
            // 
            this.dgvrenuncia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrenuncia.Location = new System.Drawing.Point(8, 77);
            this.dgvrenuncia.Name = "dgvrenuncia";
            this.dgvrenuncia.Size = new System.Drawing.Size(529, 122);
            this.dgvrenuncia.TabIndex = 6;
            this.dgvrenuncia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvrenuncia_CellContentClick);
            // 
            // btbaceptar
            // 
            this.btbaceptar.Location = new System.Drawing.Point(462, 279);
            this.btbaceptar.Name = "btbaceptar";
            this.btbaceptar.Size = new System.Drawing.Size(75, 23);
            this.btbaceptar.TabIndex = 7;
            this.btbaceptar.Text = "Aceptar";
            this.btbaceptar.UseVisualStyleBackColor = true;
            this.btbaceptar.Click += new System.EventHandler(this.btbaceptar_Click);
            // 
            // btbcancelar
            // 
            this.btbcancelar.Location = new System.Drawing.Point(307, 279);
            this.btbcancelar.Name = "btbcancelar";
            this.btbcancelar.Size = new System.Drawing.Size(75, 23);
            this.btbcancelar.TabIndex = 8;
            this.btbcancelar.Text = "Cancelar";
            this.btbcancelar.UseVisualStyleBackColor = true;
            this.btbcancelar.Click += new System.EventHandler(this.btbcancelar_Click);
            // 
            // frmrenuncia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(539, 314);
            this.Controls.Add(this.btbcancelar);
            this.Controls.Add(this.btbaceptar);
            this.Controls.Add(this.dgvrenuncia);
            this.Controls.Add(this.lblmotivo);
            this.Controls.Add(this.clxmotivo);
            this.Controls.Add(this.cbestadodelempleado);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.lblcodigo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmrenuncia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renuncias";
            this.Load += new System.EventHandler(this.frmrenuncia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvrenuncia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.ComboBox cbestadodelempleado;
        private System.Windows.Forms.CheckedListBox clxmotivo;
        private System.Windows.Forms.Label lblmotivo;
        private System.Windows.Forms.DataGridView dgvrenuncia;
        private System.Windows.Forms.Button btbaceptar;
        private System.Windows.Forms.Button btbcancelar;
    }
}