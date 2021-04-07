namespace WindowsFormsApplication1
{
    partial class AñadirUsuario
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dnitextBox1 = new System.Windows.Forms.TextBox();
            this.addresstextBox2 = new System.Windows.Forms.TextBox();
            this.nametextBox3 = new System.Windows.Forms.TextBox();
            this.zipCodetextBox4 = new System.Windows.Forms.TextBox();
            this.ibantextBox5 = new System.Windows.Forms.TextBox();
            this.birthDatedateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Añadir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ZipCode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "IBAN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Birth Date";
            // 
            // dnitextBox1
            // 
            this.dnitextBox1.Location = new System.Drawing.Point(101, 17);
            this.dnitextBox1.Name = "dnitextBox1";
            this.dnitextBox1.Size = new System.Drawing.Size(100, 20);
            this.dnitextBox1.TabIndex = 6;
            // 
            // addresstextBox2
            // 
            this.addresstextBox2.Location = new System.Drawing.Point(101, 57);
            this.addresstextBox2.Name = "addresstextBox2";
            this.addresstextBox2.Size = new System.Drawing.Size(168, 20);
            this.addresstextBox2.TabIndex = 7;
            // 
            // nametextBox3
            // 
            this.nametextBox3.Location = new System.Drawing.Point(101, 97);
            this.nametextBox3.Name = "nametextBox3";
            this.nametextBox3.Size = new System.Drawing.Size(100, 20);
            this.nametextBox3.TabIndex = 8;
            // 
            // zipCodetextBox4
            // 
            this.zipCodetextBox4.Location = new System.Drawing.Point(101, 138);
            this.zipCodetextBox4.Name = "zipCodetextBox4";
            this.zipCodetextBox4.Size = new System.Drawing.Size(65, 20);
            this.zipCodetextBox4.TabIndex = 9;
            // 
            // ibantextBox5
            // 
            this.ibantextBox5.Location = new System.Drawing.Point(101, 178);
            this.ibantextBox5.Name = "ibantextBox5";
            this.ibantextBox5.Size = new System.Drawing.Size(168, 20);
            this.ibantextBox5.TabIndex = 10;
            // 
            // birthDatedateTimePicker1
            // 
            this.birthDatedateTimePicker1.Location = new System.Drawing.Point(101, 214);
            this.birthDatedateTimePicker1.Name = "birthDatedateTimePicker1";
            this.birthDatedateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.birthDatedateTimePicker1.TabIndex = 11;
            this.birthDatedateTimePicker1.ValueChanged += new System.EventHandler(this.birthDatedateTimePicker1_ValueChanged);
            // 
            // Añadir
            // 
            this.Añadir.Location = new System.Drawing.Point(226, 257);
            this.Añadir.Name = "Añadir";
            this.Añadir.Size = new System.Drawing.Size(75, 23);
            this.Añadir.TabIndex = 12;
            this.Añadir.Text = "Añadir";
            this.Añadir.UseVisualStyleBackColor = true;
            this.Añadir.Click += new System.EventHandler(this.Añadir_Click);
            // 
            // AñadirUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 301);
            this.Controls.Add(this.Añadir);
            this.Controls.Add(this.birthDatedateTimePicker1);
            this.Controls.Add(this.ibantextBox5);
            this.Controls.Add(this.zipCodetextBox4);
            this.Controls.Add(this.nametextBox3);
            this.Controls.Add(this.addresstextBox2);
            this.Controls.Add(this.dnitextBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AñadirUsuario";
            this.Text = "Añadir Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox dnitextBox1;
        private System.Windows.Forms.TextBox addresstextBox2;
        private System.Windows.Forms.TextBox nametextBox3;
        private System.Windows.Forms.TextBox zipCodetextBox4;
        private System.Windows.Forms.TextBox ibantextBox5;
        private System.Windows.Forms.DateTimePicker birthDatedateTimePicker1;
        private System.Windows.Forms.Button Añadir;
    }
}