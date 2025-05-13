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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            User = new TextBox();
            Senha = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(230, 255, 0);
            label1.Font = new Font("Swis721 Blk BT", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(17, 25, 12);
            label1.Location = new Point(193, 42);
            label1.Name = "label1";
            label1.Size = new Size(369, 115);
            label1.TabIndex = 0;
            label1.Text = "SENAI";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(230, 255, 0);
            pictureBox1.Location = new Point(-48, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(895, 115);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(124, 122, 106);
            button1.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(193, 301);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(124, 122, 106);
            button2.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(412, 301);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 5;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            // 
            // User
            // 
            User.BackColor = Color.FromArgb(202, 196, 183);
            User.BorderStyle = BorderStyle.None;
            User.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            User.ForeColor = SystemColors.WindowFrame;
            User.Location = new Point(193, 200);
            User.Multiline = true;
            User.Name = "User";
            User.Size = new Size(369, 23);
            User.TabIndex = 6;
            User.Text = "Digite seu Usuário:";
            User.TextChanged += textBox1_TextChanged;
            // 
            // Senha
            // 
            Senha.BackColor = Color.FromArgb(202, 196, 183);
            Senha.BorderStyle = BorderStyle.None;
            Senha.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Senha.ForeColor = SystemColors.WindowFrame;
            Senha.Location = new Point(193, 243);
            Senha.Multiline = true;
            Senha.Name = "Senha";
            Senha.Size = new Size(369, 23);
            Senha.TabIndex = 7;
            Senha.Text = "Digite sua Senha:";
            Senha.TextChanged += Senha_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Swis721 Blk BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(352, 171);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 8;
            label2.Text = "LOGIN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(Senha);
            Controls.Add(User);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private TextBox User;
        private TextBox Senha;
        private Label label2;
    }
}
