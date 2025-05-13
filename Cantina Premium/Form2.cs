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
            Cardapio.Items.Add(new Cardapio("Coxinha", 5.00, 0));
            Cardapio.Items.Add(new Cardapio("Pastel", 6.00, 0));
            Cardapio.Items.Add(new Cardapio("Refrigerante", 3.00, 0));
            Cardapio.Items.Add(new Cardapio("Suco", 4.00, 0));
            Cardapio.Items.Add(new Cardapio("Brigadeiro", 2.00, 0));
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
            
        }
    }
}
