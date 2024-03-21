namespace Mercadinho
{
    partial class CadastroProdutos
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
            this.buttonCADASTRAR = new System.Windows.Forms.Button();
            this.textBoxVALOR = new System.Windows.Forms.TextBox();
            this.textBoxDESCRICAO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPONTO = new System.Windows.Forms.Label();
            this.textBoxCENTAVO = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBoxCENTAVO);
            this.panel1.Controls.Add(this.labelPONTO);
            this.panel1.Controls.Add(this.buttonCADASTRAR);
            this.panel1.Controls.Add(this.textBoxVALOR);
            this.panel1.Controls.Add(this.textBoxDESCRICAO);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 128);
            this.panel1.TabIndex = 1;
            // 
            // buttonCADASTRAR
            // 
            this.buttonCADASTRAR.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonCADASTRAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCADASTRAR.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonCADASTRAR.Location = new System.Drawing.Point(27, 60);
            this.buttonCADASTRAR.Name = "buttonCADASTRAR";
            this.buttonCADASTRAR.Size = new System.Drawing.Size(172, 23);
            this.buttonCADASTRAR.TabIndex = 8;
            this.buttonCADASTRAR.Text = "Cadastrar";
            this.buttonCADASTRAR.UseVisualStyleBackColor = false;
            this.buttonCADASTRAR.Click += new System.EventHandler(this.buttonCADASTRAR_Click);
            // 
            // textBoxVALOR
            // 
            this.textBoxVALOR.Location = new System.Drawing.Point(78, 34);
            this.textBoxVALOR.Name = "textBoxVALOR";
            this.textBoxVALOR.Size = new System.Drawing.Size(44, 20);
            this.textBoxVALOR.TabIndex = 5;
            // 
            // textBoxDESCRICAO
            // 
            this.textBoxDESCRICAO.Location = new System.Drawing.Point(88, 12);
            this.textBoxDESCRICAO.Name = "textBoxDESCRICAO";
            this.textBoxDESCRICAO.Size = new System.Drawing.Size(111, 20);
            this.textBoxDESCRICAO.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Preço: R$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição:";
            // 
            // labelPONTO
            // 
            this.labelPONTO.AutoSize = true;
            this.labelPONTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPONTO.Location = new System.Drawing.Point(122, 35);
            this.labelPONTO.Name = "labelPONTO";
            this.labelPONTO.Size = new System.Drawing.Size(13, 18);
            this.labelPONTO.TabIndex = 9;
            this.labelPONTO.Text = ".";
            // 
            // textBoxCENTAVO
            // 
            this.textBoxCENTAVO.Location = new System.Drawing.Point(134, 34);
            this.textBoxCENTAVO.Name = "textBoxCENTAVO";
            this.textBoxCENTAVO.Size = new System.Drawing.Size(44, 20);
            this.textBoxCENTAVO.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(27, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CadastroProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(259, 152);
            this.Controls.Add(this.panel1);
            this.Name = "CadastroProdutos";
            this.Text = "CadastroProdutos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPONTO;
        private System.Windows.Forms.Button buttonCADASTRAR;
        private System.Windows.Forms.TextBox textBoxVALOR;
        private System.Windows.Forms.TextBox textBoxDESCRICAO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCENTAVO;
        private System.Windows.Forms.Button button1;
    }
}