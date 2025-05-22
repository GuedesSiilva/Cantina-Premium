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
            pictureBox1.BackColor = Color.FromArgb(17, 25, 12);
            pictureBox1.Location = new Point(-62, -9);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1141, 681);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(243, 241, 238);
            button1.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(268, 441);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(197, 67);
            button1.TabIndex = 4;
            button1.Text = "ENTRAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(243, 241, 238);
            button2.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(544, 441);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(198, 67);
            button2.TabIndex = 5;
            button2.Text = "SAIR";
            button2.UseVisualStyleBackColor = false;
            // 
            // User
            // 
            User.BackColor = Color.FromArgb(202, 196, 183);
            User.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            User.ForeColor = SystemColors.WindowFrame;
            User.Location = new Point(268, 290);
            User.Margin = new Padding(3, 4, 3, 4);
            User.Multiline = true;
            User.Name = "User";
            User.Size = new Size(473, 49);
            User.TabIndex = 6;
            User.Text = "Digite seu Usuário:";
            User.TextChanged += textBox1_TextChanged;
            // 
            // Senha
            // 
            Senha.BackColor = Color.FromArgb(202, 196, 183);
            Senha.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Senha.ForeColor = SystemColors.WindowFrame;
            Senha.Location = new Point(268, 351);
            Senha.Margin = new Padding(3, 4, 3, 4);
            Senha.Multiline = true;
            Senha.Name = "Senha";
            Senha.Size = new Size(473, 49);
            Senha.TabIndex = 7;
            Senha.Text = "Digite sua Senha:";
            Senha.TextChanged += Senha_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(243, 241, 238);
            label2.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(466, 245);
            label2.Name = "label2";
            label2.Size = new Size(59, 23);
            label2.TabIndex = 8;
            label2.Text = "LOGIN";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(268, 62);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(475, 168);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 660);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(Senha);
            Controls.Add(User);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Font = new Font("Inter SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Tela de Login";
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
