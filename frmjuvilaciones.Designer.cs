namespace Programaderecursoshumanos
{
    partial class frmjuvilaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmjuvilaciones));
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lblestado = new System.Windows.Forms.Label();
            this.rbjuvilado = new System.Windows.Forms.RadioButton();
            this.rbactivo = new System.Windows.Forms.RadioButton();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lblpension = new System.Windows.Forms.Label();
            this.txtsueldo = new System.Windows.Forms.TextBox();
            this.lblcomentario = new System.Windows.Forms.Label();
            this.txtcomentario = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btbaceptar = new System.Windows.Forms.Button();
            this.btbcalculadora = new System.Windows.Forms.Button();
            this.btbnavegador = new System.Windows.Forms.Button();
            this.lblcalendario = new System.Windows.Forms.Button();
            this.btbmostrartabla = new System.Windows.Forms.Button();
            this.lblcancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(13, 12);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(43, 13);
            this.lblcodigo.TabIndex = 0;
            this.lblcodigo.Text = "Codigo:";
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(12, 45);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(109, 13);
            this.lblestado.TabIndex = 1;
            this.lblestado.Text = "Estado del empleado:";
            // 
            // rbjuvilado
            // 
            this.rbjuvilado.AutoSize = true;
            this.rbjuvilado.Location = new System.Drawing.Point(127, 43);
            this.rbjuvilado.Name = "rbjuvilado";
            this.rbjuvilado.Size = new System.Drawing.Size(64, 17);
            this.rbjuvilado.TabIndex = 2;
            this.rbjuvilado.TabStop = true;
            this.rbjuvilado.Text = "Juvilado";
            this.rbjuvilado.UseVisualStyleBackColor = true;
            this.rbjuvilado.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbactivo
            // 
            this.rbactivo.AutoSize = true;
            this.rbactivo.Location = new System.Drawing.Point(197, 43);
            this.rbactivo.Name = "rbactivo";
            this.rbactivo.Size = new System.Drawing.Size(55, 17);
            this.rbactivo.TabIndex = 3;
            this.rbactivo.TabStop = true;
            this.rbactivo.Text = "Activo";
            this.rbactivo.UseVisualStyleBackColor = true;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(62, 9);
            this.txtcodigo.MaxLength = 10;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(190, 20);
            this.txtcodigo.TabIndex = 4;
            this.txtcodigo.TextChanged += new System.EventHandler(this.txtcodigo_TextChanged);
            this.txtcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigo_KeyPress);
            // 
            // lblpension
            // 
            this.lblpension.AutoSize = true;
            this.lblpension.Location = new System.Drawing.Point(21, 77);
            this.lblpension.Name = "lblpension";
            this.lblpension.Size = new System.Drawing.Size(100, 13);
            this.lblpension.TabIndex = 5;
            this.lblpension.Text = "Valor de la pension:";
            // 
            // txtsueldo
            // 
            this.txtsueldo.Location = new System.Drawing.Point(62, 107);
            this.txtsueldo.MaxLength = 15;
            this.txtsueldo.Name = "txtsueldo";
            this.txtsueldo.Size = new System.Drawing.Size(190, 20);
            this.txtsueldo.TabIndex = 6;
            this.txtsueldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigo_KeyPress);
            // 
            // lblcomentario
            // 
            this.lblcomentario.AutoSize = true;
            this.lblcomentario.Location = new System.Drawing.Point(21, 146);
            this.lblcomentario.Name = "lblcomentario";
            this.lblcomentario.Size = new System.Drawing.Size(63, 13);
            this.lblcomentario.TabIndex = 7;
            this.lblcomentario.Text = "Comentario:";
            // 
            // txtcomentario
            // 
            this.txtcomentario.Location = new System.Drawing.Point(62, 177);
            this.txtcomentario.MaxLength = 90;
            this.txtcomentario.Name = "txtcomentario";
            this.txtcomentario.Size = new System.Drawing.Size(190, 20);
            this.txtcomentario.TabIndex = 8;
            this.txtcomentario.TextChanged += new System.EventHandler(this.txtcomentario_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(258, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btbaceptar
            // 
            this.btbaceptar.Location = new System.Drawing.Point(492, 249);
            this.btbaceptar.Name = "btbaceptar";
            this.btbaceptar.Size = new System.Drawing.Size(75, 23);
            this.btbaceptar.TabIndex = 10;
            this.btbaceptar.Text = "Aceptar";
            this.btbaceptar.UseVisualStyleBackColor = true;
            this.btbaceptar.Click += new System.EventHandler(this.btbaceptar_Click);
            // 
            // btbcalculadora
            // 
            this.btbcalculadora.Location = new System.Drawing.Point(411, 249);
            this.btbcalculadora.Name = "btbcalculadora";
            this.btbcalculadora.Size = new System.Drawing.Size(75, 23);
            this.btbcalculadora.TabIndex = 11;
            this.btbcalculadora.Text = "Calculadora";
            this.btbcalculadora.UseVisualStyleBackColor = true;
            this.btbcalculadora.Click += new System.EventHandler(this.btbcalculadora_Click);
            // 
            // btbnavegador
            // 
            this.btbnavegador.Location = new System.Drawing.Point(330, 249);
            this.btbnavegador.Name = "btbnavegador";
            this.btbnavegador.Size = new System.Drawing.Size(75, 23);
            this.btbnavegador.TabIndex = 12;
            this.btbnavegador.Text = "Navegador";
            this.btbnavegador.UseVisualStyleBackColor = true;
            this.btbnavegador.Click += new System.EventHandler(this.btbnavegador_Click);
            // 
            // lblcalendario
            // 
            this.lblcalendario.Location = new System.Drawing.Point(197, 249);
            this.lblcalendario.Name = "lblcalendario";
            this.lblcalendario.Size = new System.Drawing.Size(75, 23);
            this.lblcalendario.TabIndex = 13;
            this.lblcalendario.Text = "Calendario";
            this.lblcalendario.UseVisualStyleBackColor = true;
            this.lblcalendario.Click += new System.EventHandler(this.lblcalendario_Click);
            // 
            // btbmostrartabla
            // 
            this.btbmostrartabla.Location = new System.Drawing.Point(102, 249);
            this.btbmostrartabla.Name = "btbmostrartabla";
            this.btbmostrartabla.Size = new System.Drawing.Size(89, 23);
            this.btbmostrartabla.TabIndex = 14;
            this.btbmostrartabla.Text = "Consultar ";
            this.btbmostrartabla.UseVisualStyleBackColor = true;
            this.btbmostrartabla.Click += new System.EventHandler(this.btbmostrartabla_Click);
            // 
            // lblcancelar
            // 
            this.lblcancelar.Location = new System.Drawing.Point(12, 249);
            this.lblcancelar.Name = "lblcancelar";
            this.lblcancelar.Size = new System.Drawing.Size(84, 23);
            this.lblcancelar.TabIndex = 15;
            this.lblcancelar.Text = "Cancelar";
            this.lblcancelar.UseVisualStyleBackColor = true;
            this.lblcancelar.Click += new System.EventHandler(this.lblcancelar_Click);
            // 
            // frmjuvilaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(579, 284);
            this.Controls.Add(this.lblcancelar);
            this.Controls.Add(this.btbmostrartabla);
            this.Controls.Add(this.lblcalendario);
            this.Controls.Add(this.btbnavegador);
            this.Controls.Add(this.btbcalculadora);
            this.Controls.Add(this.btbaceptar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtcomentario);
            this.Controls.Add(this.lblcomentario);
            this.Controls.Add(this.txtsueldo);
            this.Controls.Add(this.lblpension);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.rbactivo);
            this.Controls.Add(this.rbjuvilado);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.lblcodigo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmjuvilaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juvilaciones";
            this.Load += new System.EventHandler(this.frmjuvilaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.RadioButton rbjuvilado;
        private System.Windows.Forms.RadioButton rbactivo;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lblpension;
        private System.Windows.Forms.TextBox txtsueldo;
        private System.Windows.Forms.Label lblcomentario;
        private System.Windows.Forms.TextBox txtcomentario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btbaceptar;
        private System.Windows.Forms.Button btbcalculadora;
        private System.Windows.Forms.Button btbnavegador;
        private System.Windows.Forms.Button lblcalendario;
        private System.Windows.Forms.Button btbmostrartabla;
        private System.Windows.Forms.Button lblcancelar;

    }
}