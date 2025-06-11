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

        public static void AlterarFundoLista(object sender, DrawItemEventArgs e)
        {
        }
        private void listEstoque_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            ListBox listBox = (ListBox)sender;
            bool selected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;

            // Cor de fundo personalizada
            Color backColor = selected ? Color.LightGray : listBox.BackColor;
            using (SolidBrush backgroundBrush = new SolidBrush(backColor))
            {
                e.Graphics.FillRectangle(backgroundBrush, e.Bounds);
            }

            // Cor do texto
            Color textColor = selected ? Color.Black : listBox.ForeColor;
            using (SolidBrush textBrush = new SolidBrush(textColor))
            {
                string text = listBox.Items[e.Index].ToString();
                e.Graphics.DrawString(text, e.Font, textBrush, e.Bounds);
            }

            e.DrawFocusRectangle();
        }
        private void Estoque_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            listEstoque.DrawMode = DrawMode.OwnerDrawFixed;
            listEstoque.DrawItem += listEstoque_DrawItem;
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

        private void Quant_Click(object sender, EventArgs e)
        {
            if (listEstoque.SelectedItem is Cardapio pedidoSelecionado)
            {
                string novaQuantidadeStr = Microsoft.VisualBasic.Interaction.InputBox("Digite a nova quantidade:", "Alterar Quantidade", pedidoSelecionado.Quantidade.ToString());
                if (int.TryParse(novaQuantidadeStr, out int novaQuantidade) && novaQuantidade >= 0)
                {
                    pedidoSelecionado.Quantidade = novaQuantidade;
                    listEstoque.Items[listEstoque.SelectedIndex] = pedidoSelecionado; // Atualiza o item na lista
                }
                else
                {
                    MessageBox.Show("Quantidade inválida. Por favor, insira um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditItem_Click(object sender, EventArgs e)
        {
            if (listEstoque.SelectedItem != null)
            {
                Cardapio itemSelecionado = (Cardapio)listEstoque.SelectedItem;
                string novoNome = Microsoft.VisualBasic.Interaction.InputBox("Digite o novo nome do item:", "Editar Item", itemSelecionado.Nome);
                if (string.IsNullOrWhiteSpace(novoNome))
                {
                    MessageBox.Show("O nome do item não pode ser vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string novaQuantidadeStr = Microsoft.VisualBasic.Interaction.InputBox("Digite a nova quantidade:", "Editar Item", itemSelecionado.Quantidade.ToString());
                if (!int.TryParse(novaQuantidadeStr, out int novaQuantidade) || novaQuantidade < 0)
                {
                    MessageBox.Show("Quantidade inválida. Por favor, insira um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string novoPrecoStr = Microsoft.VisualBasic.Interaction.InputBox("Digite o novo preço:", "Editar Item", itemSelecionado.Preco.ToString("F2"));
                if (!double.TryParse(novoPrecoStr, out double novoPreco) || novoPreco < 0)
                {
                    MessageBox.Show("Preço inválido. Por favor, insira um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                bool novaChapa = itemSelecionado.Chapa;
                string chapaStr = Microsoft.VisualBasic.Interaction.InputBox("O item vai para chapa? (Sim/Não)", "Editar Item", novaChapa ? "Sim" : "Não");
                if (chapaStr.Equals("Sim", StringComparison.OrdinalIgnoreCase))
                {
                    novaChapa = true;
                }
                else if (chapaStr.Equals("Não", StringComparison.OrdinalIgnoreCase))
                {
                    novaChapa = false;
                }
                else
                {
                    MessageBox.Show("Resposta inválida. Por favor, responda com 'Sim' ou 'Não'.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Atualiza o item selecionado
                itemSelecionado.Nome = novoNome;
                itemSelecionado.Quantidade = novaQuantidade;
                itemSelecionado.Preco = novoPreco;
                itemSelecionado.Chapa = novaChapa;

                listEstoque.Items[listEstoque.SelectedIndex] = itemSelecionado; // Atualiza o item na lista
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
