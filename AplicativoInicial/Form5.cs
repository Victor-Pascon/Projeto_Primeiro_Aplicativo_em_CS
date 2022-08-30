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
    public partial class frmContatos : Form
    {
        public frmContatos()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEstudante.Checked == true)
            {
                pnlEstudante.Visible = true;
            }
            else
            {
                pnlEstudante.Visible = false;
            }
        }

        private void chkInstituicao_CheckedChanged(object sender, EventArgs e)
        {
            if (chkInstituicao.Checked == true)
            {
                pnlInstituicao.Visible = true;
            }
            else
            {
                pnlInstituicao.Visible = false;
            }
        }
    }
}
