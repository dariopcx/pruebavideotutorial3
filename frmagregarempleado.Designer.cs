namespace Programaderecursoshumanos
{
    partial class frmagregarempleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmagregarempleado));
            this.lblnombreempleado = new System.Windows.Forms.Label();
            this.lblpapellido = new System.Windows.Forms.Label();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.lblcorreo = new System.Windows.Forms.Label();
            this.lbledad = new System.Windows.Forms.Label();
            this.lblestadocivil = new System.Windows.Forms.Label();
            this.lblsexo = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellidos = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblpuestoaaspirar = new System.Windows.Forms.Label();
            this.gbestadocivil = new System.Windows.Forms.GroupBox();
            this.rbsoltero = new System.Windows.Forms.RadioButton();
            this.rbcasado = new System.Windows.Forms.RadioButton();
            this.nupedad = new System.Windows.Forms.NumericUpDown();
            this.rbmasculino = new System.Windows.Forms.RadioButton();
            this.rbfemenino = new System.Windows.Forms.RadioButton();
            this.gbsexo = new System.Windows.Forms.GroupBox();
            this.btbguardar = new System.Windows.Forms.Button();
            this.btbcancelar = new System.Windows.Forms.Button();
            this.lblcedula = new System.Windows.Forms.Label();
            this.lblnumerodetelefono = new System.Windows.Forms.Label();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.lblfechadeingreso = new System.Windows.Forms.Label();
            this.cbpuesto = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtfechadeingreso = new System.Windows.Forms.TextBox();
            this.lblnacionalidad = new System.Windows.Forms.Label();
            this.txtnacionalidad = new System.Windows.Forms.TextBox();
            this.lblseguromedico = new System.Windows.Forms.Label();
            this.lbseguromedico = new System.Windows.Forms.ListBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.lblfechafinalcontrato = new System.Windows.Forms.Label();
            this.txtfechafinalizcontrato = new System.Windows.Forms.TextBox();
            this.lblcodigoparaelempleado = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lblsueldo = new System.Windows.Forms.Label();
            this.txtsueldo = new System.Windows.Forms.TextBox();
            this.lblcomentario = new System.Windows.Forms.Label();
            this.txtcomentario = new System.Windows.Forms.TextBox();
            this.lblnivelacademico = new System.Windows.Forms.Label();
            this.cbnivelacademico = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblestado = new System.Windows.Forms.Label();
            this.cbestadodelempleado = new System.Windows.Forms.ComboBox();
            this.dgvprueba = new System.Windows.Forms.DataGridView();
            this.btbmostrar = new System.Windows.Forms.Button();
            this.btbocultar = new System.Windows.Forms.Button();
            this.btblimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbestadocivil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupedad)).BeginInit();
            this.gbsexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprueba)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnombreempleado
            // 
            this.lblnombreempleado.AutoSize = true;
            this.lblnombreempleado.Location = new System.Drawing.Point(13, 9);
            this.lblnombreempleado.Name = "lblnombreempleado";
            this.lblnombreempleado.Size = new System.Drawing.Size(47, 13);
            this.lblnombreempleado.TabIndex = 36;
            this.lblnombreempleado.Text = "Nombre:";
            // 
            // lblpapellido
            // 
            this.lblpapellido.AutoSize = true;
            this.lblpapellido.Location = new System.Drawing.Point(12, 38);
            this.lblpapellido.Name = "lblpapellido";
            this.lblpapellido.Size = new System.Drawing.Size(52, 13);
            this.lblpapellido.TabIndex = 37;
            this.lblpapellido.Text = "Apellidos:";
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Location = new System.Drawing.Point(12, 98);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(121, 13);
            this.lbldireccion.TabIndex = 39;
            this.lbldireccion.Text = "Direccion de residencia:";
            // 
            // lblcorreo
            // 
            this.lblcorreo.AutoSize = true;
            this.lblcorreo.Location = new System.Drawing.Point(13, 127);
            this.lblcorreo.Name = "lblcorreo";
            this.lblcorreo.Size = new System.Drawing.Size(96, 13);
            this.lblcorreo.TabIndex = 40;
            this.lblcorreo.Text = "Correo electronico:";
            this.lblcorreo.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbledad
            // 
            this.lbledad.AutoSize = true;
            this.lbledad.Location = new System.Drawing.Point(664, 9);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(35, 13);
            this.lbledad.TabIndex = 44;
            this.lbledad.Text = "Edad:";
            // 
            // lblestadocivil
            // 
            this.lblestadocivil.AutoSize = true;
            this.lblestadocivil.Location = new System.Drawing.Point(433, 12);
            this.lblestadocivil.Name = "lblestadocivil";
            this.lblestadocivil.Size = new System.Drawing.Size(65, 13);
            this.lblestadocivil.TabIndex = 43;
            this.lblestadocivil.Text = "Estado Civil:";
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.Location = new System.Drawing.Point(455, 42);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(34, 13);
            this.lblsexo.TabIndex = 45;
            this.lblsexo.Text = "Sexo:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(66, 9);
            this.txtnombre.MaxLength = 20;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(237, 20);
            this.txtnombre.TabIndex = 0;
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            // 
            // txtapellidos
            // 
            this.txtapellidos.Location = new System.Drawing.Point(66, 35);
            this.txtapellidos.MaxLength = 45;
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.Size = new System.Drawing.Size(237, 20);
            this.txtapellidos.TabIndex = 1;
            this.txtapellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(139, 95);
            this.txtdireccion.MaxLength = 69;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(299, 20);
            this.txtdireccion.TabIndex = 3;
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(115, 124);
            this.txtcorreo.MaxLength = 49;
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(323, 20);
            this.txtcorreo.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(309, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lblpuestoaaspirar
            // 
            this.lblpuestoaaspirar.AutoSize = true;
            this.lblpuestoaaspirar.Location = new System.Drawing.Point(12, 153);
            this.lblpuestoaaspirar.Name = "lblpuestoaaspirar";
            this.lblpuestoaaspirar.Size = new System.Drawing.Size(87, 13);
            this.lblpuestoaaspirar.TabIndex = 41;
            this.lblpuestoaaspirar.Text = "Puesto a Aspirar:";
            // 
            // gbestadocivil
            // 
            this.gbestadocivil.Controls.Add(this.rbsoltero);
            this.gbestadocivil.Controls.Add(this.rbcasado);
            this.gbestadocivil.Location = new System.Drawing.Point(502, 0);
            this.gbestadocivil.Name = "gbestadocivil";
            this.gbestadocivil.Size = new System.Drawing.Size(148, 29);
            this.gbestadocivil.TabIndex = 16;
            this.gbestadocivil.TabStop = false;
            // 
            // rbsoltero
            // 
            this.rbsoltero.AutoSize = true;
            this.rbsoltero.Location = new System.Drawing.Point(73, 9);
            this.rbsoltero.Name = "rbsoltero";
            this.rbsoltero.Size = new System.Drawing.Size(58, 17);
            this.rbsoltero.TabIndex = 8;
            this.rbsoltero.TabStop = true;
            this.rbsoltero.Text = "Soltero";
            this.rbsoltero.UseVisualStyleBackColor = true;
            // 
            // rbcasado
            // 
            this.rbcasado.AutoSize = true;
            this.rbcasado.Location = new System.Drawing.Point(6, 9);
            this.rbcasado.Name = "rbcasado";
            this.rbcasado.Size = new System.Drawing.Size(61, 17);
            this.rbcasado.TabIndex = 7;
            this.rbcasado.TabStop = true;
            this.rbcasado.Text = "Casado";
            this.rbcasado.UseVisualStyleBackColor = true;
            // 
            // nupedad
            // 
            this.nupedad.Location = new System.Drawing.Point(667, 31);
            this.nupedad.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.nupedad.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nupedad.Name = "nupedad";
            this.nupedad.Size = new System.Drawing.Size(39, 20);
            this.nupedad.TabIndex = 9;
            this.nupedad.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nupedad.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // rbmasculino
            // 
            this.rbmasculino.AutoSize = true;
            this.rbmasculino.Location = new System.Drawing.Point(6, 9);
            this.rbmasculino.Name = "rbmasculino";
            this.rbmasculino.Size = new System.Drawing.Size(73, 17);
            this.rbmasculino.TabIndex = 10;
            this.rbmasculino.TabStop = true;
            this.rbmasculino.Text = "Masculino";
            this.rbmasculino.UseVisualStyleBackColor = true;
            // 
            // rbfemenino
            // 
            this.rbfemenino.AutoSize = true;
            this.rbfemenino.Location = new System.Drawing.Point(79, 9);
            this.rbfemenino.Name = "rbfemenino";
            this.rbfemenino.Size = new System.Drawing.Size(71, 17);
            this.rbfemenino.TabIndex = 11;
            this.rbfemenino.TabStop = true;
            this.rbfemenino.Text = "Femenino";
            this.rbfemenino.UseVisualStyleBackColor = true;
            // 
            // gbsexo
            // 
            this.gbsexo.Controls.Add(this.rbfemenino);
            this.gbsexo.Controls.Add(this.rbmasculino);
            this.gbsexo.Location = new System.Drawing.Point(500, 31);
            this.gbsexo.Name = "gbsexo";
            this.gbsexo.Size = new System.Drawing.Size(161, 29);
            this.gbsexo.TabIndex = 20;
            this.gbsexo.TabStop = false;
            this.gbsexo.Enter += new System.EventHandler(this.gbsexo_Enter);
            // 
            // btbguardar
            // 
            this.btbguardar.Location = new System.Drawing.Point(652, 327);
            this.btbguardar.Name = "btbguardar";
            this.btbguardar.Size = new System.Drawing.Size(75, 23);
            this.btbguardar.TabIndex = 35;
            this.btbguardar.Text = "Guardar";
            this.btbguardar.UseVisualStyleBackColor = true;
            this.btbguardar.Click += new System.EventHandler(this.btbguardar_Click);
            // 
            // btbcancelar
            // 
            this.btbcancelar.Location = new System.Drawing.Point(8, 327);
            this.btbcancelar.Name = "btbcancelar";
            this.btbcancelar.Size = new System.Drawing.Size(75, 23);
            this.btbcancelar.TabIndex = 34;
            this.btbcancelar.Text = "Cancelar";
            this.btbcancelar.UseVisualStyleBackColor = true;
            this.btbcancelar.Click += new System.EventHandler(this.btbcancelar_Click);
            // 
            // lblcedula
            // 
            this.lblcedula.AutoSize = true;
            this.lblcedula.Location = new System.Drawing.Point(12, 70);
            this.lblcedula.Name = "lblcedula";
            this.lblcedula.Size = new System.Drawing.Size(43, 13);
            this.lblcedula.TabIndex = 50;
            this.lblcedula.Text = "Cedula:";
            // 
            // lblnumerodetelefono
            // 
            this.lblnumerodetelefono.AutoSize = true;
            this.lblnumerodetelefono.Location = new System.Drawing.Point(446, 98);
            this.lblnumerodetelefono.Name = "lblnumerodetelefono";
            this.lblnumerodetelefono.Size = new System.Drawing.Size(52, 13);
            this.lblnumerodetelefono.TabIndex = 51;
            this.lblnumerodetelefono.Text = "Telefono:";
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(66, 67);
            this.txtcedula.MaxLength = 15;
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(183, 20);
            this.txtcedula.TabIndex = 17;
            this.txtcedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcedula_KeyPress);
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(502, 95);
            this.txttelefono.MaxLength = 15;
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(170, 20);
            this.txttelefono.TabIndex = 18;
            this.txttelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcedula_KeyPress);
            // 
            // lblfechadeingreso
            // 
            this.lblfechadeingreso.AutoSize = true;
            this.lblfechadeingreso.Location = new System.Drawing.Point(241, 154);
            this.lblfechadeingreso.Name = "lblfechadeingreso";
            this.lblfechadeingreso.Size = new System.Drawing.Size(92, 13);
            this.lblfechadeingreso.TabIndex = 54;
            this.lblfechadeingreso.Text = "Fecha de ingreso:";
            // 
            // cbpuesto
            // 
            this.cbpuesto.FormattingEnabled = true;
            this.cbpuesto.Items.AddRange(new object[] {
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
            "Constructor",
            ""});
            this.cbpuesto.Location = new System.Drawing.Point(106, 151);
            this.cbpuesto.Name = "cbpuesto";
            this.cbpuesto.Size = new System.Drawing.Size(127, 21);
            this.cbpuesto.TabIndex = 5;
            this.cbpuesto.SelectedIndexChanged += new System.EventHandler(this.cbpuesto_SelectedIndexChanged);
            // 
            // txtfechadeingreso
            // 
            this.txtfechadeingreso.Location = new System.Drawing.Point(339, 154);
            this.txtfechadeingreso.MaxLength = 10;
            this.txtfechadeingreso.Name = "txtfechadeingreso";
            this.txtfechadeingreso.Size = new System.Drawing.Size(138, 20);
            this.txtfechadeingreso.TabIndex = 21;
            // 
            // lblnacionalidad
            // 
            this.lblnacionalidad.AutoSize = true;
            this.lblnacionalidad.Location = new System.Drawing.Point(497, 161);
            this.lblnacionalidad.Name = "lblnacionalidad";
            this.lblnacionalidad.Size = new System.Drawing.Size(72, 13);
            this.lblnacionalidad.TabIndex = 56;
            this.lblnacionalidad.Text = "Nacionalidad:";
            // 
            // txtnacionalidad
            // 
            this.txtnacionalidad.Location = new System.Drawing.Point(572, 158);
            this.txtnacionalidad.MaxLength = 25;
            this.txtnacionalidad.Name = "txtnacionalidad";
            this.txtnacionalidad.Size = new System.Drawing.Size(127, 20);
            this.txtnacionalidad.TabIndex = 23;
            this.txtnacionalidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            // 
            // lblseguromedico
            // 
            this.lblseguromedico.AutoSize = true;
            this.lblseguromedico.Location = new System.Drawing.Point(497, 196);
            this.lblseguromedico.Name = "lblseguromedico";
            this.lblseguromedico.Size = new System.Drawing.Size(81, 13);
            this.lblseguromedico.TabIndex = 60;
            this.lblseguromedico.Text = "Seguro medico:";
            // 
            // lbseguromedico
            // 
            this.lbseguromedico.FormattingEnabled = true;
            this.lbseguromedico.Items.AddRange(new object[] {
            "Primera ARS de humano",
            "ARS Universal",
            "ARS Palic Salud ",
            "ARS Senasa",
            "ARS Futuro",
            "ARS Monumental",
            "ARS Meta Salud",
            "ARS Salud Segura",
            "ARS PN"});
            this.lbseguromedico.Location = new System.Drawing.Point(579, 192);
            this.lbseguromedico.Name = "lbseguromedico";
            this.lbseguromedico.Size = new System.Drawing.Size(137, 56);
            this.lbseguromedico.TabIndex = 28;
            // 
            // lblfechafinalcontrato
            // 
            this.lblfechafinalcontrato.AutoSize = true;
            this.lblfechafinalcontrato.Location = new System.Drawing.Point(241, 192);
            this.lblfechafinalcontrato.Name = "lblfechafinalcontrato";
            this.lblfechafinalcontrato.Size = new System.Drawing.Size(129, 13);
            this.lblfechafinalcontrato.TabIndex = 57;
            this.lblfechafinalcontrato.Text = "Fecha finaliz. de contrato:";
            // 
            // txtfechafinalizcontrato
            // 
            this.txtfechafinalizcontrato.Location = new System.Drawing.Point(374, 189);
            this.txtfechafinalizcontrato.MaxLength = 10;
            this.txtfechafinalizcontrato.Name = "txtfechafinalizcontrato";
            this.txtfechafinalizcontrato.Size = new System.Drawing.Size(103, 20);
            this.txtfechafinalizcontrato.TabIndex = 24;
            // 
            // lblcodigoparaelempleado
            // 
            this.lblcodigoparaelempleado.AutoSize = true;
            this.lblcodigoparaelempleado.Location = new System.Drawing.Point(5, 221);
            this.lblcodigoparaelempleado.Name = "lblcodigoparaelempleado";
            this.lblcodigoparaelempleado.Size = new System.Drawing.Size(127, 13);
            this.lblcodigoparaelempleado.TabIndex = 61;
            this.lblcodigoparaelempleado.Text = "Codigo para el empleado:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(138, 218);
            this.txtcodigo.MaxLength = 10;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(93, 20);
            this.txtcodigo.TabIndex = 29;
            this.txtcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcedula_KeyPress);
            // 
            // lblsueldo
            // 
            this.lblsueldo.AutoSize = true;
            this.lblsueldo.Location = new System.Drawing.Point(260, 225);
            this.lblsueldo.Name = "lblsueldo";
            this.lblsueldo.Size = new System.Drawing.Size(43, 13);
            this.lblsueldo.TabIndex = 63;
            this.lblsueldo.Text = "Sueldo:";
            // 
            // txtsueldo
            // 
            this.txtsueldo.Location = new System.Drawing.Point(319, 218);
            this.txtsueldo.Name = "txtsueldo";
            this.txtsueldo.Size = new System.Drawing.Size(138, 20);
            this.txtsueldo.TabIndex = 30;
            this.txtsueldo.TextChanged += new System.EventHandler(this.textBox15_TextChanged);
            this.txtsueldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcedula_KeyPress);
            // 
            // lblcomentario
            // 
            this.lblcomentario.AutoSize = true;
            this.lblcomentario.Location = new System.Drawing.Point(12, 297);
            this.lblcomentario.Name = "lblcomentario";
            this.lblcomentario.Size = new System.Drawing.Size(63, 13);
            this.lblcomentario.TabIndex = 65;
            this.lblcomentario.Text = "Comentario:";
            // 
            // txtcomentario
            // 
            this.txtcomentario.Location = new System.Drawing.Point(81, 294);
            this.txtcomentario.MaxLength = 90;
            this.txtcomentario.Name = "txtcomentario";
            this.txtcomentario.Size = new System.Drawing.Size(585, 20);
            this.txtcomentario.TabIndex = 33;
            // 
            // lblnivelacademico
            // 
            this.lblnivelacademico.AutoSize = true;
            this.lblnivelacademico.Location = new System.Drawing.Point(446, 127);
            this.lblnivelacademico.Name = "lblnivelacademico";
            this.lblnivelacademico.Size = new System.Drawing.Size(90, 13);
            this.lblnivelacademico.TabIndex = 47;
            this.lblnivelacademico.Text = "Nivel Academico:";
            // 
            // cbnivelacademico
            // 
            this.cbnivelacademico.FormattingEnabled = true;
            this.cbnivelacademico.Items.AddRange(new object[] {
            "Primaria",
            "Secundaria",
            "Tecnico",
            "Universitario",
            "Maestria"});
            this.cbnivelacademico.Location = new System.Drawing.Point(542, 124);
            this.cbnivelacademico.Name = "cbnivelacademico";
            this.cbnivelacademico.Size = new System.Drawing.Size(132, 21);
            this.cbnivelacademico.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(534, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 66;
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(13, 261);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(109, 13);
            this.lblestado.TabIndex = 67;
            this.lblestado.Text = "Estado del empleado:";
            // 
            // cbestadodelempleado
            // 
            this.cbestadodelempleado.FormattingEnabled = true;
            this.cbestadodelempleado.Items.AddRange(new object[] {
            "Activo"});
            this.cbestadodelempleado.Location = new System.Drawing.Point(138, 258);
            this.cbestadodelempleado.Name = "cbestadodelempleado";
            this.cbestadodelempleado.Size = new System.Drawing.Size(121, 21);
            this.cbestadodelempleado.TabIndex = 68;
            this.cbestadodelempleado.SelectedIndexChanged += new System.EventHandler(this.cbestadodelempleado_SelectedIndexChanged);
            // 
            // dgvprueba
            // 
            this.dgvprueba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvprueba.Location = new System.Drawing.Point(8, 406);
            this.dgvprueba.Name = "dgvprueba";
            this.dgvprueba.Size = new System.Drawing.Size(732, 150);
            this.dgvprueba.TabIndex = 69;
            this.dgvprueba.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvprueba_CellContentClick);
            // 
            // btbmostrar
            // 
            this.btbmostrar.Location = new System.Drawing.Point(329, 327);
            this.btbmostrar.Name = "btbmostrar";
            this.btbmostrar.Size = new System.Drawing.Size(109, 23);
            this.btbmostrar.TabIndex = 71;
            this.btbmostrar.Text = "Mostrar tabla";
            this.btbmostrar.UseVisualStyleBackColor = true;
            this.btbmostrar.Click += new System.EventHandler(this.btbmostrar_Click);
            // 
            // btbocultar
            // 
            this.btbocultar.Location = new System.Drawing.Point(350, 377);
            this.btbocultar.Name = "btbocultar";
            this.btbocultar.Size = new System.Drawing.Size(75, 23);
            this.btbocultar.TabIndex = 72;
            this.btbocultar.Text = "Ocultar";
            this.btbocultar.UseVisualStyleBackColor = true;
            this.btbocultar.Click += new System.EventHandler(this.btbocultar_Click);
            // 
            // btblimpiar
            // 
            this.btblimpiar.Location = new System.Drawing.Point(647, 258);
            this.btblimpiar.Name = "btblimpiar";
            this.btblimpiar.Size = new System.Drawing.Size(80, 23);
            this.btblimpiar.TabIndex = 73;
            this.btblimpiar.Text = "Limpiar datos";
            this.btblimpiar.UseVisualStyleBackColor = true;
            this.btblimpiar.Click += new System.EventHandler(this.btblimpiar_Click);
            // 
            // frmagregarempleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(744, 562);
            this.Controls.Add(this.btblimpiar);
            this.Controls.Add(this.btbocultar);
            this.Controls.Add(this.btbmostrar);
            this.Controls.Add(this.dgvprueba);
            this.Controls.Add(this.cbestadodelempleado);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbnivelacademico);
            this.Controls.Add(this.lblnivelacademico);
            this.Controls.Add(this.txtcomentario);
            this.Controls.Add(this.lblcomentario);
            this.Controls.Add(this.txtsueldo);
            this.Controls.Add(this.lblsueldo);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.lblcodigoparaelempleado);
            this.Controls.Add(this.txtfechafinalizcontrato);
            this.Controls.Add(this.lblfechafinalcontrato);
            this.Controls.Add(this.lbseguromedico);
            this.Controls.Add(this.lblseguromedico);
            this.Controls.Add(this.txtnacionalidad);
            this.Controls.Add(this.lblnacionalidad);
            this.Controls.Add(this.txtfechadeingreso);
            this.Controls.Add(this.cbpuesto);
            this.Controls.Add(this.lblfechadeingreso);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtcedula);
            this.Controls.Add(this.lblnumerodetelefono);
            this.Controls.Add(this.lblcedula);
            this.Controls.Add(this.btbcancelar);
            this.Controls.Add(this.btbguardar);
            this.Controls.Add(this.gbsexo);
            this.Controls.Add(this.nupedad);
            this.Controls.Add(this.gbestadocivil);
            this.Controls.Add(this.lblpuestoaaspirar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtapellidos);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lblsexo);
            this.Controls.Add(this.lblestadocivil);
            this.Controls.Add(this.lbledad);
            this.Controls.Add(this.lblcorreo);
            this.Controls.Add(this.lbldireccion);
            this.Controls.Add(this.lblpapellido);
            this.Controls.Add(this.lblnombreempleado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmagregarempleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar empleado";
            this.Load += new System.EventHandler(this.frmagregarempleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbestadocivil.ResumeLayout(false);
            this.gbestadocivil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupedad)).EndInit();
            this.gbsexo.ResumeLayout(false);
            this.gbsexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprueba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnombreempleado;
        private System.Windows.Forms.Label lblpapellido;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.Label lblcorreo;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.Label lblestadocivil;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapellidos;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblpuestoaaspirar;
        private System.Windows.Forms.GroupBox gbestadocivil;
        private System.Windows.Forms.RadioButton rbsoltero;
        private System.Windows.Forms.RadioButton rbcasado;
        private System.Windows.Forms.NumericUpDown nupedad;
        private System.Windows.Forms.RadioButton rbmasculino;
        private System.Windows.Forms.RadioButton rbfemenino;
        private System.Windows.Forms.GroupBox gbsexo;
        private System.Windows.Forms.Button btbguardar;
        private System.Windows.Forms.Button btbcancelar;
        private System.Windows.Forms.Label lblcedula;
        private System.Windows.Forms.Label lblnumerodetelefono;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label lblfechadeingreso;
        private System.Windows.Forms.ComboBox cbpuesto;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtfechadeingreso;
        private System.Windows.Forms.Label lblnacionalidad;
        private System.Windows.Forms.TextBox txtnacionalidad;
        private System.Windows.Forms.Label lblseguromedico;
        private System.Windows.Forms.ListBox lbseguromedico;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label lblfechafinalcontrato;
        private System.Windows.Forms.TextBox txtfechafinalizcontrato;
        private System.Windows.Forms.Label lblcodigoparaelempleado;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lblsueldo;
        private System.Windows.Forms.TextBox txtsueldo;
        private System.Windows.Forms.Label lblcomentario;
        private System.Windows.Forms.TextBox txtcomentario;
        private System.Windows.Forms.Label lblnivelacademico;
        private System.Windows.Forms.ComboBox cbnivelacademico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.ComboBox cbestadodelempleado;
        private System.Windows.Forms.DataGridView dgvprueba;
        private System.Windows.Forms.Button btbmostrar;
        private System.Windows.Forms.Button btbocultar;
        private System.Windows.Forms.Button btblimpiar;
    }
}