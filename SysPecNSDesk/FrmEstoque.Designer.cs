namespace SysPecNSDesk
{
    partial class FrmEstoque
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
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            dgvEstoque = new DataGridView();
            btnPesquisar = new Button();
            clnID = new DataGridViewTextBoxColumn();
            clnCategoriaID = new DataGridViewTextBoxColumn();
            clnProduto = new DataGridViewTextBoxColumn();
            clnEstoqueInicial = new DataGridViewTextBoxColumn();
            clnEntrada = new DataGridViewTextBoxColumn();
            clnSaida = new DataGridViewTextBoxColumn();
            clnEstoqueFinal = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(66, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 82);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 2;
            label1.Text = "ID";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(84, 100);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 82);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 4;
            label2.Text = "Categoria";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(190, 100);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(190, 82);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 6;
            label3.Text = "Quantidade";
            // 
            // dgvEstoque
            // 
            dgvEstoque.AllowUserToAddRows = false;
            dgvEstoque.AllowUserToDeleteRows = false;
            dgvEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstoque.Columns.AddRange(new DataGridViewColumn[] { clnID, clnCategoriaID, clnProduto, clnEstoqueInicial, clnEntrada, clnSaida, clnEstoqueFinal });
            dgvEstoque.Location = new Point(12, 177);
            dgvEstoque.Name = "dgvEstoque";
            dgvEstoque.ReadOnly = true;
            dgvEstoque.RowHeadersVisible = false;
            dgvEstoque.Size = new Size(706, 287);
            dgvEstoque.TabIndex = 7;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(305, 100);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(75, 23);
            btnPesquisar.TabIndex = 8;
            btnPesquisar.Text = "&Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // clnID
            // 
            clnID.Frozen = true;
            clnID.HeaderText = "ID";
            clnID.Name = "clnID";
            clnID.ReadOnly = true;
            // 
            // clnCategoriaID
            // 
            clnCategoriaID.Frozen = true;
            clnCategoriaID.HeaderText = "Categoria_ID";
            clnCategoriaID.Name = "clnCategoriaID";
            clnCategoriaID.ReadOnly = true;
            // 
            // clnProduto
            // 
            clnProduto.Frozen = true;
            clnProduto.HeaderText = "Produto";
            clnProduto.Name = "clnProduto";
            clnProduto.ReadOnly = true;
            // 
            // clnEstoqueInicial
            // 
            clnEstoqueInicial.Frozen = true;
            clnEstoqueInicial.HeaderText = "EstoqueInicial";
            clnEstoqueInicial.Name = "clnEstoqueInicial";
            clnEstoqueInicial.ReadOnly = true;
            // 
            // clnEntrada
            // 
            clnEntrada.Frozen = true;
            clnEntrada.HeaderText = "Entrada";
            clnEntrada.Name = "clnEntrada";
            clnEntrada.ReadOnly = true;
            // 
            // clnSaida
            // 
            clnSaida.Frozen = true;
            clnSaida.HeaderText = "Saida";
            clnSaida.Name = "clnSaida";
            clnSaida.ReadOnly = true;
            // 
            // clnEstoqueFinal
            // 
            clnEstoqueFinal.Frozen = true;
            clnEstoqueFinal.HeaderText = "EstoqueFinal";
            clnEstoqueFinal.Name = "clnEstoqueFinal";
            clnEstoqueFinal.ReadOnly = true;
            // 
            // FrmEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 475);
            Controls.Add(btnPesquisar);
            Controls.Add(dgvEstoque);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "FrmEstoque";
            Text = "FrmEstoque";
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private DataGridView dgvEstoque;
        private DataGridViewTextBoxColumn clnID;
        private DataGridViewTextBoxColumn clnCategoriaID;
        private DataGridViewTextBoxColumn clnProduto;
        private DataGridViewTextBoxColumn clnEstoqueInicial;
        private DataGridViewTextBoxColumn clnEntrada;
        private DataGridViewTextBoxColumn clnSaida;
        private DataGridViewTextBoxColumn clnEstoqueFinal;
        private Button btnPesquisar;
    }
}