namespace WindowsFormsApplication1
{
    partial class ListarCallesLibres
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
            this.piscinascomboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fechadateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridCallesLibres = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lunes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.martes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miercoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jueves = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viernes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sabado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCallesLibres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de piscinas";
            // 
            // piscinascomboBox1
            // 
            this.piscinascomboBox1.FormattingEnabled = true;
            this.piscinascomboBox1.Location = new System.Drawing.Point(127, 30);
            this.piscinascomboBox1.Name = "piscinascomboBox1";
            this.piscinascomboBox1.Size = new System.Drawing.Size(121, 21);
            this.piscinascomboBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha (seleccionar lunes)";
            // 
            // fechadateTimePicker1
            // 
            this.fechadateTimePicker1.Location = new System.Drawing.Point(496, 30);
            this.fechadateTimePicker1.Name = "fechadateTimePicker1";
            this.fechadateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.fechadateTimePicker1.TabIndex = 5;
            this.fechadateTimePicker1.Value = new System.DateTime(2018, 1, 15, 0, 0, 0, 0);
            this.fechadateTimePicker1.ValueChanged += new System.EventHandler(this.fechadateTimePicker1_ValueChanged);
            // 
            // dataGridCallesLibres
            // 
            this.dataGridCallesLibres.AutoGenerateColumns = false;
            this.dataGridCallesLibres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCallesLibres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hora,
            this.lunes,
            this.martes,
            this.miercoles,
            this.jueves,
            this.viernes,
            this.sabado});
            this.dataGridCallesLibres.DataSource = this.bindingSource1;
            this.dataGridCallesLibres.Location = new System.Drawing.Point(29, 86);
            this.dataGridCallesLibres.Name = "dataGridCallesLibres";
            this.dataGridCallesLibres.RowHeadersVisible = false;
            this.dataGridCallesLibres.Size = new System.Drawing.Size(667, 317);
            this.dataGridCallesLibres.TabIndex = 6;
            this.dataGridCallesLibres.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCallesLibres_CellContentClick);
            // 
            // hora
            // 
            this.hora.DataPropertyName = "ds_h";
            this.hora.HeaderText = "";
            this.hora.Name = "hora";
            this.hora.Width = 122;
            // 
            // lunes
            // 
            this.lunes.DataPropertyName = "ds_l";
            this.lunes.HeaderText = "Lunes";
            this.lunes.Name = "lunes";
            this.lunes.Width = 90;
            // 
            // martes
            // 
            this.martes.DataPropertyName = "ds_m";
            this.martes.HeaderText = "Martes";
            this.martes.Name = "martes";
            this.martes.Width = 90;
            // 
            // miercoles
            // 
            this.miercoles.DataPropertyName = "ds_x";
            this.miercoles.HeaderText = "Miercoles";
            this.miercoles.Name = "miercoles";
            this.miercoles.Width = 90;
            // 
            // jueves
            // 
            this.jueves.DataPropertyName = "ds_j";
            this.jueves.HeaderText = "Jueves";
            this.jueves.Name = "jueves";
            this.jueves.Width = 90;
            // 
            // viernes
            // 
            this.viernes.DataPropertyName = "ds_v";
            this.viernes.HeaderText = "Viernes";
            this.viernes.Name = "viernes";
            this.viernes.Width = 90;
            // 
            // sabado
            // 
            this.sabado.DataPropertyName = "ds_s";
            this.sabado.HeaderText = "Sabado";
            this.sabado.Name = "sabado";
            this.sabado.Width = 90;
            // 
            // ListarCallesLibres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 452);
            this.Controls.Add(this.dataGridCallesLibres);
            this.Controls.Add(this.fechadateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.piscinascomboBox1);
            this.Controls.Add(this.label1);
            this.Name = "ListarCallesLibres";
            this.Text = "Listar Calles Libres";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCallesLibres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox piscinascomboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openingHourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn closingHourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountRetiredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountLocalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn freeSwimPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fechadateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridCallesLibres;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn lunes;
        private System.Windows.Forms.DataGridViewTextBoxColumn martes;
        private System.Windows.Forms.DataGridViewTextBoxColumn miercoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn jueves;
        private System.Windows.Forms.DataGridViewTextBoxColumn viernes;
        private System.Windows.Forms.DataGridViewTextBoxColumn sabado;
    }
}