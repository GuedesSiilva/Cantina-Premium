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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox3.ClearSelected();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            foreach (var pedido in HistoricoGlobal.HistoricoPedidos)
            {
                if (pedido.Status == "- Finalizado")
                {
                    string texto = $"Cliente: {pedido.NomeCliente} | Pedido: #{pedido.Id} | {pedido.DataHora:HH:mm}";
                    listBox1.Items.Add(texto);
                    
                }
            }
            foreach (var pedido in PreparoPedidos.Instancia.Pedidos)
            {
                if (pedido.Status == "Preparando")
                {
                    string texto = $"Cliente: {pedido.NomeCliente} | Pedido: #{pedido.Id} | {pedido.DataHora:HH:mm}";
                    listBox3.Items.Add(texto);
                }
            }
            foreach (var pedido in HistoricoGlobal.HistoricoPedidos)
            {
                if (pedido.Status == "- Entregue")
                {
                    string texto = $"Cliente: {pedido.NomeCliente} | Pedido: #{pedido.Id} | {pedido.DataHora:HH:mm}";
                    listBox2.Items.Add(texto);
                }
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.ClearSelected();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.ClearSelected();
        }
    }
}
