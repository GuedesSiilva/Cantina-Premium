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
            foreach (var pedido in HistoricoGlobal.HistoricoPedidos)
            {
                if (pedido.Status == "- Finalizado")
                {
                    PedidosBalcao.Items.Add(pedido);
                }
            }
        }

        private void PedidosBalcao_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComandaBalcao.Items.Clear();
            if (PedidosBalcao.SelectedItem is Pedido pedidoselecionado)
            {
                foreach (Cardapio item in pedidoselecionado.Itens)
                {
                    ComandaBalcao.Items.Add($"{item.Nome} - Quantidade: {item.Quantidade} {pedidoselecionado.Tipo}");
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
            if (PedidosBalcao.SelectedItem is Pedido pedidoSelecionado)
            {
                DialogResult resultado = MessageBox.Show("Este pedido está pronto para entrega? ", "Entrega", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (resultado == DialogResult.Yes)
                {
                    pedidoSelecionado.Status = "- Entregue";
                    PedidosBalcao.Items[PedidosBalcao.SelectedIndex] = pedidoSelecionado;
                    PreparoPedidos.Instancia.Pedidos.Remove(pedidoSelecionado);
                    PedidosBalcao.Items.Remove(pedidoSelecionado);
                    ComandaBalcao.Items.Clear();
                    HistoricoBalcao.Items.Add(pedidoSelecionado);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
