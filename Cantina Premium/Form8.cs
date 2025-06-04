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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Estoque_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            foreach (var item in Estoque.Itens)
            {
                listEstoque.Items.Add(item);
            }
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            string nomeItem = Microsoft.VisualBasic.Interaction.InputBox("Digite o nome do item:", "Adicionar Item", "");
            if (string.IsNullOrWhiteSpace(nomeItem))
            {
                MessageBox.Show("O nome do item não pode ser vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int quantidade;
            string quantidadeStr = Microsoft.VisualBasic.Interaction.InputBox("Digite a quantidade do item:", "Adicionar Item", "1");
            if (!int.TryParse(quantidadeStr, out quantidade) || quantidade <= 0)
            {
                MessageBox.Show("Quantidade inválida. Por favor, insira um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double preco;
            string precoStr = Microsoft.VisualBasic.Interaction.InputBox("Digite o preço do item:", "Adicionar Item", "0.00");
            if (!double.TryParse(precoStr, out preco) || preco < 0)
            {
                MessageBox.Show("Preço inválido. Por favor, insira um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Estoque.Itens.Any(i => i.Nome.Equals(nomeItem, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Item já existe no estoque.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool chapa;
            string chapaStr = Microsoft.VisualBasic.Interaction.InputBox("O item vai para chapa? (Sim/Não)", "Adicionar Item", "Não");
            if (chapaStr.Equals("Sim", StringComparison.OrdinalIgnoreCase))
            {
                chapa = true;
            }
            else if (chapaStr.Equals("Não", StringComparison.OrdinalIgnoreCase))
            {
                chapa = false;
            }
            else
            {
                MessageBox.Show("Resposta inválida. Por favor, responda com 'Sim' ou 'Não'.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Estoque.Itens.Add(new Cardapio(nomeItem, preco, quantidade, chapa));
            listEstoque.Items.Add(new Cardapio(nomeItem, preco, quantidade, chapa));

        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (listEstoque.SelectedItem is Cardapio pedidoSelecionado)
            {
                Estoque.Itens.Remove(pedidoSelecionado);
                listEstoque.Items.Remove(pedidoSelecionado);
            }
        }
    }
}
