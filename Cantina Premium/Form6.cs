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
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            if (UsuarioGlobal.UsuarioLogado == "admin")
            {
                button5.Visible = true;
                button4.Visible = false;
            }
            else
            {
                button5.Visible = false;
                button4.Visible = true;
            }
            HistoricoGlobal.HistoricoPedidos = Persistencia.CarregarLista<Pedido>("historico.json");
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
                    Persistencia.SalvarLista(HistoricoGlobal.HistoricoPedidos, "historico.json");

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

        private void PedidosBalcao_DrawItem(object sender, DrawItemEventArgs e)
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

        private void ComandaBalcao_DrawItem(object sender, DrawItemEventArgs e)
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

        private void HistoricoBalcao_DrawItem(object sender, DrawItemEventArgs e)
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

        private void Form6_Load_1(object sender, EventArgs e)
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
