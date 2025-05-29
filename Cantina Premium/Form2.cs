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
            Cardapio.Items.Add(new Cardapio("Pão de Queijo", 3.50, 0,false));
            Cardapio.Items.Add(new Cardapio("Coxinha", 5.00, 0,false));
            Cardapio.Items.Add(new Cardapio("Pastel de Carne", 6.00, 0, true));
            Cardapio.Items.Add(new Cardapio("Pastel de Queijo", 5.50, 0, true));
            Cardapio.Items.Add(new Cardapio("Suco Natural (300ml)", 4.00, 0, false));
            Cardapio.Items.Add(new Cardapio("Refrigerante Lata", 4.50, 0, false));
            Cardapio.Items.Add(new Cardapio("Hambúrguer Simples", 8.00, 0,true));
            Cardapio.Items.Add(new Cardapio("Hambúrguer com Queijo", 9.00, 0,true));
            Cardapio.Items.Add(new Cardapio("X-Tudo", 12.00, 0, true));
            Cardapio.Items.Add(new Cardapio("Água Mineral (500ml)", 2.50, 0,false));
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (Cardapio.SelectedItem is Cardapio produtoSelecionado)
            {
                bool encontrado = false;
                foreach (Cardapio item in Pedindo.Items)
                {
                    if (item.Nome == produtoSelecionado.Nome)
                    {
                        item.Quantidade++;
                        item.Preco += produtoSelecionado.Preco;
                        encontrado = true;

                        int index = Pedindo.Items.IndexOf(item);
                        Pedindo.Items.RemoveAt(index);
                        Pedindo.Items.Insert(index, item);

                        break;
                    }
                }
                if (!encontrado)
                {
                    Cardapio novoItem = new Cardapio(produtoSelecionado.Nome, produtoSelecionado.Preco, 1,produtoSelecionado.Chapa);
                    Pedindo.Items.Add(novoItem);
                }

                double somaTotal = 0;
                foreach (Cardapio item in Pedindo.Items)
                {
                    somaTotal += item.Preco;
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
            if (Cardapio.SelectedItem is Cardapio produtoSelecionado)
            {
                bool encontrado = false;
                foreach (Cardapio item in Pedindo.Items)
                {
                    if (item.Nome == produtoSelecionado.Nome)
                    {
                        item.Quantidade--;
                        item.Preco -= produtoSelecionado.Preco;
                        encontrado = true;

                        if (item.Quantidade == 0)
                        {
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

                double somaTotal = 0;
                foreach (Cardapio item in Pedindo.Items)
                {
                    somaTotal += item.Preco;
                }
                if (somaTotal == 0)
                {
                    label3.Text = "R$ 0,00";
                }
                else
                {
                    label3.Text = "R$ " + somaTotal.ToString("F2");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um item válido do cardápio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {

            double somaFinal = 0;
            foreach (Cardapio item in Pedindo.Items)
            {

                somaFinal += item.Preco;
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


                Pedido novoPedido = new (form3.Entrega)
                {
                    Id = PreparoPedidos.Instancia.Pedidos.Count + 1,
                    NomeCliente = textBox1.Text,
                    Itens = Pedindo.Items.Cast<Cardapio>()
                     .Select(item => new Cardapio(item.Nome, item.Preco, item.Quantidade, item.Chapa))
                     .ToList(),
                    DataHora = DateTime.Now,
                    Tipo = form3.Entrega,
                };

                PreparoPedidos.Instancia.Pedidos.Add(novoPedido);
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
                    textBox1.Clear();
                    Pedindo.Items.Clear();
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
            Pedindo.Items.Clear();
            label3.Text = "R$ 0,00";
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show(); 
            this.Hide();
        }
    }
}
