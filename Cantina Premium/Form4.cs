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
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Pedidos.Items.Clear();

            foreach (var pedido in PreparoPedidos.Instancia.Pedidos)
            {
                if (pedido.Itens.Any(item => item.Chapa))
                {
                    Pedidos.Items.Add(pedido);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Pedidos.SelectedItem != null)
            {
                Pedido PedidoSelecionado = (Pedido)Pedidos.SelectedItem;
                DialogResult resultado = MessageBox.Show("Deseja cancelar este pedido ? ", "Cancelamento", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (resultado == DialogResult.Yes)
                {
                    PreparoPedidos.Instancia.Pedidos.Remove(PedidoSelecionado);
                    Historico.Items.Remove($"Pedido #{PedidoSelecionado.Id} - Cliente: {PedidoSelecionado.NomeCliente} - Preparando");
                    Preparando.Items.Clear();
                    MessageBox.Show("Pedido cancelado com sucesso", "Cancelamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form4_Load(null, null);
                }
                if (resultado == DialogResult.No)
                {
                    MessageBox.Show("Pedido não cancelado", "Cancelamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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
            Historico.ClearSelected();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Pedidos.SelectedItem != null)
            {

                Pedido PedidoSelecionado = (Pedido)Pedidos.SelectedItem;
                DialogResult resultado = MessageBox.Show("Este pedido foi finalizado ? ", "Finalização", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (resultado == DialogResult.Yes)
                {
                    PedidoSelecionado.Status = "- Finalizado";
                    string historicoPreparando = $"Pedido #{PedidoSelecionado.Id} - Cliente: {PedidoSelecionado.NomeCliente} - Preparando";
                    string historicoFinalizado = $"Pedido #{PedidoSelecionado.Id} - Cliente: {PedidoSelecionado.NomeCliente} - Finalizado";
                    if (Historico.Items.Contains(historicoPreparando))
                    {
                        Historico.Items.Remove(historicoPreparando);
                    }
                    else
                    {
                        MessageBox.Show("Este pedido não está sendo preparado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (!Historico.Items.Contains(historicoFinalizado))
                    {
                        Historico.Items.Add(historicoFinalizado);

                    }
                    if (!HistoricoGlobal.HistoricoPedidos.Any(p => p.Id == PedidoSelecionado.Id))
                    {
                        HistoricoGlobal.HistoricoPedidos.Add(PedidoSelecionado);
                    }


                    Preparando.Items.Clear();
                    Pedidos.Items.Remove(PedidoSelecionado);
                    PreparoPedidos.Instancia.Pedidos.Remove(PedidoSelecionado);

                    MessageBox.Show("Pedido Finalizado com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Form4_Load(null, null);
                }
                if (resultado == DialogResult.No)
                {
                    MessageBox.Show("Pedido não finalizado", "Cancelamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Pedidos_DrawItem(object sender, DrawItemEventArgs e)
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

        private void Historico_DrawItem(object sender, DrawItemEventArgs e)
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

        private void Preparando_DrawItem(object sender, DrawItemEventArgs e)
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
    }
}
