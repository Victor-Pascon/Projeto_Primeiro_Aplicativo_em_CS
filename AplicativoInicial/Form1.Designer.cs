namespace AplicativoInicial
{
    partial class frmInicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicial));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnContatos = new System.Windows.Forms.Button();
            this.btnApresentacaoImagens = new System.Windows.Forms.Button();
            this.btnCheckBocks = new System.Windows.Forms.Button();
            this.btnApresentacao = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(77, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 89);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seja Bem-Vindo ao Meu Primeiro Programa";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnContatos);
            this.panel2.Controls.Add(this.btnApresentacaoImagens);
            this.panel2.Controls.Add(this.btnCheckBocks);
            this.panel2.Controls.Add(this.btnApresentacao);
            this.panel2.Location = new System.Drawing.Point(101, 255);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(618, 316);
            this.panel2.TabIndex = 1;
            // 
            // btnContatos
            // 
            this.btnContatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContatos.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContatos.Location = new System.Drawing.Point(365, 176);
            this.btnContatos.Name = "btnContatos";
            this.btnContatos.Size = new System.Drawing.Size(206, 125);
            this.btnContatos.TabIndex = 3;
            this.btnContatos.Text = "Contatos";
            this.btnContatos.UseVisualStyleBackColor = true;
            this.btnContatos.Click += new System.EventHandler(this.btnContatos_Click);
            // 
            // btnApresentacaoImagens
            // 
            this.btnApresentacaoImagens.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApresentacaoImagens.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApresentacaoImagens.Location = new System.Drawing.Point(365, 3);
            this.btnApresentacaoImagens.Name = "btnApresentacaoImagens";
            this.btnApresentacaoImagens.Size = new System.Drawing.Size(206, 125);
            this.btnApresentacaoImagens.TabIndex = 2;
            this.btnApresentacaoImagens.Text = "Imagens";
            this.btnApresentacaoImagens.UseVisualStyleBackColor = true;
            this.btnApresentacaoImagens.Click += new System.EventHandler(this.btnApresentacaoImagens_Click);
            // 
            // btnCheckBocks
            // 
            this.btnCheckBocks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckBocks.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckBocks.Location = new System.Drawing.Point(38, 176);
            this.btnCheckBocks.Name = "btnCheckBocks";
            this.btnCheckBocks.Size = new System.Drawing.Size(206, 125);
            this.btnCheckBocks.TabIndex = 1;
            this.btnCheckBocks.Text = "Cadastros";
            this.btnCheckBocks.UseVisualStyleBackColor = true;
            this.btnCheckBocks.Click += new System.EventHandler(this.btnCheckBocks_Click);
            // 
            // btnApresentacao
            // 
            this.btnApresentacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApresentacao.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApresentacao.Location = new System.Drawing.Point(38, 3);
            this.btnApresentacao.Name = "btnApresentacao";
            this.btnApresentacao.Size = new System.Drawing.Size(206, 125);
            this.btnApresentacao.TabIndex = 0;
            this.btnApresentacao.Text = "Apresentação";
            this.btnApresentacao.UseVisualStyleBackColor = true;
            this.btnApresentacao.Click += new System.EventHandler(this.btnApresentacao_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(259, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Programas disponiveis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(746, 616);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Versão: 1.0.0";
            // 
            // frmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(831, 640);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Inicial";
            this.Load += new System.EventHandler(this.frmInicial_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnContatos;
        private System.Windows.Forms.Button btnApresentacaoImagens;
        private System.Windows.Forms.Button btnCheckBocks;
        private System.Windows.Forms.Button btnApresentacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

