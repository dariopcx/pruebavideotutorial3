namespace Programaderecursoshumanos
{
    partial class frmdespidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdespidos));
            this.dgvdespidos = new System.Windows.Forms.DataGridView();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lblestado = new System.Windows.Forms.Label();
            this.lblliquidacion = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtsueldo = new System.Windows.Forms.TextBox();
            this.cbestadodelempleado = new System.Windows.Forms.ComboBox();
            this.lblmotivo = new System.Windows.Forms.Label();
            this.clxcomentario = new System.Windows.Forms.CheckedListBox();
            this.btbcancelar = new System.Windows.Forms.Button();
            this.txtactualizar = new System.Windows.Forms.Button();
            this.btbaceptar = new System.Windows.Forms.Button();
            this.btbcalendario = new System.Windows.Forms.Button();
            this.btbcalculadora = new System.Windows.Forms.Button();
            this.btbnavegador = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdespidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdespidos
            // 
            this.dgvdespidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvdespidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdespidos.Location = new System.Drawing.Point(12, 12);
            this.dgvdespidos.Name = "dgvdespidos";
            this.dgvdespidos.Size = new System.Drawing.Size(754, 175);
            this.dgvdespidos.TabIndex = 0;
            this.dgvdespidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(28, 209);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(43, 13);
            this.lblcodigo.TabIndex = 1;
            this.lblcodigo.Text = "Codigo:";
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(28, 240);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(109, 13);
            this.lblestado.TabIndex = 2;
            this.lblestado.Text = "Estado del empleado:";
            // 
            // lblliquidacion
            // 
            this.lblliquidacion.AutoSize = true;
            this.lblliquidacion.Location = new System.Drawing.Point(28, 272);
            this.lblliquidacion.Name = "lblliquidacion";
            this.lblliquidacion.Size = new System.Drawing.Size(64, 13);
            this.lblliquidacion.TabIndex = 3;
            this.lblliquidacion.Text = "Liquidacion:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(78, 209);
            this.txtcodigo.MaxLength = 10;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 20);
            this.txtcodigo.TabIndex = 4;
            this.txtcodigo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigo_KeyPress);
            // 
            // txtsueldo
            // 
            this.txtsueldo.Location = new System.Drawing.Point(98, 269);
            this.txtsueldo.MaxLength = 10;
            this.txtsueldo.Name = "txtsueldo";
            this.txtsueldo.Size = new System.Drawing.Size(100, 20);
            this.txtsueldo.TabIndex = 5;
            this.txtsueldo.TextChanged += new System.EventHandler(this.txtsueldo_TextChanged);
            this.txtsueldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigo_KeyPress);
            // 
            // cbestadodelempleado
            // 
            this.cbestadodelempleado.AutoCompleteCustomSource.AddRange(new string[] {
            "Activo",
            "Despedido"});
            this.cbestadodelempleado.FormattingEnabled = true;
            this.cbestadodelempleado.Location = new System.Drawing.Point(143, 237);
            this.cbestadodelempleado.Name = "cbestadodelempleado";
            this.cbestadodelempleado.Size = new System.Drawing.Size(121, 21);
            this.cbestadodelempleado.TabIndex = 6;
            // 
            // lblmotivo
            // 
            this.lblmotivo.AutoSize = true;
            this.lblmotivo.Location = new System.Drawing.Point(588, 208);
            this.lblmotivo.Name = "lblmotivo";
            this.lblmotivo.Size = new System.Drawing.Size(99, 13);
            this.lblmotivo.TabIndex = 7;
            this.lblmotivo.Text = "Motivo del despido:";
            // 
            // clxcomentario
            // 
            this.clxcomentario.CheckOnClick = true;
            this.clxcomentario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clxcomentario.FormattingEnabled = true;
            this.clxcomentario.Items.AddRange(new object[] {
            "Despedido por mala conducta",
            "Despedido por robo",
            "Despedido por multiples ausencias",
            "Despedido por malos habitos",
            "Despedido por incumplimiento de su labor",
            "Despedido por cumplimiento del contrato"});
            this.clxcomentario.Location = new System.Drawing.Point(526, 237);
            this.clxcomentario.Name = "clxcomentario";
            this.clxcomentario.Size = new System.Drawing.Size(245, 94);
            this.clxcomentario.TabIndex = 8;
            // 
            // btbcancelar
            // 
            this.btbcancelar.Location = new System.Drawing.Point(12, 380);
            this.btbcancelar.Name = "btbcancelar";
            this.btbcancelar.Size = new System.Drawing.Size(75, 23);
            this.btbcancelar.TabIndex = 9;
            this.btbcancelar.Text = "Cancelar";
            this.btbcancelar.UseVisualStyleBackColor = true;
            this.btbcancelar.Click += new System.EventHandler(this.btbcancelar_Click);
            // 
            // txtactualizar
            // 
            this.txtactualizar.Location = new System.Drawing.Point(319, 308);
            this.txtactualizar.Name = "txtactualizar";
            this.txtactualizar.Size = new System.Drawing.Size(98, 23);
            this.txtactualizar.TabIndex = 10;
            this.txtactualizar.Text = "Actualizar tabla";
            this.txtactualizar.UseVisualStyleBackColor = true;
            this.txtactualizar.Click += new System.EventHandler(this.txtactualizar_Click);
            // 
            // btbaceptar
            // 
            this.btbaceptar.Location = new System.Drawing.Point(712, 380);
            this.btbaceptar.Name = "btbaceptar";
            this.btbaceptar.Size = new System.Drawing.Size(75, 23);
            this.btbaceptar.TabIndex = 11;
            this.btbaceptar.Text = "Aceptar";
            this.btbaceptar.UseVisualStyleBackColor = true;
            this.btbaceptar.Click += new System.EventHandler(this.btbaceptar_Click);
            // 
            // btbcalendario
            // 
            this.btbcalendario.Location = new System.Drawing.Point(248, 272);
            this.btbcalendario.Name = "btbcalendario";
            this.btbcalendario.Size = new System.Drawing.Size(75, 23);
            this.btbcalendario.TabIndex = 12;
            this.btbcalendario.Text = "Calendario";
            this.btbcalendario.UseVisualStyleBackColor = true;
            this.btbcalendario.Click += new System.EventHandler(this.btbcalendario_Click);
            // 
            // btbcalculadora
            // 
            this.btbcalculadora.Location = new System.Drawing.Point(329, 272);
            this.btbcalculadora.Name = "btbcalculadora";
            this.btbcalculadora.Size = new System.Drawing.Size(75, 23);
            this.btbcalculadora.TabIndex = 13;
            this.btbcalculadora.Text = "Calculadora";
            this.btbcalculadora.UseVisualStyleBackColor = true;
            this.btbcalculadora.Click += new System.EventHandler(this.btbcalculadora_Click);
            // 
            // btbnavegador
            // 
            this.btbnavegador.Location = new System.Drawing.Point(410, 272);
            this.btbnavegador.Name = "btbnavegador";
            this.btbnavegador.Size = new System.Drawing.Size(75, 23);
            this.btbnavegador.TabIndex = 14;
            this.btbnavegador.Text = "Google";
            this.btbnavegador.UseVisualStyleBackColor = true;
            this.btbnavegador.Click += new System.EventHandler(this.btbnavegador_Click);
            // 
            // frmdespidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 415);
            this.Controls.Add(this.btbnavegador);
            this.Controls.Add(this.btbcalculadora);
            this.Controls.Add(this.btbcalendario);
            this.Controls.Add(this.btbaceptar);
            this.Controls.Add(this.txtactualizar);
            this.Controls.Add(this.btbcancelar);
            this.Controls.Add(this.clxcomentario);
            this.Controls.Add(this.lblmotivo);
            this.Controls.Add(this.cbestadodelempleado);
            this.Controls.Add(this.txtsueldo);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.lblliquidacion);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.dgvdespidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmdespidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Despidos";
            this.Load += new System.EventHandler(this.frmdespidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdespidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdespidos;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.Label lblliquidacion;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtsueldo;
        private System.Windows.Forms.ComboBox cbestadodelempleado;
        private System.Windows.Forms.Label lblmotivo;
        private System.Windows.Forms.CheckedListBox clxcomentario;
        private System.Windows.Forms.Button btbcancelar;
        private System.Windows.Forms.Button txtactualizar;
        private System.Windows.Forms.Button btbaceptar;
        private System.Windows.Forms.Button btbcalendario;
        private System.Windows.Forms.Button btbcalculadora;
        private System.Windows.Forms.Button btbnavegador;
    }
}