namespace WindowsFormsApplication1
{
    partial class AsignarEstudianteACurso
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
            this.CursoComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DniTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.VolverButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Curso";
            // 
            // CursoComboBox
            // 
            this.CursoComboBox.FormattingEnabled = true;
            this.CursoComboBox.Location = new System.Drawing.Point(123, 49);
            this.CursoComboBox.Name = "CursoComboBox";
            this.CursoComboBox.Size = new System.Drawing.Size(121, 21);
            this.CursoComboBox.TabIndex = 1;
            this.CursoComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DNI";
            // 
            // DniTextBox
            // 
            this.DniTextBox.Location = new System.Drawing.Point(123, 101);
            this.DniTextBox.Name = "DniTextBox";
            this.DniTextBox.Size = new System.Drawing.Size(121, 20);
            this.DniTextBox.TabIndex = 3;
            this.DniTextBox.TextChanged += new System.EventHandler(this.DniTextBox_TextChanged);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(169, 151);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Añadir";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // VolverButton
            // 
            this.VolverButton.Location = new System.Drawing.Point(48, 151);
            this.VolverButton.Name = "VolverButton";
            this.VolverButton.Size = new System.Drawing.Size(75, 23);
            this.VolverButton.TabIndex = 5;
            this.VolverButton.Text = "Volver";
            this.VolverButton.UseVisualStyleBackColor = true;
            this.VolverButton.Click += new System.EventHandler(this.VolverButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Asignar estudiante a un curso:";
            // 
            // AsignarEstudianteACurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 204);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VolverButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DniTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CursoComboBox);
            this.Controls.Add(this.label1);
            this.Name = "AsignarEstudianteACurso";
            this.Text = "AsignarEstudianteACurso";
            this.Load += new System.EventHandler(this.AsignarEstudianteACurso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CursoComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DniTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button VolverButton;
        private System.Windows.Forms.Label label3;
    }
}