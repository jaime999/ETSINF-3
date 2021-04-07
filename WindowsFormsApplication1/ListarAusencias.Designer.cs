using System;

namespace WindowsFormsApplication1
{
    partial class ListarAusencias
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
            this.absencesTable = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enrollmentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.absencesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestDepDemo02DataSet2 = new WindowsFormsApplication1.GestDepDemo02DataSet2();
            this.bindingSourceAbsences = new System.Windows.Forms.BindingSource(this.components);
            this.gestDepDemo02DataSet = new WindowsFormsApplication1.GestDepDemo02DataSet();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CoursesTable = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finishDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startHourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minimunEnrollmentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maximunEnrollmentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancelledDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monitorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestDepDemo02DataSet1 = new WindowsFormsApplication1.GestDepDemo02DataSet1();
            this.noAbs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.coursesTableAdapter = new WindowsFormsApplication1.GestDepDemo02DataSet1TableAdapters.CoursesTableAdapter();
            this.absencesTableAdapter = new WindowsFormsApplication1.GestDepDemo02DataSet2TableAdapters.AbsencesTableAdapter();
            this.Listar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.absencesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.absencesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestDepDemo02DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAbsences)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestDepDemo02DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoursesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestDepDemo02DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // absencesTable
            // 
            this.absencesTable.AllowUserToAddRows = false;
            this.absencesTable.AllowUserToDeleteRows = false;
            this.absencesTable.AutoGenerateColumns = false;
            this.absencesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.absencesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.absencesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.dateDataGridViewTextBoxColumn,
            this.enrollmentIdDataGridViewTextBoxColumn});
            this.absencesTable.DataSource = this.absencesBindingSource;
            this.absencesTable.Location = new System.Drawing.Point(11, 237);
            this.absencesTable.MultiSelect = false;
            this.absencesTable.Name = "absencesTable";
            this.absencesTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.absencesTable.Size = new System.Drawing.Size(863, 163);
            this.absencesTable.TabIndex = 1;
            this.absencesTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.absencesTable_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // enrollmentIdDataGridViewTextBoxColumn
            // 
            this.enrollmentIdDataGridViewTextBoxColumn.DataPropertyName = "Enrollment_Id";
            this.enrollmentIdDataGridViewTextBoxColumn.HeaderText = "Enrollment_Id";
            this.enrollmentIdDataGridViewTextBoxColumn.Name = "enrollmentIdDataGridViewTextBoxColumn";
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
            // bindingSourceAbsences
            // 
            this.bindingSourceAbsences.DataSource = this.gestDepDemo02DataSet;
            this.bindingSourceAbsences.Position = 0;
            this.bindingSourceAbsences.CurrentChanged += new System.EventHandler(this.bindingSourceAbsences_CurrentChanged);
            // 
            // gestDepDemo02DataSet
            // 
            this.gestDepDemo02DataSet.DataSetName = "GestDepDemo02DataSet";
            this.gestDepDemo02DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = this.gestDepDemo02DataSet;
            this.bindingSource.Position = 0;
            // 
            // CoursesTable
            // 
            this.CoursesTable.AllowUserToAddRows = false;
            this.CoursesTable.AllowUserToDeleteRows = false;
            this.CoursesTable.AutoGenerateColumns = false;
            this.CoursesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CoursesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CoursesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.finishDateDataGridViewTextBoxColumn,
            this.startHourDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.minimunEnrollmentsDataGridViewTextBoxColumn,
            this.maximunEnrollmentsDataGridViewTextBoxColumn,
            this.cancelledDataGridViewCheckBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.courseDaysDataGridViewTextBoxColumn,
            this.monitorIdDataGridViewTextBoxColumn});
            this.CoursesTable.DataSource = this.coursesBindingSource;
            this.CoursesTable.Location = new System.Drawing.Point(11, 47);
            this.CoursesTable.Margin = new System.Windows.Forms.Padding(2);
            this.CoursesTable.MultiSelect = false;
            this.CoursesTable.Name = "CoursesTable";
            this.CoursesTable.RowTemplate.Height = 24;
            this.CoursesTable.Size = new System.Drawing.Size(863, 166);
            this.CoursesTable.TabIndex = 4;
            this.CoursesTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CoursesTable_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // finishDateDataGridViewTextBoxColumn
            // 
            this.finishDateDataGridViewTextBoxColumn.DataPropertyName = "FinishDate";
            this.finishDateDataGridViewTextBoxColumn.HeaderText = "FinishDate";
            this.finishDateDataGridViewTextBoxColumn.Name = "finishDateDataGridViewTextBoxColumn";
            // 
            // startHourDataGridViewTextBoxColumn
            // 
            this.startHourDataGridViewTextBoxColumn.DataPropertyName = "StartHour";
            this.startHourDataGridViewTextBoxColumn.HeaderText = "StartHour";
            this.startHourDataGridViewTextBoxColumn.Name = "startHourDataGridViewTextBoxColumn";
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            // 
            // minimunEnrollmentsDataGridViewTextBoxColumn
            // 
            this.minimunEnrollmentsDataGridViewTextBoxColumn.DataPropertyName = "MinimunEnrollments";
            this.minimunEnrollmentsDataGridViewTextBoxColumn.HeaderText = "MinimunEnrollments";
            this.minimunEnrollmentsDataGridViewTextBoxColumn.Name = "minimunEnrollmentsDataGridViewTextBoxColumn";
            // 
            // maximunEnrollmentsDataGridViewTextBoxColumn
            // 
            this.maximunEnrollmentsDataGridViewTextBoxColumn.DataPropertyName = "MaximunEnrollments";
            this.maximunEnrollmentsDataGridViewTextBoxColumn.HeaderText = "MaximunEnrollments";
            this.maximunEnrollmentsDataGridViewTextBoxColumn.Name = "maximunEnrollmentsDataGridViewTextBoxColumn";
            // 
            // cancelledDataGridViewCheckBoxColumn
            // 
            this.cancelledDataGridViewCheckBoxColumn.DataPropertyName = "Cancelled";
            this.cancelledDataGridViewCheckBoxColumn.HeaderText = "Cancelled";
            this.cancelledDataGridViewCheckBoxColumn.Name = "cancelledDataGridViewCheckBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // courseDaysDataGridViewTextBoxColumn
            // 
            this.courseDaysDataGridViewTextBoxColumn.DataPropertyName = "CourseDays";
            this.courseDaysDataGridViewTextBoxColumn.HeaderText = "CourseDays";
            this.courseDaysDataGridViewTextBoxColumn.Name = "courseDaysDataGridViewTextBoxColumn";
            // 
            // monitorIdDataGridViewTextBoxColumn
            // 
            this.monitorIdDataGridViewTextBoxColumn.DataPropertyName = "Monitor_Id";
            this.monitorIdDataGridViewTextBoxColumn.HeaderText = "Monitor_Id";
            this.monitorIdDataGridViewTextBoxColumn.Name = "monitorIdDataGridViewTextBoxColumn";
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "Courses";
            this.coursesBindingSource.DataSource = this.gestDepDemo02DataSet1;
            // 
            // gestDepDemo02DataSet1
            // 
            this.gestDepDemo02DataSet1.DataSetName = "GestDepDemo02DataSet1";
            this.gestDepDemo02DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // noAbs
            // 
            this.noAbs.AutoSize = true;
            this.noAbs.Location = new System.Drawing.Point(12, 415);
            this.noAbs.Name = "noAbs";
            this.noAbs.Size = new System.Drawing.Size(207, 13);
            this.noAbs.TabIndex = 5;
            this.noAbs.Text = "No hay ausencias registradas a este curso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Selecciona un curso para listar ausencias";
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // absencesTableAdapter
            // 
            this.absencesTableAdapter.ClearBeforeFill = true;
            // 
            // Listar
            // 
            this.Listar.Location = new System.Drawing.Point(469, 13);
            this.Listar.Name = "Listar";
            this.Listar.Size = new System.Drawing.Size(75, 23);
            this.Listar.TabIndex = 7;
            this.Listar.Text = "Listar";
            this.Listar.UseVisualStyleBackColor = true;
            this.Listar.Click += new System.EventHandler(this.Listar_Click);
            // 
            // ListarAusencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 450);
            this.Controls.Add(this.Listar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noAbs);
            this.Controls.Add(this.CoursesTable);
            this.Controls.Add(this.absencesTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ListarAusencias";
            this.Text = "Lista de Ausencias de un Curso";
            this.Load += new System.EventHandler(this.ListarAusencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.absencesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.absencesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestDepDemo02DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAbsences)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestDepDemo02DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoursesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestDepDemo02DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private System.Windows.Forms.DataGridView absencesTable;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.BindingSource bindingSourceAbsences;
        private System.Windows.Forms.DataGridView CoursesTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAbs;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AbsenceDay;
        private System.Windows.Forms.Label noAbs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private GestDepDemo02DataSet gestDepDemo02DataSet;
        private GestDepDemo02DataSet1 gestDepDemo02DataSet1;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private GestDepDemo02DataSet1TableAdapters.CoursesTableAdapter coursesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finishDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startHourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minimunEnrollmentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maximunEnrollmentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cancelledDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monitorIdDataGridViewTextBoxColumn;
        private GestDepDemo02DataSet2 gestDepDemo02DataSet2;
        private System.Windows.Forms.BindingSource absencesBindingSource;
        private GestDepDemo02DataSet2TableAdapters.AbsencesTableAdapter absencesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enrollmentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Listar;
    }
}