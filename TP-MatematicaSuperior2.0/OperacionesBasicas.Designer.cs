namespace TP_MatematicaSuperior2._0
{
    partial class OperacionesBasicas
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.lblB1 = new System.Windows.Forms.Label();
            this.lblA1 = new System.Windows.Forms.Label();
            this.txtB1 = new System.Windows.Forms.TextBox();
            this.txtA1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRestar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnSumar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtB2 = new System.Windows.Forms.TextBox();
            this.txtA2 = new System.Windows.Forms.TextBox();
            this.lblRta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Seleccione formato";
            // 
            // cmb1
            // 
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Items.AddRange(new object[] {
            "Binomial",
            "Polar"});
            this.cmb1.Location = new System.Drawing.Point(349, 102);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(121, 21);
            this.cmb1.TabIndex = 17;
            this.cmb1.Text = "Binomial";
            this.cmb1.SelectedIndexChanged += new System.EventHandler(this.Cmb1_SelectedIndexChanged);
            this.cmb1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cmb1_KeyPress);
            // 
            // lblB1
            // 
            this.lblB1.AutoSize = true;
            this.lblB1.Location = new System.Drawing.Point(220, 82);
            this.lblB1.Name = "lblB1";
            this.lblB1.Size = new System.Drawing.Size(51, 13);
            this.lblB1.TabIndex = 16;
            this.lblB1.Text = "Ingrese b";
            // 
            // lblA1
            // 
            this.lblA1.AutoSize = true;
            this.lblA1.Location = new System.Drawing.Point(54, 82);
            this.lblA1.Name = "lblA1";
            this.lblA1.Size = new System.Drawing.Size(51, 13);
            this.lblA1.TabIndex = 15;
            this.lblA1.Text = "Ingrese a";
            // 
            // txtB1
            // 
            this.txtB1.Location = new System.Drawing.Point(223, 103);
            this.txtB1.Name = "txtB1";
            this.txtB1.Size = new System.Drawing.Size(100, 20);
            this.txtB1.TabIndex = 14;
            // 
            // txtA1
            // 
            this.txtA1.Location = new System.Drawing.Point(54, 103);
            this.txtA1.Name = "txtA1";
            this.txtA1.Size = new System.Drawing.Size(100, 20);
            this.txtA1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Operaciones Basicas";
            // 
            // btnRestar
            // 
            this.btnRestar.Location = new System.Drawing.Point(515, 111);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(75, 23);
            this.btnRestar.TabIndex = 37;
            this.btnRestar.Text = "RESTAR";
            this.btnRestar.UseVisualStyleBackColor = true;
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(515, 181);
            this.btnDividir.Margin = new System.Windows.Forms.Padding(2);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(69, 23);
            this.btnDividir.TabIndex = 36;
            this.btnDividir.Text = "DIVIDIR";
            this.btnDividir.UseVisualStyleBackColor = true;
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(515, 145);
            this.btnMultiplicar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(90, 21);
            this.btnMultiplicar.TabIndex = 35;
            this.btnMultiplicar.Text = "MULTIPLICAR";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(515, 75);
            this.btnSumar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(61, 20);
            this.btnSumar.TabIndex = 34;
            this.btnSumar.Text = "SUMAR";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.BtnSumar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Seleccione formato";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Binomial",
            "Polar"});
            this.comboBox1.Location = new System.Drawing.Point(349, 170);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 42;
            this.comboBox1.Text = "Binomial";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBox1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Ingrese b";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Ingrese a";
            // 
            // txtB2
            // 
            this.txtB2.Location = new System.Drawing.Point(223, 171);
            this.txtB2.Name = "txtB2";
            this.txtB2.Size = new System.Drawing.Size(100, 20);
            this.txtB2.TabIndex = 39;
            // 
            // txtA2
            // 
            this.txtA2.Location = new System.Drawing.Point(54, 171);
            this.txtA2.Name = "txtA2";
            this.txtA2.Size = new System.Drawing.Size(100, 20);
            this.txtA2.TabIndex = 38;
            // 
            // lblRta
            // 
            this.lblRta.AutoSize = true;
            this.lblRta.Location = new System.Drawing.Point(180, 217);
            this.lblRta.Name = "lblRta";
            this.lblRta.Size = new System.Drawing.Size(64, 13);
            this.lblRta.TabIndex = 44;
            this.lblRta.Text = "Respuesta: ";
            // 
            // OperacionesBasicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 251);
            this.Controls.Add(this.lblRta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtB2);
            this.Controls.Add(this.txtA2);
            this.Controls.Add(this.btnRestar);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb1);
            this.Controls.Add(this.lblB1);
            this.Controls.Add(this.lblA1);
            this.Controls.Add(this.txtB1);
            this.Controls.Add(this.txtA1);
            this.Controls.Add(this.label1);
            this.Name = "OperacionesBasicas";
            this.Text = "OperacionesBasicas";
            this.Load += new System.EventHandler(this.OperacionesBasicas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb1;
        private System.Windows.Forms.Label lblB1;
        private System.Windows.Forms.Label lblA1;
        private System.Windows.Forms.TextBox txtB1;
        private System.Windows.Forms.TextBox txtA1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtB2;
        private System.Windows.Forms.TextBox txtA2;
        private System.Windows.Forms.Label lblRta;
    }
}