﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

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
    }
}
