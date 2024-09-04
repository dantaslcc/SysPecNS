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
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            var categorias = Categoria.ObterLista();
            cmbCategoria.DataSource = categorias;
            cmbCategoria.DisplayMember = "Nome";
            cmbCategoria.ValueMember = "id";

            var lista = Produto.obterLista();
            dgvProdutos.Rows.Clear();
            int count = 0;
            foreach (var produto in lista)
            {
                dgvProdutos.Rows.Add();
                dgvProdutos.Rows[count].Cells[0].Value = produto.Id;
                dgvProdutos.Rows[count].Cells[1].Value = produto.CodBar;
                dgvProdutos.Rows[count].Cells[2].Value = produto.Descricao;
                dgvProdutos.Rows[count].Cells[3].Value = produto.ValorUnit;
                dgvProdutos.Rows[count].Cells[4].Value = produto.UnidadeVenda;
                dgvProdutos.Rows[count].Cells[5].Value = produto.Categoria.Nome;
                dgvProdutos.Rows[count].Cells[6].Value = produto.EstoqueMinimo;
                dgvProdutos.Rows[count].Cells[7].Value = produto.ClasseDesconto;
                dgvProdutos.Rows[count].Cells[8].Value = produto.DataCad;
                count++;

            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Produto produto = new(txtCodBar.Text, txtDescricao.Text,
                double.Parse(txtValorUni.Text), txtUnidadeVenda.Text,
                Categoria.ObterporId(Convert.ToInt32(cmbCategoria.SelectedValue)),
                (int)npEstoqueMinimo.Value, double.Parse(txtDesconto.Text)
                );
            produto.Inserir();
            if (produto.Id > 0)
            {
                MessageBox.Show($"Produto gravado com sucesso com o ID {produto.Id}");
                FrmProduto_Load(sender, e);
            }
        }
        private void LimpaControles()
        {
            txtCodBar.Clear();
            txtValorUni.Clear();
            txtDescricao.Clear();
            txtDesconto.Clear();
            txtUnidadeVenda.Clear();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (btnConsultar.Text == "&Consultar")
            {
                txtCodBar.Clear();
                txtValorUni.Clear();
                txtDescricao.Clear();
                txtDesconto.Clear();
                txtUnidadeVenda.Clear();
                npEstoqueMinimo.Value = 0;
                btnConsultar.Text = "&Obter por ID";
                txtID.Focus();
                txtID.ReadOnly = false;
            }
            else
            {
                if (txtID.Text.Length > 0)
                {
                    Produto produto = Produto.obterPorId(int.Parse(txtID.Text));
                    txtCodBar.Text = produto.CodBar;
                    txtValorUni.Text = Convert.ToString(produto.ValorUnit);
                    txtDescricao.Text = produto.Descricao;
                    txtDesconto.Text = produto.ClasseDesconto.ToString();
                    txtUnidadeVenda.Text = produto.UnidadeVenda;
                    cmbCategoria.SelectedIndex =
                        cmbCategoria.FindString(produto.Categoria.Nome);
                    btnEditar.Enabled = true;
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Produto produto = new(
                int.Parse(txtID.Text),
                txtCodBar.Text,
                txtDescricao.Text,
                double.Parse(txtValorUni.Text),
                txtUnidadeVenda.Text,
                Categoria.ObterporId(Convert.ToInt32(cmbCategoria.SelectedValue)),
                (double)npEstoqueMinimo.Value,
                double.Parse(txtDesconto.Text),
                null,
                null
                );
            produto.Atualizar(); // gravar as alterações no banco
            MessageBox.Show($"Produto {produto.Descricao} atualizado com sucesso!");
            btnEditar.Enabled = false;
            txtID.ReadOnly = true;
            btnConsultar.Text = "&Consultar";
            LimpaControles();

        }
    }
}
