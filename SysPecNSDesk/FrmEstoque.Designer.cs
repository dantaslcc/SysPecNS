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
            txtIdProduto = new TextBox();
            label1 = new Label();
            txtQuantidade = new TextBox();
            label3 = new Label();
            dgvEstoque = new DataGridView();
            clnID = new DataGridViewTextBoxColumn();
            clnQuantidade = new DataGridViewTextBoxColumn();
            clnDataMovimento = new DataGridViewTextBoxColumn();
            btnPesquisar = new Button();
            dateMovimento = new DateTimePicker();
            label2 = new Label();
            label4 = new Label();
            btnAtualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).BeginInit();
            SuspendLayout();
            // 
            // txtIdProduto
            // 
            txtIdProduto.Location = new Point(87, 150);
            txtIdProduto.Name = "txtIdProduto";
            txtIdProduto.Size = new Size(47, 23);
            txtIdProduto.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(87, 126);
            label1.Name = "label1";
            label1.Size = new Size(27, 21);
            label1.TabIndex = 2;
            label1.Text = "ID";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(154, 150);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(100, 23);
            txtQuantidade.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(154, 126);
            label3.Name = "label3";
            label3.Size = new Size(100, 21);
            label3.TabIndex = 6;
            label3.Text = "Quantidade";
            // 
            // dgvEstoque
            // 
            dgvEstoque.AllowUserToAddRows = false;
            dgvEstoque.AllowUserToDeleteRows = false;
            dgvEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstoque.Columns.AddRange(new DataGridViewColumn[] { clnID, clnQuantidade, clnDataMovimento });
            dgvEstoque.Location = new Point(28, 233);
            dgvEstoque.Name = "dgvEstoque";
            dgvEstoque.ReadOnly = true;
            dgvEstoque.RowHeadersVisible = false;
            dgvEstoque.Size = new Size(453, 287);
            dgvEstoque.TabIndex = 7;
            dgvEstoque.CellContentClick += dgvEstoque_CellContentClick;
            // 
            // clnID
            // 
            clnID.Frozen = true;
            clnID.HeaderText = "ID";
            clnID.Name = "clnID";
            clnID.ReadOnly = true;
            // 
            // clnQuantidade
            // 
            clnQuantidade.HeaderText = "Quantidade";
            clnQuantidade.Name = "clnQuantidade";
            clnQuantidade.ReadOnly = true;
            // 
            // clnDataMovimento
            // 
            clnDataMovimento.HeaderText = "Data do Ultimo Movimento";
            clnDataMovimento.Name = "clnDataMovimento";
            clnDataMovimento.ReadOnly = true;
            clnDataMovimento.Width = 250;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(87, 193);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(75, 23);
            btnPesquisar.TabIndex = 8;
            btnPesquisar.Text = "&Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // dateMovimento
            // 
            dateMovimento.Format = DateTimePickerFormat.Short;
            dateMovimento.Location = new Point(271, 150);
            dateMovimento.Name = "dateMovimento";
            dateMovimento.Size = new Size(156, 23);
            dateMovimento.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(271, 127);
            label2.Name = "label2";
            label2.Size = new Size(135, 21);
            label2.TabIndex = 10;
            label2.Text = "DataMovimento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Snap ITC", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(87, 9);
            label4.Name = "label4";
            label4.Size = new Size(324, 82);
            label4.TabIndex = 11;
            label4.Text = "Estoque";
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(179, 193);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 12;
            btnAtualizar.Text = "&Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // FrmEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 532);
            Controls.Add(btnAtualizar);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(dateMovimento);
            Controls.Add(btnPesquisar);
            Controls.Add(dgvEstoque);
            Controls.Add(label3);
            Controls.Add(txtQuantidade);
            Controls.Add(label1);
            Controls.Add(txtIdProduto);
            Name = "FrmEstoque";
            Text = "FrmEstoque";
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdProduto;
        private Label label1;
        private TextBox txtQuantidade;
        private Label label3;
        private DataGridView dgvEstoque;
        private Button btnPesquisar;
        private DataGridViewTextBoxColumn clnID;
        private DataGridViewTextBoxColumn clnQuantidade;
        private DataGridViewTextBoxColumn clnDataMovimento;
        private DateTimePicker dateMovimento;
        private Label label2;
        private Label label4;
        private Button btnAtualizar;
    }
}