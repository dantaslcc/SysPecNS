﻿namespace SysPecNSDesk
{
    partial class FrmCliente
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView2 = new DataGridView();
            clnID = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnCPF = new DataGridViewTextBoxColumn();
            clnTelefone = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            clnDataNasc = new DataGridViewTextBoxColumn();
            clnDataCad = new DataGridViewTextBoxColumn();
            clnAtivo = new DataGridViewTextBoxColumn();
            btnCancelar = new Button();
            btnDeletar = new Button();
            btnEditar = new Button();
            btnInserir = new Button();
            checkBox1 = new CheckBox();
            label7 = new Label();
            label6 = new Label();
            dateCadastro = new DateTimePicker();
            dateNascimento = new DateTimePicker();
            label5 = new Label();
            txtTel = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtCpf = new TextBox();
            txtEmail = new TextBox();
            txtNome = new TextBox();
            txtID = new TextBox();
            tabPage2 = new TabPage();
            cmbTipo = new ComboBox();
            cmbUF = new ComboBox();
            label16 = new Label();
            txtId_endereco = new TextBox();
            btnConfirmar = new Button();
            dataGridView1 = new DataGridView();
            clnCep = new DataGridViewTextBoxColumn();
            clnNumero = new DataGridViewTextBoxColumn();
            clnLogradouro = new DataGridViewTextBoxColumn();
            clnComplemento = new DataGridViewTextBoxColumn();
            clnCidade = new DataGridViewTextBoxColumn();
            clnBairro = new DataGridViewTextBoxColumn();
            clnUF = new DataGridViewTextBoxColumn();
            clnTipo = new DataGridViewTextBoxColumn();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            txtCidade = new TextBox();
            txtBairro = new TextBox();
            txtComplemento = new TextBox();
            label10 = new Label();
            txtNumero = new TextBox();
            label9 = new Label();
            txtLogradouro = new TextBox();
            label8 = new Label();
            txtCep = new TextBox();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tabControl1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(546, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(6, 22);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(534, 385);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView2);
            tabPage1.Controls.Add(btnCancelar);
            tabPage1.Controls.Add(btnDeletar);
            tabPage1.Controls.Add(btnEditar);
            tabPage1.Controls.Add(btnInserir);
            tabPage1.Controls.Add(checkBox1);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(dateCadastro);
            tabPage1.Controls.Add(dateNascimento);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(txtTel);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtCpf);
            tabPage1.Controls.Add(txtEmail);
            tabPage1.Controls.Add(txtNome);
            tabPage1.Controls.Add(txtID);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(526, 357);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dados Cliente";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { clnID, clnNome, clnCPF, clnTelefone, clnEmail, clnDataNasc, clnDataCad, clnAtivo });
            dataGridView2.Location = new Point(14, 207);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.Size = new Size(480, 150);
            dataGridView2.TabIndex = 19;
            // 
            // clnID
            // 
            clnID.HeaderText = "ID";
            clnID.Name = "clnID";
            clnID.ReadOnly = true;
            // 
            // clnNome
            // 
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            // 
            // clnCPF
            // 
            clnCPF.HeaderText = "CPF";
            clnCPF.Name = "clnCPF";
            clnCPF.ReadOnly = true;
            // 
            // clnTelefone
            // 
            clnTelefone.HeaderText = "Telefone";
            clnTelefone.Name = "clnTelefone";
            clnTelefone.ReadOnly = true;
            // 
            // clnEmail
            // 
            clnEmail.HeaderText = "Email";
            clnEmail.Name = "clnEmail";
            clnEmail.ReadOnly = true;
            // 
            // clnDataNasc
            // 
            clnDataNasc.HeaderText = "Data de Nascimento";
            clnDataNasc.Name = "clnDataNasc";
            clnDataNasc.ReadOnly = true;
            // 
            // clnDataCad
            // 
            clnDataCad.HeaderText = "Data de Cadastro";
            clnDataCad.Name = "clnDataCad";
            clnDataCad.ReadOnly = true;
            // 
            // clnAtivo
            // 
            clnAtivo.HeaderText = "Ativo";
            clnAtivo.Name = "clnAtivo";
            clnAtivo.ReadOnly = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(274, 174);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(193, 174);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(75, 23);
            btnDeletar.TabIndex = 17;
            btnDeletar.Text = "&Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(112, 174);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 16;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(17, 174);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 15;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(17, 150);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(54, 19);
            checkBox1.TabIndex = 14;
            checkBox1.Text = "&Ativo";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(369, 154);
            label7.Name = "label7";
            label7.Size = new Size(98, 15);
            label7.TabIndex = 13;
            label7.Text = "Data do Cadastro";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(299, 103);
            label6.Name = "label6";
            label6.Size = new Size(114, 15);
            label6.TabIndex = 12;
            label6.Text = "Data de Nascimento";
            // 
            // dateCadastro
            // 
            dateCadastro.Format = DateTimePickerFormat.Short;
            dateCadastro.Location = new Point(369, 172);
            dateCadastro.Name = "dateCadastro";
            dateCadastro.Size = new Size(139, 23);
            dateCadastro.TabIndex = 11;
            // 
            // dateNascimento
            // 
            dateNascimento.Format = DateTimePickerFormat.Short;
            dateNascimento.Location = new Point(299, 120);
            dateNascimento.Name = "dateNascimento";
            dateNascimento.Size = new Size(148, 23);
            dateNascimento.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 102);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 9;
            label5.Text = "Telefone";
            // 
            // txtTel
            // 
            txtTel.Location = new Point(17, 120);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(253, 23);
            txtTel.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(299, 59);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 7;
            label4.Text = "CPF";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 59);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 6;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 15);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 5;
            label2.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 15);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 4;
            label1.Text = "ID";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(299, 77);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(148, 23);
            txtCpf.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(17, 77);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(253, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(87, 33);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(349, 23);
            txtNome.TabIndex = 1;
            // 
            // txtID
            // 
            txtID.Location = new Point(17, 33);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(51, 23);
            txtID.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(cmbTipo);
            tabPage2.Controls.Add(cmbUF);
            tabPage2.Controls.Add(label16);
            tabPage2.Controls.Add(txtId_endereco);
            tabPage2.Controls.Add(btnConfirmar);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(txtCidade);
            tabPage2.Controls.Add(txtBairro);
            tabPage2.Controls.Add(txtComplemento);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(txtNumero);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(txtLogradouro);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(txtCep);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(526, 357);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Enderecos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "RES - Rendencial", "COM - Comercial", "ENT - Entrega", "COB - Cobrança", "RET - Retirada", "TMP - Temporario" });
            cmbTipo.Location = new Point(20, 167);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(121, 23);
            cmbTipo.TabIndex = 21;
            // 
            // cmbUF
            // 
            cmbUF.FormattingEnabled = true;
            cmbUF.Items.AddRange(new object[] { "Rondônia\t RO", "Acre\tAC", "Amazonas\t AM", "Roraima\tRR", "Pará\tPA", "Amapá\tAP", "Tocantins\tTO", "Maranhão\t MA", "Piauí\tPI", "Ceará\tCE", "Paraíba\tPB", "Pernambuco\tPE", "Alagoas\t AL", "Sergipe\tSE", "Bahia\tBA", "Minas Gerais\tMG", "Espírito Santo\tES", "Rio de Janeiro\tRJ", "São Paulo\t SP", "Paraná\tPR", "Santa Catarina\tSC", "Mato Grosso\tMT", "Goiás\tGO", "Distrito Federal\tDF" });
            cmbUF.Location = new Point(355, 123);
            cmbUF.Name = "cmbUF";
            cmbUF.Size = new Size(147, 23);
            cmbUF.TabIndex = 20;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(247, 17);
            label16.Name = "label16";
            label16.Size = new Size(18, 15);
            label16.TabIndex = 19;
            label16.Text = "ID";
            // 
            // txtId_endereco
            // 
            txtId_endereco.Location = new Point(247, 35);
            txtId_endereco.Name = "txtId_endereco";
            txtId_endereco.Size = new Size(42, 23);
            txtId_endereco.TabIndex = 18;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(165, 166);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 23);
            btnConfirmar.TabIndex = 17;
            btnConfirmar.Text = "&Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clnCep, clnNumero, clnLogradouro, clnComplemento, clnCidade, clnBairro, clnUF, clnTipo });
            dataGridView1.Location = new Point(20, 204);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(482, 150);
            dataGridView1.TabIndex = 16;
            // 
            // clnCep
            // 
            clnCep.HeaderText = "CEP";
            clnCep.Name = "clnCep";
            clnCep.ReadOnly = true;
            // 
            // clnNumero
            // 
            clnNumero.HeaderText = "Numero";
            clnNumero.Name = "clnNumero";
            clnNumero.ReadOnly = true;
            // 
            // clnLogradouro
            // 
            clnLogradouro.HeaderText = "Logradouro";
            clnLogradouro.Name = "clnLogradouro";
            clnLogradouro.ReadOnly = true;
            // 
            // clnComplemento
            // 
            clnComplemento.HeaderText = "Complemento";
            clnComplemento.Name = "clnComplemento";
            clnComplemento.ReadOnly = true;
            // 
            // clnCidade
            // 
            clnCidade.HeaderText = "Cidade";
            clnCidade.Name = "clnCidade";
            clnCidade.ReadOnly = true;
            // 
            // clnBairro
            // 
            clnBairro.HeaderText = "Bairro";
            clnBairro.Name = "clnBairro";
            clnBairro.ReadOnly = true;
            // 
            // clnUF
            // 
            clnUF.HeaderText = "UF";
            clnUF.Name = "clnUF";
            clnUF.ReadOnly = true;
            // 
            // clnTipo
            // 
            clnTipo.HeaderText = "Tipo";
            clnTipo.Name = "clnTipo";
            clnTipo.ReadOnly = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(20, 149);
            label15.Name = "label15";
            label15.Size = new Size(30, 15);
            label15.TabIndex = 15;
            label15.Text = "Tipo";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(355, 105);
            label14.Name = "label14";
            label14.Size = new Size(21, 15);
            label14.TabIndex = 14;
            label14.Text = "UF";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(355, 61);
            label13.Name = "label13";
            label13.Size = new Size(44, 15);
            label13.TabIndex = 13;
            label13.Text = "Cidade";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(20, 105);
            label12.Name = "label12";
            label12.Size = new Size(38, 15);
            label12.TabIndex = 12;
            label12.Text = "Bairro";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(165, 61);
            label11.Name = "label11";
            label11.Size = new Size(84, 15);
            label11.TabIndex = 11;
            label11.Text = "Complemento";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(355, 79);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(147, 23);
            txtCidade.TabIndex = 8;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(20, 123);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(308, 23);
            txtBairro.TabIndex = 7;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(165, 79);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(155, 23);
            txtComplemento.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(165, 17);
            label10.Name = "label10";
            label10.Size = new Size(51, 15);
            label10.TabIndex = 5;
            label10.Text = "Numero";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(166, 35);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(54, 23);
            txtNumero.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(20, 61);
            label9.Name = "label9";
            label9.Size = new Size(69, 15);
            label9.TabIndex = 3;
            label9.Text = "Logradouro";
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(20, 79);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(126, 23);
            txtLogradouro.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 17);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 1;
            label8.Text = "CEP";
            // 
            // txtCep
            // 
            txtCep.Location = new Point(20, 35);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(126, 23);
            txtCep.TabIndex = 0;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 450);
            Controls.Add(groupBox1);
            Name = "FrmCliente";
            Text = "FrmCliente";
            groupBox1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox txtNome;
        private TextBox txtID;
        private TextBox txtCpf;
        private TextBox txtEmail;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateNascimento;
        private Label label5;
        private TextBox txtTel;
        private Label label6;
        private DateTimePicker dateCadastro;
        private CheckBox checkBox1;
        private Label label7;
        private Button btnDeletar;
        private Button btnEditar;
        private Button btnInserir;
        private Button btnCancelar;
        private TextBox txtCep;
        private Label label8;
        private Label label9;
        private TextBox txtLogradouro;
        private TextBox txtBairro;
        private TextBox txtComplemento;
        private Label label10;
        private TextBox txtNumero;
        private TextBox txtCidade;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label14;
        private Label label15;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn clnCep;
        private DataGridViewTextBoxColumn clnNumero;
        private DataGridViewTextBoxColumn clnLogradouro;
        private DataGridViewTextBoxColumn clnComplemento;
        private DataGridViewTextBoxColumn clnCidade;
        private DataGridViewTextBoxColumn clnBairro;
        private DataGridViewTextBoxColumn clnUF;
        private DataGridViewTextBoxColumn clnTipo;
        private Button btnConfirmar;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn clnID;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnCPF;
        private DataGridViewTextBoxColumn clnTelefone;
        private DataGridViewTextBoxColumn clnEmail;
        private DataGridViewTextBoxColumn clnDataNasc;
        private DataGridViewTextBoxColumn clnDataCad;
        private DataGridViewTextBoxColumn clnAtivo;
        private Label label16;
        private TextBox txtId_endereco;
        private ComboBox cmbUF;
        private ComboBox cmbTipo;
    }
}