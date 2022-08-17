namespace Demo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Indicador = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Cargar = new System.Windows.Forms.Button();
            this.textParv = new System.Windows.Forms.TextBox();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demoDataSet = new Demo.DemoDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboProd = new System.Windows.Forms.ComboBox();
            this.PanelOc = new System.Windows.Forms.Panel();
            this.Fecha = new System.Windows.Forms.Label();
            this.Hora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.casetaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.demoDataSet1 = new Demo.DemoDataSet1();
            this.panel2 = new System.Windows.Forms.Panel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reImpresiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textPuerto = new System.Windows.Forms.TextBox();
            this.textBaudio = new System.Windows.Forms.TextBox();
            this.Guardar = new System.Windows.Forms.Button();
            this.puertosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demoDataSetPuertosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demoDataSetPuertos = new Demo.DemoDataSetPuertos();
            this.checkConf = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.productoTableAdapter1 = new Demo.DemoDataSet1TableAdapters.ProductoTableAdapter();
            this.productoTableAdapter = new Demo.DemoDataSetTableAdapters.ProductoTableAdapter();
            this.baudiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demoDataSetBaudios = new Demo.DemoDataSetBaudios();
            this.puertosTableAdapter = new Demo.DemoDataSetPuertosTableAdapters.PuertosTableAdapter();
            this.baudiosTableAdapter = new Demo.DemoDataSetBaudiosTableAdapters.BaudiosTableAdapter();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSet1)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.puertosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSetPuertosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSetPuertos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baudiosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSetBaudios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Indicador
            // 
            this.Indicador.AutoEllipsis = true;
            this.Indicador.AutoSize = true;
            this.Indicador.BackColor = System.Drawing.Color.Black;
            this.Indicador.Font = new System.Drawing.Font("digital display tfb", 150F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Indicador.ForeColor = System.Drawing.Color.Red;
            this.Indicador.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Indicador.Location = new System.Drawing.Point(3, 17);
            this.Indicador.Name = "Indicador";
            this.Indicador.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Indicador.Size = new System.Drawing.Size(620, 209);
            this.Indicador.TabIndex = 0;
            this.Indicador.Text = "0000000";
            this.Indicador.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1160, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 61);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kg";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Cargar);
            this.panel1.Controls.Add(this.textParv);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboProd);
            this.panel1.Location = new System.Drawing.Point(12, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 176);
            this.panel1.TabIndex = 3;
            // 
            // Cargar
            // 
            this.Cargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cargar.Location = new System.Drawing.Point(130, 119);
            this.Cargar.Name = "Cargar";
            this.Cargar.Size = new System.Drawing.Size(240, 39);
            this.Cargar.TabIndex = 9;
            this.Cargar.Text = "Imprimir";
            this.Cargar.UseVisualStyleBackColor = true;
            this.Cargar.Click += new System.EventHandler(this.Cargar_Click);
            // 
            // textParv
            // 
            this.textParv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "caseta", true));
            this.textParv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textParv.Location = new System.Drawing.Point(192, 64);
            this.textParv.Name = "textParv";
            this.textParv.Size = new System.Drawing.Size(121, 31);
            this.textParv.TabIndex = 8;
            this.textParv.Click += new System.EventHandler(this.textParv_Click);
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.demoDataSet;
            // 
            // demoDataSet
            // 
            this.demoDataSet.DataSetName = "DemoDataSet";
            this.demoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Parvada/Caseta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tipo de producto";
            // 
            // comboProd
            // 
            this.comboProd.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.productoBindingSource, "TProducto", true));
            this.comboProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboProd.FormattingEnabled = true;
            this.comboProd.Items.AddRange(new object[] {
            "Huevo",
            "Jumbo",
            "Sucio",
            "Fragil"});
            this.comboProd.Location = new System.Drawing.Point(192, 10);
            this.comboProd.Name = "comboProd";
            this.comboProd.Size = new System.Drawing.Size(121, 33);
            this.comboProd.TabIndex = 0;
            // 
            // PanelOc
            // 
            this.PanelOc.Location = new System.Drawing.Point(12, 264);
            this.PanelOc.Name = "PanelOc";
            this.PanelOc.Size = new System.Drawing.Size(447, 100);
            this.PanelOc.TabIndex = 13;
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.Location = new System.Drawing.Point(1220, 35);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(118, 25);
            this.Fecha.TabIndex = 4;
            this.Fecha.Text = "DD/MM/AA";
            // 
            // Hora
            // 
            this.Hora.AutoSize = true;
            this.Hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora.Location = new System.Drawing.Point(1220, 66);
            this.Hora.Name = "Hora";
            this.Hora.Size = new System.Drawing.Size(122, 25);
            this.Hora.TabIndex = 5;
            this.Hora.Text = "HH/MM/PM";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProductoDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn,
            this.pesoDataGridViewTextBoxColumn,
            this.tProductoDataGridViewTextBoxColumn,
            this.casetaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productoBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(21, 370);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1289, 285);
            this.dataGridView1.TabIndex = 6;
            // 
            // idProductoDataGridViewTextBoxColumn
            // 
            this.idProductoDataGridViewTextBoxColumn.DataPropertyName = "IdProducto";
            this.idProductoDataGridViewTextBoxColumn.HeaderText = "IdProducto";
            this.idProductoDataGridViewTextBoxColumn.Name = "idProductoDataGridViewTextBoxColumn";
            this.idProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // horaDataGridViewTextBoxColumn
            // 
            this.horaDataGridViewTextBoxColumn.DataPropertyName = "Hora";
            this.horaDataGridViewTextBoxColumn.HeaderText = "Hora";
            this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            // 
            // pesoDataGridViewTextBoxColumn
            // 
            this.pesoDataGridViewTextBoxColumn.DataPropertyName = "Peso";
            this.pesoDataGridViewTextBoxColumn.HeaderText = "Peso";
            this.pesoDataGridViewTextBoxColumn.Name = "pesoDataGridViewTextBoxColumn";
            // 
            // tProductoDataGridViewTextBoxColumn
            // 
            this.tProductoDataGridViewTextBoxColumn.DataPropertyName = "TProducto";
            this.tProductoDataGridViewTextBoxColumn.HeaderText = "TProducto";
            this.tProductoDataGridViewTextBoxColumn.Name = "tProductoDataGridViewTextBoxColumn";
            // 
            // casetaDataGridViewTextBoxColumn
            // 
            this.casetaDataGridViewTextBoxColumn.DataPropertyName = "caseta";
            this.casetaDataGridViewTextBoxColumn.HeaderText = "caseta";
            this.casetaDataGridViewTextBoxColumn.Name = "casetaDataGridViewTextBoxColumn";
            // 
            // productoBindingSource1
            // 
            this.productoBindingSource1.DataMember = "Producto";
            this.productoBindingSource1.DataSource = this.demoDataSet1;
            // 
            // demoDataSet1
            // 
            this.demoDataSet1.DataSetName = "DemoDataSet1";
            this.demoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.Indicador);
            this.panel2.Location = new System.Drawing.Point(556, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(598, 238);
            this.panel2.TabIndex = 7;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 33);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reImpresiónToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.inicioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(70, 29);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // reImpresiónToolStripMenuItem
            // 
            this.reImpresiónToolStripMenuItem.Name = "reImpresiónToolStripMenuItem";
            this.reImpresiónToolStripMenuItem.Size = new System.Drawing.Size(204, 30);
            this.reImpresiónToolStripMenuItem.Text = "Re impresión";
            this.reImpresiónToolStripMenuItem.Click += new System.EventHandler(this.reImpresiónToolStripMenuItem_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.textPuerto);
            this.panel3.Controls.Add(this.textBaudio);
            this.panel3.Controls.Add(this.Guardar);
            this.panel3.Location = new System.Drawing.Point(12, 264);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(447, 100);
            this.panel3.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(349, 54);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 32);
            this.button3.TabIndex = 16;
            this.button3.Text = "Aceptar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(8, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 32);
            this.button2.TabIndex = 15;
            this.button2.Text = "Restablecer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(225, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Baudios";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Puerto";
            // 
            // textPuerto
            // 
            this.textPuerto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "caseta", true));
            this.textPuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPuerto.Location = new System.Drawing.Point(84, 10);
            this.textPuerto.Name = "textPuerto";
            this.textPuerto.Size = new System.Drawing.Size(121, 31);
            this.textPuerto.TabIndex = 12;
            this.textPuerto.Click += new System.EventHandler(this.textPuerto_Click);
            // 
            // textBaudio
            // 
            this.textBaudio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "caseta", true));
            this.textBaudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBaudio.Location = new System.Drawing.Point(319, 7);
            this.textBaudio.Name = "textBaudio";
            this.textBaudio.Size = new System.Drawing.Size(121, 31);
            this.textBaudio.TabIndex = 17;
            this.textBaudio.Click += new System.EventHandler(this.textBaudio_Click);
            // 
            // Guardar
            // 
            this.Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar.Location = new System.Drawing.Point(238, 54);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(91, 32);
            this.Guardar.TabIndex = 18;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.button5_Click);
            // 
            // puertosBindingSource
            // 
            this.puertosBindingSource.DataMember = "Puertos";
            this.puertosBindingSource.DataSource = this.demoDataSetPuertosBindingSource;
            // 
            // demoDataSetPuertosBindingSource
            // 
            this.demoDataSetPuertosBindingSource.DataSource = this.demoDataSetPuertos;
            this.demoDataSetPuertosBindingSource.Position = 0;
            // 
            // demoDataSetPuertos
            // 
            this.demoDataSetPuertos.DataSetName = "DemoDataSetPuertos";
            this.demoDataSetPuertos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkConf
            // 
            this.checkConf.AutoSize = true;
            this.checkConf.Location = new System.Drawing.Point(21, 680);
            this.checkConf.Name = "checkConf";
            this.checkConf.Size = new System.Drawing.Size(91, 17);
            this.checkConf.TabIndex = 14;
            this.checkConf.Text = "Configuración";
            this.checkConf.UseVisualStyleBackColor = true;
            this.checkConf.CheckedChanged += new System.EventHandler(this.checkConf_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(131, 672);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 15;
            this.textBox1.Visible = false;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(243, 667);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 37);
            this.button4.TabIndex = 16;
            this.button4.Text = "Aceptar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // productoTableAdapter1
            // 
            this.productoTableAdapter1.ClearBeforeFill = true;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // baudiosBindingSource
            // 
            this.baudiosBindingSource.DataMember = "Baudios";
            this.baudiosBindingSource.DataSource = this.demoDataSetBaudios;
            // 
            // demoDataSetBaudios
            // 
            this.demoDataSetBaudios.DataSetName = "DemoDataSetBaudios";
            this.demoDataSetBaudios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // puertosTableAdapter
            // 
            this.puertosTableAdapter.ClearBeforeFill = true;
            // 
            // baudiosTableAdapter
            // 
            this.baudiosTableAdapter.ClearBeforeFill = true;
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(204, 30);
            this.reportesToolStripMenuItem.Text = "Reportes";
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(556, 301);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.Image = global::Demo.Properties.Resources.Correcto;
            this.button1.Location = new System.Drawing.Point(319, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 48);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(193, 30);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(160, 54);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 32);
            this.button5.TabIndex = 19;
            this.button5.Text = "Ok";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkConf);
            this.Controls.Add(this.PanelOc);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Hora);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Comercializadora Hustle Co";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSet1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.puertosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSetPuertosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSetPuertos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baudiosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSetBaudios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DemoDataSet demoDataSet;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private DemoDataSetTableAdapters.ProductoTableAdapter productoTableAdapter;
        private System.Windows.Forms.Label Indicador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboProd;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.Label Hora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textParv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Cargar;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button1;
        private DemoDataSet1 demoDataSet1;
        private System.Windows.Forms.BindingSource productoBindingSource1;
        private DemoDataSet1TableAdapters.ProductoTableAdapter productoTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn casetaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reImpresiónToolStripMenuItem;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.BindingSource demoDataSetPuertosBindingSource;
        private DemoDataSetPuertos demoDataSetPuertos;
        private System.Windows.Forms.BindingSource puertosBindingSource;
        private DemoDataSetPuertosTableAdapters.PuertosTableAdapter puertosTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private DemoDataSetBaudios demoDataSetBaudios;
        private System.Windows.Forms.BindingSource baudiosBindingSource;
        private DemoDataSetBaudiosTableAdapters.BaudiosTableAdapter baudiosTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkConf;
        public System.Windows.Forms.Panel PanelOc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBaudio;
        private System.Windows.Forms.TextBox textPuerto;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button button5;
    }
}

