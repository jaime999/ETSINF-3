namespace Proyecto.GUI
{
    partial class AsignarProfesor
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
            this.button1 = new System.Windows.Forms.Button();
            this.ProfesorBox = new System.Windows.Forms.TextBox();
            this.DescBox = new System.Windows.Forms.TextBox();
            this.NombreBox = new System.Windows.Forms.TextBox();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MinutosFin = new System.Windows.Forms.TextBox();
            this.HoraFin = new System.Windows.Forms.TextBox();
            this.MinutosInicio = new System.Windows.Forms.TextBox();
            this.HoraInicio = new System.Windows.Forms.TextBox();
            this.AnyoInicio = new System.Windows.Forms.TextBox();
            this.MesInicio = new System.Windows.Forms.TextBox();
            this.DiaInicio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DiaImpartidoTextBox = new System.Windows.Forms.TextBox();
            this.Precio = new System.Windows.Forms.Label();
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.DuracionTextBox = new System.Windows.Forms.TextBox();
            this.CuotaTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(412, 521);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Asignar Profesor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProfesorBox
            // 
            this.ProfesorBox.Enabled = false;
            this.ProfesorBox.Location = new System.Drawing.Point(245, 483);
            this.ProfesorBox.Name = "ProfesorBox";
            this.ProfesorBox.Size = new System.Drawing.Size(236, 20);
            this.ProfesorBox.TabIndex = 26;
            // 
            // DescBox
            // 
            this.DescBox.Enabled = false;
            this.DescBox.Location = new System.Drawing.Point(218, 143);
            this.DescBox.Name = "DescBox";
            this.DescBox.Size = new System.Drawing.Size(263, 20);
            this.DescBox.TabIndex = 25;
            // 
            // NombreBox
            // 
            this.NombreBox.Enabled = false;
            this.NombreBox.Location = new System.Drawing.Point(218, 117);
            this.NombreBox.Name = "NombreBox";
            this.NombreBox.Size = new System.Drawing.Size(263, 20);
            this.NombreBox.TabIndex = 24;
            // 
            // IdBox
            // 
            this.IdBox.Enabled = false;
            this.IdBox.Location = new System.Drawing.Point(218, 91);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(263, 20);
            this.IdBox.TabIndex = 23;
            this.IdBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(245, 521);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(161, 21);
            this.comboBox2.TabIndex = 22;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(138, 529);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Profesor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 490);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Profesor del curso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Información del curso:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(128, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(353, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Curso impartido";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MinutosFin
            // 
            this.MinutosFin.Enabled = false;
            this.MinutosFin.Location = new System.Drawing.Point(289, 355);
            this.MinutosFin.Name = "MinutosFin";
            this.MinutosFin.Size = new System.Drawing.Size(32, 20);
            this.MinutosFin.TabIndex = 46;
            // 
            // HoraFin
            // 
            this.HoraFin.Enabled = false;
            this.HoraFin.Location = new System.Drawing.Point(235, 355);
            this.HoraFin.Name = "HoraFin";
            this.HoraFin.Size = new System.Drawing.Size(32, 20);
            this.HoraFin.TabIndex = 45;
            // 
            // MinutosInicio
            // 
            this.MinutosInicio.Enabled = false;
            this.MinutosInicio.Location = new System.Drawing.Point(449, 322);
            this.MinutosInicio.Name = "MinutosInicio";
            this.MinutosInicio.Size = new System.Drawing.Size(32, 20);
            this.MinutosInicio.TabIndex = 44;
            // 
            // HoraInicio
            // 
            this.HoraInicio.Enabled = false;
            this.HoraInicio.Location = new System.Drawing.Point(395, 322);
            this.HoraInicio.Name = "HoraInicio";
            this.HoraInicio.Size = new System.Drawing.Size(32, 20);
            this.HoraInicio.TabIndex = 43;
            // 
            // AnyoInicio
            // 
            this.AnyoInicio.Enabled = false;
            this.AnyoInicio.Location = new System.Drawing.Point(331, 322);
            this.AnyoInicio.Name = "AnyoInicio";
            this.AnyoInicio.Size = new System.Drawing.Size(51, 20);
            this.AnyoInicio.TabIndex = 42;
            // 
            // MesInicio
            // 
            this.MesInicio.Enabled = false;
            this.MesInicio.Location = new System.Drawing.Point(283, 322);
            this.MesInicio.Name = "MesInicio";
            this.MesInicio.Size = new System.Drawing.Size(24, 20);
            this.MesInicio.TabIndex = 41;
            // 
            // DiaInicio
            // 
            this.DiaInicio.Enabled = false;
            this.DiaInicio.Location = new System.Drawing.Point(235, 322);
            this.DiaInicio.Name = "DiaInicio";
            this.DiaInicio.Size = new System.Drawing.Size(24, 20);
            this.DiaInicio.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(141, 422);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Día impartido";
            // 
            // DiaImpartidoTextBox
            // 
            this.DiaImpartidoTextBox.Enabled = false;
            this.DiaImpartidoTextBox.Location = new System.Drawing.Point(235, 419);
            this.DiaImpartidoTextBox.Name = "DiaImpartidoTextBox";
            this.DiaImpartidoTextBox.Size = new System.Drawing.Size(246, 20);
            this.DiaImpartidoTextBox.TabIndex = 38;
            // 
            // Precio
            // 
            this.Precio.AutoSize = true;
            this.Precio.Location = new System.Drawing.Point(141, 274);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(64, 13);
            this.Precio.TabIndex = 37;
            this.Precio.Text = "Precio Total";
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Enabled = false;
            this.PrecioTextBox.Location = new System.Drawing.Point(218, 271);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.Size = new System.Drawing.Size(263, 20);
            this.PrecioTextBox.TabIndex = 36;
            // 
            // DuracionTextBox
            // 
            this.DuracionTextBox.Enabled = false;
            this.DuracionTextBox.Location = new System.Drawing.Point(235, 385);
            this.DuracionTextBox.Name = "DuracionTextBox";
            this.DuracionTextBox.Size = new System.Drawing.Size(246, 20);
            this.DuracionTextBox.TabIndex = 35;
            // 
            // CuotaTextBox
            // 
            this.CuotaTextBox.Enabled = false;
            this.CuotaTextBox.Location = new System.Drawing.Point(218, 241);
            this.CuotaTextBox.Name = "CuotaTextBox";
            this.CuotaTextBox.Size = new System.Drawing.Size(263, 20);
            this.CuotaTextBox.TabIndex = 34;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Enabled = false;
            this.IDTextBox.Location = new System.Drawing.Point(218, 215);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(263, 20);
            this.IDTextBox.TabIndex = 33;
            this.IDTextBox.TextChanged += new System.EventHandler(this.IDTextBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(141, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(141, 388);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Duracion";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(141, 359);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Hora finalizacion";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(141, 329);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Fecha de inicio";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(141, 241);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Cuota";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(26, 182);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(156, 13);
            this.label14.TabIndex = 47;
            this.label14.Text = "Información del curso impartido:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(313, 325);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(12, 13);
            this.label15.TabIndex = 48;
            this.label15.Text = "/";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(265, 325);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(12, 13);
            this.label16.TabIndex = 49;
            this.label16.Text = "/";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(273, 358);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(10, 13);
            this.label17.TabIndex = 50;
            this.label17.Text = ":";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(433, 325);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(10, 13);
            this.label18.TabIndex = 51;
            this.label18.Text = ":";
            // 
            // AsignarProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 565);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.MinutosFin);
            this.Controls.Add(this.HoraFin);
            this.Controls.Add(this.MinutosInicio);
            this.Controls.Add(this.HoraInicio);
            this.Controls.Add(this.AnyoInicio);
            this.Controls.Add(this.MesInicio);
            this.Controls.Add(this.DiaInicio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DiaImpartidoTextBox);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.PrecioTextBox);
            this.Controls.Add(this.DuracionTextBox);
            this.Controls.Add(this.CuotaTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProfesorBox);
            this.Controls.Add(this.DescBox);
            this.Controls.Add(this.NombreBox);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "AsignarProfesor";
            this.Text = "Asignar Profesor";
            this.Load += new System.EventHandler(this.AsignarProfesor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ProfesorBox;
        private System.Windows.Forms.TextBox DescBox;
        private System.Windows.Forms.TextBox NombreBox;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MinutosFin;
        private System.Windows.Forms.TextBox HoraFin;
        private System.Windows.Forms.TextBox MinutosInicio;
        private System.Windows.Forms.TextBox HoraInicio;
        private System.Windows.Forms.TextBox AnyoInicio;
        private System.Windows.Forms.TextBox MesInicio;
        private System.Windows.Forms.TextBox DiaInicio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DiaImpartidoTextBox;
        private System.Windows.Forms.Label Precio;
        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.TextBox DuracionTextBox;
        private System.Windows.Forms.TextBox CuotaTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}