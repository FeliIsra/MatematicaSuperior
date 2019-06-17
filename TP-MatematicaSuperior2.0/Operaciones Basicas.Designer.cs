namespace TP_MatematicaSuperior2._0
{
    partial class Operaciones_Basicas
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
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.modoDeCalcularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estructuraDeDatosYTransformacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesBasicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesAvanzadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fasoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 76);
            this.button1.TabIndex = 0;
            this.button1.Text = "Operaciones en Polares";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(258, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 76);
            this.button2.TabIndex = 1;
            this.button2.Text = "Operaciones en Bionmial";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modoDeCalcularToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(471, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modoDeCalcularToolStripMenuItem
            // 
            this.modoDeCalcularToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estructuraDeDatosYTransformacionesToolStripMenuItem,
            this.operacionesBasicasToolStripMenuItem,
            this.operacionesAvanzadasToolStripMenuItem,
            this.fasoresToolStripMenuItem});
            this.modoDeCalcularToolStripMenuItem.Name = "modoDeCalcularToolStripMenuItem";
            this.modoDeCalcularToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.modoDeCalcularToolStripMenuItem.Text = "Modo de calcular";
            // 
            // estructuraDeDatosYTransformacionesToolStripMenuItem
            // 
            this.estructuraDeDatosYTransformacionesToolStripMenuItem.Name = "estructuraDeDatosYTransformacionesToolStripMenuItem";
            this.estructuraDeDatosYTransformacionesToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.estructuraDeDatosYTransformacionesToolStripMenuItem.Text = "Estructura de datos y transformaciones";
            this.estructuraDeDatosYTransformacionesToolStripMenuItem.Click += new System.EventHandler(this.EstructuraDeDatosYTransformacionesToolStripMenuItem_Click);
            // 
            // operacionesBasicasToolStripMenuItem
            // 
            this.operacionesBasicasToolStripMenuItem.Name = "operacionesBasicasToolStripMenuItem";
            this.operacionesBasicasToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.operacionesBasicasToolStripMenuItem.Text = "Operaciones Basicas";
            this.operacionesBasicasToolStripMenuItem.Click += new System.EventHandler(this.OperacionesBasicasToolStripMenuItem_Click);
            // 
            // operacionesAvanzadasToolStripMenuItem
            // 
            this.operacionesAvanzadasToolStripMenuItem.Name = "operacionesAvanzadasToolStripMenuItem";
            this.operacionesAvanzadasToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.operacionesAvanzadasToolStripMenuItem.Text = "Operaciones Avanzadas";
            this.operacionesAvanzadasToolStripMenuItem.Click += new System.EventHandler(this.OperacionesAvanzadasToolStripMenuItem_Click);
            // 
            // fasoresToolStripMenuItem
            // 
            this.fasoresToolStripMenuItem.Name = "fasoresToolStripMenuItem";
            this.fasoresToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.fasoresToolStripMenuItem.Text = "Fasores";
            this.fasoresToolStripMenuItem.Click += new System.EventHandler(this.FasoresToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 22);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.AyudaToolStripMenuItem_Click);
            // 
            // Operaciones_Basicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(471, 207);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Operaciones_Basicas";
            this.Text = "OPERACIONES BASICAS";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modoDeCalcularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estructuraDeDatosYTransformacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesBasicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesAvanzadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fasoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
    }
}