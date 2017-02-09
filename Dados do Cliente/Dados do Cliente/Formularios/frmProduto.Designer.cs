namespace Dados_do_Cliente.Formularios
{
    partial class frmProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduto));
            this.grpbCadastroDeProdutos = new System.Windows.Forms.GroupBox();
            this.mskPreco = new System.Windows.Forms.MaskedTextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.mskData = new System.Windows.Forms.MaskedTextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtbMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtbDescricao = new System.Windows.Forms.TextBox();
            this.txtbCodigo = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tstMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.tstdSalvar = new System.Windows.Forms.ToolStripMenuItem();
            this.tstbExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.tstbPesquisar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tstSair = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tstLimpar = new System.Windows.Forms.ToolStripButton();
            this.grpbCadastroDeProdutos.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbCadastroDeProdutos
            // 
            this.grpbCadastroDeProdutos.Controls.Add(this.mskPreco);
            this.grpbCadastroDeProdutos.Controls.Add(this.lblData);
            this.grpbCadastroDeProdutos.Controls.Add(this.mskData);
            this.grpbCadastroDeProdutos.Controls.Add(this.lblPreco);
            this.grpbCadastroDeProdutos.Controls.Add(this.txtbMarca);
            this.grpbCadastroDeProdutos.Controls.Add(this.lblMarca);
            this.grpbCadastroDeProdutos.Controls.Add(this.txtbDescricao);
            this.grpbCadastroDeProdutos.Controls.Add(this.txtbCodigo);
            this.grpbCadastroDeProdutos.Controls.Add(this.lblDescricao);
            this.grpbCadastroDeProdutos.Controls.Add(this.lblCodigo);
            this.grpbCadastroDeProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbCadastroDeProdutos.Location = new System.Drawing.Point(12, 57);
            this.grpbCadastroDeProdutos.Name = "grpbCadastroDeProdutos";
            this.grpbCadastroDeProdutos.Size = new System.Drawing.Size(795, 170);
            this.grpbCadastroDeProdutos.TabIndex = 0;
            this.grpbCadastroDeProdutos.TabStop = false;
            this.grpbCadastroDeProdutos.Text = "Cadastro de Produtos";
            this.grpbCadastroDeProdutos.Enter += new System.EventHandler(this.grpbCadastroDeProdutos_Enter);
            // 
            // mskPreco
            // 
            this.mskPreco.Location = new System.Drawing.Point(220, 116);
            this.mskPreco.Mask = "$";
            this.mskPreco.Name = "mskPreco";
            this.mskPreco.Size = new System.Drawing.Size(129, 22);
            this.mskPreco.TabIndex = 10;
            this.mskPreco.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            this.mskPreco.Click += new System.EventHandler(this.mskPreco_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(393, 97);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(37, 16);
            this.lblData.TabIndex = 9;
            this.lblData.Text = "Data";
            // 
            // mskData
            // 
            this.mskData.Location = new System.Drawing.Point(396, 116);
            this.mskData.Mask = "00/00/0000";
            this.mskData.Name = "mskData";
            this.mskData.Size = new System.Drawing.Size(128, 22);
            this.mskData.TabIndex = 11;
            this.mskData.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskData_MaskInputRejected);
            this.mskData.Click += new System.EventHandler(this.mskData_Click);
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(217, 97);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(44, 16);
            this.lblPreco.TabIndex = 6;
            this.lblPreco.Text = "Preço";
            // 
            // txtbMarca
            // 
            this.txtbMarca.Location = new System.Drawing.Point(6, 116);
            this.txtbMarca.Name = "txtbMarca";
            this.txtbMarca.Size = new System.Drawing.Size(193, 22);
            this.txtbMarca.TabIndex = 5;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(6, 97);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(46, 16);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "Marca";
            // 
            // txtbDescricao
            // 
            this.txtbDescricao.Location = new System.Drawing.Point(125, 57);
            this.txtbDescricao.Name = "txtbDescricao";
            this.txtbDescricao.Size = new System.Drawing.Size(640, 22);
            this.txtbDescricao.TabIndex = 3;
            // 
            // txtbCodigo
            // 
            this.txtbCodigo.Location = new System.Drawing.Point(6, 57);
            this.txtbCodigo.Name = "txtbCodigo";
            this.txtbCodigo.Size = new System.Drawing.Size(103, 22);
            this.txtbCodigo.TabIndex = 2;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(122, 38);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(70, 16);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(6, 38);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(52, 16);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstMenu,
            this.toolStripSeparator1,
            this.tstSair,
            this.toolStripSeparator2,
            this.tstLimpar});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(819, 25);
            this.toolStrip.TabIndex = 23;
            this.toolStrip.Text = "toolStrip2";
            // 
            // tstMenu
            // 
            this.tstMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tstMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstdSalvar,
            this.tstbExcluir,
            this.tstbPesquisar});
            this.tstMenu.Image = ((System.Drawing.Image)(resources.GetObject("tstMenu.Image")));
            this.tstMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstMenu.Name = "tstMenu";
            this.tstMenu.Size = new System.Drawing.Size(51, 22);
            this.tstMenu.Text = "Menu";
            // 
            // tstdSalvar
            // 
            this.tstdSalvar.Name = "tstdSalvar";
            this.tstdSalvar.Size = new System.Drawing.Size(152, 22);
            this.tstdSalvar.Text = "&Salvar";
            this.tstdSalvar.Click += new System.EventHandler(this.tstdSalvar_Click);
            // 
            // tstbExcluir
            // 
            this.tstbExcluir.Name = "tstbExcluir";
            this.tstbExcluir.Size = new System.Drawing.Size(152, 22);
            this.tstbExcluir.Text = "&Excluir";
            // 
            // tstbPesquisar
            // 
            this.tstbPesquisar.Name = "tstbPesquisar";
            this.tstbPesquisar.Size = new System.Drawing.Size(152, 22);
            this.tstbPesquisar.Text = "&Pesquisar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tstSair
            // 
            this.tstSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tstSair.Image = ((System.Drawing.Image)(resources.GetObject("tstSair.Image")));
            this.tstSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstSair.Name = "tstSair";
            this.tstSair.Size = new System.Drawing.Size(30, 22);
            this.tstSair.Text = "Sair";
            this.tstSair.Click += new System.EventHandler(this.tstSair_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tstLimpar
            // 
            this.tstLimpar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tstLimpar.Image = ((System.Drawing.Image)(resources.GetObject("tstLimpar.Image")));
            this.tstLimpar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstLimpar.Name = "tstLimpar";
            this.tstLimpar.Size = new System.Drawing.Size(110, 22);
            this.tstLimpar.Text = "Limpar os Campos";
            this.tstLimpar.Click += new System.EventHandler(this.tstLimpar_Click);
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 251);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.grpbCadastroDeProdutos);
            this.Name = "frmProduto";
            this.Text = "frmProduto";
            this.grpbCadastroDeProdutos.ResumeLayout(false);
            this.grpbCadastroDeProdutos.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbCadastroDeProdutos;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.MaskedTextBox mskData;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtbMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtbDescricao;
        private System.Windows.Forms.TextBox txtbCodigo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.MaskedTextBox mskPreco;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripDropDownButton tstMenu;
        private System.Windows.Forms.ToolStripMenuItem tstdSalvar;
        private System.Windows.Forms.ToolStripMenuItem tstbExcluir;
        private System.Windows.Forms.ToolStripMenuItem tstbPesquisar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tstSair;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tstLimpar;
    }
}