namespace Dados_do_Cliente.Formularios
{
    partial class frmInicial
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
            this.grpCadastrar = new System.Windows.Forms.GroupBox();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.grpCadastrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCadastrar
            // 
            this.grpCadastrar.Controls.Add(this.btnProdutos);
            this.grpCadastrar.Controls.Add(this.btnClientes);
            this.grpCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCadastrar.Location = new System.Drawing.Point(12, 22);
            this.grpCadastrar.Name = "grpCadastrar";
            this.grpCadastrar.Size = new System.Drawing.Size(323, 56);
            this.grpCadastrar.TabIndex = 0;
            this.grpCadastrar.TabStop = false;
            this.grpCadastrar.Text = "Cadastrar";
            // 
            // btnClientes
            // 
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Location = new System.Drawing.Point(6, 27);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(75, 23);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutos.Location = new System.Drawing.Point(97, 27);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(75, 23);
            this.btnProdutos.TabIndex = 1;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // frmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 279);
            this.Controls.Add(this.grpCadastrar);
            this.Name = "frmInicial";
            this.Text = "frmInicial";
            this.Load += new System.EventHandler(this.frmInicial_Load);
            this.grpCadastrar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCadastrar;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnClientes;
    }
}