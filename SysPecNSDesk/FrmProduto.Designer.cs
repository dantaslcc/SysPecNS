namespace SysPecNSDesk
{
    partial class FrmProduto
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
            groupBox1 = new GroupBox();
            label9 = new Label();
            cmbCategoria = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnConsultar = new Button();
            btnEditar = new Button();
            btnAdicionar = new Button();
            txtDesconto = new TextBox();
            txtDescricao = new TextBox();
            npEstoqueMinimo = new NumericUpDown();
            txtUnidadeVenda = new TextBox();
            txtValorUni = new TextBox();
            txtCodBar = new TextBox();
            txtID = new TextBox();
            label1 = new Label();
            dgvProdutos = new DataGridView();
            clnid = new DataGridViewTextBoxColumn();
            clnCodigo = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnValorUnitario = new DataGridViewTextBoxColumn();
            clnUnidadeVenda = new DataGridViewTextBoxColumn();
            clnCategoria = new DataGridViewTextBoxColumn();
            clnEstoqueMinimo = new DataGridViewTextBoxColumn();
            clnDesconto = new DataGridViewTextBoxColumn();
            clnDataCadastro = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)npEstoqueMinimo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(cmbCategoria);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnConsultar);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(btnAdicionar);
            groupBox1.Controls.Add(txtDesconto);
            groupBox1.Controls.Add(txtDescricao);
            groupBox1.Controls.Add(npEstoqueMinimo);
            groupBox1.Controls.Add(txtUnidadeVenda);
            groupBox1.Controls.Add(txtValorUni);
            groupBox1.Controls.Add(txtCodBar);
            groupBox1.Controls.Add(txtID);
            groupBox1.Location = new Point(65, 88);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(628, 271);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(178, 131);
            label9.Name = "label9";
            label9.Size = new Size(58, 15);
            label9.TabIndex = 19;
            label9.Text = "Categoria";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(177, 148);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(283, 23);
            cmbCategoria.TabIndex = 18;
            cmbCategoria.SelectedIndexChanged += cmbCategoria_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 187);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 17;
            label8.Text = "Desconto";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 130);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 16;
            label7.Text = "Descrição";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(418, 77);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 15;
            label6.Text = "Estoque Minimo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(278, 78);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 14;
            label5.Text = "Unidade de venda";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(144, 78);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 13;
            label4.Text = "Valor Unitario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 78);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 12;
            label3.Text = "Codigo de barras";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 27);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 11;
            label2.Text = "ID";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(394, 204);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 10;
            btnConsultar.Text = "&Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Enabled = false;
            btnEditar.Location = new Point(291, 205);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(189, 205);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 8;
            btnAdicionar.Text = "&Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // txtDesconto
            // 
            txtDesconto.Location = new Point(18, 205);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(132, 23);
            txtDesconto.TabIndex = 7;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(18, 148);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(132, 23);
            txtDescricao.TabIndex = 5;
            // 
            // npEstoqueMinimo
            // 
            npEstoqueMinimo.Location = new Point(418, 95);
            npEstoqueMinimo.Name = "npEstoqueMinimo";
            npEstoqueMinimo.Size = new Size(42, 23);
            npEstoqueMinimo.TabIndex = 4;
            // 
            // txtUnidadeVenda
            // 
            txtUnidadeVenda.Location = new Point(278, 95);
            txtUnidadeVenda.Name = "txtUnidadeVenda";
            txtUnidadeVenda.Size = new Size(100, 23);
            txtUnidadeVenda.TabIndex = 3;
            // 
            // txtValorUni
            // 
            txtValorUni.Location = new Point(144, 95);
            txtValorUni.Name = "txtValorUni";
            txtValorUni.Size = new Size(100, 23);
            txtValorUni.TabIndex = 2;
            // 
            // txtCodBar
            // 
            txtCodBar.Location = new Point(18, 96);
            txtCodBar.Name = "txtCodBar";
            txtCodBar.Size = new Size(100, 23);
            txtCodBar.TabIndex = 1;
            // 
            // txtID
            // 
            txtID.Location = new Point(18, 45);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(70, 23);
            txtID.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(274, 28);
            label1.Name = "label1";
            label1.Size = new Size(214, 44);
            label1.TabIndex = 1;
            label1.Text = "PRODUTOS";
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { clnid, clnCodigo, clnDescricao, clnValorUnitario, clnUnidadeVenda, clnCategoria, clnEstoqueMinimo, clnDesconto, clnDataCadastro });
            dgvProdutos.Location = new Point(65, 380);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.RowHeadersVisible = false;
            dgvProdutos.Size = new Size(628, 180);
            dgvProdutos.TabIndex = 2;
            dgvProdutos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // clnid
            // 
            clnid.HeaderText = "ID";
            clnid.Name = "clnid";
            clnid.ReadOnly = true;
            clnid.Width = 50;
            // 
            // clnCodigo
            // 
            clnCodigo.HeaderText = "Codigo de Barras";
            clnCodigo.Name = "clnCodigo";
            clnCodigo.ReadOnly = true;
            clnCodigo.Width = 150;
            // 
            // clnDescricao
            // 
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            // 
            // clnValorUnitario
            // 
            clnValorUnitario.HeaderText = "Valor Unitario";
            clnValorUnitario.Name = "clnValorUnitario";
            clnValorUnitario.ReadOnly = true;
            // 
            // clnUnidadeVenda
            // 
            clnUnidadeVenda.HeaderText = "Unidade de Venda";
            clnUnidadeVenda.Name = "clnUnidadeVenda";
            clnUnidadeVenda.ReadOnly = true;
            clnUnidadeVenda.Width = 150;
            // 
            // clnCategoria
            // 
            clnCategoria.HeaderText = "Categoria";
            clnCategoria.Name = "clnCategoria";
            clnCategoria.ReadOnly = true;
            // 
            // clnEstoqueMinimo
            // 
            clnEstoqueMinimo.HeaderText = "Estoque Minimo";
            clnEstoqueMinimo.Name = "clnEstoqueMinimo";
            clnEstoqueMinimo.ReadOnly = true;
            clnEstoqueMinimo.Width = 150;
            // 
            // clnDesconto
            // 
            clnDesconto.HeaderText = "Desconto";
            clnDesconto.Name = "clnDesconto";
            clnDesconto.ReadOnly = true;
            // 
            // clnDataCadastro
            // 
            clnDataCadastro.HeaderText = "Data Cadastro";
            clnDataCadastro.Name = "clnDataCadastro";
            clnDataCadastro.ReadOnly = true;
            clnDataCadastro.Width = 150;
            // 
            // FrmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 590);
            Controls.Add(dgvProdutos);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "FrmProduto";
            Text = "FrmProduto";
            Load += FrmProduto_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)npEstoqueMinimo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button btnAdicionar;
        private TextBox txtDesconto;
        private TextBox txtDescricao;
        private NumericUpDown npEstoqueMinimo;
        private TextBox txtUnidadeVenda;
        private TextBox txtValorUni;
        private TextBox txtCodBar;
        private TextBox txtID;
        private Label label9;
        private ComboBox cmbCategoria;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnConsultar;
        private Button btnEditar;
        private DataGridView dgvProdutos;
        private DataGridViewTextBoxColumn clnid;
        private DataGridViewTextBoxColumn clnCodigo;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnValorUnitario;
        private DataGridViewTextBoxColumn clnUnidadeVenda;
        private DataGridViewTextBoxColumn clnCategoria;
        private DataGridViewTextBoxColumn clnEstoqueMinimo;
        private DataGridViewTextBoxColumn clnDesconto;
        private DataGridViewTextBoxColumn clnDataCadastro;
    }
}