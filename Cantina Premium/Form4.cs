using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantina_Premium
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Pedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Preparando.Items.Clear();
            if (Pedidos.SelectedItem is Pedido pedidoselecionado)
            {
                foreach (Cardapio item in pedidoselecionado.Itens.Where(vaipara => vaipara.Chapa))
                {
                    Preparando.Items.Add($"Item: {item.Nome} - Quantidade: {item.Quantidade}");
                }
            }
        }

        private void Preparando_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Pedidos.Items.Clear();

            foreach (var pedido in PreparoPedidos.Instancia.Pedidos)
            {
                Pedidos.Items.Add(pedido);
                Pedidos.Items.Add(" ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Pedidos.SelectedItem == null)
            {
                MessageBox.Show("Nenhum item selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Pedido PedidoSelecionado = (Pedido)Pedidos.SelectedItem;
                DialogResult resultado = MessageBox.Show("Deseja cancelar este pedido ? ", "Cancelamento", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (resultado == DialogResult.Yes)
                {
                    PreparoPedidos.Instancia.Pedidos.Remove(PedidoSelecionado);
                    MessageBox.Show("Pedido cancelado com sucesso", "Cancelamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form4_Load(null, null);
                }
                if (resultado == DialogResult.No)
                {
                    MessageBox.Show("Pedido não cancelado", "Cancelamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (Pedidos.SelectedItem == null)
            {
                MessageBox.Show("Nenhum item selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Pedidos.SelectedItem is Pedido pedidoSelecionado)
            {
                pedidoSelecionado.Status = "Preparando";
                int idx = Pedidos.SelectedIndex;
                Pedidos.Items[idx] = pedidoSelecionado;
                string historicoTexto = $"Pedido #{pedidoSelecionado.Id} - Cliente: {pedidoSelecionado.NomeCliente} - {pedidoSelecionado.Status}";
                if (Historico.Items.Contains(historicoTexto))
                {
                    MessageBox.Show("Este pedido já está em preparo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Historico.Items.Add(historicoTexto);
                }
            }
        }

        private void Historico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
