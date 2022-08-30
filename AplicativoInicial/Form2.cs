using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicativoInicial
{
    public partial class frmApresentacao : Form
    {
        public frmApresentacao()
        {
            InitializeComponent();
        }

        private void btnApresentar_Click(object sender, EventArgs e)
        {
            lblMensagem1.Text = "Olá meu caro! Esté é meu primeiro programa de compultador!";
            lblMensagem2.Text = "Estou migrando da linguagem Python e da IDE Visual Studio Code, para o C# e Visual Studio!";
            lblMensagem3.Text = "Estou adorando as ferramentas e recursos da linguagem, IDE e o ambiente Microsoft.NET!";
            lblMensagem4.Text = "Estou aprendendo a programar na Prepara Cursos, com o professor Junior!";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar1_Click(object sender, EventArgs e)
        {
            frmInicial Inicial = new frmInicial();
            Inicial.ShowDialog();
     
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            lblMensagem1.Text = "";
            lblMensagem2.Text = "";
            lblMensagem3.Text = "";
            lblMensagem4.Text = "";
        }

        private void frmApresentacao_Load(object sender, EventArgs e)
        {

        }
    }
}
