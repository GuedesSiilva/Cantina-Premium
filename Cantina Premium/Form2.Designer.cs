﻿namespace Cantina_Premium
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            Cardapio = new ListBox();
            button1 = new Button();
            Pedindo = new ListBox();
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            label4 = new Label();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Cardapio
            // 
            Cardapio.BackColor = Color.FromArgb(243, 241, 238);
            Cardapio.DrawMode = DrawMode.OwnerDrawFixed;
            Cardapio.Font = new Font("Consolas", 16.5F);
            Cardapio.FormattingEnabled = true;
            Cardapio.ItemHeight = 28;
            Cardapio.Location = new Point(33, 132);
            Cardapio.Margin = new Padding(3, 4, 3, 4);
            Cardapio.Name = "Cardapio";
            Cardapio.Size = new Size(589, 452);
            Cardapio.TabIndex = 0;
            Cardapio.DrawItem += Cardapio_DrawItem;
            Cardapio.SelectedIndexChanged += Cardapio_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(243, 241, 238);
            button1.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(744, 380);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(188, 50);
            button1.TabIndex = 1;
            button1.Text = "➕ Adicionar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Pedindo
            // 
            Pedindo.BackColor = Color.FromArgb(243, 241, 238);
            Pedindo.DrawMode = DrawMode.OwnerDrawFixed;
            Pedindo.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Pedindo.FormattingEnabled = true;
            Pedindo.ItemHeight = 18;
            Pedindo.Location = new Point(642, 67);
            Pedindo.Margin = new Padding(3, 4, 3, 4);
            Pedindo.Name = "Pedindo";
            Pedindo.Size = new Size(370, 274);
            Pedindo.TabIndex = 2;
            Pedindo.DrawItem += Pedindo_DrawItem;
            Pedindo.SelectedIndexChanged += Pedindo_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(243, 241, 238);
            button2.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(744, 439);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(188, 52);
            button2.TabIndex = 3;
            button2.Text = "➖ Remover";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(230, 255, 0);
            button3.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(696, 498);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(282, 63);
            button3.TabIndex = 4;
            button3.Text = "✔️ Finalizar Pedido";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 28);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 98);
            label1.Name = "label1";
            label1.Size = new Size(139, 30);
            label1.TabIndex = 6;
            label1.Text = "\U0001f6d2 Cardápio";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(642, 33);
            label2.Name = "label2";
            label2.Size = new Size(130, 30);
            label2.TabIndex = 7;
            label2.Text = "🍔 Pedidos";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Inter SemiBold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(778, 577);
            label3.Name = "label3";
            label3.Size = new Size(121, 39);
            label3.TabIndex = 8;
            label3.Text = "R$ 0,00";
            label3.Click += label3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(744, 569);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(188, 55);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(243, 241, 238);
            textBox1.Font = new Font("Inter SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(164, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(428, 33);
            textBox1.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Inter SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(311, 33);
            label4.Name = "label4";
            label4.Size = new Size(112, 30);
            label4.TabIndex = 11;
            label4.Text = "👤Cliente";
            // 
            // button4
            // 
            button4.Location = new Point(977, 28);
            button4.Name = "button4";
            button4.Size = new Size(35, 32);
            button4.TabIndex = 12;
            button4.Text = "✖";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(32, 625);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 13;
            button5.Text = "↩️";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(33, 625);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 15;
            button6.Text = "↩️";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(202, 196, 183);
            ClientSize = new Size(1028, 660);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Pedindo);
            Controls.Add(button1);
            Controls.Add(Cardapio);
            Controls.Add(pictureBox2);
            Font = new Font("Inter SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela de Vendas";
            Load += Form2_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Cardapio;
        private Button button1;
        private ListBox Pedindo;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private Label label4;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button VoltarADM;
    }
}