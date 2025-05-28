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
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            PedidosBalcao.Items.Clear();
            foreach (var pedido in PreparoPedidos.Instancia.Pedidos)
            {
                PedidosBalcao.Items.Add(pedido);
            }
        }

        private void PedidosBalcao_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void HistoricoBalcao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
