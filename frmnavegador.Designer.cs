namespace Programaderecursoshumanos
{
    partial class frmnavegador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmnavegador));
            this.lbldireccion = new System.Windows.Forms.Label();
            this.txturl = new System.Windows.Forms.TextBox();
            this.btbir = new System.Windows.Forms.Button();
            this.webgoogle = new System.Windows.Forms.WebBrowser();
            this.toolsmenu = new System.Windows.Forms.ToolStrip();
            this.toolsbtbregresar = new System.Windows.Forms.ToolStripButton();
            this.s1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolsbtbvolver = new System.Windows.Forms.ToolStripButton();
            this.s2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolsbtbstop = new System.Windows.Forms.ToolStripButton();
            this.s3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolsrecargar = new System.Windows.Forms.ToolStripButton();
            this.s4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolssalir = new System.Windows.Forms.ToolStripButton();
            this.toolsmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldireccion.Location = new System.Drawing.Point(3, 32);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(68, 16);
            this.lbldireccion.TabIndex = 0;
            this.lbldireccion.Text = "Direccion:";
            this.lbldireccion.Click += new System.EventHandler(this.label1_Click);
            // 
            // txturl
            // 
            this.txturl.Location = new System.Drawing.Point(77, 31);
            this.txturl.Name = "txturl";
            this.txturl.Size = new System.Drawing.Size(391, 20);
            this.txturl.TabIndex = 2;
            this.txturl.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btbir
            // 
            this.btbir.BackColor = System.Drawing.Color.Yellow;
            this.btbir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbir.Location = new System.Drawing.Point(474, 28);
            this.btbir.Name = "btbir";
            this.btbir.Size = new System.Drawing.Size(75, 23);
            this.btbir.TabIndex = 3;
            this.btbir.Text = "Ir";
            this.btbir.UseVisualStyleBackColor = false;
            this.btbir.Click += new System.EventHandler(this.btbir_Click);
            // 
            // webgoogle
            // 
            this.webgoogle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webgoogle.Location = new System.Drawing.Point(12, 69);
            this.webgoogle.MinimumSize = new System.Drawing.Size(20, 20);
            this.webgoogle.Name = "webgoogle";
            this.webgoogle.Size = new System.Drawing.Size(528, 216);
            this.webgoogle.TabIndex = 4;
            this.webgoogle.Url = new System.Uri("https://www.google.com.do/", System.UriKind.Absolute);
            this.webgoogle.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // toolsmenu
            // 
            this.toolsmenu.BackColor = System.Drawing.Color.Transparent;
            this.toolsmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsbtbregresar,
            this.s1,
            this.toolsbtbvolver,
            this.s2,
            this.toolsbtbstop,
            this.s3,
            this.toolsrecargar,
            this.s4,
            this.toolssalir});
            this.toolsmenu.Location = new System.Drawing.Point(0, 0);
            this.toolsmenu.Name = "toolsmenu";
            this.toolsmenu.Size = new System.Drawing.Size(552, 25);
            this.toolsmenu.TabIndex = 5;
            this.toolsmenu.Text = "Menu";
            this.toolsmenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolsmenu_ItemClicked);
            // 
            // toolsbtbregresar
            // 
            this.toolsbtbregresar.Image = ((System.Drawing.Image)(resources.GetObject("toolsbtbregresar.Image")));
            this.toolsbtbregresar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsbtbregresar.Name = "toolsbtbregresar";
            this.toolsbtbregresar.Size = new System.Drawing.Size(72, 22);
            this.toolsbtbregresar.Text = "Regresar";
            this.toolsbtbregresar.Click += new System.EventHandler(this.toolsbtbregresar_Click);
            // 
            // s1
            // 
            this.s1.Name = "s1";
            this.s1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolsbtbvolver
            // 
            this.toolsbtbvolver.Image = ((System.Drawing.Image)(resources.GetObject("toolsbtbvolver.Image")));
            this.toolsbtbvolver.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsbtbvolver.Name = "toolsbtbvolver";
            this.toolsbtbvolver.Size = new System.Drawing.Size(60, 22);
            this.toolsbtbvolver.Text = "Volver";
            this.toolsbtbvolver.Click += new System.EventHandler(this.toolsbtbvolver_Click);
            // 
            // s2
            // 
            this.s2.Name = "s2";
            this.s2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolsbtbstop
            // 
            this.toolsbtbstop.Image = ((System.Drawing.Image)(resources.GetObject("toolsbtbstop.Image")));
            this.toolsbtbstop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsbtbstop.Name = "toolsbtbstop";
            this.toolsbtbstop.Size = new System.Drawing.Size(54, 22);
            this.toolsbtbstop.Text = "Parar";
            this.toolsbtbstop.Click += new System.EventHandler(this.toolsbtbstop_Click);
            // 
            // s3
            // 
            this.s3.Name = "s3";
            this.s3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolsrecargar
            // 
            this.toolsrecargar.Image = ((System.Drawing.Image)(resources.GetObject("toolsrecargar.Image")));
            this.toolsrecargar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsrecargar.Name = "toolsrecargar";
            this.toolsrecargar.Size = new System.Drawing.Size(73, 22);
            this.toolsrecargar.Text = "Recargar";
            this.toolsrecargar.Click += new System.EventHandler(this.toolsrecargar_Click);
            // 
            // s4
            // 
            this.s4.Name = "s4";
            this.s4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolssalir
            // 
            this.toolssalir.Image = ((System.Drawing.Image)(resources.GetObject("toolssalir.Image")));
            this.toolssalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolssalir.Name = "toolssalir";
            this.toolssalir.Size = new System.Drawing.Size(49, 22);
            this.toolssalir.Text = "Salir";
            this.toolssalir.Click += new System.EventHandler(this.toolssalir_Click);
            // 
            // frmnavegador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(552, 313);
            this.Controls.Add(this.toolsmenu);
            this.Controls.Add(this.webgoogle);
            this.Controls.Add(this.btbir);
            this.Controls.Add(this.txturl);
            this.Controls.Add(this.lbldireccion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmnavegador";
            this.Text = "Navegador de Google ";
            this.Load += new System.EventHandler(this.frmnavegador_Load);
            this.toolsmenu.ResumeLayout(false);
            this.toolsmenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.TextBox txturl;
        private System.Windows.Forms.Button btbir;
        private System.Windows.Forms.WebBrowser webgoogle;
        private System.Windows.Forms.ToolStrip toolsmenu;
        private System.Windows.Forms.ToolStripButton toolsbtbregresar;
        private System.Windows.Forms.ToolStripSeparator s1;
        private System.Windows.Forms.ToolStripButton toolsbtbvolver;
        private System.Windows.Forms.ToolStripSeparator s2;
        private System.Windows.Forms.ToolStripButton toolsbtbstop;
        private System.Windows.Forms.ToolStripSeparator s3;
        private System.Windows.Forms.ToolStripButton toolsrecargar;
        private System.Windows.Forms.ToolStripSeparator s4;
        private System.Windows.Forms.ToolStripButton toolssalir;
    }
}