namespace Mercadinho
{
    partial class CadastroFunc
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCADASTRAR = new System.Windows.Forms.Button();
            this.comboBoxCARGO = new System.Windows.Forms.ComboBox();
            this.textBoxSENHA = new System.Windows.Forms.TextBox();
            this.textBoxCPF = new System.Windows.Forms.TextBox();
            this.textBoxNOME = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonCADASTRAR);
            this.panel1.Controls.Add(this.comboBoxCARGO);
            this.panel1.Controls.Add(this.textBoxSENHA);
            this.panel1.Controls.Add(this.textBoxCPF);
            this.panel1.Controls.Add(this.textBoxNOME);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 168);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(27, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCADASTRAR
            // 
            this.buttonCADASTRAR.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonCADASTRAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCADASTRAR.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonCADASTRAR.Location = new System.Drawing.Point(27, 107);
            this.buttonCADASTRAR.Name = "buttonCADASTRAR";
            this.buttonCADASTRAR.Size = new System.Drawing.Size(172, 23);
            this.buttonCADASTRAR.TabIndex = 5;
            this.buttonCADASTRAR.Text = "Cadastrar";
            this.buttonCADASTRAR.UseVisualStyleBackColor = false;
            this.buttonCADASTRAR.Click += new System.EventHandler(this.buttonCADASTRAR_Click);
            // 
            // comboBoxCARGO
            // 
            this.comboBoxCARGO.FormattingEnabled = true;
            this.comboBoxCARGO.Items.AddRange(new object[] {
            "Funcionário",
            "Gerente"});
            this.comboBoxCARGO.Location = new System.Drawing.Point(66, 80);
            this.comboBoxCARGO.Name = "comboBoxCARGO";
            this.comboBoxCARGO.Size = new System.Drawing.Size(133, 21);
            this.comboBoxCARGO.TabIndex = 4;
            this.comboBoxCARGO.Text = "Funcionário";
            // 
            // textBoxSENHA
            // 
            this.textBoxSENHA.Location = new System.Drawing.Point(66, 58);
            this.textBoxSENHA.Name = "textBoxSENHA";
            this.textBoxSENHA.PasswordChar = '*';
            this.textBoxSENHA.Size = new System.Drawing.Size(133, 20);
            this.textBoxSENHA.TabIndex = 3;
            // 
            // textBoxCPF
            // 
            this.textBoxCPF.Location = new System.Drawing.Point(66, 35);
            this.textBoxCPF.Name = "textBoxCPF";
            this.textBoxCPF.Size = new System.Drawing.Size(133, 20);
            this.textBoxCPF.TabIndex = 2;
            this.textBoxCPF.TextChanged += new System.EventHandler(this.textBoxCPF_TextChanged);
            // 
            // textBoxNOME
            // 
            this.textBoxNOME.Location = new System.Drawing.Point(66, 12);
            this.textBoxNOME.Name = "textBoxNOME";
            this.textBoxNOME.Size = new System.Drawing.Size(133, 20);
            this.textBoxNOME.TabIndex = 1;
            this.textBoxNOME.TextChanged += new System.EventHandler(this.textBoxNOME_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cargo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // CadastroFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(260, 192);
            this.Controls.Add(this.panel1);
            this.Name = "CadastroFunc";
            this.Text = "CadastroFunc";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxNOME;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCARGO;
        private System.Windows.Forms.TextBox textBoxSENHA;
        private System.Windows.Forms.TextBox textBoxCPF;
        private System.Windows.Forms.Button buttonCADASTRAR;
        private System.Windows.Forms.Button button1;
    }
}