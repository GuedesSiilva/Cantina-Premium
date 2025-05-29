namespace Cantina_Premium
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            Pedidos = new ListBox();
            label1 = new Label();
            Preparando = new ListBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            button3 = new Button();
            button4 = new Button();
            Historico = new ListBox();
            label3 = new Label();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Pedidos
            // 
            Pedidos.BackColor = Color.FromArgb(243, 241, 238);
            Pedidos.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Pedidos.FormattingEnabled = true;
            Pedidos.ItemHeight = 23;
            Pedidos.Location = new Point(33, 104);
            Pedidos.Name = "Pedidos";
            Pedidos.Size = new Size(408, 441);
            Pedidos.TabIndex = 0;
            Pedidos.SelectedIndexChanged += Pedidos_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(170, 71);
            label1.Name = "label1";
            label1.Size = new Size(135, 30);
            label1.TabIndex = 1;
            label1.Text = " 🛎️ Pedidos";
            // 
            // Preparando
            // 
            Preparando.BackColor = Color.FromArgb(243, 241, 238);
            Preparando.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Preparando.FormattingEnabled = true;
            Preparando.ItemHeight = 23;
            Preparando.Location = new Point(469, 104);
            Preparando.Name = "Preparando";
            Preparando.Size = new Size(433, 188);
            Preparando.TabIndex = 2;
            Preparando.SelectedIndexChanged += Preparando_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(618, 71);
            label2.Name = "label2";
            label2.Size = new Size(145, 30);
            label2.TabIndex = 3;
            label2.Text = "📓 Comanda";
            label2.Click += label2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 31);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(93, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(230, 255, 0);
            button3.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlText;
            button3.Location = new Point(589, 541);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(188, 50);
            button3.TabIndex = 9;
            button3.Text = "Finalizar Pedido";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(33, 569);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 10;
            button4.Text = "↩️";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Historico
            // 
            Historico.BackColor = Color.FromArgb(243, 241, 238);
            Historico.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Historico.FormattingEnabled = true;
            Historico.ItemHeight = 23;
            Historico.Location = new Point(469, 329);
            Historico.Name = "Historico";
            Historico.Size = new Size(433, 142);
            Historico.TabIndex = 11;
            Historico.SelectedIndexChanged += Historico_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inter SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(618, 296);
            label3.Name = "label3";
            label3.Size = new Size(139, 30);
            label3.TabIndex = 12;
            label3.Text = "🕑 Histórico";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(243, 241, 238);
            button2.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(714, 483);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(188, 50);
            button2.TabIndex = 8;
            button2.Text = "Preparar pedido";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(243, 241, 238);
            button1.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(469, 483);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(188, 50);
            button1.TabIndex = 7;
            button1.Text = "Cancelar Pedido";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(202, 196, 183);
            ClientSize = new Size(930, 604);
            Controls.Add(label3);
            Controls.Add(Historico);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(Preparando);
            Controls.Add(label1);
            Controls.Add(Pedidos);
            Name = "Form4";
            Text = "Tela da Cozinha";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Pedidos;
        private Label label1;
        private ListBox Preparando;
        private Label label2;
        private PictureBox pictureBox2;
        private Button button3;
        private Button button4;
        private ListBox Historico;
        private Label label3;
        private Button button2;
        private Button button1;
    }
}