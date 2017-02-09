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
    public partial class frmInicial : Form
    {
        public frmInicial()
        {
            InitializeComponent();
        }

        private void frmInicial_Load(object sender, EventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmAgenda newForm1 = new frmAgenda();
            newForm1.ShowDialog();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            
            frmProduto newForm2 = new frmProduto();
            newForm2.ShowDialog();
        }
    }
}
