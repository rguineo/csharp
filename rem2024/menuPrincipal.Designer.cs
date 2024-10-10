namespace rem2024
{
    partial class menuPrincipal
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
            this.mantenedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aFPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previsionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posicionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remuneracionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenedoresToolStripMenuItem,
            this.remuneracionesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenedoresToolStripMenuItem
            // 
            this.mantenedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aFPToolStripMenuItem,
            this.previsionToolStripMenuItem,
            this.posicionToolStripMenuItem,
            this.empleadoToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.mantenedoresToolStripMenuItem.Name = "mantenedoresToolStripMenuItem";
            this.mantenedoresToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.mantenedoresToolStripMenuItem.Text = "Mantenedores";
            // 
            // aFPToolStripMenuItem
            // 
            this.aFPToolStripMenuItem.Name = "aFPToolStripMenuItem";
            this.aFPToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aFPToolStripMenuItem.Text = "AFP";
            this.aFPToolStripMenuItem.Click += new System.EventHandler(this.aFPToolStripMenuItem_Click);
            // 
            // previsionToolStripMenuItem
            // 
            this.previsionToolStripMenuItem.Name = "previsionToolStripMenuItem";
            this.previsionToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.previsionToolStripMenuItem.Text = "Prevision";
            this.previsionToolStripMenuItem.Click += new System.EventHandler(this.previsionToolStripMenuItem_Click);
            // 
            // posicionToolStripMenuItem
            // 
            this.posicionToolStripMenuItem.Name = "posicionToolStripMenuItem";
            this.posicionToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.posicionToolStripMenuItem.Text = "Cargo";
            this.posicionToolStripMenuItem.Click += new System.EventHandler(this.posicionToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // empleadoToolStripMenuItem
            // 
            this.empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            this.empleadoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.empleadoToolStripMenuItem.Text = "Empleado";
            this.empleadoToolStripMenuItem.Click += new System.EventHandler(this.empleadoToolStripMenuItem_Click);
            // 
            // remuneracionesToolStripMenuItem
            // 
            this.remuneracionesToolStripMenuItem.Name = "remuneracionesToolStripMenuItem";
            this.remuneracionesToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.remuneracionesToolStripMenuItem.Text = "Remuneraciones";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // menuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "menuPrincipal";
            this.Text = "menuPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.menuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remuneracionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aFPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previsionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem posicionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem;
    }
}