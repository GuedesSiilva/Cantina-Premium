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
    public partial class Form2 : Form
    {
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
            Cardapio.Items.Add(new Cardapio("Pão de Queijo", 3.50, 0));
            Cardapio.Items.Add(new Cardapio("Coxinha", 5.00, 0));
            Cardapio.Items.Add(new Cardapio("Pastel de Carne", 6.00, 0));
            Cardapio.Items.Add(new Cardapio("Pastel de Queijo", 5.50, 0));
            Cardapio.Items.Add(new Cardapio("Suco Natural (300ml)", 4.00, 0));
            Cardapio.Items.Add(new Cardapio("Refrigerante Lata", 4.50, 0));
            Cardapio.Items.Add(new Cardapio("Hambúrguer Simples", 8.00, 0));
            Cardapio.Items.Add(new Cardapio("Hambúrguer com Queijo", 9.00, 0));
            Cardapio.Items.Add(new Cardapio("X-Tudo", 12.00, 0));
            Cardapio.Items.Add(new Cardapio("Água Mineral (500ml)", 2.50, 0));
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
                    Cardapio novoItem = new Cardapio(produtoSelecionado.Nome, produtoSelecionado.Preco, 1);
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

            string mensagem = "Você realizou os seguintes pedidos:\n\n";

            foreach (var item in Pedindo.Items)
            {
                mensagem += "- " + item.ToString() + "\n";
            }
            mensagem += $"\nTotal: R$ {somaFinal:F2}";
            MessageBox.Show(mensagem, "Pedidos Realizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
