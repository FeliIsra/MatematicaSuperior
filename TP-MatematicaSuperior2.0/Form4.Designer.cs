﻿namespace TP_MatematicaSuperior2._0
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
            this.lblRta = new System.Windows.Forms.Label();
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
            // lblRta
            // 
            this.lblRta.AutoSize = true;
            this.lblRta.Location = new System.Drawing.Point(502, 150);
            this.lblRta.Name = "lblRta";
            this.lblRta.Size = new System.Drawing.Size(64, 13);
            this.lblRta.TabIndex = 19;
            this.lblRta.Text = "Respuesta: ";
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
            this.menuStrip1.Size = new System.Drawing.Size(665, 24);
            this.menuStrip1.TabIndex = 35;
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
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(665, 190);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblRta);
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
            this.Name = "Form4";
            this.Text = "OPERACIONES AVANZADAS";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label lblRta;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modoDeCalcularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estructuraDeDatosYTransformacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesBasicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesAvanzadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fasoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
    }
}