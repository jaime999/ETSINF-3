namespace WindowsFormsApplication1
{
    partial class VentanaPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cursilloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darDeAltaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarMonitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscribirUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarCallesLibresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirAusenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarAusenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cursilloToolStripMenuItem,
            this.listarCallesLibresToolStripMenuItem,
            this.añadirAusenciaToolStripMenuItem,
            this.listarAusenciasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(599, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cursilloToolStripMenuItem
            // 
            this.cursilloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darDeAltaToolStripMenuItem,
            this.asignarMonitorToolStripMenuItem,
            this.inscribirUsuarioToolStripMenuItem});
            this.cursilloToolStripMenuItem.Name = "cursilloToolStripMenuItem";
            this.cursilloToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.cursilloToolStripMenuItem.Text = "Cursillo";
            // 
            // darDeAltaToolStripMenuItem
            // 
            this.darDeAltaToolStripMenuItem.Name = "darDeAltaToolStripMenuItem";
            this.darDeAltaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.darDeAltaToolStripMenuItem.Text = "Dar de alta";
            this.darDeAltaToolStripMenuItem.Click += new System.EventHandler(this.darDeAltaToolStripMenuItem_Click);
            // 
            // asignarMonitorToolStripMenuItem
            // 
            this.asignarMonitorToolStripMenuItem.Name = "asignarMonitorToolStripMenuItem";
            this.asignarMonitorToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.asignarMonitorToolStripMenuItem.Text = "Asignar monitor";
            this.asignarMonitorToolStripMenuItem.Click += new System.EventHandler(this.asignarMonitorToolStripMenuItem_Click);
            // 
            // inscribirUsuarioToolStripMenuItem
            // 
            this.inscribirUsuarioToolStripMenuItem.Name = "inscribirUsuarioToolStripMenuItem";
            this.inscribirUsuarioToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.inscribirUsuarioToolStripMenuItem.Text = "Inscribir usuario";
            this.inscribirUsuarioToolStripMenuItem.Click += new System.EventHandler(this.inscribirUsuarioToolStripMenuItem_Click);
            // 
            // listarCallesLibresToolStripMenuItem
            // 
            this.listarCallesLibresToolStripMenuItem.Name = "listarCallesLibresToolStripMenuItem";
            this.listarCallesLibresToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.listarCallesLibresToolStripMenuItem.Text = "Listar calles libres";
            this.listarCallesLibresToolStripMenuItem.Click += new System.EventHandler(this.listarCallesLibresToolStripMenuItem_Click);
            // 
            // añadirAusenciaToolStripMenuItem
            // 
            this.añadirAusenciaToolStripMenuItem.Name = "añadirAusenciaToolStripMenuItem";
            this.añadirAusenciaToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.añadirAusenciaToolStripMenuItem.Text = "Añadir ausencia";
            this.añadirAusenciaToolStripMenuItem.Click += new System.EventHandler(this.añadirAusenciaToolStripMenuItem_Click);
            // 
            // listarAusenciasToolStripMenuItem
            // 
            this.listarAusenciasToolStripMenuItem.Name = "listarAusenciasToolStripMenuItem";
            this.listarAusenciasToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.listarAusenciasToolStripMenuItem.Text = "Listar Ausencias";
            this.listarAusenciasToolStripMenuItem.Click += new System.EventHandler(this.listarAusenciasToolStripMenuItem_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VentanaPrincipal";
            this.Text = "VentanaPrincipal";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cursilloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darDeAltaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarMonitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscribirUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarCallesLibresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirAusenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarAusenciasToolStripMenuItem;
    }
}