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
              txtLogradouro.Text,
              txtNumero.Text,
              txtComplemento.Text,
              txtBairro.Text,
              txtCidade.Text,
              cmbUF.Text,
              cmbTipo.Text

              );

            endereco.Inserir();
            if (endereco.Id > 0)
            {
                txtId_endereco.Text = endereco.Id.ToString();
                MessageBox.Show($"O Endereço, Foi inserido com sucesso, com o ID do cliente{endereco.Id}");
                txtCep.Clear();
                txtLogradouro.Clear();
                txtNumero.Clear();
                txtComplemento.Clear();
                txtBairro.Clear();
                txtCidade.Clear();
                cmbUF.Focus();
                cmbTipo.Focus();
                txtId_endereco.Text = endereco.Id.ToString();
            }
            else
            {
                MessageBox.Show("Falha ao gravar o endereço do cliente!");
            }


        }
    }
}
