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

        }

        private void Preparando_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Pedidos.Items.Clear();

            foreach (var pedido in PreparoPedidos.Instancia.Pedidos)
            {
                Pedidos.Items.Add($"Pedido #{pedido.Id} - Cliente: {pedido.NomeCliente} - {pedido.DataHora}");

                foreach (var item in pedido.Itens)
                {
                    Pedidos.Items.Add($"  {item.Nome} - Quantidade: {item.Quantidade}");
                }

                Pedidos.Items.Add("");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Pedidos.SelectedItem == null)
            {
                MessageBox.Show("Nenhum item selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int selectedIndex = Pedidos.SelectedIndex;
            if (selectedIndex < 0)
                return;

            int pedidoIndex = 0;
            int linha = 0;

            foreach (var pedido in PreparoPedidos.Instancia.Pedidos)
            {
                if (linha == selectedIndex)
                    break;
                linha += 1 + pedido.Itens.Count + 1;
                pedidoIndex++;
            }

            if(pedidoIndex < PreparoPedidos.Instancia.Pedidos.Count)
            {
                DialogResult resultado = MessageBox.Show("Deseja cancelar este pedido ? ", "Cancelamento", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (resultado == DialogResult.Yes)
                {
                   PreparoPedidos.Instancia.Pedidos.RemoveAt(pedidoIndex);
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
    }
}
