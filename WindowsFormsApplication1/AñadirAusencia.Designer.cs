namespace WindowsFormsApplication1
{
    partial class AñadirAusencia
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
            this.dniMonitorBox = new System.Windows.Forms.TextBox();
            this.listaDeCursosBox = new System.Windows.Forms.ComboBox();
            this.listaUsuariosBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AñadirButton = new System.Windows.Forms.Button();
            this.BorrarButton = new System.Windows.Forms.Button();
            this.cargarCursosButton = new System.Windows.Forms.Button();
            this.tablaDeAbsences = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enrollmentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.absencesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestDepDemo02DataSet2 = new WindowsFormsApplication1.GestDepDemo02DataSet2();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.absencesTableAdapter = new WindowsFormsApplication1.GestDepDemo02DataSet2TableAdapters.AbsencesTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.faltadateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDeAbsences)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.absencesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestDepDemo02DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI Monitor";
            // 
            // dniMonitorBox
            // 
            this.dniMonitorBox.Location = new System.Drawing.Point(156, 27);
            this.dniMonitorBox.Name = "dniMonitorBox";
            this.dniMonitorBox.Size = new System.Drawing.Size(100, 20);
            this.dniMonitorBox.TabIndex = 1;
            // 
            // listaDeCursosBox
            // 
            this.listaDeCursosBox.FormattingEnabled = true;
            this.listaDeCursosBox.Location = new System.Drawing.Point(156, 96);
            this.listaDeCursosBox.Name = "listaDeCursosBox";
            this.listaDeCursosBox.Size = new System.Drawing.Size(121, 21);
            this.listaDeCursosBox.TabIndex = 2;
            this.listaDeCursosBox.SelectedIndexChanged += new System.EventHandler(this.listaDeCursosBox_SelectedIndexChanged);
            // 
            // listaUsuariosBox
            // 
            this.listaUsuariosBox.FormattingEnabled = true;
            this.listaUsuariosBox.Location = new System.Drawing.Point(156, 148);
            this.listaUsuariosBox.Name = "listaUsuariosBox";
            this.listaUsuariosBox.Size = new System.Drawing.Size(121, 21);
            this.listaUsuariosBox.TabIndex = 3;
            this.listaUsuariosBox.SelectedIndexChanged += new System.EventHandler(this.listaUsuariosBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cursos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Usuarios Inscritos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Faltas del Usuario";
            // 
            // AñadirButton
            // 
            this.AñadirButton.Location = new System.Drawing.Point(247, 419);
            this.AñadirButton.Name = "AñadirButton";
            this.AñadirButton.Size = new System.Drawing.Size(75, 23);
            this.AñadirButton.TabIndex = 8;
            this.AñadirButton.Text = "Añadir";
            this.AñadirButton.UseVisualStyleBackColor = true;
            this.AñadirButton.Click += new System.EventHandler(this.AñadirButton_Click);
            // 
            // BorrarButton
            // 
            this.BorrarButton.Location = new System.Drawing.Point(85, 419);
            this.BorrarButton.Name = "BorrarButton";
            this.BorrarButton.Size = new System.Drawing.Size(75, 23);
            this.BorrarButton.TabIndex = 9;
            this.BorrarButton.Text = "Borrar";
            this.BorrarButton.UseVisualStyleBackColor = true;
            this.BorrarButton.Click += new System.EventHandler(this.BorrarButton_Click);
            // 
            // cargarCursosButton
            // 
            this.cargarCursosButton.Location = new System.Drawing.Point(130, 57);
            this.cargarCursosButton.Name = "cargarCursosButton";
            this.cargarCursosButton.Size = new System.Drawing.Size(96, 23);
            this.cargarCursosButton.TabIndex = 10;
            this.cargarCursosButton.Text = "Cargar Cursos";
            this.cargarCursosButton.UseVisualStyleBackColor = true;
            this.cargarCursosButton.Click += new System.EventHandler(this.cargarCursosButton_Click);
            // 
            // tablaDeAbsences
            // 
            this.tablaDeAbsences.AllowUserToAddRows = false;
            this.tablaDeAbsences.AllowUserToDeleteRows = false;
            this.tablaDeAbsences.AutoGenerateColumns = false;
            this.tablaDeAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDeAbsences.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.enrollmentIdDataGridViewTextBoxColumn});
            this.tablaDeAbsences.DataSource = this.absencesBindingSource;
            this.tablaDeAbsences.Location = new System.Drawing.Point(47, 214);
            this.tablaDeAbsences.Name = "tablaDeAbsences";
            this.tablaDeAbsences.ReadOnly = true;
            this.tablaDeAbsences.Size = new System.Drawing.Size(344, 141);
            this.tablaDeAbsences.TabIndex = 11;
            this.tablaDeAbsences.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaDeAbsences_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enrollmentIdDataGridViewTextBoxColumn
            // 
            this.enrollmentIdDataGridViewTextBoxColumn.DataPropertyName = "Enrollment_Id";
            this.enrollmentIdDataGridViewTextBoxColumn.HeaderText = "Enrollment_Id";
            this.enrollmentIdDataGridViewTextBoxColumn.Name = "enrollmentIdDataGridViewTextBoxColumn";
            this.enrollmentIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // absencesBindingSource
            // 
            this.absencesBindingSource.DataMember = "Absences";
            this.absencesBindingSource.DataSource = this.gestDepDemo02DataSet2;
            // 
            // gestDepDemo02DataSet2
            // 
            this.gestDepDemo02DataSet2.DataSetName = "GestDepDemo02DataSet2";
            this.gestDepDemo02DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // absencesTableAdapter
            // 
            this.absencesTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fecha falta";
            // 
            // faltadateTimePicker1
            // 
            this.faltadateTimePicker1.CustomFormat = "yyyy/MM/dd";
            this.faltadateTimePicker1.Location = new System.Drawing.Point(156, 374);
            this.faltadateTimePicker1.Name = "faltadateTimePicker1";
            this.faltadateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.faltadateTimePicker1.TabIndex = 13;
            // 
            // AñadirAusencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 454);
            this.Controls.Add(this.faltadateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tablaDeAbsences);
            this.Controls.Add(this.cargarCursosButton);
            this.Controls.Add(this.BorrarButton);
            this.Controls.Add(this.AñadirButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listaUsuariosBox);
            this.Controls.Add(this.listaDeCursosBox);
            this.Controls.Add(this.dniMonitorBox);
            this.Controls.Add(this.label1);
            this.Name = "AñadirAusencia";
            this.Text = "Añadir Ausencia";
            this.Load += new System.EventHandler(this.AñadirAusencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaDeAbsences)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.absencesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestDepDemo02DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dniMonitorBox;
        private System.Windows.Forms.ComboBox listaDeCursosBox;
        private System.Windows.Forms.ComboBox listaUsuariosBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AñadirButton;
        private System.Windows.Forms.Button BorrarButton;
        private System.Windows.Forms.Button cargarCursosButton;
        private System.Windows.Forms.DataGridView tablaDeAbsences;
        private System.Windows.Forms.BindingSource bindingSource1;
        private GestDepDemo02DataSet2 gestDepDemo02DataSet2;
        private System.Windows.Forms.BindingSource absencesBindingSource;
        private GestDepDemo02DataSet2TableAdapters.AbsencesTableAdapter absencesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enrollmentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker faltadateTimePicker1;
    }
}