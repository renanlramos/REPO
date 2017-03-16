using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dados_do_Cliente.Formularios
{
    public partial class frmProduto : Form
    {

        public frmProduto()
        {
            InitializeComponent();
        }

        private void txtbPreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void grpbCadastroDeProdutos_Enter(object sender, EventArgs e)
        {

        }

        private void tstLimpar_Click(object sender, EventArgs e)
        {
            txtbCodigo.Text = (" ");
            txtbDescricao.Text = (" ");
            txtbMarca.Text = (" ");
            mskData.Text = (" ");
            mskPreco.Text = (" ");
        }

        private void tstdSalvar_Click(object sender, EventArgs e)
        {          
        }

        private void tstSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mskPreco_Click(object sender, EventArgs e)
        {
            mskPreco.SelectionStart = 0;
        }

        private void mskData_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskData_Click(object sender, EventArgs e)
        {
           mskData.SelectionStart = 0;
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {

        }
    }
}
