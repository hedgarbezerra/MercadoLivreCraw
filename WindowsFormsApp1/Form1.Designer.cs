namespace WindowsFormsApp1
{
    partial class MLSearchBot
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgProdutos = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearchInput = new System.Windows.Forms.TextBox();
            this.pbProduto = new System.Windows.Forms.PictureBox();
            this.btnAlerta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(506, 371);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(164, 40);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "Pesquisar produto";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dgProdutos
            // 
            this.dgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdutos.Location = new System.Drawing.Point(32, 29);
            this.dgProdutos.Name = "dgProdutos";
            this.dgProdutos.Size = new System.Drawing.Size(301, 394);
            this.dgProdutos.TabIndex = 1;
            this.dgProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(532, 329);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(89, 13);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Nome do produto";
            // 
            // txtSearchInput
            // 
            this.txtSearchInput.Location = new System.Drawing.Point(451, 345);
            this.txtSearchInput.Name = "txtSearchInput";
            this.txtSearchInput.Size = new System.Drawing.Size(268, 20);
            this.txtSearchInput.TabIndex = 3;
            this.txtSearchInput.TextChanged += new System.EventHandler(this.TxtSearchInput_TextChanged);
            // 
            // pbProduto
            // 
            this.pbProduto.Location = new System.Drawing.Point(413, 29);
            this.pbProduto.Name = "pbProduto";
            this.pbProduto.Size = new System.Drawing.Size(345, 224);
            this.pbProduto.TabIndex = 6;
            this.pbProduto.TabStop = false;
            // 
            // btnAlerta
            // 
            this.btnAlerta.Location = new System.Drawing.Point(478, 259);
            this.btnAlerta.Name = "btnAlerta";
            this.btnAlerta.Size = new System.Drawing.Size(220, 40);
            this.btnAlerta.TabIndex = 7;
            this.btnAlerta.Text = "Criar alerta";
            this.btnAlerta.UseVisualStyleBackColor = true;
            this.btnAlerta.Click += new System.EventHandler(this.BtnAlerta_Click);
            // 
            // MLSearchBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAlerta);
            this.Controls.Add(this.pbProduto);
            this.Controls.Add(this.txtSearchInput);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgProdutos);
            this.Controls.Add(this.btnPesquisar);
            this.Name = "MLSearchBot";
            this.Text = "Mercado Livre Search";
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dgProdutos;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearchInput;
        private System.Windows.Forms.PictureBox pbProduto;
        private System.Windows.Forms.Button btnAlerta;
    }
}

