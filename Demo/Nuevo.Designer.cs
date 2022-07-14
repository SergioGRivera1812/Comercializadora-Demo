namespace Demo
{
    partial class Nuevo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AñadirP = new System.Windows.Forms.Button();
            this.Puerto = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AñadirB = new System.Windows.Forms.Button();
            this.Baudio = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Puerto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baudio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Añadir Nuevo Atributo";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.AñadirP);
            this.panel1.Controls.Add(this.Puerto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 166);
            this.panel1.TabIndex = 3;
            // 
            // AñadirP
            // 
            this.AñadirP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AñadirP.Location = new System.Drawing.Point(24, 125);
            this.AñadirP.Name = "AñadirP";
            this.AñadirP.Size = new System.Drawing.Size(100, 29);
            this.AñadirP.TabIndex = 2;
            this.AñadirP.Text = "Añadir";
            this.AñadirP.UseVisualStyleBackColor = true;
            this.AñadirP.Click += new System.EventHandler(this.AñadirP_Click);
            // 
            // Puerto
            // 
            this.Puerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Puerto.Location = new System.Drawing.Point(24, 78);
            this.Puerto.Name = "Puerto";
            this.Puerto.Size = new System.Drawing.Size(100, 29);
            this.Puerto.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.AñadirB);
            this.panel2.Controls.Add(this.Baudio);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(268, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(153, 166);
            this.panel2.TabIndex = 4;
            // 
            // AñadirB
            // 
            this.AñadirB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AñadirB.Location = new System.Drawing.Point(28, 125);
            this.AñadirB.Name = "AñadirB";
            this.AñadirB.Size = new System.Drawing.Size(100, 29);
            this.AñadirB.TabIndex = 3;
            this.AñadirB.Text = "Añadir";
            this.AñadirB.UseVisualStyleBackColor = true;
            this.AñadirB.Click += new System.EventHandler(this.AñadirB_Click);
            // 
            // Baudio
            // 
            this.Baudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Baudio.Location = new System.Drawing.Point(28, 78);
            this.Baudio.Name = "Baudio";
            this.Baudio.Size = new System.Drawing.Size(100, 29);
            this.Baudio.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(321, 238);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 29);
            this.button3.TabIndex = 3;
            this.button3.Text = "Aceptar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Nuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(433, 279);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Nuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AñadirP;
        private System.Windows.Forms.TextBox Puerto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AñadirB;
        private System.Windows.Forms.TextBox Baudio;
        private System.Windows.Forms.Button button3;
    }
}