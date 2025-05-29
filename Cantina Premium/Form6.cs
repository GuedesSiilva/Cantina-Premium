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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form6_Load);
        }

        private void Pedidos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            PedidosBalcao.Items.Clear();
            foreach (var pedido in PreparoPedidos.Instancia.Pedidos)
            {
                PedidosBalcao.Items.Add(pedido);
            }
            foreach (var hist in HistoricoGlobal.HistoricoPedidos)
            {
                HistoricoBalcao.Items.Add(hist);
            }
        }

        private void PedidosBalcao_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComandaBalcao.Items.Clear();
            if (PedidosBalcao.SelectedItem is Pedido pedidoselecionado)
            {
                foreach (Cardapio item in pedidoselecionado.Itens)
                {
                    ComandaBalcao.Items.Add($"{item.Nome} - Quantidade: {item.Quantidade} - {pedidoselecionado.Tipo}");
                }
            }
        }

        private void HistoricoBalcao_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void ComandaBalcao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComandaBalcao_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string PedidoPronto = (string)PedidosBalcao.SelectedItem;
            PedidosBalcao.Items.Remove(PedidoPronto);

            if (HistoricoBalcao.SelectedItem == null)
            {
                MessageBox.Show("Nenhum item selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (HistoricoBalcao.SelectedItem is Pedido pedidoSelecionado)
            {
                pedidoSelecionado.Status = "Entregue";
                int idx = PedidosBalcao.SelectedIndex;
                PedidosBalcao.Items[idx] = pedidoSelecionado;
                string historicoTexto = $"Pedido #{pedidoSelecionado.Id} - Cliente: {pedidoSelecionado.NomeCliente} - {pedidoSelecionado.Status}";
                if (HistoricoBalcao.Items.Contains(historicoTexto))
                {
                    MessageBox.Show("Este pedido já foi entregue", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    HistoricoBalcao.Items.Add(historicoTexto);
                }
            }
        }
    }
}
