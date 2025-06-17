using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Cantina_Premium
{
    public partial class Form2 : Form
    {
        public DateTime HorarioPedido { get; private set; } = DateTime.Now;
        public Form2()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form2_Load);

        }


        private void Cardapio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void Form2_Load(object sender, EventArgs e)
        {
            if (UsuarioGlobal.UsuarioLogado == "admin")
            { 
             button6.Visible = true;
             button5.Visible = false;
            }
            else
            {
                button6.Visible = false; 
                button5.Visible = true;
            }
            Cardapio.Items.Clear();
            foreach (var item in Estoque.Itens.OrderBy(x => x.ID))
            {
                Cardapio.Items.Add(item);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Pedindo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void AtualizarCardapioListBox()
        {
            int selectedIndex = Cardapio.SelectedIndex;


            Cardapio.BeginUpdate();
            Cardapio.Items.Clear();
            foreach (var item in Estoque.Itens.OrderBy(x => x.ID))
            {
                Cardapio.Items.Add(item);
            }
            Cardapio.EndUpdate();

            if (selectedIndex >= 0 && selectedIndex < Cardapio.Items.Count)
                Cardapio.SelectedIndex = selectedIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Cardapio.SelectedItem is Cardapio produtoSelecionado)
            {
                if (produtoSelecionado.Quantidade <= 0)
                {
                    MessageBox.Show("Estoque insuficiente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (produtoSelecionado.Quantidade <= 5)
                {
                    MessageBox.Show("Estoque baixo! Apenas " + produtoSelecionado.Quantidade + " unidades restantes.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                bool encontrado = false;
                foreach (Cardapio item in Pedindo.Items)
                {
                    if (item.Nome == produtoSelecionado.Nome)
                    {
                        item.Quantidade++;
                        encontrado = true;

                        int index = Pedindo.Items.IndexOf(item);
                        Pedindo.Items.RemoveAt(index);
                        Pedindo.Items.Insert(index, item);

                        break;
                    }
                }
                if (!encontrado)
                {
                    Cardapio novoItem = new Cardapio(produtoSelecionado.ID, produtoSelecionado.Nome, produtoSelecionado.Preco, 1, produtoSelecionado.Chapa);
                    Pedindo.Items.Add(novoItem);
                }

                produtoSelecionado.Quantidade--;
                Persistencia.SalvarLista(Estoque.Itens, "estoque.json");
                AtualizarCardapioListBox();
                Cardapio.Focus();

                double somaTotal = 0;
                foreach (Cardapio item in Pedindo.Items)
                {
                    somaTotal += item.Preco * item.Quantidade;
                }
                label3.Text = "R$ " + somaTotal.ToString("F2");
            }
            else
            {
                MessageBox.Show("Por favor, selecione um item válido do cardápio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //remover items
            if (Pedindo.SelectedItem is Cardapio produtoSelecionado)
            {
                foreach (Cardapio item in Pedindo.Items)
                {
                    if (item.Nome == produtoSelecionado.Nome)
                    {
                        var estoqueItem = Estoque.Itens.FirstOrDefault(x => x.Nome == item.Nome);
                        if (estoqueItem != null)
                            estoqueItem.Quantidade++;

                        item.Quantidade--;

                        if (item.Quantidade == 0)
                        {
                            if (estoqueItem != null)
                                estoqueItem.Quantidade += Math.Max(0, item.Quantidade);
                            Pedindo.Items.Remove(item);
                        }
                        else
                        {
                            int index = Pedindo.Items.IndexOf(item);
                            Pedindo.Items.RemoveAt(index);
                            Pedindo.Items.Insert(index, item);
                        }
                        break;
                    }
                }
                Persistencia.SalvarLista(Estoque.Itens, "estoque.json");
                Persistencia.SalvarLista(PreparoPedidos.Instancia.Pedidos, "pedidos.json");
                AtualizarCardapioListBox();
                double somaTotal = 0;
                foreach (Cardapio item in Pedindo.Items)
                {
                    somaTotal += item.Preco * item.Quantidade;
                }
                label3.Text = somaTotal == 0 ? "R$ 0,00" : "R$ " + somaTotal.ToString("F2");
            }
            else
            {
                MessageBox.Show("Por favor, selecione um item válido do pedido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {

            double somaFinal = 0;
            foreach (Cardapio item in Pedindo.Items)
            {

                somaFinal += item.Preco * item.Quantidade;
            }
            if (Pedindo.Items.Count == 0)
            {
                MessageBox.Show("Nenhum pedido foi realizado no momento.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Por favor, insira o nome do cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Form3 form3 = new Form3();
            form3.SomaFinal = somaFinal;
            if (form3.ShowDialog() == DialogResult.OK)
            {
                string forma = form3.FormaSelecionada;
                string entrega = form3.Entrega;
                MessageBox.Show("Forma de pagamento: " + forma + entrega);
            }
            string nomeCliente = textBox1.Text;

            string mensagem = $"{HorarioPedido}";
            mensagem += $"\n{nomeCliente} realizou os seguintes pedidos:\n\n";

            foreach (var item in Pedindo.Items)
            {
                mensagem += "- " + item.ToString() + "\n";
            }
            mensagem += $"\nTotal: R$ {somaFinal:F2}";
            mensagem += "\nTroco: R$ " + (form3.Troco).ToString("F2");
            mensagem += "\n\nEstes pedidos estão corretos?";
            DialogResult resultado = MessageBox.Show(mensagem, "Confirmação de Pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {


                MessageBox.Show($"O pedido de {nomeCliente} foi realizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var pedidosEmPreparo = Persistencia.CarregarLista<Pedido>("pedidos.json");
                var historico = Persistencia.CarregarLista<Pedido>("historico.json");

  
                int maiorId = 0;
                if (pedidosEmPreparo.Any())
                    maiorId = pedidosEmPreparo.Max(p => p.Id);
                if (historico.Any())
                    maiorId = Math.Max(maiorId, historico.Max(p => p.Id));


                int novoId = maiorId + 1;


                Pedido novoPedido = new(form3.Entrega)
                {
                    Id = novoId,
                    NomeCliente = textBox1.Text,
                    Itens = Pedindo.Items.Cast<Cardapio>()
                     .Select(item => new Cardapio(item.ID, item.Nome, item.Preco, item.Quantidade, item.Chapa))
                     .ToList(),
                    DataHora = DateTime.Now,
                    Tipo = form3.Entrega,
                };

                PreparoPedidos.Instancia.Pedidos.Add(novoPedido);
                Persistencia.SalvarLista(PreparoPedidos.Instancia.Pedidos, "pedidos.json");
                Persistencia.SalvarLista(Estoque.Itens, "estoque.json");
                if (!novoPedido.Itens.Any(item => item.Chapa))
                {
                    novoPedido.Status = "- Finalizado";
                    HistoricoGlobal.HistoricoPedidos.Add(novoPedido);
                    Persistencia.SalvarLista(HistoricoGlobal.HistoricoPedidos, "historico.json");

                }
                textBox1.Clear();
                Pedindo.Items.Clear();
                somaFinal = 0;
                label3.Text = "R$ 0,00";
            }
            else
            {
                DialogResult resultado2 = MessageBox.Show("Deseja remover todos os itens do pedido?", "Remover Itens", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado2 == DialogResult.Yes)
                {
                    var itensParaDevolver = Pedindo.Items.Cast<Cardapio>().ToList();

                    foreach (Cardapio item in itensParaDevolver)
                    {
                        var estoqueItem = Estoque.Itens.FirstOrDefault(x => x.Nome == item.Nome);
                        if (estoqueItem != null)
                            estoqueItem.Quantidade += item.Quantidade;
                    }
                    Persistencia.SalvarLista(Estoque.Itens, "estoque.json");
                    textBox1.Clear();
                    Pedindo.Items.Clear();
                    AtualizarCardapioListBox();
                    label3.Text = "R$ 0,00";
                }
                else
                {
                    MessageBox.Show("Os itens permanecerão no pedido.", "Itens Mantidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var itensParaDevolver = Pedindo.Items.Cast<Cardapio>().ToList();

            foreach (Cardapio item in itensParaDevolver)
            {
                var estoqueItem = Estoque.Itens.FirstOrDefault(x => x.Nome == item.Nome);
                if (estoqueItem != null)
                    estoqueItem.Quantidade += item.Quantidade;
            }
            Persistencia.SalvarLista(Estoque.Itens, "estoque.json");
            Pedindo.Items.Clear();
            AtualizarCardapioListBox();
            label3.Text = "R$ 0,00";
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Cardapio_DrawItem(object sender, DrawItemEventArgs e)
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

        private void Pedindo_DrawItem(object sender, DrawItemEventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
        {

                Form5 form5 = new Form5();
                form5.Show();
                this.Hide();
        }
    }
}
