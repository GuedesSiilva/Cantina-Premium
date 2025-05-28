namespace Cantina_Premium
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            User.Enter += textbox1_Enter;
            User.Leave += textBox1_Leave;
            Senha.Enter += Senha_Enter;
            Senha.Leave += Senha_Leave;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Senha_TextChanged(object sender, EventArgs e)
        {

        }
        private void Senha_Enter(object sender, EventArgs e)
        {
            if (Senha.Text == "Digite sua Senha:")
            {
                Senha.Text = "";
                Senha.ForeColor = Color.Black;
            }
        }
        private void Senha_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Senha.Text))
            {
                Senha.Text = "Digite sua Senha:";
                Senha.ForeColor = Color.Gray;
            }
        }

        private void textbox1_Enter(object sender, EventArgs e)
        {
            if (User.Text == "Digite seu Usuário:")
            {
                User.Text = "";
                User.ForeColor = Color.Black;
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(User.Text))
            {
                User.Text = "Digite seu Usuário:";
                User.ForeColor = Color.Gray;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja sair do serviço?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
