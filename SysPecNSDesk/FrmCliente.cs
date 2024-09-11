using MySqlX.XDevAPI;
using SysPecNSLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysPecNSDesk
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }


        private void btnInserir_Click(object sender, EventArgs e)
        {

            // MessageBox.Show(cmbNivel.SelectedValue.ToString());
            Cliente cliente = new(
                    txtNome.Text,
                    txtEmail.Text,
                    txtCpf.Text,
                    txtTel.Text,
                    dateCadastro.Value,
                    dateNascimento.Value = DateTime.Now
                );
            cliente.Inserir();
            if (cliente.Id > 0)
            {
                txtID.Text = cliente.Id.ToString();
                MessageBox.Show($"O usuário {cliente.Nome}, " +
                    $"foi inserido com sucesso, com o ID {cliente.Id} ");
                txtID.Clear();
                txtNome.Clear();
                txtEmail.Clear();
                txtCpf.Clear();
                txtTel.Clear();
                txtNome.Focus();
                txtId_endereco.Text = cliente.Id.ToString();


            }
            else
            {
                MessageBox.Show("Falha ao gravar o cliente!");
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Endereco endereco = new(
              Cliente.ObterporId(int.Parse(txtId_endereco.Text)),
              txtCep.Text,
              txtNumero.Text,
              txtLogradouro.Text,
              txtComplemento.Text,
              txtCidade.Text,
              txtBairro.Text,
              txtUF.Text,
              txtTipo.Text

              );
            endereco.Inserir();
            if (endereco.Id > 0)
            {
                txtID.Text = endereco.Id.ToString(); // para limpar apos o comando ser executado.
                txtID.Clear();
                txtNome.Clear();
                txtEmail.Clear();
                txtCpf.Clear();
                txtTel.Clear();
                txtNome.Focus();


            }
        }
    }
}
