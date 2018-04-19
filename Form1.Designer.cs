namespace AppOrga
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.botonEjecutar = new System.Windows.Forms.Button();
            this.cajaTiempo = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cajaVelocidad = new System.Windows.Forms.ComboBox();
            this.botonAbajo = new System.Windows.Forms.Button();
            this.botonDer = new System.Windows.Forms.Button();
            this.botonIzq = new System.Windows.Forms.Button();
            this.botonArriba = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cajaTiempo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(727, 456);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkGreen;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.botonEjecutar);
            this.tabPage1.Controls.Add(this.cajaTiempo);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cajaVelocidad);
            this.tabPage1.Controls.Add(this.botonAbajo);
            this.tabPage1.Controls.Add(this.botonDer);
            this.tabPage1.Controls.Add(this.botonIzq);
            this.tabPage1.Controls.Add(this.botonArriba);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(719, 430);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Modo Cableado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(444, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "label6";
            // 
            // botonEjecutar
            // 
            this.botonEjecutar.BackColor = System.Drawing.Color.Black;
            this.botonEjecutar.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonEjecutar.Location = new System.Drawing.Point(471, 326);
            this.botonEjecutar.Name = "botonEjecutar";
            this.botonEjecutar.Size = new System.Drawing.Size(153, 43);
            this.botonEjecutar.TabIndex = 12;
            this.botonEjecutar.Text = "Ejecutar";
            this.botonEjecutar.UseVisualStyleBackColor = false;
            this.botonEjecutar.Click += new System.EventHandler(this.botonEjecutar_Click);
            // 
            // cajaTiempo
            // 
            this.cajaTiempo.Location = new System.Drawing.Point(143, 348);
            this.cajaTiempo.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.cajaTiempo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cajaTiempo.Name = "cajaTiempo";
            this.cajaTiempo.Size = new System.Drawing.Size(120, 20);
            this.cajaTiempo.TabIndex = 11;
            this.cajaTiempo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(442, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cantidad de choques:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(442, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cantidad de Baches:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(442, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Distancia recorrida:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(47, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tiempo (s)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(44, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Velocidad";
            // 
            // cajaVelocidad
            // 
            this.cajaVelocidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cajaVelocidad.FormattingEnabled = true;
            this.cajaVelocidad.Items.AddRange(new object[] {
            "Alta ",
            "Media ",
            "Baja"});
            this.cajaVelocidad.Location = new System.Drawing.Point(143, 292);
            this.cajaVelocidad.Name = "cajaVelocidad";
            this.cajaVelocidad.Size = new System.Drawing.Size(121, 21);
            this.cajaVelocidad.TabIndex = 4;
            // 
            // botonAbajo
            // 
            this.botonAbajo.BackgroundImage = global::AppOrga.Properties.Resources.down;
            this.botonAbajo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonAbajo.Location = new System.Drawing.Point(158, 177);
            this.botonAbajo.Name = "botonAbajo";
            this.botonAbajo.Size = new System.Drawing.Size(56, 45);
            this.botonAbajo.TabIndex = 3;
            this.botonAbajo.UseVisualStyleBackColor = true;
            this.botonAbajo.Click += new System.EventHandler(this.botonAbajo_Click);
            // 
            // botonDer
            // 
            this.botonDer.BackgroundImage = global::AppOrga.Properties.Resources.rightP;
            this.botonDer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonDer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.botonDer.Location = new System.Drawing.Point(238, 102);
            this.botonDer.Name = "botonDer";
            this.botonDer.Size = new System.Drawing.Size(64, 43);
            this.botonDer.TabIndex = 2;
            this.botonDer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonDer.UseVisualStyleBackColor = true;
            this.botonDer.Click += new System.EventHandler(this.botonDer_Click);
            // 
            // botonIzq
            // 
            this.botonIzq.BackgroundImage = global::AppOrga.Properties.Resources.leftP;
            this.botonIzq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonIzq.Location = new System.Drawing.Point(71, 102);
            this.botonIzq.Name = "botonIzq";
            this.botonIzq.Size = new System.Drawing.Size(64, 43);
            this.botonIzq.TabIndex = 1;
            this.botonIzq.UseVisualStyleBackColor = true;
            this.botonIzq.Click += new System.EventHandler(this.botonIzq_Click);
            // 
            // botonArriba
            // 
            this.botonArriba.Image = global::AppOrga.Properties.Resources.up;
            this.botonArriba.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.botonArriba.Location = new System.Drawing.Point(158, 27);
            this.botonArriba.Name = "botonArriba";
            this.botonArriba.Size = new System.Drawing.Size(56, 43);
            this.botonArriba.TabIndex = 0;
            this.botonArriba.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonArriba.UseVisualStyleBackColor = true;
            this.botonArriba.Click += new System.EventHandler(this.botonArriba_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(719, 430);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modo Inalambrico";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(751, 480);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cajaTiempo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button botonAbajo;
        private System.Windows.Forms.Button botonDer;
        private System.Windows.Forms.Button botonIzq;
        private System.Windows.Forms.Button botonArriba;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cajaVelocidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown cajaTiempo;
        private System.Windows.Forms.Button botonEjecutar;
        private System.Windows.Forms.Label label6;
    }
}

