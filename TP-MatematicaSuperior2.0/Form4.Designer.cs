namespace TP_MatematicaSuperior2._0
{
    partial class Form4
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
            this.txtA1 = new System.Windows.Forms.TextBox();
            this.txtB1 = new System.Windows.Forms.TextBox();
            this.lblA1 = new System.Windows.Forms.Label();
            this.lblB1 = new System.Windows.Forms.Label();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcularPot = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.btnCalcularRaiz = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.modoDeCalcularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binomialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nCOMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRta = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operaciones Avanzadas";
            // 
            // txtA1
            // 
            this.txtA1.Location = new System.Drawing.Point(45, 85);
            this.txtA1.Name = "txtA1";
            this.txtA1.Size = new System.Drawing.Size(100, 20);
            this.txtA1.TabIndex = 1;
            // 
            // txtB1
            // 
            this.txtB1.Location = new System.Drawing.Point(214, 85);
            this.txtB1.Name = "txtB1";
            this.txtB1.Size = new System.Drawing.Size(100, 20);
            this.txtB1.TabIndex = 2;
            // 
            // lblA1
            // 
            this.lblA1.AutoSize = true;
            this.lblA1.Location = new System.Drawing.Point(45, 57);
            this.lblA1.Name = "lblA1";
            this.lblA1.Size = new System.Drawing.Size(51, 13);
            this.lblA1.TabIndex = 5;
            this.lblA1.Text = "Ingrese a";
            // 
            // lblB1
            // 
            this.lblB1.AutoSize = true;
            this.lblB1.Location = new System.Drawing.Point(211, 57);
            this.lblB1.Name = "lblB1";
            this.lblB1.Size = new System.Drawing.Size(51, 13);
            this.lblB1.TabIndex = 6;
            this.lblB1.Text = "Ingrese b";
            // 
            // cmb1
            // 
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Items.AddRange(new object[] {
            "Binomial",
            "Polar"});
            this.cmb1.Location = new System.Drawing.Point(340, 84);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(121, 21);
            this.cmb1.TabIndex = 9;
            this.cmb1.Text = "Binomial";
            this.cmb1.SelectedIndexChanged += new System.EventHandler(this.Cmb1_SelectedIndexChanged);
            this.cmb1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cmb1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Seleccione formato";
            // 
            // btnCalcularPot
            // 
            this.btnCalcularPot.Location = new System.Drawing.Point(502, 27);
            this.btnCalcularPot.Name = "btnCalcularPot";
            this.btnCalcularPot.Size = new System.Drawing.Size(140, 39);
            this.btnCalcularPot.TabIndex = 13;
            this.btnCalcularPot.Text = "Calcular potencia n-sima";
            this.btnCalcularPot.UseVisualStyleBackColor = true;
            this.btnCalcularPot.Click += new System.EventHandler(this.BtnCalcularPot_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ingrese N";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(214, 148);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 20);
            this.txtN.TabIndex = 14;
            // 
            // btnCalcularRaiz
            // 
            this.btnCalcularRaiz.Location = new System.Drawing.Point(502, 75);
            this.btnCalcularRaiz.Name = "btnCalcularRaiz";
            this.btnCalcularRaiz.Size = new System.Drawing.Size(140, 39);
            this.btnCalcularRaiz.TabIndex = 16;
            this.btnCalcularRaiz.Text = "Calcular raiz n-sima";
            this.btnCalcularRaiz.UseVisualStyleBackColor = true;
            this.btnCalcularRaiz.Click += new System.EventHandler(this.BtnCalcularRaiz_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modoDeCalcularToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(665, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modoDeCalcularToolStripMenuItem
            // 
            this.modoDeCalcularToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binomialToolStripMenuItem,
            this.polarToolStripMenuItem,
            this.nCOMToolStripMenuItem});
            this.modoDeCalcularToolStripMenuItem.Name = "modoDeCalcularToolStripMenuItem";
            this.modoDeCalcularToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.modoDeCalcularToolStripMenuItem.Text = "Modo de calcular";
            // 
            // binomialToolStripMenuItem
            // 
            this.binomialToolStripMenuItem.Name = "binomialToolStripMenuItem";
            this.binomialToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.binomialToolStripMenuItem.Text = "Binomial";
            // 
            // polarToolStripMenuItem
            // 
            this.polarToolStripMenuItem.Name = "polarToolStripMenuItem";
            this.polarToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.polarToolStripMenuItem.Text = "Polar";
            // 
            // nCOMToolStripMenuItem
            // 
            this.nCOMToolStripMenuItem.Name = "nCOMToolStripMenuItem";
            this.nCOMToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.nCOMToolStripMenuItem.Text = "NCOM";
            // 
            // lblRta
            // 
            this.lblRta.AutoSize = true;
            this.lblRta.Location = new System.Drawing.Point(502, 150);
            this.lblRta.Name = "lblRta";
            this.lblRta.Size = new System.Drawing.Size(64, 13);
            this.lblRta.TabIndex = 19;
            this.lblRta.Text = "Respuesta: ";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 190);
            this.Controls.Add(this.lblRta);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnCalcularRaiz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.btnCalcularPot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb1);
            this.Controls.Add(this.lblB1);
            this.Controls.Add(this.lblA1);
            this.Controls.Add(this.txtB1);
            this.Controls.Add(this.txtA1);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtA1;
        private System.Windows.Forms.TextBox txtB1;
        private System.Windows.Forms.Label lblA1;
        private System.Windows.Forms.Label lblB1;
        private System.Windows.Forms.ComboBox cmb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalcularPot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnCalcularRaiz;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modoDeCalcularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binomialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nCOMToolStripMenuItem;
        private System.Windows.Forms.Label lblRta;
    }
}