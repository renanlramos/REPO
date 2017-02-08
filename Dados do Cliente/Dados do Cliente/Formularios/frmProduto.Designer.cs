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
            this.grpbCadastroDoProduto = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtbCodigo = new System.Windows.Forms.TextBox();
            this.txtbDescricao = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtbMarca = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtbPreco = new System.Windows.Forms.TextBox();
            this.mskData = new System.Windows.Forms.MaskedTextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.grpbCadastroDoProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbCadastroDoProduto
            // 
            this.grpbCadastroDoProduto.Controls.Add(this.lblData);
            this.grpbCadastroDoProduto.Controls.Add(this.mskData);
            this.grpbCadastroDoProduto.Controls.Add(this.txtbPreco);
            this.grpbCadastroDoProduto.Controls.Add(this.lblPreco);
            this.grpbCadastroDoProduto.Controls.Add(this.txtbMarca);
            this.grpbCadastroDoProduto.Controls.Add(this.lblMarca);
            this.grpbCadastroDoProduto.Controls.Add(this.txtbDescricao);
            this.grpbCadastroDoProduto.Controls.Add(this.txtbCodigo);
            this.grpbCadastroDoProduto.Controls.Add(this.lblDescricao);
            this.grpbCadastroDoProduto.Controls.Add(this.lblCodigo);
            this.grpbCadastroDoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbCadastroDoProduto.Location = new System.Drawing.Point(12, 57);
            this.grpbCadastroDoProduto.Name = "grpbCadastroDoProduto";
            this.grpbCadastroDoProduto.Size = new System.Drawing.Size(795, 272);
            this.grpbCadastroDoProduto.TabIndex = 0;
            this.grpbCadastroDoProduto.TabStop = false;
            this.grpbCadastroDoProduto.Text = "Cadastro do Produto";
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
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(122, 38);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(70, 16);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Text = "Descrição";
            // 
            // txtbCodigo
            // 
            this.txtbCodigo.Location = new System.Drawing.Point(6, 57);
            this.txtbCodigo.Name = "txtbCodigo";
            this.txtbCodigo.Size = new System.Drawing.Size(103, 22);
            this.txtbCodigo.TabIndex = 2;
            // 
            // txtbDescricao
            // 
            this.txtbDescricao.Location = new System.Drawing.Point(125, 57);
            this.txtbDescricao.Name = "txtbDescricao";
            this.txtbDescricao.Size = new System.Drawing.Size(640, 22);
            this.txtbDescricao.TabIndex = 3;
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
            // txtbMarca
            // 
            this.txtbMarca.Location = new System.Drawing.Point(6, 116);
            this.txtbMarca.Name = "txtbMarca";
            this.txtbMarca.Size = new System.Drawing.Size(193, 22);
            this.txtbMarca.TabIndex = 5;
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
            // txtbPreco
            // 
            this.txtbPreco.Location = new System.Drawing.Point(220, 116);
            this.txtbPreco.Name = "txtbPreco";
            this.txtbPreco.Size = new System.Drawing.Size(154, 22);
            this.txtbPreco.TabIndex = 7;
            // 
            // mskData
            // 
            this.mskData.Location = new System.Drawing.Point(396, 116);
            this.mskData.Mask = "00/00/0000";
            this.mskData.Name = "mskData";
            this.mskData.Size = new System.Drawing.Size(128, 22);
            this.mskData.TabIndex = 8;
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
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 368);
            this.Controls.Add(this.grpbCadastroDoProduto);
            this.Name = "frmProduto";
            this.Text = "frmProduto";
            this.grpbCadastroDoProduto.ResumeLayout(false);
            this.grpbCadastroDoProduto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbCadastroDoProduto;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.MaskedTextBox mskData;
        private System.Windows.Forms.TextBox txtbPreco;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtbMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtbDescricao;
        private System.Windows.Forms.TextBox txtbCodigo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblCodigo;
    }
}