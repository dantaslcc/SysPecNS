namespace SysPecNSDesk
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
            label9 = new Label();
            textBox2 = new TextBox();
            label8 = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            label10 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
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
            // btnCancelar
            // 
            btnCancelar.Location = new Point(308, 253);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(218, 253);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(75, 23);
            btnDeletar.TabIndex = 17;
            btnDeletar.Text = "&Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(126, 253);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 16;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(29, 253);
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
            checkBox1.Location = new Point(29, 191);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(54, 19);
            checkBox1.TabIndex = 14;
            checkBox1.Text = "&Ativo";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(308, 191);
            label7.Name = "label7";
            label7.Size = new Size(98, 15);
            label7.TabIndex = 13;
            label7.Text = "Data do Cadastro";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(308, 137);
            label6.Name = "label6";
            label6.Size = new Size(114, 15);
            label6.TabIndex = 12;
            label6.Text = "Data de Nascimento";
            // 
            // dateCadastro
            // 
            dateCadastro.Format = DateTimePickerFormat.Short;
            dateCadastro.Location = new Point(308, 209);
            dateCadastro.Name = "dateCadastro";
            dateCadastro.Size = new Size(139, 23);
            dateCadastro.TabIndex = 11;
            // 
            // dateNascimento
            // 
            dateNascimento.Format = DateTimePickerFormat.Short;
            dateNascimento.Location = new Point(308, 155);
            dateNascimento.Name = "dateNascimento";
            dateNascimento.Size = new Size(139, 23);
            dateNascimento.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 137);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 9;
            label5.Text = "Telefone";
            // 
            // txtTel
            // 
            txtTel.Location = new Point(29, 155);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(253, 23);
            txtTel.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(299, 84);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 7;
            label4.Text = "CPF";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 84);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 6;
            label3.Text = "Email";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 34);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 5;
            label2.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 34);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 4;
            label1.Text = "ID";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(299, 102);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(148, 23);
            txtCpf.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(29, 102);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(253, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(98, 52);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(349, 23);
            txtNome.TabIndex = 1;
            // 
            // txtID
            // 
            txtID.Location = new Point(29, 52);
            txtID.Name = "txtID";
            txtID.Size = new Size(51, 23);
            txtID.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(textBox8);
            tabPage2.Controls.Add(textBox7);
            tabPage2.Controls.Add(textBox6);
            tabPage2.Controls.Add(textBox5);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(526, 357);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Enderecos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 66);
            label9.Name = "label9";
            label9.Size = new Size(69, 15);
            label9.TabIndex = 3;
            label9.Text = "Logradouro";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(20, 87);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(126, 23);
            textBox2.TabIndex = 2;
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
            // textBox1
            // 
            textBox1.Location = new Point(20, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(126, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(166, 35);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(54, 23);
            textBox3.TabIndex = 4;
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
            // textBox4
            // 
            textBox4.Location = new Point(173, 87);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(155, 23);
            textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(20, 140);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(308, 23);
            textBox5.TabIndex = 7;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(355, 140);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 8;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(20, 195);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(137, 23);
            textBox7.TabIndex = 9;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(191, 195);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(173, 69);
            label11.Name = "label11";
            label11.Size = new Size(84, 15);
            label11.TabIndex = 11;
            label11.Text = "Complemento";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(20, 122);
            label12.Name = "label12";
            label12.Size = new Size(38, 15);
            label12.TabIndex = 12;
            label12.Text = "Bairro";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(355, 122);
            label13.Name = "label13";
            label13.Size = new Size(44, 15);
            label13.TabIndex = 13;
            label13.Text = "Cidade";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(21, 176);
            label14.Name = "label14";
            label14.Size = new Size(21, 15);
            label14.TabIndex = 14;
            label14.Text = "UF";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(193, 176);
            label15.Name = "label15";
            label15.Size = new Size(30, 15);
            label15.TabIndex = 15;
            label15.Text = "Tipo";
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
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
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
        private TextBox textBox1;
        private Label label8;
        private Label label9;
        private TextBox textBox2;
        private TextBox textBox5;
        private TextBox textBox4;
        private Label label10;
        private TextBox textBox3;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label14;
        private Label label15;
    }
}