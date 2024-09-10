namespace SysPecNSDesk
{
    partial class FrmPedidoNovo
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
            grbIdentificao = new GroupBox();
            btnInserePedido = new Button();
            txtCliente = new TextBox();
            txtUsuario = new TextBox();
            txtIdCliente = new TextBox();
            label3 = new Label();
            label4 = new Label();
            grbItens = new GroupBox();
            textBox1 = new TextBox();
            la = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtDescontoItem = new TextBox();
            txtQuantidade = new TextBox();
            txtValorUnit = new TextBox();
            txtCodBar = new TextBox();
            txtDescricao = new TextBox();
            btnAddItem = new Button();
            dgvItensPedido = new DataGridView();
            clnSeq = new DataGridViewTextBoxColumn();
            clnCodBar = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnValorUnit = new DataGridViewTextBoxColumn();
            clnQuantidade = new DataGridViewTextBoxColumn();
            clnDescontoItem = new DataGridViewTextBoxColumn();
            clnTotalItem = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            txtIdPedido = new TextBox();
            txtDescontoItens = new TextBox();
            txtDescontoPedido = new TextBox();
            textBox4 = new TextBox();
            btnFechar = new Button();
            txtSubTotal = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            grbIdentificao.SuspendLayout();
            grbItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).BeginInit();
            SuspendLayout();
            // 
            // grbIdentificao
            // 
            grbIdentificao.Controls.Add(btnInserePedido);
            grbIdentificao.Controls.Add(txtCliente);
            grbIdentificao.Controls.Add(txtUsuario);
            grbIdentificao.Controls.Add(txtIdCliente);
            grbIdentificao.Controls.Add(label3);
            grbIdentificao.Controls.Add(label4);
            grbIdentificao.Location = new Point(36, 52);
            grbIdentificao.Name = "grbIdentificao";
            grbIdentificao.Size = new Size(638, 144);
            grbIdentificao.TabIndex = 0;
            grbIdentificao.TabStop = false;
            grbIdentificao.Text = "Identificação";
            // 
            // btnInserePedido
            // 
            btnInserePedido.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInserePedido.Location = new Point(326, 38);
            btnInserePedido.Name = "btnInserePedido";
            btnInserePedido.Size = new Size(75, 60);
            btnInserePedido.TabIndex = 5;
            btnInserePedido.Text = "&Abrir";
            btnInserePedido.UseVisualStyleBackColor = true;
            btnInserePedido.Click += btnInserePedido_Click;
            // 
            // txtCliente
            // 
            txtCliente.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCliente.Location = new Point(124, 85);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(157, 27);
            txtCliente.TabIndex = 1;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(68, 31);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = true;
            txtUsuario.Size = new Size(213, 27);
            txtUsuario.TabIndex = 1;
            // 
            // txtIdCliente
            // 
            txtIdCliente.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdCliente.Location = new Point(71, 85);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(47, 27);
            txtIdCliente.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 38);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 0;
            label3.Text = "Usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 92);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 3;
            label4.Text = "Cliente";
            // 
            // grbItens
            // 
            grbItens.Controls.Add(textBox1);
            grbItens.Controls.Add(la);
            grbItens.Controls.Add(label9);
            grbItens.Controls.Add(label8);
            grbItens.Controls.Add(label7);
            grbItens.Controls.Add(label6);
            grbItens.Controls.Add(label5);
            grbItens.Controls.Add(txtDescontoItem);
            grbItens.Controls.Add(txtQuantidade);
            grbItens.Controls.Add(txtValorUnit);
            grbItens.Controls.Add(txtCodBar);
            grbItens.Controls.Add(txtDescricao);
            grbItens.Controls.Add(btnAddItem);
            grbItens.Controls.Add(dgvItensPedido);
            grbItens.Enabled = false;
            grbItens.Location = new Point(36, 202);
            grbItens.Name = "grbItens";
            grbItens.Size = new Size(640, 268);
            grbItens.TabIndex = 1;
            grbItens.TabStop = false;
            grbItens.Text = "Itens do Pedido";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(532, 229);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(100, 33);
            textBox1.TabIndex = 13;
            // 
            // la
            // 
            la.AutoSize = true;
            la.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            la.Location = new Point(445, 232);
            la.Name = "la";
            la.Size = new Size(81, 25);
            la.TabIndex = 12;
            la.Text = "Total R$";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(445, 27);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 11;
            label9.Text = "Desconto";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(375, 27);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 10;
            label8.Text = "Quant.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(298, 27);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 9;
            label7.Text = "Valor Unit";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(124, 27);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 8;
            label6.Text = "Descriçao";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 27);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 7;
            label5.Text = "Codigo de Barras";
            // 
            // txtDescontoItem
            // 
            txtDescontoItem.Location = new Point(445, 45);
            txtDescontoItem.Name = "txtDescontoItem";
            txtDescontoItem.Size = new Size(100, 23);
            txtDescontoItem.TabIndex = 4;
            txtDescontoItem.Text = "0";
            txtDescontoItem.TextAlign = HorizontalAlignment.Right;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(375, 45);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(59, 23);
            txtQuantidade.TabIndex = 3;
            txtQuantidade.Text = "1";
            txtQuantidade.TextAlign = HorizontalAlignment.Right;
            // 
            // txtValorUnit
            // 
            txtValorUnit.Location = new Point(305, 45);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.Size = new Size(51, 23);
            txtValorUnit.TabIndex = 2;
            // 
            // txtCodBar
            // 
            txtCodBar.Location = new Point(6, 45);
            txtCodBar.Name = "txtCodBar";
            txtCodBar.Size = new Size(97, 23);
            txtCodBar.TabIndex = 0;
            txtCodBar.Leave += txtCodBar_Leave;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(124, 45);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(165, 23);
            txtDescricao.TabIndex = 1;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(557, 45);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(75, 24);
            btnAddItem.TabIndex = 5;
            btnAddItem.Text = "A&dicionar";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // dgvItensPedido
            // 
            dgvItensPedido.AllowUserToAddRows = false;
            dgvItensPedido.AllowUserToDeleteRows = false;
            dgvItensPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItensPedido.Columns.AddRange(new DataGridViewColumn[] { clnSeq, clnCodBar, clnDescricao, clnValorUnit, clnQuantidade, clnDescontoItem, clnTotalItem });
            dgvItensPedido.Location = new Point(6, 72);
            dgvItensPedido.Name = "dgvItensPedido";
            dgvItensPedido.ReadOnly = true;
            dgvItensPedido.RowHeadersVisible = false;
            dgvItensPedido.Size = new Size(628, 151);
            dgvItensPedido.TabIndex = 0;
            // 
            // clnSeq
            // 
            clnSeq.Frozen = true;
            clnSeq.HeaderText = "#SEQ";
            clnSeq.Name = "clnSeq";
            clnSeq.ReadOnly = true;
            clnSeq.Width = 40;
            // 
            // clnCodBar
            // 
            clnCodBar.Frozen = true;
            clnCodBar.HeaderText = "Cod Barras";
            clnCodBar.Name = "clnCodBar";
            clnCodBar.ReadOnly = true;
            clnCodBar.Width = 90;
            // 
            // clnDescricao
            // 
            clnDescricao.Frozen = true;
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            clnDescricao.Width = 170;
            // 
            // clnValorUnit
            // 
            clnValorUnit.Frozen = true;
            clnValorUnit.HeaderText = "Valor Unit";
            clnValorUnit.Name = "clnValorUnit";
            clnValorUnit.ReadOnly = true;
            clnValorUnit.Width = 90;
            // 
            // clnQuantidade
            // 
            clnQuantidade.Frozen = true;
            clnQuantidade.HeaderText = "Quant";
            clnQuantidade.Name = "clnQuantidade";
            clnQuantidade.ReadOnly = true;
            // 
            // clnDescontoItem
            // 
            clnDescontoItem.Frozen = true;
            clnDescontoItem.HeaderText = "Desconto";
            clnDescontoItem.Name = "clnDescontoItem";
            clnDescontoItem.ReadOnly = true;
            clnDescontoItem.Width = 70;
            // 
            // clnTotalItem
            // 
            clnTotalItem.Frozen = true;
            clnTotalItem.HeaderText = "Total";
            clnTotalItem.Name = "clnTotalItem";
            clnTotalItem.ReadOnly = true;
            clnTotalItem.Width = 90;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Goudy Stout", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(313, 12);
            label1.Name = "label1";
            label1.Size = new Size(345, 37);
            label1.TabIndex = 2;
            label1.Text = "Novo Pedido";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(694, 63);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Numero";
            // 
            // txtIdPedido
            // 
            txtIdPedido.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdPedido.Location = new Point(751, 52);
            txtIdPedido.Name = "txtIdPedido";
            txtIdPedido.Size = new Size(174, 33);
            txtIdPedido.TabIndex = 4;
            // 
            // txtDescontoItens
            // 
            txtDescontoItens.Location = new Point(769, 295);
            txtDescontoItens.Name = "txtDescontoItens";
            txtDescontoItens.ReadOnly = true;
            txtDescontoItens.Size = new Size(100, 23);
            txtDescontoItens.TabIndex = 5;
            // 
            // txtDescontoPedido
            // 
            txtDescontoPedido.Location = new Point(769, 342);
            txtDescontoPedido.Name = "txtDescontoPedido";
            txtDescontoPedido.Size = new Size(100, 23);
            txtDescontoPedido.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(769, 387);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(100, 29);
            textBox4.TabIndex = 6;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(778, 434);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 24);
            btnFechar.TabIndex = 2;
            btnFechar.Text = "&Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(769, 247);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(100, 23);
            txtSubTotal.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(791, 229);
            label10.Name = "label10";
            label10.Size = new Size(52, 15);
            label10.TabIndex = 3;
            label10.Text = "SubTotal";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(778, 277);
            label11.Name = "label11";
            label11.Size = new Size(85, 15);
            label11.TabIndex = 3;
            label11.Text = "Desconto Itens";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(791, 324);
            label12.Name = "label12";
            label12.Size = new Size(60, 15);
            label12.TabIndex = 3;
            label12.Text = "Desconto ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(802, 369);
            label13.Name = "label13";
            label13.Size = new Size(32, 15);
            label13.TabIndex = 3;
            label13.Text = "Total";
            // 
            // FrmPedidoNovo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 482);
            Controls.Add(textBox4);
            Controls.Add(txtDescontoPedido);
            Controls.Add(txtSubTotal);
            Controls.Add(txtDescontoItens);
            Controls.Add(txtIdPedido);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(grbItens);
            Controls.Add(grbIdentificao);
            Controls.Add(btnFechar);
            Name = "FrmPedidoNovo";
            Text = "FrmPedidoNovo";
            Load += FrmPedidoNovo_Load;
            grbIdentificao.ResumeLayout(false);
            grbIdentificao.PerformLayout();
            grbItens.ResumeLayout(false);
            grbItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbIdentificao;
        private GroupBox grbItens;
        private Label label3;
        private Label label1;
        private Label label2;
        private TextBox txtIdPedido;
        private TextBox txtCliente;
        private TextBox txtUsuario;
        private Label label4;
        private TextBox txtIdCliente;
        private Button btnInserePedido;
        private TextBox txtValorUnit;
        private TextBox txtCodBar;
        private TextBox txtDescricao;
        private Button btnAddItem;
        private DataGridView dgvItensPedido;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtDescontoItem;
        private TextBox txtQuantidade;
        private TextBox textBox1;
        private Label la;
        private TextBox txtDescontoItens;
        private TextBox txtDescontoPedido;
        private TextBox textBox4;
        private Button btnFechar;
        private TextBox txtSubTotal;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private DataGridViewTextBoxColumn clnSeq;
        private DataGridViewTextBoxColumn clnCodBar;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnValorUnit;
        private DataGridViewTextBoxColumn clnQuantidade;
        private DataGridViewTextBoxColumn clnDescontoItem;
        private DataGridViewTextBoxColumn clnTotalItem;
    }
}