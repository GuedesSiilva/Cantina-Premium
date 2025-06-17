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
            if (UsuarioGlobal.UsuarioLogado == "admin")
            {
                button5.Visible = true;
                button1.Visible = false;
            }
            else
            {
                button5.Visible = false;
                button1.Visible = true;
            }

            // Últimos 5 finalizados
            var ultimosFinalizados = HistoricoGlobal.HistoricoPedidos
                .Where(p => p.Status == "- Finalizado")
                .OrderByDescending(p => p.DataHora)
                .Take(5)
                .OrderBy(p => p.DataHora); // Exibe do mais antigo ao mais novo

            listBox1.Items.Clear();
            foreach (var pedido in ultimosFinalizados)
            {
                string texto = $"Cliente: {pedido.NomeCliente} | Pedido: #{pedido.Id} | {pedido.DataHora:HH:mm}";
                listBox1.Items.Add(texto);
            }

            // Últimos 5 preparando
            var ultimosPreparando = PreparoPedidos.Instancia.Pedidos
                .Where(p => p.Status == "Preparando")
                .OrderByDescending(p => p.DataHora)
                .Take(5)
                .OrderBy(p => p.DataHora);

            listBox3.Items.Clear();
            foreach (var pedido in ultimosPreparando)
            {
                string texto = $"Cliente: {pedido.NomeCliente} | Pedido: #{pedido.Id} | {pedido.DataHora:HH:mm}";
                listBox3.Items.Add(texto);
            }

            // Últimos 5 entregues
            var ultimosEntregues = HistoricoGlobal.HistoricoPedidos
                .Where(p => p.Status == "- Entregue")
                .OrderByDescending(p => p.DataHora)
                .Take(5)
                .OrderBy(p => p.DataHora);

            listBox2.Items.Clear();
            foreach (var pedido in ultimosEntregues)
            {
                string texto = $"Cliente: {pedido.NomeCliente} | Pedido: #{pedido.Id} | {pedido.DataHora:HH:mm}";
                listBox2.Items.Add(texto);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
