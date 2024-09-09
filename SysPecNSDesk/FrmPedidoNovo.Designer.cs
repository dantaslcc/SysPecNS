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
            groupBox1 = new GroupBox();
            btnInserePedido = new Button();
            txtIdCliente = new TextBox();
            label4 = new Label();
            txtCliente = new TextBox();
            txtUsuario = new TextBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            txtIdPedido = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnInserePedido);
            groupBox1.Controls.Add(txtIdCliente);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtCliente);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(36, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(456, 144);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Identificação";
            // 
            // btnInserePedido
            // 
            btnInserePedido.Location = new Point(361, 88);
            btnInserePedido.Name = "btnInserePedido";
            btnInserePedido.Size = new Size(75, 23);
            btnInserePedido.TabIndex = 5;
            btnInserePedido.Text = "&Abrir";
            btnInserePedido.UseVisualStyleBackColor = true;
            btnInserePedido.Click += btnInsererPedido_Click;
            // 
            // txtIdCliente
            // 
            txtIdCliente.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdCliente.Location = new Point(132, 85);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(47, 27);
            txtIdCliente.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(79, 88);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 3;
            label4.Text = "Cliente";
            // 
            // txtCliente
            // 
            txtCliente.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCliente.Location = new Point(185, 85);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(157, 27);
            txtCliente.TabIndex = 2;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(132, 31);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = true;
            txtUsuario.Size = new Size(157, 27);
            txtUsuario.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 38);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 0;
            label3.Text = "Usuario";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(36, 230);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(456, 224);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Itens do Pedido";
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
            label2.Location = new Point(530, 214);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Numero";
            // 
            // txtIdPedido
            // 
            txtIdPedido.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdPedido.Location = new Point(587, 203);
            txtIdPedido.Name = "txtIdPedido";
            txtIdPedido.Size = new Size(174, 33);
            txtIdPedido.TabIndex = 4;
            // 
            // FrmPedidoNovo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 482);
            Controls.Add(txtIdPedido);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmPedidoNovo";
            Text = "FrmPedidoNovo";
            Load += FrmPedidoNovo_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label3;
        private Label label1;
        private Label label2;
        private TextBox txtIdPedido;
        private TextBox txtCliente;
        private TextBox txtUsuario;
        private Label label4;
        private TextBox txtIdCliente;
        private Button btnInserePedido;
    }
}