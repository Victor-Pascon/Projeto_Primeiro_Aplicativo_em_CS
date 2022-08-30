namespace AplicativoInicial
{
    partial class frmApresentacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmApresentacao));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnApresentar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblMensagem1 = new System.Windows.Forms.Label();
            this.lblMensagem2 = new System.Windows.Forms.Label();
            this.lblMensagem3 = new System.Windows.Forms.Label();
            this.lblMensagem4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMensagem4);
            this.panel1.Controls.Add(this.lblMensagem3);
            this.panel1.Controls.Add(this.lblMensagem2);
            this.panel1.Controls.Add(this.lblMensagem1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1017, 341);
            this.panel1.TabIndex = 0;
            // 
            // btnApresentar
            // 
            this.btnApresentar.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApresentar.Location = new System.Drawing.Point(148, 384);
            this.btnApresentar.Name = "btnApresentar";
            this.btnApresentar.Size = new System.Drawing.Size(242, 101);
            this.btnApresentar.TabIndex = 1;
            this.btnApresentar.Text = "Apresentar";
            this.btnApresentar.UseVisualStyleBackColor = true;
            this.btnApresentar.Click += new System.EventHandler(this.btnApresentar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(710, 384);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(242, 101);
            this.btnApagar.TabIndex = 2;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // lblMensagem1
            // 
            this.lblMensagem1.AutoSize = true;
            this.lblMensagem1.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMensagem1.Location = new System.Drawing.Point(19, 47);
            this.lblMensagem1.Name = "lblMensagem1";
            this.lblMensagem1.Size = new System.Drawing.Size(0, 28);
            this.lblMensagem1.TabIndex = 0;
            // 
            // lblMensagem2
            // 
            this.lblMensagem2.AutoSize = true;
            this.lblMensagem2.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMensagem2.Location = new System.Drawing.Point(19, 118);
            this.lblMensagem2.Name = "lblMensagem2";
            this.lblMensagem2.Size = new System.Drawing.Size(0, 28);
            this.lblMensagem2.TabIndex = 1;
            this.lblMensagem2.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMensagem3
            // 
            this.lblMensagem3.AutoSize = true;
            this.lblMensagem3.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMensagem3.Location = new System.Drawing.Point(19, 194);
            this.lblMensagem3.Name = "lblMensagem3";
            this.lblMensagem3.Size = new System.Drawing.Size(0, 28);
            this.lblMensagem3.TabIndex = 2;
            // 
            // lblMensagem4
            // 
            this.lblMensagem4.AutoSize = true;
            this.lblMensagem4.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMensagem4.Location = new System.Drawing.Point(19, 265);
            this.lblMensagem4.Name = "lblMensagem4";
            this.lblMensagem4.Size = new System.Drawing.Size(0, 28);
            this.lblMensagem4.TabIndex = 3;
            // 
            // frmApresentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1042, 507);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnApresentar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmApresentacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apresentação";
            this.Load += new System.EventHandler(this.frmApresentacao_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnApresentar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblMensagem1;
        private System.Windows.Forms.Label lblMensagem2;
        private System.Windows.Forms.Label lblMensagem3;
        private System.Windows.Forms.Label lblMensagem4;
    }
}