namespace Demo
{
    partial class Configuracion
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBaudio = new System.Windows.Forms.ComboBox();
            this.comboPuerto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.baudiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demoDataSetBaudios = new Demo.DemoDataSetBaudios();
            this.puertosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demoDataSetPuertos = new Demo.DemoDataSetPuertos();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.puertosTableAdapter = new Demo.DemoDataSetPuertosTableAdapters.PuertosTableAdapter();
            this.baudiosTableAdapter = new Demo.DemoDataSetBaudiosTableAdapters.BaudiosTableAdapter();
            this.updateOrderOptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demoDataSetPuertos2 = new Demo.DemoDataSetPuertos2();
            this.puertosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.puertosTableAdapter1 = new Demo.DemoDataSetPuertos2TableAdapters.PuertosTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baudiosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSetBaudios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puertosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSetPuertos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateOrderOptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSetPuertos2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puertosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.comboBaudio);
            this.panel1.Controls.Add(this.comboPuerto);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 214);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(22, 167);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 33);
            this.button3.TabIndex = 6;
            this.button3.Text = "Nuevo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(305, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Aplicar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBaudio
            // 
            this.comboBaudio.DataSource = this.baudiosBindingSource;
            this.comboBaudio.DisplayMember = "Baudio";
            this.comboBaudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBaudio.FormattingEnabled = true;
            this.comboBaudio.Location = new System.Drawing.Point(139, 83);
            this.comboBaudio.Name = "comboBaudio";
            this.comboBaudio.Size = new System.Drawing.Size(121, 32);
            this.comboBaudio.TabIndex = 3;
            // 
            // comboPuerto
            // 
            this.comboPuerto.AutoCompleteCustomSource.AddRange(new string[] {
            ""});
            this.comboPuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPuerto.FormattingEnabled = true;
            this.comboPuerto.Location = new System.Drawing.Point(139, 40);
            this.comboPuerto.Name = "comboPuerto";
            this.comboPuerto.Size = new System.Drawing.Size(121, 32);
            this.comboPuerto.TabIndex = 2;
            this.comboPuerto.SelectedIndexChanged += new System.EventHandler(this.comboPuerto_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baudios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Puerto";
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
            // puertosBindingSource
            // 
            this.puertosBindingSource.DataMember = "Puertos";
            this.puertosBindingSource.DataSource = this.demoDataSetPuertos;
            // 
            // demoDataSetPuertos
            // 
            this.demoDataSetPuertos.DataSetName = "DemoDataSetPuertos";
            this.demoDataSetPuertos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // puertosTableAdapter
            // 
            this.puertosTableAdapter.ClearBeforeFill = true;
            // 
            // baudiosTableAdapter
            // 
            this.baudiosTableAdapter.ClearBeforeFill = true;
            // 
            // updateOrderOptionBindingSource
            // 
            this.updateOrderOptionBindingSource.DataSource = typeof(Demo.DemoDataSetPuertosTableAdapters.TableAdapterManager.UpdateOrderOption);
            // 
            // demoDataSetPuertos2
            // 
            this.demoDataSetPuertos2.DataSetName = "DemoDataSetPuertos2";
            this.demoDataSetPuertos2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // puertosBindingSource1
            // 
            this.puertosBindingSource1.DataMember = "Puertos";
            this.puertosBindingSource1.DataSource = this.demoDataSetPuertos2;
            // 
            // puertosTableAdapter1
            // 
            this.puertosTableAdapter1.ClearBeforeFill = true;
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(433, 239);
            this.Controls.Add(this.panel1);
            this.Name = "Configuracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración";
            this.Load += new System.EventHandler(this.Configuracion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baudiosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSetBaudios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puertosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSetPuertos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateOrderOptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSetPuertos2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puertosBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox comboBaudio;
        public System.Windows.Forms.ComboBox comboPuerto;
        private System.Windows.Forms.Button button3;
        private DemoDataSetPuertos demoDataSetPuertos;
        private System.Windows.Forms.BindingSource puertosBindingSource;
        private DemoDataSetPuertosTableAdapters.PuertosTableAdapter puertosTableAdapter;
        private DemoDataSetBaudios demoDataSetBaudios;
        private System.Windows.Forms.BindingSource baudiosBindingSource;
        private DemoDataSetBaudiosTableAdapters.BaudiosTableAdapter baudiosTableAdapter;
        private System.Windows.Forms.BindingSource updateOrderOptionBindingSource;
        private DemoDataSetPuertos2 demoDataSetPuertos2;
        private System.Windows.Forms.BindingSource puertosBindingSource1;
        private DemoDataSetPuertos2TableAdapters.PuertosTableAdapter puertosTableAdapter1;
    }
}