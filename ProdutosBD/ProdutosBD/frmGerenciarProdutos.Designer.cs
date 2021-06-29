namespace ProdutosBD
{
    partial class frmGerenciarProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciarProdutos));
            this.ltbProd = new System.Windows.Forms.ListBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.gpbDadosProd = new System.Windows.Forms.GroupBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtEstAtual = new System.Windows.Forms.TextBox();
            this.txtPreCompr = new System.Windows.Forms.TextBox();
            this.txtPreVend = new System.Windows.Forms.TextBox();
            this.txtDescr = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblEstAtual = new System.Windows.Forms.Label();
            this.lblPrCompr = new System.Windows.Forms.Label();
            this.lblPrVend = new System.Windows.Forms.Label();
            this.lblDescr = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.rdbCodigo = new System.Windows.Forms.RadioButton();
            this.gpbPesquisa = new System.Windows.Forms.GroupBox();
            this.btnCodProd = new System.Windows.Forms.Button();
            this.lblCodProd = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblInformacao = new System.Windows.Forms.Label();
            this.gpbDadosProd.SuspendLayout();
            this.gpbPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // ltbProd
            // 
            this.ltbProd.FormattingEnabled = true;
            this.ltbProd.ItemHeight = 16;
            this.ltbProd.Location = new System.Drawing.Point(596, 23);
            this.ltbProd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ltbProd.Name = "ltbProd";
            this.ltbProd.Size = new System.Drawing.Size(239, 388);
            this.ltbProd.TabIndex = 9;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(457, 23);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 60);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Image = ((System.Drawing.Image)(resources.GetObject("btnGravar.Image")));
            this.btnGravar.Location = new System.Drawing.Point(349, 23);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(100, 60);
            this.btnGravar.TabIndex = 9;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(235, 23);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 60);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(120, 23);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(100, 60);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // gpbDadosProd
            // 
            this.gpbDadosProd.Controls.Add(this.lblInformacao);
            this.gpbDadosProd.Controls.Add(this.btnCancelar);
            this.gpbDadosProd.Controls.Add(this.btnGravar);
            this.gpbDadosProd.Controls.Add(this.btnExcluir);
            this.gpbDadosProd.Controls.Add(this.btnAlterar);
            this.gpbDadosProd.Controls.Add(this.btnNovo);
            this.gpbDadosProd.Controls.Add(this.txtEstAtual);
            this.gpbDadosProd.Controls.Add(this.txtPreCompr);
            this.gpbDadosProd.Controls.Add(this.txtPreVend);
            this.gpbDadosProd.Controls.Add(this.txtDescr);
            this.gpbDadosProd.Controls.Add(this.txtCodigo);
            this.gpbDadosProd.Controls.Add(this.lblEstAtual);
            this.gpbDadosProd.Controls.Add(this.lblPrCompr);
            this.gpbDadosProd.Controls.Add(this.lblPrVend);
            this.gpbDadosProd.Controls.Add(this.lblDescr);
            this.gpbDadosProd.Controls.Add(this.lblCodigo);
            this.gpbDadosProd.Location = new System.Drawing.Point(17, 122);
            this.gpbDadosProd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbDadosProd.Name = "gpbDadosProd";
            this.gpbDadosProd.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbDadosProd.Size = new System.Drawing.Size(571, 292);
            this.gpbDadosProd.TabIndex = 8;
            this.gpbDadosProd.TabStop = false;
            this.gpbDadosProd.Text = "Dados do Produto";
            // 
            // btnNovo
            // 
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(7, 23);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(100, 60);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // txtEstAtual
            // 
            this.txtEstAtual.Location = new System.Drawing.Point(188, 247);
            this.txtEstAtual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEstAtual.Name = "txtEstAtual";
            this.txtEstAtual.ReadOnly = true;
            this.txtEstAtual.Size = new System.Drawing.Size(132, 22);
            this.txtEstAtual.TabIndex = 15;
            // 
            // txtPreCompr
            // 
            this.txtPreCompr.Location = new System.Drawing.Point(157, 215);
            this.txtPreCompr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPreCompr.Name = "txtPreCompr";
            this.txtPreCompr.ReadOnly = true;
            this.txtPreCompr.Size = new System.Drawing.Size(132, 22);
            this.txtPreCompr.TabIndex = 14;
            // 
            // txtPreVend
            // 
            this.txtPreVend.Location = new System.Drawing.Point(152, 177);
            this.txtPreVend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPreVend.Name = "txtPreVend";
            this.txtPreVend.ReadOnly = true;
            this.txtPreVend.Size = new System.Drawing.Size(132, 22);
            this.txtPreVend.TabIndex = 13;
            // 
            // txtDescr
            // 
            this.txtDescr.Location = new System.Drawing.Point(95, 140);
            this.txtDescr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescr.Name = "txtDescr";
            this.txtDescr.ReadOnly = true;
            this.txtDescr.Size = new System.Drawing.Size(461, 22);
            this.txtDescr.TabIndex = 12;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(92, 102);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(132, 22);
            this.txtCodigo.TabIndex = 11;
            this.txtCodigo.TabStop = false;
            // 
            // lblEstAtual
            // 
            this.lblEstAtual.AutoSize = true;
            this.lblEstAtual.Location = new System.Drawing.Point(13, 256);
            this.lblEstAtual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstAtual.Name = "lblEstAtual";
            this.lblEstAtual.Size = new System.Drawing.Size(147, 17);
            this.lblEstAtual.TabIndex = 4;
            this.lblEstAtual.Text = "Estoque Atual na Loja";
            // 
            // lblPrCompr
            // 
            this.lblPrCompr.AutoSize = true;
            this.lblPrCompr.Location = new System.Drawing.Point(13, 224);
            this.lblPrCompr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrCompr.Name = "lblPrCompr";
            this.lblPrCompr.Size = new System.Drawing.Size(118, 17);
            this.lblPrCompr.TabIndex = 3;
            this.lblPrCompr.Text = "Preço de Compra";
            // 
            // lblPrVend
            // 
            this.lblPrVend.AutoSize = true;
            this.lblPrVend.Location = new System.Drawing.Point(13, 186);
            this.lblPrVend.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrVend.Name = "lblPrVend";
            this.lblPrVend.Size = new System.Drawing.Size(110, 17);
            this.lblPrVend.TabIndex = 2;
            this.lblPrVend.Text = "Preço de Venda";
            // 
            // lblDescr
            // 
            this.lblDescr.AutoSize = true;
            this.lblDescr.Location = new System.Drawing.Point(13, 149);
            this.lblDescr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescr.Name = "lblDescr";
            this.lblDescr.Size = new System.Drawing.Size(71, 17);
            this.lblDescr.TabIndex = 1;
            this.lblDescr.Text = "Descrição";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(13, 111);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(52, 17);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // rdbNome
            // 
            this.rdbNome.AutoSize = true;
            this.rdbNome.Location = new System.Drawing.Point(225, 23);
            this.rdbNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbNome.Name = "rdbNome";
            this.rdbNome.Size = new System.Drawing.Size(66, 21);
            this.rdbNome.TabIndex = 4;
            this.rdbNome.TabStop = true;
            this.rdbNome.Text = "Nome";
            this.rdbNome.UseVisualStyleBackColor = true;
            // 
            // rdbCodigo
            // 
            this.rdbCodigo.AutoSize = true;
            this.rdbCodigo.Location = new System.Drawing.Point(93, 23);
            this.rdbCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbCodigo.Name = "rdbCodigo";
            this.rdbCodigo.Size = new System.Drawing.Size(73, 21);
            this.rdbCodigo.TabIndex = 3;
            this.rdbCodigo.TabStop = true;
            this.rdbCodigo.Text = "Código";
            this.rdbCodigo.UseVisualStyleBackColor = true;
            // 
            // gpbPesquisa
            // 
            this.gpbPesquisa.Controls.Add(this.rdbNome);
            this.gpbPesquisa.Controls.Add(this.rdbCodigo);
            this.gpbPesquisa.Controls.Add(this.btnCodProd);
            this.gpbPesquisa.Controls.Add(this.lblCodProd);
            this.gpbPesquisa.Controls.Add(this.txtDescricao);
            this.gpbPesquisa.Location = new System.Drawing.Point(16, 15);
            this.gpbPesquisa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbPesquisa.Name = "gpbPesquisa";
            this.gpbPesquisa.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbPesquisa.Size = new System.Drawing.Size(572, 100);
            this.gpbPesquisa.TabIndex = 7;
            this.gpbPesquisa.TabStop = false;
            this.gpbPesquisa.Text = "Pesquisa por:";
            // 
            // btnCodProd
            // 
            this.btnCodProd.Image = ((System.Drawing.Image)(resources.GetObject("btnCodProd.Image")));
            this.btnCodProd.Location = new System.Drawing.Point(459, 20);
            this.btnCodProd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCodProd.Name = "btnCodProd";
            this.btnCodProd.Size = new System.Drawing.Size(100, 60);
            this.btnCodProd.TabIndex = 2;
            this.btnCodProd.Text = "Pesquisar";
            this.btnCodProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCodProd.UseVisualStyleBackColor = true;
            this.btnCodProd.Click += new System.EventHandler(this.btnCodProd_Click);
            // 
            // lblCodProd
            // 
            this.lblCodProd.AutoSize = true;
            this.lblCodProd.Location = new System.Drawing.Point(15, 68);
            this.lblCodProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodProd.Name = "lblCodProd";
            this.lblCodProd.Size = new System.Drawing.Size(71, 17);
            this.lblCodProd.TabIndex = 0;
            this.lblCodProd.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(93, 59);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(324, 22);
            this.txtDescricao.TabIndex = 1;
            // 
            // lblInformacao
            // 
            this.lblInformacao.AutoSize = true;
            this.lblInformacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacao.ForeColor = System.Drawing.Color.Red;
            this.lblInformacao.Location = new System.Drawing.Point(244, 107);
            this.lblInformacao.Name = "lblInformacao";
            this.lblInformacao.Size = new System.Drawing.Size(0, 17);
            this.lblInformacao.TabIndex = 16;
            // 
            // frmGerenciarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 447);
            this.Controls.Add(this.ltbProd);
            this.Controls.Add(this.gpbDadosProd);
            this.Controls.Add(this.gpbPesquisa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmGerenciarProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Produtos";
            this.gpbDadosProd.ResumeLayout(false);
            this.gpbDadosProd.PerformLayout();
            this.gpbPesquisa.ResumeLayout(false);
            this.gpbPesquisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ltbProd;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.GroupBox gpbDadosProd;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txtEstAtual;
        private System.Windows.Forms.TextBox txtPreCompr;
        private System.Windows.Forms.TextBox txtPreVend;
        private System.Windows.Forms.TextBox txtDescr;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblEstAtual;
        private System.Windows.Forms.Label lblPrCompr;
        private System.Windows.Forms.Label lblPrVend;
        private System.Windows.Forms.Label lblDescr;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.RadioButton rdbNome;
        private System.Windows.Forms.RadioButton rdbCodigo;
        private System.Windows.Forms.GroupBox gpbPesquisa;
        private System.Windows.Forms.Button btnCodProd;
        private System.Windows.Forms.Label lblCodProd;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblInformacao;
    }
}

