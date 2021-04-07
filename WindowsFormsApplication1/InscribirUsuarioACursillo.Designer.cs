namespace WindowsFormsApplication1
{
    partial class InscribirUsuarioACursillo
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
            this.label1 = new System.Windows.Forms.Label();
            this.dnitextBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.usuariodataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iBANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retiredDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ssnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discriminatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peopleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestDepDemo02DataSet = new WindowsFormsApplication1.GestDepDemo02DataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.cursillocomboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.peopleTableAdapter = new WindowsFormsApplication1.GestDepDemo02DataSetTableAdapters.PeopleTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usuariodataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestDepDemo02DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Cursillos";
            // 
            // dnitextBox1
            // 
            this.dnitextBox1.Location = new System.Drawing.Point(142, 55);
            this.dnitextBox1.Name = "dnitextBox1";
            this.dnitextBox1.Size = new System.Drawing.Size(100, 20);
            this.dnitextBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "DNI";
            // 
            // usuariodataGridView2
            // 
            this.usuariodataGridView2.AutoGenerateColumns = false;
            this.usuariodataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuariodataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.zipCodeDataGridViewTextBoxColumn,
            this.iBANDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn,
            this.retiredDataGridViewCheckBoxColumn,
            this.ssnDataGridViewTextBoxColumn,
            this.discriminatorDataGridViewTextBoxColumn});
            this.usuariodataGridView2.DataSource = this.peopleBindingSource;
            this.usuariodataGridView2.Location = new System.Drawing.Point(29, 123);
            this.usuariodataGridView2.Name = "usuariodataGridView2";
            this.usuariodataGridView2.Size = new System.Drawing.Size(491, 63);
            this.usuariodataGridView2.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // zipCodeDataGridViewTextBoxColumn
            // 
            this.zipCodeDataGridViewTextBoxColumn.DataPropertyName = "ZipCode";
            this.zipCodeDataGridViewTextBoxColumn.HeaderText = "ZipCode";
            this.zipCodeDataGridViewTextBoxColumn.Name = "zipCodeDataGridViewTextBoxColumn";
            // 
            // iBANDataGridViewTextBoxColumn
            // 
            this.iBANDataGridViewTextBoxColumn.DataPropertyName = "IBAN";
            this.iBANDataGridViewTextBoxColumn.HeaderText = "IBAN";
            this.iBANDataGridViewTextBoxColumn.Name = "iBANDataGridViewTextBoxColumn";
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.HeaderText = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            // 
            // retiredDataGridViewCheckBoxColumn
            // 
            this.retiredDataGridViewCheckBoxColumn.DataPropertyName = "Retired";
            this.retiredDataGridViewCheckBoxColumn.HeaderText = "Retired";
            this.retiredDataGridViewCheckBoxColumn.Name = "retiredDataGridViewCheckBoxColumn";
            // 
            // ssnDataGridViewTextBoxColumn
            // 
            this.ssnDataGridViewTextBoxColumn.DataPropertyName = "Ssn";
            this.ssnDataGridViewTextBoxColumn.HeaderText = "Ssn";
            this.ssnDataGridViewTextBoxColumn.Name = "ssnDataGridViewTextBoxColumn";
            // 
            // discriminatorDataGridViewTextBoxColumn
            // 
            this.discriminatorDataGridViewTextBoxColumn.DataPropertyName = "Discriminator";
            this.discriminatorDataGridViewTextBoxColumn.HeaderText = "Discriminator";
            this.discriminatorDataGridViewTextBoxColumn.Name = "discriminatorDataGridViewTextBoxColumn";
            // 
            // peopleBindingSource
            // 
            this.peopleBindingSource.DataMember = "People";
            this.peopleBindingSource.DataSource = this.gestDepDemo02DataSet;
            // 
            // gestDepDemo02DataSet
            // 
            this.gestDepDemo02DataSet.DataSetName = "GestDepDemo02DataSet";
            this.gestDepDemo02DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Usuario";
            // 
            // cursillocomboBox1
            // 
            this.cursillocomboBox1.FormattingEnabled = true;
            this.cursillocomboBox1.Location = new System.Drawing.Point(142, 19);
            this.cursillocomboBox1.Name = "cursillocomboBox1";
            this.cursillocomboBox1.Size = new System.Drawing.Size(121, 21);
            this.cursillocomboBox1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // peopleTableAdapter
            // 
            this.peopleTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Precio primera cuota:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "label5";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(331, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Confirmar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // InscribirUsuarioACursillo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 248);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cursillocomboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usuariodataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dnitextBox1);
            this.Controls.Add(this.label1);
            this.Name = "InscribirUsuarioACursillo";
            this.Text = "InscribirUsuarioACursillo";
            ((System.ComponentModel.ISupportInitialize)(this.usuariodataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestDepDemo02DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dnitextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView usuariodataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cursillocomboBox1;
        private System.Windows.Forms.Button button1;
        private GestDepDemo02DataSet gestDepDemo02DataSet;
        private System.Windows.Forms.BindingSource peopleBindingSource;
        private GestDepDemo02DataSetTableAdapters.PeopleTableAdapter peopleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iBANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn retiredDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discriminatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
    }
}