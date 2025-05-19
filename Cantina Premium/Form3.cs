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
    public partial class Form3 : Form
    {
        public List<string> OpcoesSelecionadas { get; private set; } = new List<string>();
        public double SomaFinal { get; set; }
        public double Troco { get; set; } = 0.0;

        public Form3()
        {
            InitializeComponent();
            Consumo.Checked = true;
            Debito.Checked = true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Dinheiro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Credito_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Dinheiro_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public string FormaSelecionada { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Dinheiro.Checked)
                FormaSelecionada = "Dinheiro";
            else if (Credito.Checked)
                FormaSelecionada = "Crédito";
            else if (Debito.Checked)
                FormaSelecionada = "Débito";
            else if (pix.Checked)
                FormaSelecionada = "Pix";
            else
            {
                MessageBox.Show("Selecione uma forma de pagamento.");
                return;
            }
            if (Viagem.Checked)
                FormaSelecionada += " - Viagem";
            if (Consumo.Checked)
                FormaSelecionada += " - Consumo";
            this.DialogResult = DialogResult.OK;
            this.Close();
            if (FormaSelecionada == "Dinheiro - Viagem")
            {
                while (true)
                {
                    string valorStr = Microsoft.VisualBasic.Interaction.InputBox("Digite o valor recebido:", "Dinheiro", "0");
                    if (double.TryParse(valorStr, out double valorRecebido))
                    {
                        if (valorRecebido >= SomaFinal)
                        {
                            Troco = valorRecebido - SomaFinal;
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Valor inválido. Por favor, insira novamente.");
                    }
                }
            }

            else if (FormaSelecionada == "Dinheiro - Consumo")
            {
                while (true)
                {
                    string valorStr = Microsoft.VisualBasic.Interaction.InputBox("Digite o valor recebido:", "Dinheiro", "0");
                    if (double.TryParse(valorStr, out double valorRecebido))
                    {
                        if (valorRecebido >= SomaFinal)
                        {
                            Troco = valorRecebido - SomaFinal;
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Valor inválido. Por favor, insira novamente.");
                    }
                }
            }
        }

        private void pix_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
