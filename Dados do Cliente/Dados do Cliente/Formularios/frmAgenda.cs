using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using System.Data.SqlClient;

namespace Dados_do_Cliente
{
    public partial class frmAgenda : Form
    {

        public frmAgenda()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pesquisar();
        }
       
        private void btnCEP_Click(object sender, EventArgs e)
        {
            PesquisarCEP(mskCEP.Text);
           
        }

        private void frmAgenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void tstSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tstSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                errError.SetError(lblNome, "Campo Obrigatório");
                return;
            }
            else
            {
                errError.SetError(lblNome, "");
            }         
        }
       private void PesquisarCEP(string CEP)
        {
            //pesquisa de CEP
            DataSet ds = new DataSet();

            string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", CEP);
            ds.ReadXml(xml);
            if (ds.Tables[0].Rows[0]["resultado_txt"].ToString() == "sucesso - cep completo" || ds.Tables[0].Rows[0]["resultado_txt"].ToString() == "sucesso - cep único")
            {
                txtEndereco.Text = ds.Tables[0].Rows[0]["tipo_logradouro"].ToString() + " " + ds.Tables[0].Rows[0]["logradouro"].ToString();
                txtBairro.Text = ds.Tables[0].Rows[0]["bairro"].ToString();
                txtCidade.Text = ds.Tables[0].Rows[0]["cidade"].ToString();
                cboEstado.Text = ds.Tables[0].Rows[0]["uf"].ToString();
                txtNumero.Focus();
            }
            else
            {
                MessageBox.Show("CEP não Encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tstExcluir_Click(object sender, EventArgs e)
        {

        }

        private void tstPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                if (txtNome.Text == "")
                {
                    errError.SetError(lblNome, "Campo Obrigatório");
                    return;
                }
                else
                {
                    errError.SetError(lblNome, "");
                }
            }

            {
                clClientes clClientes = new clClientes();

                clClientes.cliNome = txtNome.Text;
                clClientes.cliEndereco = txtEndereco.Text;
                clClientes.cliNumero = txtNumero.Text;
                clClientes.cliBairro = txtBairro.Text;
                clClientes.cliCidade = txtCidade.Text;
                clClientes.cliEstado = cboEstado.Text;
                clClientes.cliCEP = mskCEP.Text;
                clClientes.cliCelular = mskCelular.Text;

                clClientes.banco = Properties.Settings.Default.conexaoDB;

                clClientes.Gravar();

                MessageBox.Show("Cliente Incluído com Sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            limpar();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            limpar();
            
        }
        private void limpar()
        {
            txtBairro.Text = (" ");
            txtCidade.Text = (" ");
            txtCodigo.Text = (" ");
            txtEndereco.Text = (" ");
            txtNome.Text = (" ");
            txtNumero.Text = (" ");
            mskCelular.Text = (" ");
            mskCEP.Text = (" ");
        }

        private void mskCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void mskCEP_Click(object sender, EventArgs e)
        {
            mskCEP.SelectionStart = 0;
        }

        private void mskCEP_Enter(object sender, EventArgs e)
        {
        }

        private void mskCelular_Click(object sender, EventArgs e)
        {
            mskCelular.SelectionStart = 0;
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void Pesquisar()
        {
            string campo = "";

            //seleciona o campo de pesquisa
            if (cboOpcao.Text == "CÓDIGO")
            {
                campo = "cliCodigo";
            }
            else if (cboOpcao.Text == "NOME")
            {
                campo = "cliNome";
            }
            else if (cboOpcao.Text == "CELULAR")
            {
                campo = "cliCelular";
            }
            //carrega o datagridviwe com os clientes cadastrados
            clClientes clClientes = new clClientes();
            clClientes.banco = Properties.Settings.Default.conexaoDB;
            dgvClientes.DataSource = clClientes.Pesquisar(campo, txtFiltro.Text).Tables[0];

            //comando utilizado para gerar um efeito "zebrado" no datagridview
            dgvClientes.AlternatingRowsDefaultCellStyle.BackColor = Color.Green;
        }

        private void dgvClientes_DoubleClick(object sender, EventArgs e)
        {
            //verificar se existe itens na grid
            if (dgvClientes.RowCount == 0)
            {
                return;
            }

            //carrega a tela com todos os dados do cliente
            SqlDataReader drReader;
            clClientes clClientes = new clClientes();
            clClientes.banco = Properties.Settings.Default.conexaoDB;
            drReader = clClientes.PesquisarCodigo(Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value));

            if (drReader.Read())
            {
                //transfere os dados do banco de dados para os campos do formulário
                txtCodigo.Text = drReader["cliCodigo"].ToString();
                txtNome.Text = drReader["cliNome"].ToString();
                txtEndereco.Text = drReader["cliNome"].ToString();
                txtNumero.Text = drReader["cliNome"].ToString();
                txtBairro.Text = drReader["cliNome"].ToString();
                txtCidade.Text = drReader["cliNome"].ToString();
                cboEstado.Text = drReader["cliNome"].ToString();
                mskCelular.Text = drReader["cliNome"].ToString();
                mskCEP.Text = drReader["cliNome"].ToString();

                //habilita o frame e envia o cursor para o campo descrição
                tabControl1.SelectedTab = tabPage2;
                txtNome.Focus();
            }
            drReader.Close();
        }

        private void tstbExcluir_Click(object sender, EventArgs e)
        {
            //validação do conteudo
            if (txtCodigo.Text == "")
            {
                return;
            }
            //pergunta para o usuario se ele confirma a exclusão do cadastro
            DialogResult resposta;
            resposta = MessageBox.Show("Confirma a exclusão do cliente?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resposta.Equals(DialogResult.No))
            {
                return;
            }

            //instancia classe do negocio
            clClientes clClientes = new clClientes();

            //variavel com a string de conexão com o banco de dados
            clClientes.banco = Properties.Settings.Default.conexaoDB;
            clClientes.cliCodigo = Convert.ToInt32(txtCodigo.Text);
            clClientes.Excluir();

            //atualiza o datagridview
            Pesquisar();

            //limpar a tela

            limpar();

            //mensagem de confirmação de exclusão
            MessageBox.Show("Cliente excluido com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
