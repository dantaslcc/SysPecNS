﻿using SysPecNSLib;
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
    public partial class FrmPedidoNovo : Form
    {
        public FrmPedidoNovo()
        {
            InitializeComponent();
        }

        private void FrmPedidoNovo_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = Program.UsuarioLogado.Id + " - " + Program.UsuarioLogado.Nome;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInsererPedido_Click(object sender, EventArgs e)
        {
            Pedido pedido = new(
            Program.UsuarioLogado,
            Cliente.ObterporId(int.Parse(txtIdCliente.Text)), 0
            );
            txtIdPedido.Text = pedido.Id.ToString();
            MessageBox.Show($"Novo Pedido criado - {pedido.Id} ");
        }
    }
}
