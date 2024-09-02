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

        private void label3_Click(object sender, EventArgs e)
        {

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


            }
            else
            {
                MessageBox.Show("Falha ao gravar o cliente!");
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
