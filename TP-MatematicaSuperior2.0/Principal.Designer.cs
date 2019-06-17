namespace TP_MatematicaSuperior2._0
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.modoDeCalcularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nCOMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binomialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesAvanzadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fasoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido a NCOM";
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
            this.menuStrip1.Size = new System.Drawing.Size(498, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modoDeCalcularToolStripMenuItem
            // 
            this.modoDeCalcularToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nCOMToolStripMenuItem,
            this.binomialToolStripMenuItem,
            this.operacionesAvanzadasToolStripMenuItem,
            this.fasoresToolStripMenuItem});
            this.modoDeCalcularToolStripMenuItem.Name = "modoDeCalcularToolStripMenuItem";
            this.modoDeCalcularToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.modoDeCalcularToolStripMenuItem.Text = "Modo de calcular";
            // 
            // nCOMToolStripMenuItem
            // 
            this.nCOMToolStripMenuItem.Name = "nCOMToolStripMenuItem";
            this.nCOMToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.nCOMToolStripMenuItem.Text = "Estructuras de datos y transformaciones";
            this.nCOMToolStripMenuItem.Click += new System.EventHandler(this.NCOMToolStripMenuItem_Click);
            // 
            // binomialToolStripMenuItem
            // 
            this.binomialToolStripMenuItem.Name = "binomialToolStripMenuItem";
            this.binomialToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.binomialToolStripMenuItem.Text = "Operaciones Basicas";
            this.binomialToolStripMenuItem.Click += new System.EventHandler(this.BinomialToolStripMenuItem_Click);
            // 
            // operacionesAvanzadasToolStripMenuItem
            // 
            this.operacionesAvanzadasToolStripMenuItem.Name = "operacionesAvanzadasToolStripMenuItem";
            this.operacionesAvanzadasToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.operacionesAvanzadasToolStripMenuItem.Text = "Operaciones Avanzadas";
            this.operacionesAvanzadasToolStripMenuItem.Click += new System.EventHandler(this.OperacionesAvanzadasToolStripMenuItem_Click);
            // 
            // fasoresToolStripMenuItem
            // 
            this.fasoresToolStripMenuItem.Name = "fasoresToolStripMenuItem";
            this.fasoresToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.fasoresToolStripMenuItem.Text = "Fasores";
            this.fasoresToolStripMenuItem.Click += new System.EventHandler(this.FasoresToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Elija la operacion que desee desde el menu superior.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TP_MatematicaSuperior2._0.Properties.Resources.complex;
            this.pictureBox1.Location = new System.Drawing.Point(182, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 22);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.AyudaToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(498, 264);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Name = "Principal";
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modoDeCalcularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nCOMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binomialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesAvanzadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fasoresToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
    }
}