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
    public partial class frmImagens : Form
    {
        public frmImagens()
        {
            InitializeComponent();
        }

        private void btnApresentarImagem_Click(object sender, EventArgs e)
        {
            if(ofdImagens.ShowDialog() == DialogResult.OK)
            {
                pbImagem.Load(ofdImagens.FileName);
            }
        }
    }
}
