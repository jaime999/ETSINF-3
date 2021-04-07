namespace Proyecto.GUI
{
    partial class ProyectoApp
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
            this.button1 = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.listarEstudiantesYCursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitarListasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.listarProfesoresYEnrrollmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitarListasProfesoresYEnrrollmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.verInscripcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarProfesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.añadirUnCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.añadirEstudainteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.bindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(599, 544);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.administradorToolStripMenuItem,
            this.empleadoToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(687, 24);
            this.MainMenu.TabIndex = 2;
            this.MainMenu.Text = "MainMenu";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.listarEstudiantesYCursosToolStripMenuItem,
            this.quitarListasToolStripMenuItem,
            this.exitToolStripMenuItem2,
            this.listarProfesoresYEnrrollmentToolStripMenuItem,
            this.quitarListasProfesoresYEnrrollmentToolStripMenuItem,
            this.toolStripMenuItem4,
            this.exitToolStripMenuItem3,
            this.verInscripcionesToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.exitToolStripMenuItem.Text = "Menu";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(305, 22);
            this.exitToolStripMenuItem1.Text = "Cargar Piscinas";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(302, 6);
            // 
            // listarEstudiantesYCursosToolStripMenuItem
            // 
            this.listarEstudiantesYCursosToolStripMenuItem.Name = "listarEstudiantesYCursosToolStripMenuItem";
            this.listarEstudiantesYCursosToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.listarEstudiantesYCursosToolStripMenuItem.Text = "Listar Estudiantes y Cursos";
            this.listarEstudiantesYCursosToolStripMenuItem.Click += new System.EventHandler(this.listarEstudiantesYCursosToolStripMenuItem_Click);
            // 
            // quitarListasToolStripMenuItem
            // 
            this.quitarListasToolStripMenuItem.Name = "quitarListasToolStripMenuItem";
            this.quitarListasToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.quitarListasToolStripMenuItem.Text = "Quitar Listas Estudiantes y Cursos";
            this.quitarListasToolStripMenuItem.Click += new System.EventHandler(this.quitarListasToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem2
            // 
            this.exitToolStripMenuItem2.Name = "exitToolStripMenuItem2";
            this.exitToolStripMenuItem2.Size = new System.Drawing.Size(302, 6);
            this.exitToolStripMenuItem2.Click += new System.EventHandler(this.exitToolStripMenuItem2_Click);
            // 
            // listarProfesoresYEnrrollmentToolStripMenuItem
            // 
            this.listarProfesoresYEnrrollmentToolStripMenuItem.Name = "listarProfesoresYEnrrollmentToolStripMenuItem";
            this.listarProfesoresYEnrrollmentToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.listarProfesoresYEnrrollmentToolStripMenuItem.Text = "Listar Profesores y Cursos impartidos";
            this.listarProfesoresYEnrrollmentToolStripMenuItem.Click += new System.EventHandler(this.listarProfesoresYEnrrollmentToolStripMenuItem_Click);
            // 
            // quitarListasProfesoresYEnrrollmentToolStripMenuItem
            // 
            this.quitarListasProfesoresYEnrrollmentToolStripMenuItem.Name = "quitarListasProfesoresYEnrrollmentToolStripMenuItem";
            this.quitarListasProfesoresYEnrrollmentToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.quitarListasProfesoresYEnrrollmentToolStripMenuItem.Text = "Quitar Listas Profesores y Cursos impartidos";
            this.quitarListasProfesoresYEnrrollmentToolStripMenuItem.Click += new System.EventHandler(this.quitarListasProfesoresYEnrrollmentToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(302, 6);
            // 
            // exitToolStripMenuItem3
            // 
            this.exitToolStripMenuItem3.Name = "exitToolStripMenuItem3";
            this.exitToolStripMenuItem3.Size = new System.Drawing.Size(305, 22);
            this.exitToolStripMenuItem3.Text = "Exit";
            this.exitToolStripMenuItem3.Click += new System.EventHandler(this.exitToolStripMenuItem3_Click);
            // 
            // verInscripcionesToolStripMenuItem
            // 
            this.verInscripcionesToolStripMenuItem.Name = "verInscripcionesToolStripMenuItem";
            this.verInscripcionesToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.verInscripcionesToolStripMenuItem.Text = "Ver Inscripciones";
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asignarToolStripMenuItem,
            this.asignarProfesorToolStripMenuItem,
            this.añadirUnCursoToolStripMenuItem,
            this.toolStripMenuItem3});
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.administradorToolStripMenuItem.Text = "Administrador";
            this.administradorToolStripMenuItem.Click += new System.EventHandler(this.administradorToolStripMenuItem_Click);
            // 
            // asignarToolStripMenuItem
            // 
            this.asignarToolStripMenuItem.Name = "asignarToolStripMenuItem";
            this.asignarToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.asignarToolStripMenuItem.Text = "Añadir curso a impartir";
            this.asignarToolStripMenuItem.Click += new System.EventHandler(this.asignarToolStripMenuItem_Click);
            // 
            // asignarProfesorToolStripMenuItem
            // 
            this.asignarProfesorToolStripMenuItem.Name = "asignarProfesorToolStripMenuItem";
            this.asignarProfesorToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.asignarProfesorToolStripMenuItem.Text = "Asignar Monitor a Curso";
            this.asignarProfesorToolStripMenuItem.Click += new System.EventHandler(this.asignarProfesorToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(200, 6);
            // 
            // añadirUnCursoToolStripMenuItem
            // 
            this.añadirUnCursoToolStripMenuItem.Name = "añadirUnCursoToolStripMenuItem";
            this.añadirUnCursoToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.añadirUnCursoToolStripMenuItem.Text = "Añadir un Curso";
            this.añadirUnCursoToolStripMenuItem.Click += new System.EventHandler(this.añadirUnCursoToolStripMenuItem_Click);
            // 
            // empleadoToolStripMenuItem
            // 
            this.empleadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirEstudianteToolStripMenuItem,
            this.toolStripMenuItem2,
            this.añadirEstudainteToolStripMenuItem});
            this.empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            this.empleadoToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.empleadoToolStripMenuItem.Text = "Usuario";
            // 
            // añadirEstudianteToolStripMenuItem
            // 
            this.añadirEstudianteToolStripMenuItem.Name = "añadirEstudianteToolStripMenuItem";
            this.añadirEstudianteToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.añadirEstudianteToolStripMenuItem.Text = "Añadir estudiante a un curso";
            this.añadirEstudianteToolStripMenuItem.Click += new System.EventHandler(this.añadirEstudianteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(222, 6);
            // 
            // añadirEstudainteToolStripMenuItem
            // 
            this.añadirEstudainteToolStripMenuItem.Name = "añadirEstudainteToolStripMenuItem";
            this.añadirEstudainteToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.añadirEstudainteToolStripMenuItem.Text = "Añadir estudainte";
            this.añadirEstudainteToolStripMenuItem.Click += new System.EventHandler(this.añadirEstudainteToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(13, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(662, 203);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.DataSource = this.bindingSource2;
            this.dataGridView2.Location = new System.Drawing.Point(13, 300);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(662, 207);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.DataSource = this.bindingSource3;
            this.dataGridView3.Location = new System.Drawing.Point(12, 54);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(662, 203);
            this.dataGridView3.TabIndex = 5;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.DataSource = this.bindingSource4;
            this.dataGridView4.Location = new System.Drawing.Point(12, 300);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(662, 207);
            this.dataGridView4.TabIndex = 6;
            this.dataGridView4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
            // 
            // bindingSource4
            // 
            this.bindingSource4.CurrentChanged += new System.EventHandler(this.bindingSource4_CurrentChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lista de estudiantes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Lista de cursos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Lista de cursos impartidos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Lista de profesores:";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // ProyectoApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 579);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MainMenu);
            this.Name = "ProyectoApp";
            this.Text = "GestAca App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.Button button1;
            private System.Windows.Forms.MenuStrip MainMenu;
            private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
            private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
            private System.Windows.Forms.ToolStripSeparator exitToolStripMenuItem2;
            private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem3;
            private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
            private System.Windows.Forms.ToolStripMenuItem asignarToolStripMenuItem;
            private System.Windows.Forms.ToolStripMenuItem asignarProfesorToolStripMenuItem;
            private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem;
            private System.Windows.Forms.ToolStripMenuItem añadirUnCursoToolStripMenuItem;
            private System.Windows.Forms.BindingSource bindingSource1;
            private System.Windows.Forms.DataGridView dataGridView1;
            private System.Windows.Forms.DataGridView dataGridView2;
            private System.Windows.Forms.BindingSource bindingSource2;
            private System.Windows.Forms.ToolStripMenuItem listarEstudiantesYCursosToolStripMenuItem;
            private System.Windows.Forms.DataGridViewTextBoxColumn ID;
            private new System.Windows.Forms.DataGridViewTextBoxColumn Name;
            private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
            private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
            private System.Windows.Forms.ToolStripMenuItem quitarListasToolStripMenuItem;
            private System.Windows.Forms.ToolStripMenuItem añadirEstudianteToolStripMenuItem;
            private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
            private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
            private System.Windows.Forms.ToolStripMenuItem añadirEstudainteToolStripMenuItem;
            private System.Windows.Forms.DataGridView dataGridView3;
            private System.Windows.Forms.BindingSource bindingSource3;
            private System.Windows.Forms.DataGridView dataGridView4;
            private System.Windows.Forms.BindingSource bindingSource4;
            private System.Windows.Forms.ToolStripMenuItem listarProfesoresYEnrrollmentToolStripMenuItem;
            private System.Windows.Forms.ToolStripMenuItem quitarListasProfesoresYEnrrollmentToolStripMenuItem;
            private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
            private System.Windows.Forms.DataGridViewTextBoxColumn IdStudent;
            private System.Windows.Forms.DataGridViewTextBoxColumn nameStudent;
            private System.Windows.Forms.DataGridViewTextBoxColumn address;
            private System.Windows.Forms.DataGridViewTextBoxColumn Zip;
            private System.Windows.Forms.DataGridViewTextBoxColumn IBAM;
            private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
            private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
            private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
            private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
            private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
            private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
            private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
            private System.Windows.Forms.DataGridViewTextBoxColumn Quota;
            private System.Windows.Forms.DataGridViewTextBoxColumn Duracion;
            private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
            private System.Windows.Forms.DataGridViewTextBoxColumn DiaSemana;
            private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
            private System.Windows.Forms.Label label1;
            private System.Windows.Forms.Label label2;
            private System.Windows.Forms.Label label3;
            private System.Windows.Forms.Label label4;
            private System.Windows.Forms.ToolStripMenuItem verInscripcionesToolStripMenuItem;
            private System.ComponentModel.BackgroundWorker backgroundWorker1;
      }
 }


