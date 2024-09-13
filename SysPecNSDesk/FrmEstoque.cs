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
    public partial class FrmEstoque : Form
    {
        public FrmEstoque()
        {
            InitializeComponent();
        }

        private void dgvEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            {

                Estoque estoque = new(
                     Convert.ToInt32(txtIdProduto.Text),
                     Convert.ToDouble(txtQuantidade.Text),
                     dateMovimento.Value = DateTime.Now

                     );

                estoque.Inserir();
                if (estoque.Id > 0)
                {
                    txtIdProduto.Text = estoque.Id.ToString();
                    MessageBox.Show("Sucesso!!");

                    txtIdProduto.Clear();
                    txtQuantidade.Clear();

                }



            }
        }     
    }
}
