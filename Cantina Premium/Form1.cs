using System.Security.Cryptography;
using System.Text;

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
                Senha.PasswordChar = '#' ;
            }
        }
        private void Senha_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Senha.Text))
            {
                Senha.Text = "Digite sua Senha:";
                Senha.ForeColor = Color.Gray;
                Senha.PasswordChar = '\0';
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



        private void Form1_Load(object sender, EventArgs e)
        {
            if (Estoque.Itens.Count == 0)
            {
                Estoque.Itens.Add(new Cardapio(10,"Pão de Queijo", 3.50, 10, false));
                Estoque.Itens.Add(new Cardapio(1, "Coxinha", 5.00, 10, false));
                Estoque.Itens.Add(new Cardapio(2,"Pastel de Carne", 6.00, 10, true));
                Estoque.Itens.Add(new Cardapio(3, "Pastel de Queijo", 5.50, 10, true));
                Estoque.Itens.Add(new Cardapio(4, "Suco Natural (300ml)", 4.00, 10, false));
                Estoque.Itens.Add(new Cardapio(5, "Refrigerante Lata", 4.50, 10, false));
                Estoque.Itens.Add(new Cardapio(6, "Hambúrguer Simples", 8.00, 10, true));
                Estoque.Itens.Add(new Cardapio(7, "Hambúrguer com Queijo", 9.00, 10, true));
                Estoque.Itens.Add(new Cardapio(8, "X-Tudo", 12.00, 10, true));
                Estoque.Itens.Add(new Cardapio(9, "Água Mineral (500ml)", 2.50, 10, false));
            }
            Senha.Text = "Digite sua Senha:";
            Senha.ForeColor = Color.Gray;
            Senha.PasswordChar = '\0';
        }
        private string GerarHash(string senha)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(senha));
                StringBuilder builder = new StringBuilder();
                foreach (var b in bytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }
        private static string GerarHashStatic(string senha)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(senha));
                StringBuilder builder = new StringBuilder();
                foreach (var b in bytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }
        private readonly Dictionary<string, string> usuarios = new()
        {
            { "admin", GerarHashStatic("admin") },
            { "caixa", GerarHashStatic("vendasBolt") },
            { "telão", GerarHashStatic("telãoBolt") },
            { "cozinha", GerarHashStatic("cozinhaBolt") },
            { "balcão", GerarHashStatic("balcãoBolt") }
        };

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = User.Text;
            string senhaDigitada = Senha.Text;
            string hashSenha = GerarHash(senhaDigitada);

            if (usuarios.TryGetValue(usuario, out string hashSalvoUsuario) && hashSenha == hashSalvoUsuario)
            {
                if (usuario == "admin")
                {
                    Form5 form5 = new Form5();
                    form5.Show();
                    this.Hide();
                }
                else if (usuario == "caixa")
                {
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();
                }
                else if (usuario == "telão")
                {
                    Form7 form7 = new Form7();
                    form7.Show();
                    this.Hide();
                }
                else if (usuario == "cozinha")
                {
                    Form4 form4 = new Form4();
                    form4.Show();
                    this.Hide();
                }
                else if (usuario == "balcão")
                {
                    Form6 form6 = new Form6();
                    form6.Show();
                    this.Hide();
                }

            }
            else
            {
                MessageBox.Show("Usuário ou Senha Invalidos", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Senha.PasswordChar = '\0'; 
            }
            else
            {
                Senha.PasswordChar = '*'; 
            }
        }
    }
}
