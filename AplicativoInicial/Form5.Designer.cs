namespace AplicativoInicial
{
    partial class frmContatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContatos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlEstudante = new System.Windows.Forms.Panel();
            this.pnlInstituicao = new System.Windows.Forms.Panel();
            this.chkEstudante = new System.Windows.Forms.CheckBox();
            this.chkInstituicao = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlEstudante.SuspendLayout();
            this.pnlInstituicao.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(61, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 101);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(98, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(715, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informações para contato";
            // 
            // pnlEstudante
            // 
            this.pnlEstudante.BackColor = System.Drawing.Color.CadetBlue;
            this.pnlEstudante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEstudante.Controls.Add(this.label6);
            this.pnlEstudante.Controls.Add(this.label5);
            this.pnlEstudante.Controls.Add(this.label4);
            this.pnlEstudante.Controls.Add(this.label3);
            this.pnlEstudante.Location = new System.Drawing.Point(355, 162);
            this.pnlEstudante.Name = "pnlEstudante";
            this.pnlEstudante.Size = new System.Drawing.Size(309, 311);
            this.pnlEstudante.TabIndex = 1;
            this.pnlEstudante.Visible = false;
            // 
            // pnlInstituicao
            // 
            this.pnlInstituicao.BackColor = System.Drawing.Color.CadetBlue;
            this.pnlInstituicao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInstituicao.Controls.Add(this.label7);
            this.pnlInstituicao.Controls.Add(this.label8);
            this.pnlInstituicao.Controls.Add(this.label9);
            this.pnlInstituicao.Controls.Add(this.label10);
            this.pnlInstituicao.Location = new System.Drawing.Point(670, 162);
            this.pnlInstituicao.Name = "pnlInstituicao";
            this.pnlInstituicao.Size = new System.Drawing.Size(306, 311);
            this.pnlInstituicao.TabIndex = 0;
            this.pnlInstituicao.Visible = false;
            // 
            // chkEstudante
            // 
            this.chkEstudante.AutoSize = true;
            this.chkEstudante.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEstudante.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.chkEstudante.Location = new System.Drawing.Point(20, 66);
            this.chkEstudante.Name = "chkEstudante";
            this.chkEstudante.Size = new System.Drawing.Size(176, 22);
            this.chkEstudante.TabIndex = 2;
            this.chkEstudante.Text = "Contato do estudante";
            this.chkEstudante.UseVisualStyleBackColor = true;
            this.chkEstudante.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chkInstituicao
            // 
            this.chkInstituicao.AutoSize = true;
            this.chkInstituicao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInstituicao.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.chkInstituicao.Location = new System.Drawing.Point(20, 107);
            this.chkInstituicao.Name = "chkInstituicao";
            this.chkInstituicao.Size = new System.Drawing.Size(250, 22);
            this.chkInstituicao.TabIndex = 3;
            this.chkInstituicao.Text = "Contato da instituição de ensino";
            this.chkInstituicao.UseVisualStyleBackColor = true;
            this.chkInstituicao.CheckedChanged += new System.EventHandler(this.chkInstituicao_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CadetBlue;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.chkInstituicao);
            this.panel4.Controls.Add(this.chkEstudante);
            this.panel4.Location = new System.Drawing.Point(41, 245);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(291, 151);
            this.panel4.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(48, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Opções de contato";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(27, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Contato do estudante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(15, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nome:     João Victor Pascon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(15, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Telefone:    (79) 9 9652-0695";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(16, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(268, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "E-MAIL:    pasconvictor@outlook.com";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(25, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(236, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Instagram:    @prepara.itabaiana";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(18, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(258, 22);
            this.label8.TabIndex = 6;
            this.label8.Text = "Telefone:    (79) 9 9688-9669";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(18, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(224, 22);
            this.label9.TabIndex = 5;
            this.label9.Text = "Nome:     Prepara Cursos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(24, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(250, 23);
            this.label10.TabIndex = 4;
            this.label10.Text = "Contato da instituição";
            // 
            // frmContatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1058, 502);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnlInstituicao);
            this.Controls.Add(this.pnlEstudante);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmContatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contatos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlEstudante.ResumeLayout(false);
            this.pnlEstudante.PerformLayout();
            this.pnlInstituicao.ResumeLayout(false);
            this.pnlInstituicao.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlEstudante;
        private System.Windows.Forms.Panel pnlInstituicao;
        private System.Windows.Forms.CheckBox chkEstudante;
        private System.Windows.Forms.CheckBox chkInstituicao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
    }
}