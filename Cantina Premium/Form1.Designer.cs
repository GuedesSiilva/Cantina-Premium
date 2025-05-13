namespace Cantina_Premium
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            User = new TextBox();
            Senha = new TextBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(230, 255, 0);
            pictureBox1.Location = new Point(-48, -6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(887, 464);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(124, 122, 106);
            button1.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(208, 301);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 4;
            button1.Text = "ENTRAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(124, 122, 106);
            button2.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(427, 301);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 5;
            button2.Text = "SAIR";
            button2.UseVisualStyleBackColor = false;
            // 
            // User
            // 
            User.BackColor = Color.FromArgb(202, 196, 183);
            User.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            User.ForeColor = SystemColors.WindowFrame;
            User.Location = new Point(208, 198);
            User.Multiline = true;
            User.Name = "User";
            User.Size = new Size(369, 35);
            User.TabIndex = 6;
            User.Text = "Digite seu Usuário:";
            User.TextChanged += textBox1_TextChanged;
            // 
            // Senha
            // 
            Senha.BackColor = Color.FromArgb(202, 196, 183);
            Senha.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Senha.ForeColor = SystemColors.WindowFrame;
            Senha.Location = new Point(208, 239);
            Senha.Multiline = true;
            Senha.Name = "Senha";
            Senha.Size = new Size(369, 35);
            Senha.TabIndex = 7;
            Senha.Text = "Digite sua Senha:";
            Senha.TextChanged += Senha_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(202, 196, 183);
            label2.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(362, 167);
            label2.Name = "label2";
            label2.Size = new Size(64, 19);
            label2.TabIndex = 8;
            label2.Text = "LOGIN";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(208, 42);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(369, 115);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(Senha);
            Controls.Add(User);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private TextBox User;
        private TextBox Senha;
        private Label label2;
        private PictureBox pictureBox2;
    }
}
