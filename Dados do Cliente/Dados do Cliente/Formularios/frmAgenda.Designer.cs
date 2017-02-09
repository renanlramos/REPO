namespace Dados_do_Cliente
{
    partial class frmAgenda
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgenda));
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mskCelular = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCEP = new System.Windows.Forms.Button();
            this.errError = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tstMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.tstdSalvar = new System.Windows.Forms.ToolStripMenuItem();
            this.tstbExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.tstbPesquisar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tstSair = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errError)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(10, 56);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(100, 22);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(114, 38);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 16);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(117, 57);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(646, 22);
            this.txtNome.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "CEP";
            // 
            // mskCEP
            // 
            this.mskCEP.Location = new System.Drawing.Point(10, 113);
            this.mskCEP.Mask = "00000-000";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mskCEP.Size = new System.Drawing.Size(100, 22);
            this.mskCEP.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(158, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Endereço";
            // 
            // txtEndereco
            // 
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.Location = new System.Drawing.Point(161, 113);
            this.txtEndereco.MaxLength = 50;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(514, 22);
            this.txtEndereco.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(682, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Número";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(685, 113);
            this.txtNumero.MaxLength = 3;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(78, 22);
            this.txtNumero.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Location = new System.Drawing.Point(10, 173);
            this.txtBairro.MaxLength = 30;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(175, 22);
            this.txtBairro.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(188, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Cidade";
            // 
            // txtCidade
            // 
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Location = new System.Drawing.Point(191, 173);
            this.txtCidade.MaxLength = 50;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(351, 22);
            this.txtCidade.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(545, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Estado";
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "SP",
            "MG",
            "BA"});
            this.cboEstado.Location = new System.Drawing.Point(548, 173);
            this.cboEstado.MaxLength = 2;
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(85, 24);
            this.cboEstado.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(636, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Celular";
            // 
            // mskCelular
            // 
            this.mskCelular.Location = new System.Drawing.Point(639, 174);
            this.mskCelular.Mask = "(00) 00000-0000";
            this.mskCelular.Name = "mskCelular";
            this.mskCelular.Size = new System.Drawing.Size(124, 22);
            this.mskCelular.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.btnCEP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mskCelular);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.cboEstado);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.mskCEP);
            this.groupBox1.Controls.Add(this.txtCidade);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtEndereco);
            this.groupBox1.Controls.Add(this.txtBairro);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(771, 226);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Cliente";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnCEP
            // 
            this.btnCEP.Image = global::Dados_do_Cliente.Properties.Resources.Pesquisa;
            this.btnCEP.Location = new System.Drawing.Point(116, 112);
            this.btnCEP.Name = "btnCEP";
            this.btnCEP.Size = new System.Drawing.Size(35, 26);
            this.btnCEP.TabIndex = 3;
            this.btnCEP.UseVisualStyleBackColor = true;
            this.btnCEP.Click += new System.EventHandler(this.btnCEP_Click);
            // 
            // errError
            // 
            this.errError.ContainerControl = this;
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstMenu,
            this.toolStripSeparator1,
            this.tstSair});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(819, 25);
            this.toolStrip.TabIndex = 22;
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
            this.tstMenu.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // tstdSalvar
            // 
            this.tstdSalvar.Name = "tstdSalvar";
            this.tstdSalvar.Size = new System.Drawing.Size(124, 22);
            this.tstdSalvar.Text = "&Salvar";
            this.tstdSalvar.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // tstbExcluir
            // 
            this.tstbExcluir.Name = "tstbExcluir";
            this.tstbExcluir.Size = new System.Drawing.Size(124, 22);
            this.tstbExcluir.Text = "&Excluir";
            // 
            // tstbPesquisar
            // 
            this.tstbPesquisar.Name = "tstbPesquisar";
            this.tstbPesquisar.Size = new System.Drawing.Size(124, 22);
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
            this.tstSair.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // frmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 368);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "frmAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cliente";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmAgenda_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errError)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mskCelular;
        private System.Windows.Forms.Button btnCEP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider errError;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripDropDownButton tstMenu;
        private System.Windows.Forms.ToolStripMenuItem tstdSalvar;
        private System.Windows.Forms.ToolStripMenuItem tstbExcluir;
        private System.Windows.Forms.ToolStripMenuItem tstbPesquisar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tstSair;
    }
}

