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
    public partial class frmInicial : Form
    {
        public frmInicial()
        {
            InitializeComponent();
        }

        private void btnApresentacao_Click(object sender, EventArgs e)
        {
            frmApresentacao Apresentacao = new frmApresentacao();
            Apresentacao.ShowDialog();
        }

        private void btnCheckBocks_Click(object sender, EventArgs e)
        {
            frmCadastro Cadastro = new frmCadastro();
            Cadastro.ShowDialog();
        }

        private void btnApresentacaoImagens_Click(object sender, EventArgs e)
        {
            frmImagens Imagens = new frmImagens();
            Imagens.ShowDialog();
        }

        private void btnContatos_Click(object sender, EventArgs e)
        {
            frmContatos Contatos = new frmContatos();
            Contatos.ShowDialog();
        }

        private void frmInicial_Load(object sender, EventArgs e)
        {

        }
    }
}
