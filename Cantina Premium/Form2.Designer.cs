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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Cardapio
            // 
            Cardapio.BackColor = Color.FromArgb(243, 241, 238);
            Cardapio.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cardapio.FormattingEnabled = true;
            Cardapio.ItemHeight = 24;
            Cardapio.Location = new Point(23, 90);
            Cardapio.Name = "Cardapio";
            Cardapio.Size = new Size(499, 340);
            Cardapio.TabIndex = 0;
            Cardapio.SelectedIndexChanged += Cardapio_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(230, 255, 0);
            button1.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(578, 268);
            button1.Name = "button1";
            button1.Size = new Size(146, 45);
            button1.TabIndex = 1;
            button1.Text = "➕ Adicionar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Pedindo
            // 
            Pedindo.BackColor = Color.FromArgb(243, 241, 238);
            Pedindo.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Pedindo.FormattingEnabled = true;
            Pedindo.ItemHeight = 19;
            Pedindo.Location = new Point(528, 41);
            Pedindo.Name = "Pedindo";
            Pedindo.Size = new Size(250, 213);
            Pedindo.TabIndex = 2;
            Pedindo.SelectedIndexChanged += Pedindo_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(230, 255, 0);
            button2.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(578, 319);
            button2.Name = "button2";
            button2.Size = new Size(146, 45);
            button2.TabIndex = 3;
            button2.Text = "➖ Remover";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(230, 255, 0);
            button3.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(528, 370);
            button3.Name = "button3";
            button3.Size = new Size(250, 60);
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
            label1.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 68);
            label1.Name = "label1";
            label1.Size = new Size(110, 19);
            label1.TabIndex = 6;
            label1.Text = "\U0001f6d2 Cardápio";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(528, 19);
            label2.Name = "label2";
            label2.Size = new Size(101, 19);
            label2.TabIndex = 7;
            label2.Text = "🍔 Pedidos";
            label2.Click += label2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(202, 196, 183);
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Pedindo);
            Controls.Add(button1);
            Controls.Add(Cardapio);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
    }
}