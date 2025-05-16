namespace Cantina_Premium
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Cardapio
            // 
            Cardapio.BackColor = Color.FromArgb(243, 241, 238);
            Cardapio.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Cardapio.FormattingEnabled = true;
            Cardapio.ItemHeight = 22;
            Cardapio.Location = new Point(23, 90);
            Cardapio.Name = "Cardapio";
            Cardapio.Size = new Size(472, 312);
            Cardapio.TabIndex = 0;
            Cardapio.SelectedIndexChanged += Cardapio_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(230, 255, 0);
            button1.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(578, 259);
            button1.Name = "button1";
            button1.Size = new Size(146, 34);
            button1.TabIndex = 1;
            button1.Text = "➕ Adicionar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Pedindo
            // 
            Pedindo.BackColor = Color.FromArgb(243, 241, 238);
            Pedindo.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Pedindo.FormattingEnabled = true;
            Pedindo.ItemHeight = 13;
            Pedindo.Location = new Point(511, 41);
            Pedindo.Name = "Pedindo";
            Pedindo.Size = new Size(277, 212);
            Pedindo.TabIndex = 2;
            Pedindo.SelectedIndexChanged += Pedindo_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(230, 255, 0);
            button2.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(578, 299);
            button2.Name = "button2";
            button2.Size = new Size(146, 35);
            button2.TabIndex = 3;
            button2.Text = "➖ Remover";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(230, 255, 0);
            button3.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(542, 340);
            button3.Name = "button3";
            button3.Size = new Size(220, 43);
            button3.TabIndex = 4;
            button3.Text = "✔️ Finalizar Pedido";
            button3.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 68);
            label1.Name = "label1";
            label1.Size = new Size(107, 23);
            label1.TabIndex = 6;
            label1.Text = "\U0001f6d2 Cardápio";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(511, 19);
            label2.Name = "label2";
            label2.Size = new Size(99, 23);
            label2.TabIndex = 7;
            label2.Text = "🍔 Pedidos";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Inter SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(594, 390);
            label3.Name = "label3";
            label3.Size = new Size(117, 35);
            label3.TabIndex = 8;
            label3.Text = "R$00,00";
            label3.Click += label3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(578, 388);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(146, 38);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(202, 196, 183);
            ClientSize = new Size(800, 450);
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
            Name = "Form2";
            Text = "Form2";
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
    }
}